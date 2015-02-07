namespace CodeFirstDevLab.Migrations.LocationsMigrations
{
    using CodeFirstDevLab.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstDevLab.Models.LocationsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\LocationsMigrations";
        }

        protected override void Seed(CodeFirstDevLab.Models.LocationsContext context)
        {
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
            context.Provinces.AddOrUpdate(
                p => p.ProvinceName,
                new Province() { ProvinceCode = "BC", ProvinceName = "British Columbia" },
                new Province() { ProvinceCode = "AB", ProvinceName = "Alberta" },
                new Province() { ProvinceCode = "ON", ProvinceName = "Ontario" }
                );
            context.SaveChanges();

            context.Cities.AddOrUpdate(
                p => p.Name,
                new City() { Name = "Burnaby", Population = 50000, ProvinceId = context.Provinces.First(s => s.ProvinceCode == "BC").ProvinceId },
                new City() { Name = "Toronto", Population = 2550000, ProvinceId = context.Provinces.First(s => s.ProvinceCode == "ON").ProvinceId },
                new City() { Name = "Calgary", Population = 720000, ProvinceId = context.Provinces.First(s => s.ProvinceCode == "AB").ProvinceId }
            );
        }
    }
}
