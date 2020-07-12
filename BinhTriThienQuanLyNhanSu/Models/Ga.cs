using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class Ga
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string MaGa { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        public int? CungId { get; set; }

        [ForeignKey(nameof(CungId))]
        [InverseProperty("Ga")]
        public virtual Cung Cung { get; set; }
    }
}
