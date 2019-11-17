namespace TourismApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lieu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lieux",
                c => new
                    {
                        lieuId = c.Int(nullable: false, identity: true),
                        nameLieu = c.String(nullable: false, maxLength: 128),
                        ville = c.String(nullable: false, maxLength: 128),
                        zoneGeo = c.String(nullable: false, maxLength: 256),
                        temperatureZone = c.String(nullable: false, maxLength: 256),
                        image = c.String(nullable: false, maxLength: 256),
                        description = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.lieuId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lieux");
        }
    }
}
