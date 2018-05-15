using PlusUltraDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltraDB
{
    class PlusUltraDbContext : DbContext
    {


        public DbSet Game { get; set; }

    }
}
