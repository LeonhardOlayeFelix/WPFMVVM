using System.Configuration;
using System.Data;
using System.Windows;
using System.Runtime.InteropServices;

namespace WPFMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AllocConsole();

            InitialiseServices();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void InitialiseServices()
        {
            
        }

    }

}
