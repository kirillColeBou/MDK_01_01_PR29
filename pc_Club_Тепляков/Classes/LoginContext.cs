using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using pc_Club_Тепляков.Classes.Common;
using pc_Club_Тепляков.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace pc_Club_Тепляков.Classes
{
    public class LoginContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
        public LoginContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
