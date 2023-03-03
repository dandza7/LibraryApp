using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Services;
using LibraryApp.SupportClasses.JWTGenerator;
using LibraryApp.SupportClasses.ResponseMessagesDictionary;
using LibraryApp.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        private readonly IJWTGenerator _jwtGenerator;
        public AuthenticationController(IUserService userService, IMapper mapper, ILogger<UserController> logger, IJWTGenerator jwtGenerator)
        {
            _userService = userService;
            _mapper = mapper;
            _logger = logger;
            _jwtGenerator = jwtGenerator;
        }

        /// <summary>
        /// [Anonymous] Authenticates user
        /// </summary>
        /// <response code="200">Returns JWToken and its expiration date</response>
        /// <response code="400">If credentials do not match</response>
        /// <response code="404">If email does not exists in database</response>
        [HttpPost("LogIn", Name = "LogInUser")]
        [AllowAnonymous]
        public ActionResult<LogInResponseDTO> LogIn([FromBody] LogInRequestDTO logInRequestDTO)
        {
            _logger.LogInformation("[REQUEST] Request for user login created.");
            User? user = _userService.AuthenticateUser(logInRequestDTO);
            _logger.LogInformation("[RESPONSE] User with ID {user.Id} Successfully logged in.", user.Id);
            return Ok(_jwtGenerator.GenerateToken(user));
        }

        /// <summary>
        /// [Anonymous] Register user
        /// </summary>
        /// <response code="200">Returns ID of newly created user</response>
        /// <response code="400">If email already exists in database or if regular expression is not fullfilled</response>
        [HttpPost(Name = "RegisterUser")]
        [AllowAnonymous]
        public async Task<ActionResult<long>> Register([FromBody] NewUserDTO newUserDTO)
        {
            _logger.LogInformation("[REQUEST] Request for user registration created.");
            _userService.CheckEmailUniqueness(newUserDTO.Email);
            long createdUserId = await _userService.RegisterUser(_mapper.Map<User>(newUserDTO));
            _logger.LogInformation("[RESPONSE] User with ID {createdUserId} created.", createdUserId);
            return Ok(ResponseMessagesDictionary.User.Created(createdUserId));
        }

        /// <summary>
        /// [Admin] Updates users role
        /// </summary>
        /// <response code="200">Returns ID of newly created user</response>
        /// <response code="404">If user with sent ID does not exists</response>
        [HttpPatch("UpgradeRole/{id}", Name = "UpgradeUsersRole")]
        [Authorize(Roles = Roles.AuthorizationLevelAdmin)]
        public async Task<ActionResult> UpgradeUsersRole(long id)
        {
            _logger.LogInformation("[REQUEST] Request for upgrade role of user with ID {id}.", id);
            User? updatedUser = await _userService.UpgradeUsersRole(id);
            _logger.LogInformation("[RESPONSE] User with ID {updatedUser.Id} is now {updatedUser.Role}", updatedUser.Id, updatedUser.Role);
            return Ok(ResponseMessagesDictionary.User.Updated(id));
        }

        /// <summary>
        /// [Admin] Updates users role
        /// </summary>
        /// <response code="200">Returns ID of newly created user</response>
        /// <response code="404">If user with sent ID does not exists</response>
        [HttpPatch("DowngradeRole/{id}", Name = "DowngradeUsersRole")]
        [Authorize(Roles = Roles.AuthorizationLevelAdmin)]
        public async Task<ActionResult> DowngradeUsersRole(long id)
        {
            _logger.LogInformation("[REQUEST] Request for downgrade role of user with ID {id}.", id);
            User? updatedUser = await _userService.DowngradeUsersRole(id);
            _logger.LogInformation("[RESPONSE] User with ID {updatedUser.Id} is now {updatedUser.Role}", updatedUser.Id, updatedUser.Role);
            return Ok(ResponseMessagesDictionary.User.Updated(id));
        }
    }
}
