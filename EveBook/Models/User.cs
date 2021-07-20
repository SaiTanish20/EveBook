using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_user")]
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Answer { get; set; }
        public string PhoneNo { get; set; }
        public int SquId { get; set; }
        public int RoleId { get; set; }

        [ForeignKey(nameof(SquId))]
        public SecurityQuestion SecurityQuestion { get; set; }

        [ForeignKey(nameof(RoleId))]
        public UserRole Role { get; set; }
    }
}
