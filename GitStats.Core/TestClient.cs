using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitStats.Core
{
    public class TestClient
    {
        public async Task<User> GetUserInfo(string userId)
        {
            var client = new GitHubClient(new ProductHeaderValue("GitStats"));

            var user = client.User.Get(userId);

            return await user;
        }
    }
}
