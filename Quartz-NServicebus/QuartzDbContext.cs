using System;
using System.Data.Entity;

namespace Quartz_NServicebus
{
    public class QuartzDbContext : DbContext
    {
        static QuartzDbContext()
        {
            Database.SetInitializer(new QuartzDbContextInitializer());
        }

        public QuartzDbContext()
            : base("Quartz_DataStore")
        {
        }
    }
}