using MediatR;
using Slamty.Application.Features.Auth.Dtos;
using Slamty.Application.ResponseTypes;

namespace Slamty.Application.Features.Auth.Commands.ResetPassword
{
    public record ResetPasswordCommand(ResetPasswordDto ResetPasswordDto) : IRequest<ApiResponse<bool>>;


}
