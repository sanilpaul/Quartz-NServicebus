using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_SIMPLE_TRIGGERS
    {
        public string SCHED_NAME { get; set; }
        public string TRIGGER_NAME { get; set; }
        public string TRIGGER_GROUP { get; set; }
        public int REPEAT_COUNT { get; set; }
        public long REPEAT_INTERVAL { get; set; }
        public int TIMES_TRIGGERED { get; set; }
        public virtual QRTZ_TRIGGERS QRTZ_TRIGGERS { get; set; }
    }
}
