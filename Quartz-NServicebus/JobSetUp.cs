using System;
using System.Linq;
using NServiceBus;
using Quartz;
using Quartz_NServicebus.Data;

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
            using (var context = new QuartzDbContext())
            {
                var depots = context.Depots.ToList();
                var schedules = context.DepotSchedules.ToList();

                foreach (var depot in depots)
                {
                    var schedule = schedules.Single(s => s.DepotId == depot.Id);

                    var jobKey = new JobKey(depot.Id.ToString(), depot.Name);
                    var jobDetail = JobBuilder.Create<JobInEst>().WithIdentity(jobKey).Build();
                    var trigger = CreateTrigger(schedule).ForJob(jobDetail).Build();

                    scheduler.ScheduleJob(jobDetail, trigger);
                }
            }
            Console.WriteLine("Job Has been Setup");
        }

        private static TriggerBuilder CreateTrigger(DepotSchedule depotSchedule)
        {
            var expression = CronExpressionConverter.ConvertToCronExpression(depotSchedule.DaysOfTheWeek, depotSchedule.Hour, depotSchedule.Minutes);
            var result = CronExpression.IsValidExpression(expression);
            return TriggerBuilder.Create().WithCronSchedule(expression);
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}