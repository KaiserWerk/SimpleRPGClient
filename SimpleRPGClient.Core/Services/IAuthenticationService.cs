using SimpleRPGClient.Core.Models.Auth;

namespace SimpleRPGClient.Core.Services
{
    public interface IAuthenticationService
    {
        Task<LoginResponse> Login(LoginRequest request);
        Task<LogoutResponse> Logout(LogoutRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request);
        Task<ConfirmRegistrationResponse> ConfirmRegistration(ConfirmRegistrationRequest request);
        Task<InitiatePasswordResetResponse> InitiatePasswordReset(InitiatePasswordResetRequest request);
        Task<SetNewPasswordResponse> SetNewPassword(SetNewPasswordRequest request);
    }
}