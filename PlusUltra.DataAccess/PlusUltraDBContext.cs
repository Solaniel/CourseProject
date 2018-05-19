using 
using System.Data.Entity;


namespace PlusUltraDB
{
    class PlusUltraDbContext : DbContext
    {
        public PlusUltraDbContext() :base("PlusUltraDbContext")
        {

        }

        public DbSet<Game> Games { get; set; }

    }
}
