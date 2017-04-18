namespace Model.ENTITY
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TOYDB : DbContext
    {
        public TOYDB()
            : base("name=TOYDB")
        {
        }

        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANGTT> KHACHHANGTTs { get; set; }
        public virtual DbSet<LOAISP> LOAISPs { get; set; }
        public virtual DbSet<NGDUNG> NGDUNGs { get; set; }
        public virtual DbSet<NHACC> NHACCs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<CT_DONDATHANG> CT_DONDATHANG { get; set; }
        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<CT_PHIEUXUAT> CT_PHIEUXUAT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
