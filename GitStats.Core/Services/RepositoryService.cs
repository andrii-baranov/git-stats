using GitStats.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitStats.Core.Services
{
    public class RepositoryService : GitStats.Core.Services.IRepositoryService
    {
        public List<Repository> GetRandomRepositories()
        {
            return new List<Repository>()
            {
                new Repository {Name = "repo name", Description = "Repo desc"},
                new Repository {Name = "repo name2", Description = "Repo desc 2"},
                new Repository {Name = "repo name3", Description = "Repo desc 3"},
                new Repository {Name = "repo name4", Description = "Repo desc 4"}
            };
        }

        public Repository GetRepoDetails(string id)
        {
            return new Repository
            {
                Name = "test name",
                Author = "John Doe",
                Description = "Description",
                Url = "https://github.com/andrii-baranov/git-stats"
            };
        }
    }
}
