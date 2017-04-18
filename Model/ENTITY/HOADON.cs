namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        public int ID { get; set; }

        public DateTime? NGAYXUAT { get; set; }

        [StringLength(50)]
        public string MAKHTT { get; set; }

        public int? THANHTIEN { get; set; }
    }
}
