namespace BabyStore.Migrations
{
    using BabyStore.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BabyStore.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            // ContextKey = "BabyStore.DAL.StoreContext";
        }

        protected override void Seed(BabyStore.DAL.StoreContext context)
        {
            var categories = new List<Category>
            {
                new Category {Name = "Clothes"},
                new Category {Name = "Play and Toys"},
                new Category {Name = "Feeding"},
                new Category {Name = "Medicine"},
                new Category {Name = "Travel"},
                new Category {Name = "Sleeping"},
            };

            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product {Name="Sleep Suit", Description="For sleeping", Price=4.00M, CategoryID=categories.Single(c => c.Name == "Clothes").ID},
                 new Product {Name="Sleep Suit", Description="For sleeping", Price=4.00M, CategoryID=categories.Single(c => c.Name == "Sleeping").ID},
                  new Product {Name="Sleep Suit", Description="For sleeping", Price=4.00M, CategoryID=categories.Single(c => c.Name == "Travel").ID},
                   new Product {Name="Sleep Suit", Description="For sleeping", Price=4.00M, CategoryID=categories.Single(c => c.Name == "Medicine").ID},
                    new Product {Name="Sleep Suit", Description="For sleeping", Price=4.00M, CategoryID=categories.Single(c => c.Name == "Feeding").ID},
                     new Product {Name="Sleep Suit", Description="For sleeping", Price=4.00M, CategoryID=categories.Single(c => c.Name == "Clothes").ID},
                      new Product {Name="Sleep Suit", Description="For sleeping", Price=4.00M, CategoryID=categories.Single(c => c.Name == "Clothes").ID},
            };

            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
