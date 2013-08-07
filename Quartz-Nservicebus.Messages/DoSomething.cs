using System;
using NServiceBus;

namespace Quartz_Nservicebus.Messages
{
    public class DoSomething : IMessage
    {
        public DateTime MessageCreatedAtInUtc { get; set; }
    }
}
