using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveBook.Models
{
    [Table("tbl_Address_Type")]
    public class AddressTypeInfo
    {
        [Key]
        public int AdtId { get; set; }
        public string AddressType { get; set; }
    }
}
