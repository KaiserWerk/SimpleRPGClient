using SimpleRPGClient.Core.Models.Auth;

namespace SimpleRPGClient.Core.Services;

public class AuthenticationService : IAuthenticationService
{
    public async Task<LoginResponse> Login(LoginRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<LogoutResponse> Logout(LogoutRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<RegistrationResponse> Register(RegistrationRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<ConfirmRegistrationResponse> ConfirmRegistration(ConfirmRegistrationRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<InitiatePasswordResetResponse> InitiatePasswordReset(InitiatePasswordResetRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<SetNewPasswordResponse> InitiatePasswordReset(SetNewPasswordRequest request)
    {
        throw new NotImplementedException();
    }
}
