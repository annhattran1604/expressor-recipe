using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang20T1020001.Model
{
    [Table("Drinks")]
    public class Drinks
    {
        [Key]
        [StringLength(20)]
        public string MaDoUong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên đồ uống")]
        [StringLength(50)]
        public string TenDoUong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập cách đóng gói")]
        public long Gia {  get; set; }
        public long SoLuong { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime NgayHH { get; set; }
        public string HinhAnh { get; set; }

        //set khoá ngoại
        public string MaLoai { get; set; }
        //thiết lập khoá ngoại với category (bên nhiều)
        [ForeignKey(nameof(MaLoai))]
        public virtual Types Type { get; set; }

        public string MaNCC { get; set; }
        //thiết lập khoá ngoại với category (bên nhiều)
        [ForeignKey(nameof(MaNCC))]
        public virtual Provider Provider { get; set; }

    }
}
