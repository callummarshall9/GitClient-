using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitClient.ViewModels
{
    public class CloneRepositoryViewModel : ViewModelBase
    {
        Window Window;
        public String CloneURL { get; set; }
        public CloneRepositoryViewModel(Window Parent)
        {
            Window = Parent;
        }

        public void CloneRepository()
        {

            Window.Close();
        }
    }
}
