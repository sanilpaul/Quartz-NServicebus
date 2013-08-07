using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_JOB_DETAILS
    {
        public QRTZ_JOB_DETAILS()
        {
            this.QRTZ_TRIGGERS = new List<QRTZ_TRIGGERS>();
        }

        public string SCHED_NAME { get; set; }
        public string JOB_NAME { get; set; }
        public string JOB_GROUP { get; set; }
        public string DESCRIPTION { get; set; }
        public string JOB_CLASS_NAME { get; set; }
        public bool IS_DURABLE { get; set; }
        public bool IS_NONCONCURRENT { get; set; }
        public bool IS_UPDATE_DATA { get; set; }
        public bool REQUESTS_RECOVERY { get; set; }
        public byte[] JOB_DATA { get; set; }
        public virtual ICollection<QRTZ_TRIGGERS> QRTZ_TRIGGERS { get; set; }
    }
}
