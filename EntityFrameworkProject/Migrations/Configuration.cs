namespace EntityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntityFrameworkProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkProject.Models.NMMDb_D1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EntityFrameworkProject.NMMDb_D1";
        }

        protected override void Seed(EntityFrameworkProject.Models.NMMDb_D1 context)
        {
            context.Breweries.AddOrUpdate(b => b.Name,
                new Brewery
                {
                    Name = "Johnny's Hops",
                    City = "Empire",
                    State = "MI",
                    Zip = "12345",
                    Address = "asdfg"
                },

                new Brewery
                {
                    Name = "Billy's Brew",
                    City = "Empire",
                    State = "MI",
                    Zip = "12345",
                    Address = "asdfg"
                },

                new Brewery
                {
                    Name = "Suzy's Suds",
                    City = "Empire",
                    State = "MI",
                    Zip = "12345",
                    Address = "asdfg"
                }
            );
        }
    }
}
