using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Quartz_NServicebus.Models.Mapping
{
    public class QRTZ_LOCKSMap : EntityTypeConfiguration<QRTZ_LOCKS>
    {
        public QRTZ_LOCKSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SCHED_NAME, t.LOCK_NAME });

            // Properties
            this.Property(t => t.SCHED_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LOCK_NAME)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("QRTZ_LOCKS");
            this.Property(t => t.SCHED_NAME).HasColumnName("SCHED_NAME");
            this.Property(t => t.LOCK_NAME).HasColumnName("LOCK_NAME");
        }
    }
}
