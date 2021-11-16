using EFCoreContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreContext
{
    public class EFCoreContext : DbContext
    {
        public EFCoreContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(
                new DbContextOptionsBuilder(),
                connectionString
                )
                .Options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFCoreContext");
            }
        }

        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<MonitoringLog> MonitoringLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("Asset");

                entity.HasKey(e => e.AssetId);
            });

            modelBuilder.Entity<MonitoringLog>(entity =>
            {
                entity.HasKey(e => e.MonitoringLogId)
                    .IsClustered(false);

                entity.ToTable("MonitoringLog");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.MonitoringLogs)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonitoringLog_Asset");
            });
        }
    }
}
