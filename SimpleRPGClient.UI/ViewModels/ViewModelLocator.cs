using KaiserMVVMCore;
using SimpleRPGClient.UI.ViewModels.Auth;

namespace SimpleRPGClient.UI.ViewModels;

public class ViewModelLocator
{
    public ViewModelLocator()
    {
        Container.Default.Register<AuthViewModel>();
    }

    public AuthViewModel AuthViewModel => Container.Default.GetInstance<AuthViewModel>();
}
