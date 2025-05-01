using SimpleRPGClient.UI.Views;
using SimpleRPGClient.UI.Views.Auth;

namespace SimpleRPGClient.UI.Helper;

public static class WindowManager
{
    private static GameWindow? gameWindow;
    public static void OpenGameWindow()
    {
        GameWindow gameWindow = new GameWindow();
        gameWindow.Show();
    }

    public static void CloseGameWindow()
    {
        gameWindow?.Close();
        gameWindow = null;
    }

    private static AuthWindow? authWindow;
    public static void OpenAuthWindow()
    {
        AuthWindow authWindow = new AuthWindow();
        authWindow.Show();
    }

    public static void CloseAuthWindow()
    {
        authWindow?.Close();
        authWindow = null;
    }
}
