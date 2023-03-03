using FluentValidation;
using LibraryApp.Models.DTO;

namespace LibraryApp.Validators
{
    public class NewAuthorDTOValidator : AbstractValidator<NewAuthorDTO>
    {
        public NewAuthorDTOValidator()
        {
            RuleFor(a => a.FirstName).NotEmpty().MaximumLength(100);
            RuleFor(a => a.LastName).NotEmpty().MaximumLength(100);
        }
    }
}
