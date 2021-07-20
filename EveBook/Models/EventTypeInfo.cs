using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Events_Type")]
    public class EventTypeInfo
    {
        [Key]
        public int EventId { get; set; }
        public string Event { get; set; }
    }
}
