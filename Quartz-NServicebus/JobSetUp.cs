using System;
using System.Linq;
using NServiceBus;
using Quartz;
using Quartz.Spi;
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
                    
                    var trigger = CreateTrigger(schedule, depot, jobKey);

                    scheduler.ScheduleJob(jobDetail, trigger);
                }
            }
            Console.WriteLine("Job Has been Setup");
        }

        private static ICronTrigger CreateTrigger(DepotSchedule depotSchedule, Depot depot, JobKey jobKey)
        {
            var expression = CronExpressionConverter.ConvertToCronExpression(depotSchedule.DaysOfTheWeek, depotSchedule.Hour, depotSchedule.Minutes);
            
            //This is for debugging purposes
            //var result = CronExpression.IsValidExpression(expression); 

            var timezone = TimeZoneInfo.GetSystemTimeZones().Single(tz => tz.Id == depot.TimeZoneId);
            
            var cronScheduleBuilder = CronScheduleBuilder.CronSchedule(expression).InTimeZone(timezone).WithMisfireHandlingInstructionFireAndProceed();
            return (ICronTrigger) TriggerBuilder.Create().ForJob(jobKey).WithSchedule(cronScheduleBuilder).Build();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}