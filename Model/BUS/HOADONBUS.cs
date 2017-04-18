using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.ENTITY;

namespace Model.BUS
{
    public class HOADONBUS
    {
        HOADONDAO hdao;
        public HOADONBUS()
        {
            hdao = new HOADONDAO();
        }
        public bool ThemHoaDon(HOADON hd,List<CT_HOADON> ct)
        {
            return hdao.Insert(hd, ct);
        }

        public decimal? tonggianhaptheongay(DateTime? dt)
        {
            return hdao.Search(c => c.NGAYXUAT == dt).Sum(c => (c.THANHTIEN));
        }
        public decimal? tonggianhaptheothang(int thang, int nam)
        {
            return hdao.Search(c => c.NGAYXUAT.Value.Month == thang).Sum(c => (c.THANHTIEN));
        }
        public decimal? tonggianhaptheonam(int nam)
        {
            return hdao.Search(c => c.NGAYXUAT.Value.Year == nam).Sum(c => (c.THANHTIEN));
        }
    }
}
