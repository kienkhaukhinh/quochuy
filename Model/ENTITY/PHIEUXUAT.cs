namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXUAT")]
    public partial class PHIEUNHAP
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string IDNGUOIXUAT { get; set; }

        public DateTime? NGAYXUAT { get; set; }
    }
}
