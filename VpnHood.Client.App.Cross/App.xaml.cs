using Microsoft.Maui.Controls;

namespace VpnHood.Client.App.Cross;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MainPage();
    }
}