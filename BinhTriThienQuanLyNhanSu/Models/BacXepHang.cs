using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class BacXepHang
    {
        public BacXepHang()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string MaBacXepHang { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal HeSoLuong { get; set; }

        [InverseProperty("BacXepHang")]
        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
