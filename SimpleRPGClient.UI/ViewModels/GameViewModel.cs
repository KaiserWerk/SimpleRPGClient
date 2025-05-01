using KaiserMVVMCore;
using SimpleRPGClient.Core.Models.Auth;
using SimpleRPGClient.Core.Services;
using SimpleRPGClient.UI.Messages;

namespace SimpleRPGClient.UI.ViewModels;

public class GameViewModel : ViewModelBase
{
    private readonly IAuthenticationService authService;
    private LoginResponse? loginData;

    public GameViewModel(IAuthenticationService authService)
    {
        this.authService = authService;

        Messenger.Register<LoginMessage>(this.HandleLogin);
    }

    private void HandleLogin(object obj)
    {
        if (!(obj is LoginMessage loginMessage)) 
            return;

        if (loginMessage.LoginData == null)
            return;

        this.loginData = loginMessage.LoginData;
    }
}
