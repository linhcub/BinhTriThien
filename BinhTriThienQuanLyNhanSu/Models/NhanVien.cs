using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            CungAnToanVeSinhVienNavigation = new HashSet<Cung>();
            CungCongDoanVienNavigation = new HashSet<Cung>();
            CungCungPhoNavigation = new HashSet<Cung>();
            CungCungTruongNavigation = new HashSet<Cung>();
            PhongPhoPhongNavigation = new HashSet<Phong>();
            PhongTruongPhongNavigation = new HashSet<Phong>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Ma { get; set; }
        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
        [Required]
        [StringLength(50)]
        public string Ho { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string DienThoaiDiDong { get; set; }
        [StringLength(50)]
        public string DienThoaiCoDinh { get; set; }
        public int LoaiTaiKhoanId { get; set; }
        public int BacXepHangId { get; set; }
        public string AnhDaiDien { get; set; }
        public int? CungId { get; set; }
        public int? PhongId { get; set; }

        [ForeignKey(nameof(BacXepHangId))]
        [InverseProperty("NhanVien")]
        public virtual BacXepHang BacXepHang { get; set; }
        [ForeignKey(nameof(CungId))]
        [InverseProperty("NhanVien")]
        public virtual Cung Cung { get; set; }
        [ForeignKey(nameof(LoaiTaiKhoanId))]
        [InverseProperty("NhanVien")]
        public virtual LoaiTaiKhoan LoaiTaiKhoan { get; set; }
        [ForeignKey(nameof(PhongId))]
        [InverseProperty("NhanVien")]
        public virtual Phong Phong { get; set; }
        [InverseProperty("AnToanVeSinhVienNavigation")]
        public virtual ICollection<Cung> CungAnToanVeSinhVienNavigation { get; set; }
        [InverseProperty("CongDoanVienNavigation")]
        public virtual ICollection<Cung> CungCongDoanVienNavigation { get; set; }
        [InverseProperty("CungPhoNavigation")]
        public virtual ICollection<Cung> CungCungPhoNavigation { get; set; }
        [InverseProperty("CungTruongNavigation")]
        public virtual ICollection<Cung> CungCungTruongNavigation { get; set; }
        [InverseProperty("PhoPhongNavigation")]
        public virtual ICollection<Phong> PhongPhoPhongNavigation { get; set; }
        [InverseProperty("TruongPhongNavigation")]
        public virtual ICollection<Phong> PhongTruongPhongNavigation { get; set; }
    }
}
