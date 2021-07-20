using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_customer")]
    public class Customer
    {
        [Key]
        public int AddId { get; set; }

        public int AdtId { get; set; }

        public int UserId { get; set; }

        public string AlternativePhoneNo { get; set; }

        public string HouseNo { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public string Landmark { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(AdtId))]
        public AddressTypeInfo AddressType { get; set; }
    }
}
