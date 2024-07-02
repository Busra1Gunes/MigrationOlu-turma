namespace MigrationOluşturma.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MigrationOluşturma.Model.Context.VerilerDbContext>
    {
        public Configuration()
        {
            //Bu(AutomaticMigrationsEnabled) özelliği sayesinde otomatik olarak veritabanını güncelletebiliyoruz.
            //Haliyle “false” değerde olunca bu özellik kapalı olmaktadır. O yüzden “true” değerini set ediyoruz.
            AutomaticMigrationsEnabled = true;
            ContextKey = "MigrationOluşturma.Model.Context.VerilerDbContext";
        }

        protected override void Seed(MigrationOluşturma.Model.Context.VerilerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
