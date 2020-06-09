using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GitClient.ViewModels;

namespace GitClient.Views
{
    public class CloneRepositoryWindow : Window
    {
        public CloneRepositoryWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            DataContext = new CloneRepositoryViewModel(this);
            MaxWidth = 400;
            MaxHeight = 75;
            CanResize = false;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
