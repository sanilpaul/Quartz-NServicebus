using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Quartz_NServicebus.Models.Mapping
{
    public class QRTZ_CALENDARSMap : EntityTypeConfiguration<QRTZ_CALENDARS>
    {
        public QRTZ_CALENDARSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SCHED_NAME, t.CALENDAR_NAME });

            // Properties
            this.Property(t => t.SCHED_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CALENDAR_NAME)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CALENDAR)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("QRTZ_CALENDARS");
            this.Property(t => t.SCHED_NAME).HasColumnName("SCHED_NAME");
            this.Property(t => t.CALENDAR_NAME).HasColumnName("CALENDAR_NAME");
            this.Property(t => t.CALENDAR).HasColumnName("CALENDAR");
        }
    }
}
