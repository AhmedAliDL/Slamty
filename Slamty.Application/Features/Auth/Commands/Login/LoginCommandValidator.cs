using FluentValidation;

namespace Slamty.Application.Features.Auth.Commands.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.NationalId).NotEmpty().WithMessage("National ID is required.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required.");
        }
    }
}
