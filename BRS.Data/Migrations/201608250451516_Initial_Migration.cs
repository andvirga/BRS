namespace BRS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusDrivers",
                c => new
                    {
                        BusDriverId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DNI = c.String(nullable: false),
                        DayOfBirth = c.DateTime(nullable: false),
                        PrimaryAddress = c.String(nullable: false),
                        SecondaryAddress = c.String(),
                        PrimaryPhone = c.String(nullable: false),
                        SecondaryPhone = c.String(),
                        Email = c.String(),
                        City = c.String(nullable: false),
                        Province = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BusDriverId);
            
            CreateTable(
                "dbo.Coordinators",
                c => new
                    {
                        CoordinatorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DNI = c.String(nullable: false),
                        DayOfBirth = c.DateTime(nullable: false),
                        PrimaryAddress = c.String(nullable: false),
                        SecondaryAddress = c.String(),
                        PrimaryPhone = c.String(nullable: false),
                        SecondaryPhone = c.String(),
                        Email = c.String(),
                        City = c.String(nullable: false),
                        Province = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CoordinatorId);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        DestinationName = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Province = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        PassengerId = c.Int(nullable: false, identity: true),
                        TravelHistory = c.String(),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DNI = c.String(nullable: false),
                        DayOfBirth = c.DateTime(nullable: false),
                        PrimaryAddress = c.String(nullable: false),
                        SecondaryAddress = c.String(),
                        PrimaryPhone = c.String(nullable: false),
                        SecondaryPhone = c.String(),
                        Email = c.String(),
                        City = c.String(nullable: false),
                        Province = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                        Travel_TravelId = c.Int(),
                    })
                .PrimaryKey(t => t.PassengerId)
                .ForeignKey("dbo.Travels", t => t.Travel_TravelId)
                .Index(t => t.Travel_TravelId);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelId = c.Int(nullable: false, identity: true),
                        DestinationId = c.Int(nullable: false),
                        CoordinatorId = c.Int(nullable: false),
                        BusDriverId = c.Int(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        ReturnTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TravelId)
                .ForeignKey("dbo.BusDrivers", t => t.BusDriverId, cascadeDelete: true)
                .ForeignKey("dbo.Coordinators", t => t.CoordinatorId, cascadeDelete: true)
                .ForeignKey("dbo.Destinations", t => t.DestinationId, cascadeDelete: true)
                .Index(t => t.DestinationId)
                .Index(t => t.CoordinatorId)
                .Index(t => t.BusDriverId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passengers", "Travel_TravelId", "dbo.Travels");
            DropForeignKey("dbo.Travels", "DestinationId", "dbo.Destinations");
            DropForeignKey("dbo.Travels", "CoordinatorId", "dbo.Coordinators");
            DropForeignKey("dbo.Travels", "BusDriverId", "dbo.BusDrivers");
            DropIndex("dbo.Travels", new[] { "BusDriverId" });
            DropIndex("dbo.Travels", new[] { "CoordinatorId" });
            DropIndex("dbo.Travels", new[] { "DestinationId" });
            DropIndex("dbo.Passengers", new[] { "Travel_TravelId" });
            DropTable("dbo.Travels");
            DropTable("dbo.Passengers");
            DropTable("dbo.Destinations");
            DropTable("dbo.Coordinators");
            DropTable("dbo.BusDrivers");
        }
    }
}
