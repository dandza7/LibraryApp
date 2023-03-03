using FluentValidation;
using LibraryApp.Models.DTO;

namespace LibraryApp.Validators
{
    public class NewBookDTOValidator : AbstractValidator<NewBookDTO>
    {
        public NewBookDTOValidator()
        {
            RuleFor(b => b.Name).NotEmpty().MaximumLength(100);
            RuleFor(b => b.Quantity).GreaterThanOrEqualTo(0);
        }
    }
}
