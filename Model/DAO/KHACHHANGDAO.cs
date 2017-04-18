using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;

namespace Model.DAO
{
    public class KHACHHANGDAO : GenericDataRepository<KHACHHANGTT>
    {
        public static bool trudiemtichluy;
        public KHACHHANGDAO()
        {
            trudiemtichluy = false;
        }

        public List<string> GetIDList()
        {
            return db.KHACHHANGTTs.Select(x => x.ID).ToList();
        }
        
      
        public bool UpdateDiemTL(string makh, int diemcong)
        {
            bool update = false;
            KHACHHANGTT kh = new KHACHHANGTT();
            kh = db.KHACHHANGTTs.Where(x => x.ID == makh).FirstOrDefault();
            try
            {
                kh.DIEMTL += diemcong;
                db.SaveChanges();
                update = true;
                if (kh.DIEMTL >= 10)
                {
                    kh.DIEMTL = kh.DIEMTL - 10;
                    db.SaveChanges();
                    trudiemtichluy = true;
                }
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return update;
        }

       

    }

}
