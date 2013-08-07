using System;
using System.Linq;
using NServiceBus;
using Quartz;
using Quartz.Impl;
using Quartz_NServicebus.Data;

namespace Quartz_NServicebus
{
    public class ContainerInitialization : IWantCustomInitialization
    {
        public void Init()
        {
            using (var context = new QuartzDbContext())
            {
                var depots = context.Depots.ToList();
            }

            Configure.Instance.Configurer.ConfigureComponent<IScheduler>(() =>
            {
                var factory = new StdSchedulerFactory();
                factory.Initialize();

                var scheduler = factory.GetScheduler();
                return scheduler;
            }, DependencyLifecycle.SingleInstance);
        }
    }
}