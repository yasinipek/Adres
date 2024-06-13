using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Il> Iller { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YASIN;Database=Adres;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
