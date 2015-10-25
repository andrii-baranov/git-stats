using Akka.Actor;
using Akka.Event;
using GitStats.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitStats.Core.Actors
{
    public class StatsCollectorActor : ReceiveActor
    {
        protected ILoggingAdapter Log = Context.GetLogger();

        public StatsCollectorActor()
        {
            Receive<StatsRequest>(message => 
            {
                Log.Info("Message received {0}", message.RepoName);
            });
        }
    }
}
