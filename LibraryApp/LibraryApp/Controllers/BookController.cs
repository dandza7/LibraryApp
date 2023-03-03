using AutoMapper;
using LibraryApp.Models;
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
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public BookController(IBookService bookService, IMapper mapper, ILogger<UserController> logger)
        {
            _bookService = bookService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// [Admin, Librarian, User] Gets all books (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name, Quantity
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), Name (string), Quantity (number)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all books</response>
        /// <response code="204">If there are no books in database</response>
        [HttpPost(Name = "GetAllBooks")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public ActionResult<PaginationResponseWrapper<PreviewBookDTO>> GetAll(PaginationQueryDTO paginationQueryDTO)
        {
            _logger.LogInformation("[REQUEST] Request for get all Books created.");
            var books = _bookService.GetAll(paginationQueryDTO);
            _logger.LogInformation("[RESPONSE] Response with all Books created.");
            return Ok(new PaginationResponseWrapper<PreviewBookDTO>(_mapper.Map<List<PreviewBookDTO>>(books.Items), books.TotalCount));
        }

        /// <summary>
        /// [Admin, Librarian, User] Gets book by ID
        /// </summary>
        /// <response code="200">Returns book with sent ID</response>
        /// <response code="404">If book with sent ID does not exists</response>
        [HttpGet("{id}", Name = "GetBooksDetails")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult<PreviewBookDetailedDTO>> GetBooksDetails(long id)
        {
            _logger.LogInformation("[REQUEST] Request for Book with ID {id} created.", id);
            var book = await _bookService.GetByIdDetailed(id);
            _logger.LogInformation("[RESPONSE] Response with Book with ID {id} created.", id);
            return Ok(_mapper.Map<PreviewBookDetailedDTO>(book));
        }

        /// <summary>
        /// [Admin, Librarian] Gets books rent history by books ID
        /// </summary>
        /// <response code="200">Returns books rent history</response>
        /// <response code="204">Returns if book has not been rented yet</response>
        /// <response code="404">If book with sent ID does not exists</response>
        [HttpGet("rentHistory/{id}", Name = "GetBooksRentHistory")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<PreviewBookRentHistoryDTO>> GetBooksRentHistory(long id)
        {
            _logger.LogInformation("[REQUEST] Request for rent history of Book with ID {id} created.", id);
            var booksRentHistory = await _bookService.GetBooksRentHistory(id);
            _logger.LogInformation("[RESPONSE] Response with rent history of Book with ID {id} created.", id);
            return Ok(booksRentHistory);
        }

        /// <summary>
        /// [Admin, Librarian] Adds new book
        /// </summary>
        /// <response code="200">Returns ID of newly created book</response>
        /// <response code="404">If author with sent ID does not exist</response>
        [HttpPost("add", Name = "AddBook")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<long>> AddBook([FromBody] NewBookDTO newBookDTO)
        {
            _logger.LogInformation("[REQUEST] Request for adding new book created.");
            long createdBookId = await _bookService.CreateBook(newBookDTO);
            _logger.LogInformation("[RESPONSE] Book with ID {createdBookId} created.", createdBookId);
            return Ok(ResponseMessagesDictionary.Book.Created(createdBookId));
        }

        /// <summary>
        /// [Admin, Librarian] Updates book
        /// </summary>
        /// <response code="200">Returns ID of updated book</response>
        /// <response code="404">If book with sent ID does not exist</response>
        [HttpPatch(Name = "UpdateBook")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<PreviewBookDetailedDTO>> UpdateBook([FromBody] UpdateBookDTO updateBookDTO)
        {
            _logger.LogInformation("[REQUEST] Request for update of a book created.");
            var updatedBook = await _bookService.UpdateBook(updateBookDTO);
            _logger.LogInformation("[RESPONSE] Book with ID {updatedBook.Id} updated.", updatedBook.Id);
            return Ok(ResponseMessagesDictionary.Book.Updated(updatedBook.Id));
        }

        /// <summary>
        /// [Admin, Librarian] Updates authors of book
        /// </summary>
        /// <response code="200">Returns book with authors</response>
        /// <response code="400">If author or book with sent ID does not exist</response>
        [HttpPatch("/authors", Name = "AddBooksAuthors")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<PreviewBookDetailedDTO>> AddBooksAuthors([FromBody] AddBooksAuthorsDTO addBooksAuthorsDTO)
        {
            _logger.LogInformation("[REQUEST] Request for books authors update created.");
            Book? updatedBook = await _bookService.AddAuthor(addBooksAuthorsDTO);
            _logger.LogInformation("[RESPONSE] Authors of book with ID {updatedBook.Id} updated.", updatedBook.Id);
            return Ok(ResponseMessagesDictionary.Book.Updated(updatedBook.Id));
        }

        /// <summary>
        /// [Admin, Librarian] Updates authors of book
        /// </summary>
        /// <response code="200">Returns book with authors</response>
        /// <response code="400">If author or book with sent ID does not exist</response>
        [HttpPatch("/deleteAuthors", Name = "RemoveBooksAuthors")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult<PreviewBookDetailedDTO>> RemoveBooksAuthors([FromBody] RemoveBooksAuthorDTO removeBooksAuthorsDTO)
        {
            _logger.LogInformation("[REQUEST] Request for books authors update created.");
            Book? updatedBook = await _bookService.RemoveAuthor(removeBooksAuthorsDTO);
            _logger.LogInformation("[RESPONSE] Authors of book with ID {updatedBook.Id} updated.", updatedBook.Id);
            return Ok(ResponseMessagesDictionary.Book.Updated(updatedBook.Id));
        }

        /// <summary>
        /// [Admin, Librarian] Deletes book
        /// </summary>
        /// <response code="200">If book is deleted</response>
        /// <response code="404">If book with sent ID does not exist</response>
        [HttpDelete("{id}", Name = "DeleteBook")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult> DeleteBook(long id)
        {
            _logger.LogInformation("[REQUEST] Request for book deleting created.");
            await _bookService.DeleteBook(id);
            _logger.LogInformation("[RESPONSE] Book with ID {id} deleted.", id);
            return Ok(ResponseMessagesDictionary.Book.Deleted(id));
        }

        /// <summary>
        /// [Admin, Librarian] Updates book's cover
        /// </summary>
        /// <response code="200">If cover is updated successfully</response>
        /// <response code="400">If cover is too big or in wrong extension</response>
        /// <response code="404">If book with sent id does not exists</response>
        [HttpPatch("cover", Name = "UpdateCover")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult> UpdateCover(long id, IFormFile cover)
        {
            if (!ImageValidator.IsValid(cover))
            {
                _logger.LogWarning("Exit upload cover flow because: file is too big or it's not right extension");
                return BadRequest("File must be size maximum 2MB and in extensions: jpg, jpeg, png or gif");
            }
            _logger.LogInformation("[REQUEST] Request for cover update created.");
            await _bookService.UpdateBookCover(id, cover);
            _logger.LogInformation("[RESPONSE] Cover updated. Response with new cover created.");
            return Ok(ResponseMessagesDictionary.Book.Cover.Updated(id));
        }

        /// <summary>
        /// [Admin, Librarian] Gets book's cover
        /// </summary>
        /// <response code="200">Returns book 's cover</response>
        /// <response code="204">If book does not have cover</response>
        /// <response code="404">If book with sent id does not exists</response>
        [HttpGet("cover", Name = "GetCover")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult> GetCover(long id)
        {
            _logger.LogInformation("[REQUEST] Request for cover created.");
            byte[] cover = await _bookService.GetBookCover(id);
            _logger.LogInformation("[RESPONSE] Response with cover created.");
            return File(cover, "image/*");
        }

        /// <summary>
        /// [Admin, Librarian] Removes book's cover
        /// </summary>
        /// <response code="200">Returns if cover is removed successfully</response>
        /// <response code="404">If book with sent id does not exists</response>
        [HttpPatch("removeCover", Name = "RemoveCover")]
        [Authorize(Roles = Roles.AuthorizationLevelLibrarian)]
        public async Task<ActionResult> RemoveCover(long id)
        {
            _logger.LogInformation("[REQUEST] Request for cover removal created.");
            await _bookService.DeleteBookCover(id);
            _logger.LogInformation("[RESPONSE] Cover removed successfully.");
            return Ok(ResponseMessagesDictionary.Book.Cover.Deleted(id));
        }

        [HttpPost("rentBook", Name = "RentBook")]
        [Authorize(Roles = Roles.AuthorizationLevelUser)]
        public async Task<ActionResult> RentBook(long id)
        {
            _logger.LogInformation("[REQUEST] Request for book rented.");
            string email = User.GetEmail();
            if (!await _bookService.RentBook(id, email))
            {
                _logger.LogInformation("[RESPONSE] Book isn't rented because there is no available in stock.");
                return StatusCode(204, $"There is no book with id = {id} in stock.");
            }
            _logger.LogInformation("[RESPONSE] Book rented successfully.");
            return Ok($"Book with id = {id} rented successfully.");
        }
    }
}
