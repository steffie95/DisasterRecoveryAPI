using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DisasterRecoveryAPI.Models
{
    public class TimecardContext : DbContext
    {
        public TimecardContext(DbContextOptions<TimecardContext> options) : base(options)
        {

        }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Machines> Machines { get; set; }
        public DbSet<Timecard> Timecards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Jobs_Timecard> Jobs_Timecards { get; set; }
        public DbSet<Machines_Timecard> Machines_Timecards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HM255OB\SQLEXPRESS;Database=DisasterRecovery;Trusted_Connection=True;");
         }
    }
}
