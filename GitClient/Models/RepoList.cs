using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GitClient.Models
{
    public class RepoList
    {
        public ObservableCollection<Repo> Repos { get; } = new ObservableCollection<Repo>();
    }
}
