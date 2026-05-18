using FluentValidation;

namespace Slamty.Application.Features.UserProfile.Queries.GetProfile
{
    public class GetProfileQueryValidator : AbstractValidator<GetProfileQuery>
    {
        public GetProfileQueryValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("User ID is required.")
                .NotNull().WithMessage("User ID cannot be null.");
        }
    }
}
