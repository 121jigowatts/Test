namespace WebFormsWithAutocomplete.SQLServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebFormsWithAutocomplete.SQLServer.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebFormsWithAutocomplete.SQLServer.EFContext context)
        {            
            context.Products.AddOrUpdate(
                p => p.Code,
                new Product { Code = "001", Name = "Sample A", Price = 100, CreateData = DateTime.Now },
                new Product { Code = "002", Name = "Sample B", Price = 200, CreateData = DateTime.Now },
                new Product { Code = "003", Name = "Sample C", Price = 300, CreateData = DateTime.Now },
                new Product { Code = "004", Name = "Sample D", Price = 400, CreateData = DateTime.Now },
                new Product { Code = "005", Name = "Sample E", Price = 500, CreateData = DateTime.Now },
                new Product { Code = "006", Name = "Sample F", Price = 600, CreateData = DateTime.Now },
                new Product { Code = "007", Name = "Sample A-1", Price = 1000, CreateData = DateTime.Now },
                new Product { Code = "008", Name = "Sample B-2", Price = 2000, CreateData = DateTime.Now },
                new Product { Code = "009", Name = "Sample C-3", Price = 3000, CreateData = DateTime.Now },
                new Product { Code = "010", Name = "Sample D-4", Price = 4000, CreateData = DateTime.Now },
                new Product { Code = "011", Name = "Sample E-5", Price = 5000, CreateData = DateTime.Now },
                new Product { Code = "012", Name = "Sample F-6", Price = 6000, CreateData = DateTime.Now }

            );

        }
    }
}
