namespace MigrationOluşturma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        DersId = c.Int(nullable: false, identity: true),
                        DersAdi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DersId);
            
            CreateTable(
                "dbo.Ogretmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OgretmenAdi = c.String(),
                        OgretmenSoyadi = c.String(),
                        DersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ders", t => t.DersId, cascadeDelete: true)
                .Index(t => t.DersId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogretmen", "DersId", "dbo.Ders");
            DropIndex("dbo.Ogretmen", new[] { "DersId" });
            DropTable("dbo.Users");
            DropTable("dbo.Ogretmen");
            DropTable("dbo.Ders");
        }
    }
}
