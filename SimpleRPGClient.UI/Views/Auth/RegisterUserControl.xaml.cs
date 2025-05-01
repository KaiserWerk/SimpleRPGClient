using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleRPGClient.UI.Views.Auth;

public partial class RegisterUserControl : UserControl
{
    public RegisterUserControl()
    {
        InitializeComponent();
    }



    public string Email
    {
        get { return (string)GetValue(EmailProperty); }
        set { SetValue(EmailProperty, value); }
    }

    public static readonly DependencyProperty EmailProperty =
        DependencyProperty.Register(nameof(Email), typeof(string), typeof(RegisterUserControl), new PropertyMetadata(string.Empty));



    public string Password
    {
        get { return (string)GetValue(PasswordProperty); }
        set { SetValue(PasswordProperty, value); }
    }

    public static readonly DependencyProperty PasswordProperty =
        DependencyProperty.Register(nameof(Password), typeof(string), typeof(RegisterUserControl), new PropertyMetadata(string.Empty));



    public string PasswordRepeat
    {
        get { return (string)GetValue(PasswordRepeatProperty); }
        set { SetValue(PasswordRepeatProperty, value); }
    }

    public static readonly DependencyProperty PasswordRepeatProperty =
        DependencyProperty.Register(nameof(PasswordRepeat), typeof(string), typeof(RegisterUserControl), new PropertyMetadata(string.Empty));



    public ICommand RegisterAccountCommand
    {
        get { return (ICommand)GetValue(RegisterAccountCommandProperty); }
        set { SetValue(RegisterAccountCommandProperty, value); }
    }

    public static readonly DependencyProperty RegisterAccountCommandProperty =
        DependencyProperty.Register(nameof(RegisterAccountCommand), typeof(ICommand), typeof(RegisterUserControl), new PropertyMetadata(null));

    public ICommand GoToLoginCommand
    {
        get { return (ICommand)GetValue(GoToLoginCommandProperty); }
        set { SetValue(GoToLoginCommandProperty, value); }
    }

    public static readonly DependencyProperty GoToLoginCommandProperty =
        DependencyProperty.Register(nameof(GoToLoginCommand), typeof(ICommand), typeof(RegisterUserControl), new PropertyMetadata(null));

    private void Password_Changed(object sender, RoutedEventArgs e)
    {
        this.Password = this.PasswordBox.Password;
    }

    private void PasswordRepeat_Changed(object sender, RoutedEventArgs e)
    {
        this.PasswordRepeat = this.PasswordRepeatBox.Password;
    }
}
