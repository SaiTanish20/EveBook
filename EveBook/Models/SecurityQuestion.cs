using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_security_question")]
    public class SecurityQuestion
    {
        [Key]
        public int SquId { get; set; }
        public string Question { get; set; }
    }
}
