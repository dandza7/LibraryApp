using FluentValidation;
using LibraryApp.Models.DTO;

namespace LibraryApp.Validators
{
    public class NewUserDTOValidator : AbstractValidator<NewUserDTO>
    {
        public NewUserDTOValidator()
        {
            RuleFor(u => u.FirstName).MaximumLength(100);
            RuleFor(u => u.LastName).MaximumLength(100);
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(user => user.Password).NotEmpty().WithMessage("Password is required!")
                .NotNull().WithMessage("Password is required!")
                .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more capital letters!")
                .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters!")
                .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits!")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{PropertyName}' must contain one or more special characters!")
                .Matches("^[^£# “”]*$").WithMessage("'{PropertyName}' must not contain the following characters £ # “” or spaces!")
                .Length(8, 16).WithMessage("Password should be between 8 and 16 characters!");
        }
    }
}
