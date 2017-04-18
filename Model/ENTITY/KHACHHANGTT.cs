namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANGTT")]
    public partial class KHACHHANGTT
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string TENKH { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        public int? DIEMTL { get; set; }

        public DateTime? NGAYCAP { get; set; }

        public DateTime? NGAYHETHAN { get; set; }
    }
}
