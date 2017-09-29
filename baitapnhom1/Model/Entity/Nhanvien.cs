namespace baitapnhom1.Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhanvien")]
    public partial class Nhanvien
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string Name1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(10)]

        public string Gioitinh { get ; set; }

        [StringLength(80)]
        public string Noiohiennay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngayvaolam { get; set; }

        [StringLength(50)]
        public string Bangcap { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string CMT { get; set; }

        public int? ChucvuID { get; set; }

        public int? PhongbanID { get; set; }
    }
}
