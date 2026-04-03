using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetMonitor.Web.Domain;

namespace NetMonitor.Web.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
    {
        public DbSet<Machine> Machines { get; set; }
        public DbSet<PingResult> PingResults { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Machine>(e =>
            {
                e.HasIndex(m => m.HostnameAd).IsUnique();
                e.HasIndex(m => m.IpAd);
                e.HasIndex(m => m.HasDnsConflict);
            });

            mb.Entity<PingResult>(e =>
            {
                e.HasIndex(p => new {p.MachineId, p.checkedAt});

                e.HasOne(p => p.Machine)
                .WithMany(m => m.PingHistory)
                .HasForeignKey(p => p.MachineId)
                .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}