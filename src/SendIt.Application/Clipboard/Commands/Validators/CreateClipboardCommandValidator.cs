using FluentValidation;

namespace SendIt.Application.Clipboard.Commands.Validators
{
    public class CreateClipboardCommandValidator: AbstractValidator<CreateClipboardRequest>
    {
        public CreateClipboardCommandValidator()
        {
            RuleFor(r => r.Data)
                .NotNull()
                .NotEmpty()
                .WithMessage("Object cannot be null or empty");

            RuleFor(r => r.Data.ClipboardName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Property cannot be null or empty");
        }
    }
}
