namespace PlusUltraDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PlusUltraDB.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<PlusUltraDB.PlusUltraDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlusUltraDB.PlusUltraDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            User normalUser = new User
            {
                FirstName = "Spas",
                LastName = "Spasov",
                UserName = "Spas4o",
                PhoneNumber = "0000",
                Password = "saps",  
                EMail = "spas4o@abv.bg"
            };

            context.User.AddOrUpdate(normalUser);

        }
    }
}
