using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key] //Khóa chính
        [MaxLength(50)]
        public string ID { get; set; }
        [Required] //Bắt buộc phải có giá trị (phải nhập)
        public string Content { get; set; }
    }
}
