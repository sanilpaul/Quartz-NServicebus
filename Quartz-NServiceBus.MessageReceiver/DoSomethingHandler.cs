using System;
using NServiceBus;
using Quartz_Nservicebus.Messages;

namespace Quartz_NServiceBus.MessageReceiver
{
    public class DoSomethingHandler : IHandleMessages<DoSomething>
    {
        public void Handle(DoSomething message)
        {
            Console.WriteLine("Received Message generated @ " + message.MessageCreatedAtInUtc);
        }
    }
}