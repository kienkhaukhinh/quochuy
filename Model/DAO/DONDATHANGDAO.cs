using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;
using Model.VIEWMODEL;
namespace Model.DAO
{
    public class DONDATHANGDAO : GenericDataRepository<DONDATHANG>
    {
        public bool Insert(DONDATHANG ddh, List<CT_DONDATHANG> ctdh)
        {
            bool insert = false;
            try
            {
                db.DONDATHANGs.Add(ddh);
                db.SaveChanges();
                foreach (CT_DONDATHANG ct in ctdh)
                {
                    ct.IDDONDAT = ddh.ID;
                    db.CT_DONDATHANG.Add(ct);
                    db.SaveChanges();
                    insert = true;
                }
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return insert;

        }

        public List<ViewCTDDH> GetList(int ma)
        {
            var query = from ctddh in db.CT_DONDATHANG
                        join sp in db.SANPHAMs
                       on ctddh.IDSANPHAM equals sp.ID
                        where ctddh.IDDONDAT == ma
                        select new ViewCTDDH()
                        {
                            MaSP = sp.ID,
                            TenSP = sp.TENSP,
                            SL_Nhap = ctddh.SL_NHAP,
                            SL = ctddh.SL,
                            DonGia = ctddh.DONGIA,
                            TongTien = ctddh.TONG
                        };
            return query.ToList();
        }

        public bool Update(int maddh, List<CT_DONDATHANG> ctdh)
        {
            SANPHAMDAO spdao = new SANPHAMDAO();
            CTDONHANGDAO ctdao = new CTDONHANGDAO();
            bool update = false;
            try
            {
                foreach (CT_DONDATHANG ct_in_list in ctdh)
                {
                    int sl_hientai = db.CT_DONDATHANG.Where(x => x.IDSANPHAM == ct_in_list.IDSANPHAM && x.IDDONDAT == ct_in_list.IDDONDAT).Select(x => x.SL_NHAP).FirstOrDefault();

                    if (ctdao.UpdateSLNhap(ct_in_list))
                    {
                        spdao.CapNhatSLTonSP(ct_in_list.IDSANPHAM, sl_hientai - ct_in_list.SL_NHAP);
                    }
     
                }
                UpdateTrangThai(maddh);
                update = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return update;
        }

        public void UpdateTrangThai(int maddh)
        {
            int sum_sl_dat = db.CT_DONDATHANG.Where(X=>X.IDDONDAT == maddh).Sum(x => x.SL);
            int sum_sl_nhap = db.CT_DONDATHANG.Where(X=>X.IDDONDAT == maddh).Sum(x => x.SL_NHAP);
            if (sum_sl_dat == sum_sl_nhap)
            {
                try
                {
                    DONDATHANG dh = db.DONDATHANGs.Where(x => x.ID == maddh).FirstOrDefault();
                    dh.TRANGTHAI = true;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                }
            }
        }


       
        public void UpdateSL(DONDATHANG ddh, List<CT_DONDATHANG> ctdh)
        {
            //bool update = false;
            //try
            //{
            //foreach (CT_DONDATHANG ct in ctdh)
            //{
            //    CT_DONDATHANG ctddh = db.CT_DONDATHANG.Where(x => x.IDSANPHAM == ct.IDSANPHAM && x.IDDONDAT == ct.IDDONDAT).FirstOrDefault();
            //    //ctddh.
            //}
            //}
        }
    }
}
