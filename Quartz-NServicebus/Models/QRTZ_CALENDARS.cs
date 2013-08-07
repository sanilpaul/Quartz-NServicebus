using System;
using System.Collections.Generic;

namespace Quartz_NServicebus.Models
{
    public partial class QRTZ_CALENDARS
    {
        public string SCHED_NAME { get; set; }
        public string CALENDAR_NAME { get; set; }
        public byte[] CALENDAR { get; set; }
    }
}
