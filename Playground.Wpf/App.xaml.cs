using System.Windows;

namespace Playground.Wpf
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new ShellWindow();
            var vm = new ShellWindowViewModel();

            mainWindow.DataContext = vm;

            Current.MainWindow = mainWindow;

            mainWindow.Show();
        }
    }
}
