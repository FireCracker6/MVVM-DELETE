using System.Windows;
using WPF_APP_CONTACTS_MVVM.MVVM.ViewModels;

namespace WPF_APP_CONTACTS_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
