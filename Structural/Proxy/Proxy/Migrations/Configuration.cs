namespace Proxy.Migrations
{
    using Proxy.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Proxy.Models.Contexts.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Proxy.Models.Contexts.ProductDbContext context)
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Name = "First product"
                },
                new Product()
                {
                    Name = "Last name",
                }
            };

            context.Products.AddRange(products);

            base.Seed(context);
        }
    }
}
