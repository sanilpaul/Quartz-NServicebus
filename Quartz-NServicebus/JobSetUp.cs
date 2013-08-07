using System;
using NServiceBus;
using Quartz;

namespace Quartz_NServicebus
{
    public class JobSetUp : IWantToRunWhenBusStartsAndStops
    {
        private readonly IScheduler scheduler;

        public JobSetUp(IScheduler scheduler)
        {
            this.scheduler = scheduler;
        }

        public void Start()
        {
            var jobKey = new JobKey(Guid.NewGuid().ToString());
            var jobDetail = JobBuilder.Create<JobInEst>().WithIdentity(jobKey).Build();
            var trigger = CreateTrigger().ForJob(jobDetail).Build();
            scheduler.ScheduleJob(jobDetail, trigger);
            Console.WriteLine("Job Has been Setup");
        }

        private static TriggerBuilder CreateTrigger()
        {
            return TriggerBuilder.Create().WithCalendarIntervalSchedule(b => b.WithIntervalInSeconds(5));
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}