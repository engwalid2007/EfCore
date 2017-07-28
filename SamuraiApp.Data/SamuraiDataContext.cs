using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Data
{
    public class SamuraiDataContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Buttle> Buttles { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SamuraiDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
