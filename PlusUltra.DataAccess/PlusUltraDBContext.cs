using System.Data.Entity;
using PlusUltra.DataAccess;
using System;
using PlusUltraDB.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace PlusUltra.DataAccess
{
    class PlusUltraDbContext : DbContext
    {
        public PlusUltraDbContext()
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //method that prevents table names to be pluralized
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}

