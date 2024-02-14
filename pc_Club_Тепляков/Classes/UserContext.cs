using Microsoft.EntityFrameworkCore;
using pc_Club_Тепляков.Classes.Common;
using pc_Club_Тепляков.Models;

namespace pc_Club_Тепляков.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
