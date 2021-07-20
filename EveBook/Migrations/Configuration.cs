namespace EveBook.Migrations
{
    using EveBook.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EveBook.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EveBook.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Roles.AddOrUpdate(new UserRole { RoleId = 1, RoleName = "Admin" });
            context.Roles.AddOrUpdate(new UserRole { RoleId = 2, RoleName = "Vendor" });
            context.Roles.AddOrUpdate(new UserRole { RoleId = 3, RoleName = "Customer" });

            context.AddressTypes.AddOrUpdate(new AddressTypeInfo { AdtId = 1, AddressType = "Residential" });
            context.AddressTypes.AddOrUpdate(new AddressTypeInfo { AdtId = 2, AddressType = "Venue" });

            context.Statuses.AddOrUpdate(new StatusInfo { StatusId = 1, Status = "Approved" });
            context.Statuses.AddOrUpdate(new StatusInfo { StatusId = 2, Status = "Cancelled" });
            context.Statuses.AddOrUpdate(new StatusInfo { StatusId = 3, Status = "Pending" });
            context.Statuses.AddOrUpdate(new StatusInfo { StatusId = 4, Status = "Booked" });
            context.Statuses.AddOrUpdate(new StatusInfo { StatusId = 5, Status = "Available" });
            context.Statuses.AddOrUpdate(new StatusInfo { StatusId = 6, Status = "Closed" });

            context.Entertainments.AddOrUpdate(new EntertainmentInfo { EntertainmentId = 1, EntertainmentType = "Balloon Decorators", Cost = 5000 });
            context.Entertainments.AddOrUpdate(new EntertainmentInfo { EntertainmentId = 2, EntertainmentType = "Orchestra Bands", Cost = 25000 });
            context.Entertainments.AddOrUpdate(new EntertainmentInfo { EntertainmentId = 3, EntertainmentType = "Caterers", Cost = 500 });
            context.Entertainments.AddOrUpdate(new EntertainmentInfo { EntertainmentId = 4, EntertainmentType = "Photographers", Cost = 10000 });
            context.Entertainments.AddOrUpdate(new EntertainmentInfo { EntertainmentId = 5, EntertainmentType = "Stage Decorators", Cost = 10000 });
            context.Entertainments.AddOrUpdate(new EntertainmentInfo { EntertainmentId = 6, EntertainmentType = "Light Music", Cost = 20000 });
            context.Entertainments.AddOrUpdate(new EntertainmentInfo { EntertainmentId = 7, EntertainmentType = "Fusion Instrumental", Cost = 20000 });

            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 1, VenueType = "Bars, pubs, and clubs" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 2, VenueType = "Restaurants" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 3, VenueType = "Hotels" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 4, VenueType = "Conference centres" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 5, VenueType = "Business centres" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 6, VenueType = "Community centres" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 7, VenueType = "Sports clubs" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 8, VenueType = "Art galleries" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 9, VenueType = "Academic venues" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 10, VenueType = "Stately homes" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 11, VenueType = "Stadiums and arenas" });
            context.VenueTypes.AddOrUpdate(new VenueTypeInfo { VenueTypeId = 12, VenueType = "Parks and fields" });

            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 1, Question = "What is your mother's maiden name?" });
            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 2, Question = "What is the name of your first pet?" });
            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 3, Question = "What was your first car?" });
            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 4, Question = "What elementary school did you attend" });
            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 5, Question = "What is the name of the town where you were born?" });
            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 6, Question = "When you were young,what did you want to be when you grew up?" });
            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 7, Question = "Who was your childhood hero?" });
            context.Questions.AddOrUpdate(new SecurityQuestion { SquId = 8, Question = "Where was your best family vacation as a kid?" });

            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 1, Event = "Conferences" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 2, Event = "Exhibitions" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 3, Event = "Promotions" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 4, Event = "Seminars" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 5, Event = "Rock concerts" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 6, Event = "Birthday parties" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 7, Event = "Wedding" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 8, Event = "Community events" });
            context.EventTypes.AddOrUpdate(new EventTypeInfo { EventId = 9, Event = "Political Events" });
        }
    }
}
