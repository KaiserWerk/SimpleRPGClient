using SimpleRPGClient.Core.Models.Auth;

namespace SimpleRPGClient.Core.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient httpClient;

    public AuthenticationService()
    {
        
    }

    public async Task<LoginResponse> Login(LoginRequest request)
    {
        
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

    public async Task<SetNewPasswordResponse> SetNewPassword(SetNewPasswordRequest request)
    {
        throw new NotImplementedException();
    }
}
