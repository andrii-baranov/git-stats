using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitStats.Core.Messages
{
    public class StatsRequest
    {
        public StatsRequest(string repoName)
        {
            RepoName = repoName;
        }

        public string RepoName { get; private set; }
    }
}
