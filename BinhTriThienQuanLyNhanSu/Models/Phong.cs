using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class Phong
    {
        public Phong()
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
        public int? TruongPhong { get; set; }
        public int? PhoPhong { get; set; }

        [ForeignKey(nameof(PhoPhong))]
        [InverseProperty("PhongPhoPhongNavigation")]
        public virtual NhanVien PhoPhongNavigation { get; set; }
        [ForeignKey(nameof(TruongPhong))]
        [InverseProperty("PhongTruongPhongNavigation")]
        public virtual NhanVien TruongPhongNavigation { get; set; }
        [InverseProperty("Phong")]
        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
