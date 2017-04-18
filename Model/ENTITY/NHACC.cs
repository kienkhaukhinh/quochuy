namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACC")]
    public partial class NHACC
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TENNCC { get; set; }

        [StringLength(13)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }
    }
}
