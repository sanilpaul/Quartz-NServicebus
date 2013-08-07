using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_CRON_TRIGGERS
    {
        public string SCHED_NAME { get; set; }
        public string TRIGGER_NAME { get; set; }
        public string TRIGGER_GROUP { get; set; }
        public string CRON_EXPRESSION { get; set; }
        public string TIME_ZONE_ID { get; set; }
        public virtual QRTZ_TRIGGERS QRTZ_TRIGGERS { get; set; }
    }
}
