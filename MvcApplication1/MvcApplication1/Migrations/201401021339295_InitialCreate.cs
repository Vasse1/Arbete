namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        PaymentType = c.String(),
                        Deposit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                        RentableObject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RentableObjects", t => t.RentableObject_Id)
                .Index(t => t.RentableObject_Id);
            
            CreateTable(
                "dbo.RentableObjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ObjectType = c.String(nullable: false),
                        SizeSqm = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Available = c.Boolean(nullable: false),
                        SeasonStart = c.DateTime(nullable: false),
                        SeasonEnd = c.DateTime(nullable: false),
                        Beds = c.Int(nullable: false),
                        NumberOfRooms = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        PostTown = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        Floors = c.Int(nullable: false),
                        Elevator = c.Boolean(nullable: false),
                        DisabledAdaptation = c.Boolean(nullable: false),
                        DisabledAdaptationDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookedFrom = c.DateTime(nullable: false),
                        BookedTo = c.DateTime(nullable: false),
                        Status = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        TelephoneNumber = c.Int(nullable: false),
                        Payment_Id = c.Int(),
                        RentableObject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payments", t => t.Payment_Id)
                .ForeignKey("dbo.RentableObjects", t => t.RentableObject_Id)
                .Index(t => t.Payment_Id)
                .Index(t => t.RentableObject_Id);
            
            CreateTable(
                "dbo.Renters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SirName = c.String(nullable: false),
                        email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        AccountNumber = c.Int(nullable: false),
                        Website = c.String(),
                        TelephoneNumber = c.Int(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        PostTown = c.String(nullable: false),
                        UserId_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfile", t => t.UserId_UserId)
                .Index(t => t.UserId_UserId);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Renters", "UserId_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Rentals", "RentableObject_Id", "dbo.RentableObjects");
            DropForeignKey("dbo.Rentals", "Payment_Id", "dbo.Payments");
            DropForeignKey("dbo.Pictures", "RentableObject_Id", "dbo.RentableObjects");
            DropIndex("dbo.Renters", new[] { "UserId_UserId" });
            DropIndex("dbo.Rentals", new[] { "RentableObject_Id" });
            DropIndex("dbo.Rentals", new[] { "Payment_Id" });
            DropIndex("dbo.Pictures", new[] { "RentableObject_Id" });
            DropTable("dbo.UserProfile");
            DropTable("dbo.Renters");
            DropTable("dbo.Rentals");
            DropTable("dbo.RentableObjects");
            DropTable("dbo.Pictures");
            DropTable("dbo.Payments");
        }
    }
}
