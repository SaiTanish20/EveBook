using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Bill_Details")]
    public class BillInfo
    {
        [Key]
        public int BillId { get; set; }
        public DateTime BillDate { get; set; }
        public int BookingId { get; set; }
        public int EventVenuePrice { get; set; }
        public int EntertainmentPrice { get; set; }
        public int TotalCost { get; set; }
        public string ModePayment { get; set; }
        public int? StatusId { get; set; }

        [ForeignKey(nameof(BookingId))]
        public BookingInfo Booking { get; set; }

        [ForeignKey(nameof(StatusId))]
        public StatusInfo Status { get; set; }
    }
}
