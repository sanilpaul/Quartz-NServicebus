using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Quartz_NServicebus.Models.Mapping
{
    public class QRTZ_CRON_TRIGGERSMap : EntityTypeConfiguration<QRTZ_CRON_TRIGGERS>
    {
        public QRTZ_CRON_TRIGGERSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SCHED_NAME, t.TRIGGER_NAME, t.TRIGGER_GROUP });

            // Properties
            this.Property(t => t.SCHED_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TRIGGER_NAME)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.TRIGGER_GROUP)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.CRON_EXPRESSION)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.TIME_ZONE_ID)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("QRTZ_CRON_TRIGGERS");
            this.Property(t => t.SCHED_NAME).HasColumnName("SCHED_NAME");
            this.Property(t => t.TRIGGER_NAME).HasColumnName("TRIGGER_NAME");
            this.Property(t => t.TRIGGER_GROUP).HasColumnName("TRIGGER_GROUP");
            this.Property(t => t.CRON_EXPRESSION).HasColumnName("CRON_EXPRESSION");
            this.Property(t => t.TIME_ZONE_ID).HasColumnName("TIME_ZONE_ID");

            // Relationships
            this.HasRequired(t => t.QRTZ_TRIGGERS)
                .WithOptional(t => t.QRTZ_CRON_TRIGGERS);

        }
    }
}
