using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_feedback")]
    public class FeedbackInfo
    {
        [Key]
        public int FbId { get; set; }

        public int UserId { get; set; }

        public short Rating { get; set; }
        public string Feedback { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
