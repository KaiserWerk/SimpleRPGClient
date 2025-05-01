using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleRPGClient.UI.Views.Auth;

public partial class LoginUserControl : UserControl
{
    public LoginUserControl()
    {
        InitializeComponent();
    }   

    public string Email
    {
        get { return (string)GetValue(EmailProperty); }
        set { SetValue(EmailProperty, value); }
    }

    public static readonly DependencyProperty EmailProperty =
      DependencyProperty.Register(nameof(Email), typeof(string), typeof(LoginUserControl), new PropertyMetadata(string.Empty));

    public string Password
    {
        get { return (string)GetValue(PasswordProperty); }
        set { SetValue(PasswordProperty, value); }
    }

    public static readonly DependencyProperty PasswordProperty =
      DependencyProperty.Register(nameof(Password), typeof(string), typeof(LoginUserControl), new PropertyMetadata(string.Empty));

    private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        this.Password = this.PasswordBox.Password;
    }

    public int LoginCommand
    {
        get { return (int)GetValue(LoginCommandProperty); }
        set { SetValue(LoginCommandProperty, value); }
    }

    public static readonly DependencyProperty LoginCommandProperty =
        DependencyProperty.Register(nameof(LoginCommand), typeof(ICommand), typeof(LoginUserControl), new PropertyMetadata(null));

    public int GoToResetPasswordCommand
    {
        get { return (int)GetValue(GoToResetPasswordCommandProperty); }
        set { SetValue(GoToResetPasswordCommandProperty, value); }
    }

    public static readonly DependencyProperty GoToResetPasswordCommandProperty =
        DependencyProperty.Register(nameof(GoToResetPasswordCommand), typeof(ICommand), typeof(LoginUserControl), new PropertyMetadata(null));

    public int GoToRegistrationCommand
    {
        get { return (int)GetValue(GoToRegistrationCommandProperty); }
        set { SetValue(GoToRegistrationCommandProperty, value); }
    }

    public static readonly DependencyProperty GoToRegistrationCommandProperty =
        DependencyProperty.Register(nameof(GoToRegistrationCommand), typeof(ICommand), typeof(LoginUserControl), new PropertyMetadata(null));

}
