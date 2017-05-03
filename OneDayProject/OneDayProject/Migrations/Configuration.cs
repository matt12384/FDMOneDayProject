namespace OneDayProject.Migrations
{
    using ModelPoco;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OneDayProject.OneDayProjectEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OneDayProject.OneDayProjectEntities context)
        {
            context.Products.AddOrUpdate(x => x.ProductId,
                new Product() { ProductId = 1, Name = "Nexus 5x", Category = "Phone", Price = 200.00m, NumberInStock = 20, ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Nexus_5X_(White).jpg/270px-Nexus_5X_(White).jpg", SearchTerms = "phone nexus 5x phone lg google" },
                new Product() { ProductId = 2, Name = "iPhone 6s", Category = "Phone", Price = 700.00m, NumberInStock = 20, ImageLink = "http://cdn2.gsmarena.com/vv/bigpic/apple-iphone-6s1.jpg", SearchTerms = "iphone phone 6s apple" },
                new Product() { ProductId = 3, Name = "iPhone 7", Category = "Phone", Price = 800.00m, NumberInStock = 20, ImageLink = "http://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-7-1.jpg", SearchTerms = "iphone phone 7 apple" },
                new Product() { ProductId = 4, Name = "Samsung Galaxy S7", Category = "Phone", Price = 600.00m, NumberInStock = 20, ImageLink = "http://cdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s7-edge-.jpg", SearchTerms = "samsung galaxy s7 phone" },
                new Product() { ProductId = 5, Name = "Google Pixel XL", Category = "Phone", Price = 600.00m, NumberInStock = 20, ImageLink = "http://cdn2.gsmarena.com/vv/pics/google/google-pixel-xl-1.jpg", SearchTerms = "google pixel xl phone" },
                new Product() { ProductId = 6, Name = "LG G5", Category = "Phone", Price = 500.00m, NumberInStock = 20, SearchTerms = "lg g5 phone", ImageLink = "http://cdn2.gsmarena.com/vv/bigpic/lg-g5.jpg" }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
