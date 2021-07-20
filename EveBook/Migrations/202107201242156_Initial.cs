namespace EveBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Address_Type",
                c => new
                    {
                        AdtId = c.Int(nullable: false, identity: true),
                        AddressType = c.String(),
                    })
                .PrimaryKey(t => t.AdtId);
            
            CreateTable(
                "dbo.tbl_Bill_Details",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        BillDate = c.DateTime(nullable: false),
                        BookingId = c.Int(nullable: false),
                        EventVenuePrice = c.Int(nullable: false),
                        EntertainmentPrice = c.Int(nullable: false),
                        TotalCost = c.Int(nullable: false),
                        ModePayment = c.String(),
                        StatusId = c.Int(),
                    })
                .PrimaryKey(t => t.BillId)
                .ForeignKey("dbo.tbl_Booking", t => t.BookingId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Status", t => t.StatusId)
                .Index(t => t.BookingId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.tbl_Booking",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        EventTypeId = c.Int(nullable: false),
                        BookingDate = c.DateTime(nullable: false),
                        Attendees = c.Int(nullable: false),
                        VenueId = c.Int(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        EventPrice = c.Int(nullable: false),
                        ExtraFacility = c.Boolean(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.tbl_Events_Type", t => t.EventTypeId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_user", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Venue", t => t.VenueId)
                .Index(t => t.UserId)
                .Index(t => t.EventTypeId)
                .Index(t => t.VenueId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.tbl_Events_Type",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Event = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.tbl_Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.tbl_user",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Answer = c.String(),
                        PhoneNo = c.String(),
                        SquId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.tbl_user_role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_security_question", t => t.SquId, cascadeDelete: true)
                .Index(t => t.SquId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tbl_user_role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.tbl_security_question",
                c => new
                    {
                        SquId = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                    })
                .PrimaryKey(t => t.SquId);
            
            CreateTable(
                "dbo.tbl_Venue",
                c => new
                    {
                        VenueId = c.Int(nullable: false, identity: true),
                        VenueTypeId = c.Int(nullable: false),
                        VenueImage = c.String(),
                        Description = c.String(),
                        Cost = c.Int(nullable: false),
                        AddId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VenueId)
                .ForeignKey("dbo.tbl_customer", t => t.AddId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Venue_Type", t => t.VenueTypeId, cascadeDelete: true)
                .Index(t => t.VenueTypeId)
                .Index(t => t.AddId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.tbl_customer",
                c => new
                    {
                        AddId = c.Int(nullable: false, identity: true),
                        AdtId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        AlternativePhoneNo = c.String(),
                        HouseNo = c.String(),
                        Address = c.String(),
                        Locality = c.String(),
                        Landmark = c.String(),
                        Town = c.String(),
                        State = c.String(),
                        Pincode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddId)
                .ForeignKey("dbo.tbl_Address_Type", t => t.AdtId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_user", t => t.UserId, cascadeDelete: true)
                .Index(t => t.AdtId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tbl_Venue_Type",
                c => new
                    {
                        VenueTypeId = c.Int(nullable: false, identity: true),
                        VenueType = c.String(),
                    })
                .PrimaryKey(t => t.VenueTypeId);
            
            CreateTable(
                "dbo.tbl_Entertainment_Booking",
                c => new
                    {
                        EbId = c.Int(nullable: false, identity: true),
                        BookingId = c.Int(nullable: false),
                        EntertainmentId = c.Int(nullable: false),
                        EntertainmentPrice = c.Int(nullable: false),
                        StatusId = c.Int(),
                    })
                .PrimaryKey(t => t.EbId)
                .ForeignKey("dbo.tbl_Booking", t => t.BookingId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Entertainment", t => t.EntertainmentId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Status", t => t.StatusId)
                .Index(t => t.BookingId)
                .Index(t => t.EntertainmentId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.tbl_Entertainment",
                c => new
                    {
                        EntertainmentId = c.Int(nullable: false, identity: true),
                        EntertainmentType = c.String(),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EntertainmentId);
            
            CreateTable(
                "dbo.tbl_feedback",
                c => new
                    {
                        FbId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Rating = c.Short(nullable: false),
                        Feedback = c.String(),
                    })
                .PrimaryKey(t => t.FbId)
                .ForeignKey("dbo.tbl_user", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_feedback", "UserId", "dbo.tbl_user");
            DropForeignKey("dbo.tbl_Entertainment_Booking", "StatusId", "dbo.tbl_Status");
            DropForeignKey("dbo.tbl_Entertainment_Booking", "EntertainmentId", "dbo.tbl_Entertainment");
            DropForeignKey("dbo.tbl_Entertainment_Booking", "BookingId", "dbo.tbl_Booking");
            DropForeignKey("dbo.tbl_Bill_Details", "StatusId", "dbo.tbl_Status");
            DropForeignKey("dbo.tbl_Bill_Details", "BookingId", "dbo.tbl_Booking");
            DropForeignKey("dbo.tbl_Booking", "VenueId", "dbo.tbl_Venue");
            DropForeignKey("dbo.tbl_Venue", "VenueTypeId", "dbo.tbl_Venue_Type");
            DropForeignKey("dbo.tbl_Venue", "StatusId", "dbo.tbl_Status");
            DropForeignKey("dbo.tbl_Venue", "AddId", "dbo.tbl_customer");
            DropForeignKey("dbo.tbl_customer", "UserId", "dbo.tbl_user");
            DropForeignKey("dbo.tbl_customer", "AdtId", "dbo.tbl_Address_Type");
            DropForeignKey("dbo.tbl_Booking", "UserId", "dbo.tbl_user");
            DropForeignKey("dbo.tbl_user", "SquId", "dbo.tbl_security_question");
            DropForeignKey("dbo.tbl_user", "RoleId", "dbo.tbl_user_role");
            DropForeignKey("dbo.tbl_Booking", "StatusId", "dbo.tbl_Status");
            DropForeignKey("dbo.tbl_Booking", "EventTypeId", "dbo.tbl_Events_Type");
            DropIndex("dbo.tbl_feedback", new[] { "UserId" });
            DropIndex("dbo.tbl_Entertainment_Booking", new[] { "StatusId" });
            DropIndex("dbo.tbl_Entertainment_Booking", new[] { "EntertainmentId" });
            DropIndex("dbo.tbl_Entertainment_Booking", new[] { "BookingId" });
            DropIndex("dbo.tbl_customer", new[] { "UserId" });
            DropIndex("dbo.tbl_customer", new[] { "AdtId" });
            DropIndex("dbo.tbl_Venue", new[] { "StatusId" });
            DropIndex("dbo.tbl_Venue", new[] { "AddId" });
            DropIndex("dbo.tbl_Venue", new[] { "VenueTypeId" });
            DropIndex("dbo.tbl_user", new[] { "RoleId" });
            DropIndex("dbo.tbl_user", new[] { "SquId" });
            DropIndex("dbo.tbl_Booking", new[] { "StatusId" });
            DropIndex("dbo.tbl_Booking", new[] { "VenueId" });
            DropIndex("dbo.tbl_Booking", new[] { "EventTypeId" });
            DropIndex("dbo.tbl_Booking", new[] { "UserId" });
            DropIndex("dbo.tbl_Bill_Details", new[] { "StatusId" });
            DropIndex("dbo.tbl_Bill_Details", new[] { "BookingId" });
            DropTable("dbo.tbl_feedback");
            DropTable("dbo.tbl_Entertainment");
            DropTable("dbo.tbl_Entertainment_Booking");
            DropTable("dbo.tbl_Venue_Type");
            DropTable("dbo.tbl_customer");
            DropTable("dbo.tbl_Venue");
            DropTable("dbo.tbl_security_question");
            DropTable("dbo.tbl_user_role");
            DropTable("dbo.tbl_user");
            DropTable("dbo.tbl_Status");
            DropTable("dbo.tbl_Events_Type");
            DropTable("dbo.tbl_Booking");
            DropTable("dbo.tbl_Bill_Details");
            DropTable("dbo.tbl_Address_Type");
        }
    }
}
