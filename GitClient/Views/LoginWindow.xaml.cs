using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GitClient.ViewModels;

namespace GitClient.Views
{
    public class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginWindowViewModel(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}