using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public partial class AAAContext
    {
        public static string MSSQL = "Server=localhost\\MSSQLSERVER01;Database=aaa;user=sa;pwd=123456;TrustServerCertificate=true";
        public AAAContext() { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(MSSQL);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
