using KaiserMVVMCore;
using System.Windows;
using System.Windows.Input;

namespace SimpleRPGClient.UI.ViewModels.Auth;

public class AuthViewModel : ViewModelBase
{
    private bool showLogin = true;
    public bool ShowLogin { get => showLogin; set => base.Set(ref this.showLogin, value); }

    private bool showRegistration = false;
    public bool ShowRegistration { get => showRegistration; set => base.Set(ref this.showRegistration, value); }

    private bool showPasswordReset = false;
    public bool ShowPasswordReset { get => showPasswordReset; set => base.Set(ref this.showPasswordReset, value); }

    public string LoginEmail { get; set; } = string.Empty;
    public string LoginPassword { get; set; } = string.Empty;
    public ICommand LoginCommand { get; set; }
    public ICommand LoginResetPasswordCommand { get; set; }

    public AuthViewModel()
    {
        this.LoginCommand = new RelayCommand(this.LoginCommandExecute);
        this.LoginResetPasswordCommand = new RelayCommand(this.LoginResetPasswordCommandExecute);
    }

    private void LoginCommandExecute()
    {
        MessageBox.Show("Login: " + this.LoginEmail + " - " + this.LoginPassword);
    }

    private void LoginResetPasswordCommandExecute()
    {
        MessageBox.Show("Login: Reset PW!");
    }
}
