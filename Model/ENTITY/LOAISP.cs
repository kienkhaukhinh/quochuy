namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAISP")]
    public partial class LOAISP
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TENLOAI { get; set; }
    }
}
