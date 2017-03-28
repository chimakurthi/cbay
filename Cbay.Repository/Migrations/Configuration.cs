using System.Collections.Generic;
using Cbay.Model;

namespace Cbay.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cbay.Repository.CbayContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Cbay.Repository.CbayContext context)
        {
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Category ON");
            var categoires = new List<Category>()
            {
                new Category {Id = 1, Name = "Electric"},
                new Category {Id = 2, Name = "Non Electric"}
            };
            categoires.ForEach(c=>context.Categories.Add(c));
            context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Category OFF");

            var products = new List<Product>()
            {
                new Product {Name = "Electronic Digital Kitchen Scale - Red", CategoryId = 1, Quantity = 1},
                new Product {Name = "Electronic Digital Kitchen Scale - Black", CategoryId = 1, Quantity = 10},
                new Product {Name = "Black Digital BathRoom Scale", CategoryId = 1, Quantity = 5},
                new Product {Name = "Red Electronic Salt Pepper Mill", CategoryId = 1, Quantity = 6},
                new Product {Name = "Smart Electronic Measuring Jug", CategoryId = 1, Quantity = 9},
                new Product {Name = "Wooden Clothes Dryer Rack", CategoryId = 2, Quantity = 9},
                new Product {Name = "Solar Lamp", CategoryId = 2, Quantity = 10},
                new Product {Name = "Office Chair", CategoryId = 2, Quantity = 4},
                new Product {Name = "Computer Table", CategoryId = 2, Quantity = 5},
                new Product {Name = "Bottle Opener", CategoryId = 2, Quantity = 8},
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}
