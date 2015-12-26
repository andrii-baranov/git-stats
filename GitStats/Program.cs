using Akka.Actor;
using GitStats.Core;
using GitStats.Core.Actors;
using GitStats.Core.Messages;
using GitStats.Data;
using GitStats.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitStats
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var repo = new MongoDbRepository("mongodb://localhost:27017/test");

                //Repository testData = new Repository
                //{
                //    Author = "AB",
                //    Description = "Desc",
                //    Name = "Repo Name",
                //    Url = "https://github.com/andrii-baranov/git-stats"
                //};

                //repo.AddRepo(testData);

                var items = repo.Get();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //var system = ActorSystem.Create("GitStats");
            //var repoActor = system.ActorOf(Props.Create(() => new StatsCollectorActor()), "repoHandler");

            //bool exit = false;

            //while (!exit)
            //{
            //    Console.WriteLine("Enter repo name:");

            //    string repoName = Console.ReadLine();

            //    if (repoName != "exit")
            //    {
            //        repoActor.Tell(new StatsRequest(repoName));
            //    } 
            //    else
            //    {
            //        exit = true;
            //    }
            //}

            //system.Shutdown();

            Console.ReadKey();
        }
    }
}
