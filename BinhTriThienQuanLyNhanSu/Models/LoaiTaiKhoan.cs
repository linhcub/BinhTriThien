using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class LoaiTaiKhoan
    {
        public LoaiTaiKhoan()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Ma { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        public int CapDo { get; set; }

        [InverseProperty("LoaiTaiKhoan")]
        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
