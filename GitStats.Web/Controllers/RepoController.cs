using GitStats.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitStats.Web.Controllers
{
    public class RepoController : ApiController
    {
        [HttpGet]
        [Route("api/repo/list")]
        public List<Repo> Get()
        {
            return new List<Repo>()
            {
                new Repo {Name = "repo name", Description = "Repo desc"},
                new Repo {Name = "repo name2", Description = "Repo desc 2"},
                new Repo {Name = "repo name3", Description = "Repo desc 3"},
                new Repo {Name = "repo name4", Description = "Repo desc 4"}
            };
        }

        [HttpGet]
        [Route("api/repo/{id:int}")]
        public Repo Get(int id)
        {
            return new Repo { Name = "repo name", Description = "Repo desc" };
        }
    }
}
