using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Quartz_NServicebus.Models.Mapping
{
    public class QRTZ_TRIGGERSMap : EntityTypeConfiguration<QRTZ_TRIGGERS>
    {
        public QRTZ_TRIGGERSMap()
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

            this.Property(t => t.JOB_NAME)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.JOB_GROUP)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(250);

            this.Property(t => t.TRIGGER_STATE)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.TRIGGER_TYPE)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.CALENDAR_NAME)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("QRTZ_TRIGGERS");
            this.Property(t => t.SCHED_NAME).HasColumnName("SCHED_NAME");
            this.Property(t => t.TRIGGER_NAME).HasColumnName("TRIGGER_NAME");
            this.Property(t => t.TRIGGER_GROUP).HasColumnName("TRIGGER_GROUP");
            this.Property(t => t.JOB_NAME).HasColumnName("JOB_NAME");
            this.Property(t => t.JOB_GROUP).HasColumnName("JOB_GROUP");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.NEXT_FIRE_TIME).HasColumnName("NEXT_FIRE_TIME");
            this.Property(t => t.PREV_FIRE_TIME).HasColumnName("PREV_FIRE_TIME");
            this.Property(t => t.PRIORITY).HasColumnName("PRIORITY");
            this.Property(t => t.TRIGGER_STATE).HasColumnName("TRIGGER_STATE");
            this.Property(t => t.TRIGGER_TYPE).HasColumnName("TRIGGER_TYPE");
            this.Property(t => t.START_TIME).HasColumnName("START_TIME");
            this.Property(t => t.END_TIME).HasColumnName("END_TIME");
            this.Property(t => t.CALENDAR_NAME).HasColumnName("CALENDAR_NAME");
            this.Property(t => t.MISFIRE_INSTR).HasColumnName("MISFIRE_INSTR");
            this.Property(t => t.JOB_DATA).HasColumnName("JOB_DATA");

            // Relationships
            this.HasRequired(t => t.QRTZ_JOB_DETAILS)
                .WithMany(t => t.QRTZ_TRIGGERS)
                .HasForeignKey(d => new { d.SCHED_NAME, d.JOB_NAME, d.JOB_GROUP });

        }
    }
}
