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

    // LoginUserControl
    public string LoginEmail { get; set; } = string.Empty;
    public string LoginPassword { get; set; } = string.Empty;
    public ICommand LoginCommand { get; set; }
    public ICommand GoToResetPasswordCommand { get; set; }
    public ICommand GoToRegistrationCommand { get; set; }

    // RegisterUserControl
    public string RegisterEmail { get; set; } = string.Empty;
    public string RegisterPassword { get; set; } = string.Empty;
    public string RegisterPasswordRepeat { get; set; } = string.Empty;
    public ICommand RegisterAccountCommand { get; set; }
    public ICommand GoToLoginCommand { get; set; }

    // ResetPasswordUserControl
    public string ResetPasswordEmail { get; set; } = string.Empty;
    public ICommand SendResetEmailCommand { get; set; }

    public AuthViewModel()
    {
        this.LoginCommand = new RelayCommand(this.LoginCommandExecute);
        this.RegisterAccountCommand = new RelayCommand(this.RegisterAccountCommandExecute);
        this.SendResetEmailCommand = new RelayCommand(this.SendResetEmailCommandExecute);

        this.GoToResetPasswordCommand = new RelayCommand(this.GoToResetPasswordCommandExecute);
        this.GoToRegistrationCommand = new RelayCommand(this.GoToRegistrationCommandExecute);
        this.GoToLoginCommand = new RelayCommand(this.GoToLoginCommandExecute);
    }

    private void LoginCommandExecute()
    {
        MessageBox.Show("Login: " + this.LoginEmail + " - " + this.LoginPassword);
    }

    private void RegisterAccountCommandExecute()
    {
        MessageBox.Show($"register: {this.RegisterEmail} - {this.RegisterPassword} - {this.RegisterPasswordRepeat}");
    }

    private void SendResetEmailCommandExecute()
    {
        MessageBox.Show("reset pw: " + this.ResetPasswordEmail);
    }

    private void GoToResetPasswordCommandExecute()
    {
        this.ShowLogin = false;
        this.ShowRegistration = false;
        this.ShowPasswordReset = true;
    }
    private void GoToRegistrationCommandExecute()
    {
        this.ShowLogin = false;
        this.ShowRegistration = true;
        this.ShowPasswordReset = false;
    }
    private void GoToLoginCommandExecute()
    {
        this.ShowLogin = true;
        this.ShowRegistration = false;
        this.ShowPasswordReset = false;
    }
}
