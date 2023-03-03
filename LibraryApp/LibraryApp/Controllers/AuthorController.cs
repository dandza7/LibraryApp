using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;
using LibraryApp.Services;
using LibraryApp.SupportClasses.ResponseMessagesDictionary;
using LibraryApp.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LibraryApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public AuthorController(IAuthorService authorService, IMapper mapper, ILogger<UserController> logger)
        {
            _authorService = authorService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// [Admin, Librarian, User] Gets all authors (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders
        /// <br/>  >>> OrderField must be one of the following: ID, FirstName, LastName
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), FirstName (string), LastName (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all authors</response>
        /// <response code="204">If there are no authors in database</response>
        [HttpPost(Name = "GetAllAuthors")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public ActionResult<PaginationResponseWrapper<PreviewAuthorDTO>> GetAll(PaginationQueryDTO paginationQueryDTO)
        {
            _logger.LogInformation("[REQUEST] Request for all Authors created.");
            var authors = _authorService.GetAll(paginationQueryDTO);
            _logger.LogInformation("[RESPONSE] Response with all Authors created.");
            return Ok(new PaginationResponseWrapper<PreviewAuthorDTO>(_mapper.Map<List<PreviewAuthorDTO>>(authors.Items), authors.TotalCount));
        }

        /// <summary>
        /// [Admin, Librarian, User] Gets author by ID
        /// </summary>
        /// <response code="200">Returns all authors</response>
        /// <response code="404">If Author with sent ID does not exists</response>
        [HttpGet("{id}", Name = "GetAuthorById")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult<PreviewAuthorDTO>> GetById(long id)
        {
            _logger.LogInformation("[REQUEST] Request for Author with ID: {id} created.", id);
            var author = await _authorService.GetById(id);
            _logger.LogInformation("[RESPONSE] Response with Author with ID: {author.Id} created.", author.Id);
            return Ok(_mapper.Map<PreviewAuthorDTO>(author));
        }

        /// <summary>
        /// [Admin, Librarian] Deletes author by ID
        /// </summary>
        /// <response code="200">If Author is deleted successfully</response>
        /// <response code="404">If Author with sent ID does not exists</response>
        [HttpDelete("{id}", Name = "DeleteById")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult> DeleteAuthor(long id)
        {
            _logger.LogInformation("[REQUEST] Request for author deleting created.");
            await _authorService.DeleteAuthor(id);
            _logger.LogInformation("[RESPONSE] Author with ID {id} deleted.", id);
            return Ok(ResponseMessagesDictionary.Author.Deleted(id));
        }

        /// <summary>
        /// [Admin, Librarian] Adds new author
        /// </summary>
        /// <response code="200">Returns ID of newly created author</response>
        [HttpPost("add", Name = "AddAuthor")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<long>> AddAuthor([FromBody] NewAuthorDTO newAuthorDTO)
        {
            _logger.LogInformation("[REQUEST] Request for adding new author created.");
            long createdAuthorId = await _authorService.CreateAuthor(_mapper.Map<Author>(newAuthorDTO));
            _logger.LogInformation("[RESPONSE] Author with ID {createdAuthorId} created.", createdAuthorId);
            return Ok(ResponseMessagesDictionary.Author.Created(createdAuthorId));
        }

        /// <summary>
        /// [Admin, Librarian] Updates author
        /// </summary>
        /// <response code="200">Returns ID of updated author</response>
        /// <response code="404">If Author with sent ID does not exists</response>
        [HttpPatch(Name = "UpdateAuthor")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<long>> UpdateAuthor([FromBody] UpdateAuthorDTO updateAuthorDTO)
        {
            _logger.LogInformation("[REQUEST] Request for adding new book created.");
            var updatedAuthor = await _authorService.Update(updateAuthorDTO);
            _logger.LogInformation("[RESPONSE] Book with ID {updatedAuthor.Id} created.", updatedAuthor.Id);
            return Ok(ResponseMessagesDictionary.Author.Updated(updatedAuthor.Id));
        }

        /// <summary>
        /// [Admin, Librarian, User] Gets all books of Author with sent ID
        /// </summary>
        /// <response code="200">Returns all books of Author with sent ID</response>
        /// <response code="404">If Author with sent ID does not exists</response>
        [HttpGet("books/{id}", Name = "GetAuthorsBooks")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult<IEnumerable<PreviewBookDTO>>> GetAuthorsBooks(long id)
        {
            _logger.LogInformation("[REQUEST] Request for get all Books of Author with ID: {id} created.", id);
            var books = await _authorService.GetAuthorsBooks(id);
            _logger.LogInformation("[RESPONSE] Response with all Books of Author with ID: {id} created.", id);
            return Ok(_mapper.Map<IEnumerable<PreviewBookDTO>>(books));
        }
    }
}
