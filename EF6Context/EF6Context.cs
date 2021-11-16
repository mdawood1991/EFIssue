using EF6Context.Entities;
using System;
using System.Data.Entity;

namespace EF6Context
{
    public class EF6Context : DbContext
    {
        public EF6Context() : base("Data Source=.;Initial Catalog=EF6Context;")
        {
            Database.SetInitializer<EF6Context>(null);
        }

        public EF6Context(String connectionString) : base(connectionString)
        {
            Database.SetInitializer<EF6Context>(null);
        }


        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<MonitoringLog> MonitoringLogs { get; set; }


    }
}
