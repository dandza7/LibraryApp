using FluentValidation;
using LibraryApp.Models.DTO;

namespace LibraryApp.Validators
{
    public class LoginRequestDTOValidator : AbstractValidator<LogInRequestDTO>
    {
        public LoginRequestDTOValidator()
        {
            RuleFor(login => login.Email).NotEmpty();
            RuleFor(login => login.Password).NotEmpty();
        }
    }
}
