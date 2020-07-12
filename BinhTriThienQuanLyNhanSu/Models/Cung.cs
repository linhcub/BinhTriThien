using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class Cung
    {
        public Cung()
        {
            Ga = new HashSet<Ga>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string MaCung { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        public int CungTruong { get; set; }
        public int? CungPho { get; set; }
        public int? AnToanVeSinhVien { get; set; }
        public int? CongDoanVien { get; set; }

        [ForeignKey(nameof(AnToanVeSinhVien))]
        [InverseProperty(nameof(NhanVien.CungAnToanVeSinhVienNavigation))]
        public virtual NhanVien AnToanVeSinhVienNavigation { get; set; }
        [ForeignKey(nameof(CongDoanVien))]
        [InverseProperty(nameof(NhanVien.CungCongDoanVienNavigation))]
        public virtual NhanVien CongDoanVienNavigation { get; set; }
        [ForeignKey(nameof(CungPho))]
        [InverseProperty(nameof(NhanVien.CungCungPhoNavigation))]
        public virtual NhanVien CungPhoNavigation { get; set; }
        [ForeignKey(nameof(CungTruong))]
        [InverseProperty(nameof(NhanVien.CungCungTruongNavigation))]
        public virtual NhanVien CungTruongNavigation { get; set; }
        [InverseProperty("Cung")]
        public virtual ICollection<Ga> Ga { get; set; }
    }
}
