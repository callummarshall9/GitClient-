using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitClient.ViewModels
{
    public class LoginWindowViewModel : ViewModelBase
    {
        Window owner;
        public LoginWindowViewModel(Window window)
        {
            owner = window;
        }
        public void Login()
        {
            owner.Close();
        }
    }
}
