using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_TRIGGERS
    {
        public string SCHED_NAME { get; set; }
        public string TRIGGER_NAME { get; set; }
        public string TRIGGER_GROUP { get; set; }
        public string JOB_NAME { get; set; }
        public string JOB_GROUP { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<long> NEXT_FIRE_TIME { get; set; }
        public Nullable<long> PREV_FIRE_TIME { get; set; }
        public Nullable<int> PRIORITY { get; set; }
        public string TRIGGER_STATE { get; set; }
        public string TRIGGER_TYPE { get; set; }
        public long START_TIME { get; set; }
        public Nullable<long> END_TIME { get; set; }
        public string CALENDAR_NAME { get; set; }
        public Nullable<int> MISFIRE_INSTR { get; set; }
        public byte[] JOB_DATA { get; set; }
        public virtual QRTZ_CRON_TRIGGERS QRTZ_CRON_TRIGGERS { get; set; }
        public virtual QRTZ_JOB_DETAILS QRTZ_JOB_DETAILS { get; set; }
        public virtual QRTZ_SIMPLE_TRIGGERS QRTZ_SIMPLE_TRIGGERS { get; set; }
        public virtual QRTZ_SIMPROP_TRIGGERS QRTZ_SIMPROP_TRIGGERS { get; set; }
    }
}
