using System;
using NServiceBus;
using Quartz;

namespace Quartz_NServicebus
{
    public class SchedulerSetUp : IWantToRunWhenBusStartsAndStops
    {
        private readonly IScheduler scheduler;

        public SchedulerSetUp(IScheduler scheduler)
        {
            this.scheduler = scheduler;
        }

        public void Start()
        {
            scheduler.Start();
            Console.WriteLine("Scheduler Started ");
        }

        public void Stop()
        {
            scheduler.Shutdown(true);
        }
    }
}