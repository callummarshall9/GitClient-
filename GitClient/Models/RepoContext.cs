using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GitClient.Models
{
    public class RepoContext : DbContext
    {

        public DbSet<Repo> Repos;
        public DbSet<Settings> Settings;

        public String GetSetting(String Key)
        {
            var Results = Settings.Where(b => b.Value == Key).ToList();
            if(Results.Count == 0)
            {
                return "";
            } else
            {
                return Results[0].Value;
            }

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=repos.db");
        }
    }
}
