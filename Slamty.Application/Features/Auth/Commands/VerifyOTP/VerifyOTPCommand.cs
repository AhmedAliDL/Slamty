using MediatR;
using Slamty.Application.Features.Auth.Dtos;
using Slamty.Application.ResponseTypes;

namespace Slamty.Application.Features.Auth.Commands.VerifyOTP
{
    public record VerifyOTPCommand(OTPVerificationDto OTPVerificationDto) : IRequest<ApiResponse<bool>>;


}
