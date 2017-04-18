namespace Model.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGDUNG")]
    public partial class NGDUNG
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string PASSWD { get; set; }

        [StringLength(50)]
        public string TENNGDUNG { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        public Int16 PHANQUYEN { get; set; }
    }
}
