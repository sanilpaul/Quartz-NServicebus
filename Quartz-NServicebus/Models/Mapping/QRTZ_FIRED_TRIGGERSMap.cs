using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Quartz_NServicebus.Models.Mapping
{
    public class QRTZ_FIRED_TRIGGERSMap : EntityTypeConfiguration<QRTZ_FIRED_TRIGGERS>
    {
        public QRTZ_FIRED_TRIGGERSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SCHED_NAME, t.ENTRY_ID });

            // Properties
            this.Property(t => t.SCHED_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ENTRY_ID)
                .IsRequired()
                .HasMaxLength(95);

            this.Property(t => t.TRIGGER_NAME)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.TRIGGER_GROUP)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.INSTANCE_NAME)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.STATE)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.JOB_NAME)
                .HasMaxLength(150);

            this.Property(t => t.JOB_GROUP)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QRTZ_FIRED_TRIGGERS");
            this.Property(t => t.SCHED_NAME).HasColumnName("SCHED_NAME");
            this.Property(t => t.ENTRY_ID).HasColumnName("ENTRY_ID");
            this.Property(t => t.TRIGGER_NAME).HasColumnName("TRIGGER_NAME");
            this.Property(t => t.TRIGGER_GROUP).HasColumnName("TRIGGER_GROUP");
            this.Property(t => t.INSTANCE_NAME).HasColumnName("INSTANCE_NAME");
            this.Property(t => t.FIRED_TIME).HasColumnName("FIRED_TIME");
            this.Property(t => t.PRIORITY).HasColumnName("PRIORITY");
            this.Property(t => t.STATE).HasColumnName("STATE");
            this.Property(t => t.JOB_NAME).HasColumnName("JOB_NAME");
            this.Property(t => t.JOB_GROUP).HasColumnName("JOB_GROUP");
            this.Property(t => t.IS_NONCONCURRENT).HasColumnName("IS_NONCONCURRENT");
            this.Property(t => t.REQUESTS_RECOVERY).HasColumnName("REQUESTS_RECOVERY");
        }
    }
}
