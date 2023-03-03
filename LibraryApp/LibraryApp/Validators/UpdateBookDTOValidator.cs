using FluentValidation;
using LibraryApp.Models.DTO;
using LibraryApp.Services;

namespace LibraryApp.Validators
{
    public class UpdateBookDTOValidator : AbstractValidator<UpdateBookDTO>
    {
        private readonly IBookService _bookService;
        public UpdateBookDTOValidator(IBookService bookService)
        {
            _bookService = bookService;

            RuleFor(b => b.Id).NotEmpty()
                .Must(id => _bookService.IsThereBookWithId(id)).WithMessage(b => $"There is no Book with Id {b.Id}");
            RuleFor(b => b.Name).MaximumLength(100);
            RuleFor(b => b.Quantity).GreaterThanOrEqualTo(0);
        }
    }
}
