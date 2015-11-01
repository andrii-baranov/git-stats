using System;
namespace GitStats.Core.Services
{
    public interface IRepositoryService
    {
        System.Collections.Generic.List<GitStats.Domain.Models.Repository> GetRandomRepositories();
        GitStats.Domain.Models.Repository GetRepoDetails(string id);
    }
}
