using Avalonia.Controls;
using GitClient.Models;
using GitClient.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace GitClient.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Repo> Repos { get; }
        Window Window;
        public MainWindowViewModel(Window Parent)
        {
            Repos = new ObservableCollection<Repo>(FillRepos());
            Window = Parent;
        }

        public void CloneRepository()
        {
            CloneRepositoryWindow CloneWindow = new CloneRepositoryWindow();
            CloneWindow.ShowDialog(Window);
        }

        private List<Repo> FillRepos()
        {
            return new List<Repo>() {
                new Repo()
                {
                    RepoName = "Git Repo 1",
                    RepoBranches =
                    {
                        new Branch()
                        {
                            BranchName = "master"
                        },
                        new Branch()
                        {
                            BranchName = "dev"
                        }
                    }
                }, new Repo()
                {
                    RepoName = "Git Repo 2",
                    RepoBranches =
                    {
                        new Branch()
                        {
                            BranchName = "master"
                        },
                        new Branch()
                        {
                            BranchName = "dev"
                        }
                    }
                }
             };
        }
    }
}
