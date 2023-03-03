using FluentValidation;
using LibraryApp.Models.DTO;

namespace LibraryApp.Validators
{
    public class UpdateProfileDTOValidator : AbstractValidator<UpdateProfileDTO>
    {
        public UpdateProfileDTOValidator()
        {
            RuleFor(p => p.FirstName).MaximumLength(100);
            RuleFor(p => p.LastName).MaximumLength(100);
        }
    }
}
