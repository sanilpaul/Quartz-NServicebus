using System;
using NServiceBus;
using Quartz;
using Quartz_Nservicebus.Messages;

namespace Quartz_NServicebus
{
    public class JobInEst : IJob
    {
        //TODO: Get this DI working..Low priority
        public IBus Bus { get; set; }

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine(string.Format("JobInEST with Id {0} Executed ", context.JobDetail.Key.Name));
            Bus.Send("receiver", new DoSomething { MessageCreatedAtInUtc = DateTime.UtcNow });
        }
    }
}