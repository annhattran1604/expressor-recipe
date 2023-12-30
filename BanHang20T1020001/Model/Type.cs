using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang20T1020001.Model
{
    [Table("Type")]
    public class Types
    {
        [Key]
        [StringLength(20)]
        public string maloai { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên loại sản phẩm")]
        [StringLength(50)]
        public string tenloai { get; set; }
        public DateTime ngaynhap { get; set; }

        //Tạo quan hệ 1.n
        public virtual ICollection<Drinks> Drinks { get; set; }
    }
}
