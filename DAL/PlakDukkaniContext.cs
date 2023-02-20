using DAL.Config;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlakDukkaniContext:DbContext
    {

       public DbSet<User>User { get; set; }

        public DbSet<PlakBilgileri> PlakBilgileri { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //BESTE 

            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q56AEMU\MSSQLKD14;Initial Catalog=PlakDukkaniDb;user Id=sa;Password=Beste1998.");
            //base.OnConfiguring(optionsBuilder);

            //YUŞA

            optionsBuilder.UseSqlServer(@"Data Source=YUSATOSUN\SQLEXPRESS;Initial Catalog=PlakDukkaniDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
            //doğukan

            //optionsBuilder.UseSqlServer(@"Data Source=YUSATOSUN\SQLEXPRESS;Initial Catalog=PlakDukkaniDb;user Id=sa;Password=Beste1998.");
            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration()).ApplyConfiguration(new PlakBilgileriConfiguration());
        }
    }
}
