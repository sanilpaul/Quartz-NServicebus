using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_BLOB_TRIGGERS
    {
        public string SCHED_NAME { get; set; }
        public string TRIGGER_NAME { get; set; }
        public string TRIGGER_GROUP { get; set; }
        public byte[] BLOB_DATA { get; set; }
    }
}
