using KaiserMVVMCore;
using SimpleRPGClient.Core.Services;
using SimpleRPGClient.UI.ViewModels.Auth;

namespace SimpleRPGClient.UI.ViewModels;

public class ViewModelLocator
{
    public ViewModelLocator()
    {
        // dependencies
        Container.Default.Register<IAuthenticationService, AuthenticationService>();

        // viewmodels
        Container.Default.Register<AuthViewModel>();
        Container.Default.Register<GameViewModel>();
    }

    public AuthViewModel AuthViewModel => Container.Default.GetInstance<AuthViewModel>();
    public GameViewModel GameViewModel => Container.Default.GetInstance<GameViewModel>();
}
