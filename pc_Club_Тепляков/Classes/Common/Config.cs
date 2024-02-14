using Microsoft.EntityFrameworkCore;
using System;

namespace pc_Club_Тепляков.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=127.0.0.1;uid=root;database=pcClub";
        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
