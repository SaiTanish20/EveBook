using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Venue")]
    public class VenueInfo
    {
        [Key]
        public int VenueId { get; set; }

        public int VenueTypeId { get; set; }
        public string VenueImage { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int AddId { get; set; }
        public int StatusId { get; set; }

        [ForeignKey(nameof(VenueTypeId))]
        public VenueTypeInfo VenueType { get; set; }

        [ForeignKey(nameof(StatusId))]
        public StatusInfo Status { get; set; }

        [ForeignKey(nameof(AddId))]
        public Customer Customer { get; set; }
    }
}
