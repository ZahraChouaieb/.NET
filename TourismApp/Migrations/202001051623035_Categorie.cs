namespace TourismApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categorie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        catId = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.catId);
            
            CreateTable(
                "dbo.Lieux",
                c => new
                    {
                        lieuId = c.Int(nullable: false, identity: true),
                        nameLieu = c.String(nullable: false, maxLength: 128),
                        ville = c.String(nullable: false, maxLength: 128),
                        zoneGeo = c.String(nullable: false, maxLength: 256),
                        catId = c.Int(),
                        temperatureZone = c.String(nullable: false, maxLength: 256),
                        image = c.String(nullable: false, maxLength: 256),
                        description = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.lieuId)
                .ForeignKey("dbo.Categories", t => t.catId)
                .Index(t => t.catId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 256),
                        Password = c.String(nullable: false, maxLength: 256),
                        ConfirmPassword = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lieux", "catId", "dbo.Categories");
            DropIndex("dbo.Lieux", new[] { "catId" });
            DropTable("dbo.Users");
            DropTable("dbo.Lieux");
            DropTable("dbo.Categories");
        }
    }
}
