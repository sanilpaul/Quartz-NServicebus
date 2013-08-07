using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Quartz_NServicebus.Models.Mapping
{
    public class QRTZ_SCHEDULER_STATEMap : EntityTypeConfiguration<QRTZ_SCHEDULER_STATE>
    {
        public QRTZ_SCHEDULER_STATEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SCHED_NAME, t.INSTANCE_NAME });

            // Properties
            this.Property(t => t.SCHED_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.INSTANCE_NAME)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("QRTZ_SCHEDULER_STATE");
            this.Property(t => t.SCHED_NAME).HasColumnName("SCHED_NAME");
            this.Property(t => t.INSTANCE_NAME).HasColumnName("INSTANCE_NAME");
            this.Property(t => t.LAST_CHECKIN_TIME).HasColumnName("LAST_CHECKIN_TIME");
            this.Property(t => t.CHECKIN_INTERVAL).HasColumnName("CHECKIN_INTERVAL");
        }
    }
}
