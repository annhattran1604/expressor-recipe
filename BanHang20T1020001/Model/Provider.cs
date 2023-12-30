using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang20T1020001.Model
{
    [Table("Provider")]
    public class Provider
    {
        [Key]
        [StringLength(20)]
        public string MaNCC { get; set; }
        [Required][StringLength(50)]
        public string TenNCC { get; set; }
        [Required][StringLength(20)]
        public string SoDT { get; set; }
        [Required]
        public string DiaChi { get; set; }
        //1-n
        public virtual ICollection<Drinks> Drinks { get; set; }
    }
}
