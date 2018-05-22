using System.Data.Entity;
using PlusUltra.DataAccess;
using System;
using PlusUltraDB.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PlusUltraDB
{
    class PlusUltraDbContext : DbContext
    {
        public PlusUltraDbContext() :base("PlusUltraDbContext")
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
