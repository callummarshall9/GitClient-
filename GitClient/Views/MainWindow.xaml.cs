using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GitClient.ViewModels;
using System.Threading.Tasks;

namespace GitClient.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            DataContext = new MainWindowViewModel(this);
            

            /*var LoginForm = new LoginWindow();
            LoginForm.MaxWidth = 400;
            LoginForm.MaxHeight = 150;
            LoginForm.ShowDialog(this);*/
        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

    }
}
