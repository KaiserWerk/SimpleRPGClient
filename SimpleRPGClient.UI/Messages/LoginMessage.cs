using SimpleRPGClient.Core.Models.Auth;

namespace SimpleRPGClient.UI.Messages;

public class LoginMessage
{
    public LoginResponse LoginData;

    public LoginMessage(LoginResponse loginData)
    {
        this.LoginData = loginData;
    }
}
