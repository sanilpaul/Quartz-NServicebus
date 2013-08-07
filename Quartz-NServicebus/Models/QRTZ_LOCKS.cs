using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_LOCKS
    {
        public string SCHED_NAME { get; set; }
        public string LOCK_NAME { get; set; }
    }
}
