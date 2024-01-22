using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang20T1020001.Model
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        [StringLength(20)]
        public string MaDoUong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên đồ uống")]
        [StringLength(50)]
        public string TenDoUong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập cách đóng gói")]
        public long Gia { get; set; }
        public long SoLuong { get; set; }

    }
}
