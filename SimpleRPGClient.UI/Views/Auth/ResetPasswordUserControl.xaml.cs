using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleRPGClient.UI.Views.Auth;

public partial class ResetPasswordUserControl : UserControl
{
    public ResetPasswordUserControl()
    {
        InitializeComponent();
    }


    public string Email
    {
        get { return (string)GetValue(EmailProperty); }
        set { SetValue(EmailProperty, value); }
    }

    public static readonly DependencyProperty EmailProperty =
        DependencyProperty.Register(nameof(Email), typeof(string), typeof(ResetPasswordUserControl), new PropertyMetadata(string.Empty));


    public ICommand SendResetEmailCommand
    {
        get { return (ICommand)GetValue(SendResetEmailCommandProperty); }
        set { SetValue(SendResetEmailCommandProperty, value); }
    }

    public static readonly DependencyProperty SendResetEmailCommandProperty =
        DependencyProperty.Register(nameof(SendResetEmailCommand), typeof(ICommand), typeof(ResetPasswordUserControl), new PropertyMetadata(null));


    public ICommand GoToLoginCommand
    {
        get { return (ICommand)GetValue(GoToLoginCommandProperty); }
        set { SetValue(GoToLoginCommandProperty, value); }
    }

    public static readonly DependencyProperty GoToLoginCommandProperty =
        DependencyProperty.Register(nameof(GoToLoginCommand), typeof(ICommand), typeof(ResetPasswordUserControl), new PropertyMetadata(null));


}
