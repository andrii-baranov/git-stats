using Akka.Actor;
using GitStats.Core;
using GitStats.Core.Actors;
using GitStats.Core.Messages;
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
            var system = ActorSystem.Create("GitStats");
            var repoActor = system.ActorOf(Props.Create(() => new StatsCollectorActor()), "repoHandler");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter repo name:");

                string repoName = Console.ReadLine();

                if (repoName != "exit")
                {
                    repoActor.Tell(new StatsRequest(repoName));
                } 
                else
                {
                    exit = true;
                }
            }

            system.Shutdown();

            Console.ReadKey();
        }
    }
}
