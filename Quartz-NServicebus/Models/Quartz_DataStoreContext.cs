using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Quartz_NServicebus.Models.Mapping;

namespace Quartz_NServicebus.Models
{
    public partial class Quartz_DataStoreContext : DbContext
    {
        static Quartz_DataStoreContext()
        {
            Database.SetInitializer<Quartz_DataStoreContext>(null);
        }

        public Quartz_DataStoreContext()
            : base("Name=Quartz_DataStoreContext")
        {
        }

        public DbSet<QRTZ_BLOB_TRIGGERS> QRTZ_BLOB_TRIGGERS { get; set; }
        public DbSet<QRTZ_CALENDARS> QRTZ_CALENDARS { get; set; }
        public DbSet<QRTZ_CRON_TRIGGERS> QRTZ_CRON_TRIGGERS { get; set; }
        public DbSet<QRTZ_FIRED_TRIGGERS> QRTZ_FIRED_TRIGGERS { get; set; }
        public DbSet<QRTZ_JOB_DETAILS> QRTZ_JOB_DETAILS { get; set; }
        public DbSet<QRTZ_LOCKS> QRTZ_LOCKS { get; set; }
        public DbSet<QRTZ_PAUSED_TRIGGER_GRPS> QRTZ_PAUSED_TRIGGER_GRPS { get; set; }
        public DbSet<QRTZ_SCHEDULER_STATE> QRTZ_SCHEDULER_STATE { get; set; }
        public DbSet<QRTZ_SIMPLE_TRIGGERS> QRTZ_SIMPLE_TRIGGERS { get; set; }
        public DbSet<QRTZ_SIMPROP_TRIGGERS> QRTZ_SIMPROP_TRIGGERS { get; set; }
        public DbSet<QRTZ_TRIGGERS> QRTZ_TRIGGERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new QRTZ_BLOB_TRIGGERSMap());
            modelBuilder.Configurations.Add(new QRTZ_CALENDARSMap());
            modelBuilder.Configurations.Add(new QRTZ_CRON_TRIGGERSMap());
            modelBuilder.Configurations.Add(new QRTZ_FIRED_TRIGGERSMap());
            modelBuilder.Configurations.Add(new QRTZ_JOB_DETAILSMap());
            modelBuilder.Configurations.Add(new QRTZ_LOCKSMap());
            modelBuilder.Configurations.Add(new QRTZ_PAUSED_TRIGGER_GRPSMap());
            modelBuilder.Configurations.Add(new QRTZ_SCHEDULER_STATEMap());
            modelBuilder.Configurations.Add(new QRTZ_SIMPLE_TRIGGERSMap());
            modelBuilder.Configurations.Add(new QRTZ_SIMPROP_TRIGGERSMap());
            modelBuilder.Configurations.Add(new QRTZ_TRIGGERSMap());
        }
    }
}
