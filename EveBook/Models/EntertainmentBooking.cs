using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Entertainment_Booking")]
    public class EntertainmentBooking
    {
        [Key]
        public int EbId { get; set; }
        public int BookingId { get; set; }
        public int EntertainmentId { get; set; }
        public int EntertainmentPrice { get; set; }
        public int? StatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        public StatusInfo Status { get; set; }

        [ForeignKey(nameof(BookingId))]
        public BookingInfo Booking { get; set; }

        [ForeignKey(nameof(EntertainmentId))]
        public EntertainmentInfo Entertainment { get; set; }
    }
}
