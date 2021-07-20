using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Venue_Type")]
    public class VenueTypeInfo
    {
        [Key]
        public int VenueTypeId { get; set; }
        public string VenueType { get; set; }
    }
}
