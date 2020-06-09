using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GitClient.Models
{

    public class Repo
    {
        public string RepoLocalURL { get; set; }
        public string RepoRemoteURL { get; set;  }
        public string RepoName { get; set; }
        public ObservableCollection<Branch> RepoBranches { get; } = new ObservableCollection<Branch>();
    }
}
