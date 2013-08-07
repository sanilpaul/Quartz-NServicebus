using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_SCHEDULER_STATE
    {
        public string SCHED_NAME { get; set; }
        public string INSTANCE_NAME { get; set; }
        public long LAST_CHECKIN_TIME { get; set; }
        public long CHECKIN_INTERVAL { get; set; }
    }
}
