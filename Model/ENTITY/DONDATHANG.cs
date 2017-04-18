namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONDATHANG")]
    public partial class DONDATHANG
    {
        public int ID { get; set; }

        public DateTime? NGAYDAT { get; set; }

        public int? IDNCC { get; set; }

        [StringLength(50)]
        public string IDNGUOIDAT { get; set; }


  
        public int? TONGCONG { get; set; }

        public bool? TRANGTHAI { get; set; }
    }
}
