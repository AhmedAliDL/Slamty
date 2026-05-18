namespace Slamty.Application.Features.Auth.Dtos
{
    public sealed record OTPVerificationDto(string EmailAddress, string OTP);

}
