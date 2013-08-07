using System;
using System.ComponentModel.DataAnnotations;

namespace Quartz_NServicebus
{
    public class DepotSchedule
    {
        [Key]
        public Guid DepotId { get; set; }
        //This could be an DayOfWeek System Enum
        public string DaysOfTheWeek { get; set; }

        //range of values 0-23
        public int Hour { get; set; }

        //range of values 0-59
        public int Minutes { get; set; }
    }
}