using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class Phong
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        public int TruongPhong { get; set; }
        public int? PhoPhong { get; set; }

        [ForeignKey(nameof(PhoPhong))]
        [InverseProperty(nameof(NhanVien.PhongPhoPhongNavigation))]
        public virtual NhanVien PhoPhongNavigation { get; set; }
        [ForeignKey(nameof(TruongPhong))]
        [InverseProperty(nameof(NhanVien.PhongTruongPhongNavigation))]
        public virtual NhanVien TruongPhongNavigation { get; set; }
    }
}
