using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_FIRED_TRIGGERS
    {
        public string SCHED_NAME { get; set; }
        public string ENTRY_ID { get; set; }
        public string TRIGGER_NAME { get; set; }
        public string TRIGGER_GROUP { get; set; }
        public string INSTANCE_NAME { get; set; }
        public long FIRED_TIME { get; set; }
        public int PRIORITY { get; set; }
        public string STATE { get; set; }
        public string JOB_NAME { get; set; }
        public string JOB_GROUP { get; set; }
        public Nullable<bool> IS_NONCONCURRENT { get; set; }
        public Nullable<bool> REQUESTS_RECOVERY { get; set; }
        public long SCHED_TIME { get; set; }
    }
}
