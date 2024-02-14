using Microsoft.EntityFrameworkCore;
using pc_Club_Тепляков.Classes.Common;
using pc_Club_Тепляков.Models;

namespace pc_Club_Тепляков.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
