using FluentValidation;
using LibraryApp.Models.DTO;
using LibraryApp.Services;

namespace LibraryApp.Validators
{
    public class UpdateAuthorDTOValidator : AbstractValidator<UpdateAuthorDTO>
    {
        private readonly IAuthorService _authorService;
        public UpdateAuthorDTOValidator(IAuthorService authorService)
        {
            _authorService = authorService;

            RuleFor(a => a.Id).NotEmpty().Must(id => _authorService.IsThereAuthorWithId(id)).WithMessage(a => $"There is no Author with Id {a.Id}");
            RuleFor(a => a.FirstName).MaximumLength(100);
            RuleFor(a => a.LastName).MaximumLength(100);
        }
    }
}
