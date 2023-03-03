using FluentValidation;
using LibraryApp.Models.DTO;
using LibraryApp.Services;

namespace LibraryApp.Validators
{
    public class UpdateBooksAuthorsDTOValidator : AbstractValidator<AddBooksAuthorsDTO>
    {
        IAuthorService _authorService;
        IBookService _bookService;

        public UpdateBooksAuthorsDTOValidator(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;

            RuleFor(ba => ba.BookId).NotEmpty()
                .Must(id => _bookService.IsThereBookWithId(id)).WithMessage(ba => $"There is no Book with id {ba.BookId}");
            RuleFor(ba => ba.AuthorId).NotEmpty()
                .Must(id => _authorService.IsThereAuthorWithId(id)).WithMessage(ba => $"There is no Author with id {ba.AuthorId}");
        }
    }
}
