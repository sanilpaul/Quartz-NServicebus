using System;
using NServiceBus;
using Quartz;
using Quartz.Impl;

namespace Quartz_NServicebus
{
    public class ContainerInitialization : IWantCustomInitialization
    {
        public void Init()
        {
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