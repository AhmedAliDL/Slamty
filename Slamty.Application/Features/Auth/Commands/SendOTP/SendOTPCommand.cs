using MediatR;
using Slamty.Application.ResponseTypes;

namespace Slamty.Application.Features.Auth.Commands.SendOTP
{
    public record SendOTPCommand(string EmailAddress) : IRequest<ApiResponse<bool>>;

}
