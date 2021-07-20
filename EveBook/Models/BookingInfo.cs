using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Booking")]
    public class BookingInfo
    {
        [Key]
        public int BookingId { get; set; }

        public int UserId { get; set; }
        public int EventTypeId { get; set; }
        public DateTime BookingDate { get; set; }
        public int Attendees { get; set; }
        public int? VenueId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EventPrice { get; set; }
        public bool ExtraFacility { get; set; }
        public int StatusId { get; set; }

        [ForeignKey(nameof(VenueId))]
        public VenueInfo Venue { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(EventTypeId))]
        public EventTypeInfo EventType { get; set; }

        [ForeignKey(nameof(StatusId))]
        public StatusInfo Status { get; set; }
    }
}
