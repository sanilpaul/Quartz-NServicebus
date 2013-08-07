using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Quartz_NServicebus.Models.Mapping
{
    public class QRTZ_PAUSED_TRIGGER_GRPSMap : EntityTypeConfiguration<QRTZ_PAUSED_TRIGGER_GRPS>
    {
        public QRTZ_PAUSED_TRIGGER_GRPSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SCHED_NAME, t.TRIGGER_GROUP });

            // Properties
            this.Property(t => t.SCHED_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TRIGGER_GROUP)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QRTZ_PAUSED_TRIGGER_GRPS");
            this.Property(t => t.SCHED_NAME).HasColumnName("SCHED_NAME");
            this.Property(t => t.TRIGGER_GROUP).HasColumnName("TRIGGER_GROUP");
        }
    }
}
