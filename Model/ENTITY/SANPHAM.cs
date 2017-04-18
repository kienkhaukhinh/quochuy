namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSP { get; set; }

        [StringLength(50)]
        public string XUATXU { get; set; }

        public int? SLTON { get; set; }

        public int? SLBAYBAN { get; set; }

        public int? GIATIEN { get; set; }

        public int? IDLOAISP { get; set; }

        [StringLength(100)]
        public string HINHANH { get; set; }
    }
}
