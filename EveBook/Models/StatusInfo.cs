using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Status")]
    public class StatusInfo
    {
        [Key]
        public int StatusId { get; set; }
        public string Status { get; set; }
    }
}
