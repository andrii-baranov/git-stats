using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GitStats.Domain.Models;
using GitStats.Core.Services;

namespace GitStats.Web.Controllers
{
    public class RepoController : ApiController
    {
        private IRepositoryService _service;

        public RepoController()
        {
            // todo use IOC for this
            _service = new RepositoryService();
        }
        
        [HttpGet]
        [Route("api/repo/list")]
        public List<GitStats.Domain.Models.Repository> Get()
        {
           return _service.GetRandomRepositories();
        }

        [HttpGet]
        [Route("api/repo/{id:int}")]
        public Repository Get(int id)
        {
           return _service.GetRepoDetails(id.ToString());
        }
    }
}
