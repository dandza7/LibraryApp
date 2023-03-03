using AutoMapper;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;
using LibraryApp.Services;
using LibraryApp.SupportClasses.MyExtensions;
using LibraryApp.SupportClasses.ResponseMessagesDictionary;
using LibraryApp.SupportClasses.Roles;
using LibraryApp.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public UserController(IUserService userService, IMapper mapper, ILogger<UserController> logger)
        {
            _userService = userService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// [Admin, Librarian] Gets all users (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, FirstName, LastName, Email, Role
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), FirstName (string), LastName (string), Email (string), Role (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all users</response>
        /// <response code="204">If there are no users in database</response>
        [HttpPost(Name = "GetAllUsers")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public ActionResult<PaginationResponseWrapper<PreviewUserDTO>> GetAll([FromBody] PaginationQueryDTO paginationQueryDTO)
        {
            _logger.LogInformation("[REQUEST] Request for get all Users created.");
            var users = _userService.GetAll(paginationQueryDTO);
            _logger.LogInformation("[RESPONSE] Response with all Users created.");
            return Ok(new PaginationResponseWrapper<PreviewUserDTO>(_mapper.Map<List<PreviewUserDTO>>(users.Items), users.TotalCount));
        }

        /// <summary>
        /// [Admin, Librarian] Gets user by ID
        /// </summary>
        /// <response code="200">Returns user with sent ID</response>
        /// <response code="404">If user with sent ID does not exists</response>
        [HttpGet("{id}", Name = "GetUser")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<PreviewUserDTO>> GetById(long id)
        {
            _logger.LogInformation("[REQUEST] Request for User with ID {id} created.", id);
            var user = await _userService.GetById(id);
            _logger.LogInformation("[RESPONSE] Response with User with ID {id} created.", id);
            return Ok(_mapper.Map<PreviewUserDTO>(user));
        }

        /// <summary>
        /// [Admin, Librarian] Gets users rent history by users ID
        /// </summary>
        /// <response code="200">Returns books rent history</response>
        /// <response code="204">Returns if user has not been renting yet</response>
        /// <response code="404">If book with sent ID does not exists</response>
        [HttpGet("rentHistory/{id}", Name = "GetUsersRentHistory")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<PreviewUserRentHistoryDTO>> GetUsersRentHistory(long id)
        {
            _logger.LogInformation("[REQUEST] Request for rent history of User with ID {id} created.", id);
            var usersRentHistory = await _userService.GetUsersRentHistory(id);
            _logger.LogInformation("[RESPONSE] Response with rent history of User with ID {id} created.", id);
            return Ok(usersRentHistory);
        }

        /// <summary>
        /// [Admin, Librarian, User] Updates users names
        /// </summary>
        /// <response code="200">Returns updated user</response>
        /// <response code="404">If user with sent email does not exists</response>
        [HttpPatch("update", Name = "UpdateProfile")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult<PreviewUserDTO>> UpdateProfile([FromBody] UpdateProfileDTO updateProfileDTO)
        {
            _logger.LogInformation("[REQUEST] Request for profile update created.");
            string userEmail = User.GetEmail();
            var updatedUser = await _userService.UpdateProfile(userEmail, updateProfileDTO);
            _logger.LogInformation("[RESPONSE] Profile updated. Response with updated user created.");
            return Ok(ResponseMessagesDictionary.User.Updated(updatedUser.Id));
        }

        /// <summary>
        /// [Admin, Librarian, User] Gets profile of signed in user
        /// </summary>
        /// <response code="200">Returns profile of signed in user</response>
        /// <response code="404">If user with sent email does not exists</response>
        [HttpGet("profile", Name = "GetProfile")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult<PreviewUserDTO>> GetProfile()
        {
            _logger.LogInformation("[REQUEST] Request for users profile created.");
            string userEmail = User.GetEmail();
            var user = await _userService.GetByEmail(userEmail);
            _logger.LogInformation("[RESPONSE] Response with users profile created.");
            return Ok(_mapper.Map<PreviewUserDTO>(user));
        }

        /// <summary>
        /// [Admin, Librarian, User] Updates users avatar
        /// </summary>
        /// <response code="200">If avatar is updated successfully</response>
        /// <response code="400">If avatar is too big or in wrong extension</response>
        /// <response code="404">If user with sent email does not exists</response>
        [HttpPatch("avatar", Name = "UpdateAvatar")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult> UpdateAvatar(IFormFile avatar)
        {
            if (!ImageValidator.IsValid(avatar))
            {
                _logger.LogWarning("Exit upload avatar flow because: file is too big or it's not right extension");
                return BadRequest("File must be size maximum 2MB and in extensions: jpg, jpeg, png or gif");
            }
            _logger.LogInformation("[REQUEST] Request for avatar update created.");
            string userEmail = User.GetEmail();
            await _userService.UpdateAvatar(userEmail, avatar);
            _logger.LogInformation("[RESPONSE] Avatar updated. Response with new avatar created.");
            return Ok(ResponseMessagesDictionary.User.Avatar.Updated(userEmail));
        }

        /// <summary>
        /// [Admin, Librarian, User] Gets users avatar
        /// </summary>
        /// <response code="200">Returns users avatar</response>
        /// <response code="204">If user does not have avatar</response>
        /// <response code="404">If user with sent email does not exists</response>
        [HttpGet("avatar", Name = "GetAvatar")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public ActionResult GetAvatar()
        {
            _logger.LogInformation("[REQUEST] Request for avatar created.");
            string userEmail = User.GetEmail();
            byte[] avatar = _userService.GetAvatar(userEmail);
            _logger.LogInformation("[RESPONSE] Response with avatar created.");
            return File(avatar, "image/*");
        }

        /// <summary>
        /// [Admin, Librarian, User] Removes users avatar
        /// </summary>
        /// <response code="200">Returns if avatar is removed successfully</response>
        /// <response code="404">If user with sent email does not exists</response>
        [HttpPatch("removeAvatar", Name = "RemoveAvatar")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult> RemoveAvatar()
        {
            _logger.LogInformation("[REQUEST] Request for avatar removal created.");
            string userEmail = User.GetEmail();
            await _userService.DeleteAvatar(userEmail);
            _logger.LogInformation("[RESPONSE] Avatar removed successfully.");
            return Ok(ResponseMessagesDictionary.User.Avatar.Deleted(userEmail));
        }
    }
}
