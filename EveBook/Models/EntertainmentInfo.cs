using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Entertainment")]
    public class EntertainmentInfo
    {
        [Key]
        public int EntertainmentId { get; set; }
        public string EntertainmentType { get; set; }
        public int Cost { get; set; }
    }
}
