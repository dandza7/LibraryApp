using FluentValidation;
using LibraryApp.Models.DTO;

namespace LibraryApp.Validators
{
    public class RemoveBooksAuthorDTOValidator : AbstractValidator<RemoveBooksAuthorDTO>
    {
        public RemoveBooksAuthorDTOValidator()
        {
            RuleFor(ba => ba.BookId).NotEmpty();
            RuleFor(ba => ba.AuthorId).GreaterThanOrEqualTo(0);
        }
    }
}
