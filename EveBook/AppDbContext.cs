using EveBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EveBook
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> Roles { get; set; }
        public DbSet<SecurityQuestion> Questions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AddressTypeInfo> AddressTypes { get; set; }
        public DbSet<FeedbackInfo> Feedbacks { get; set; }
        public DbSet<EventTypeInfo> EventTypes { get; set; }
        public DbSet<VenueTypeInfo> VenueTypes { get; set; }
        public DbSet<EntertainmentInfo> Entertainments { get; set; }
        public DbSet<StatusInfo> Statuses { get; set; }
        public DbSet<BookingInfo> Bookings { get; set; }
        public DbSet<VenueInfo> Venues { get; set; }
        public DbSet<EntertainmentBooking> EntertainmentBookings { get; set; }
        public DbSet<BillInfo> Bills { get; set; }
    }
}