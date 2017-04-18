using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;
using Model.DAO;
namespace Model.BUS
{
    public class KHACHHANGBUS
    {
        KHACHHANGDAO khdao = null;
        public KHACHHANGBUS()
        {
            khdao = new KHACHHANGDAO();
        }
        public List<KHACHHANGTT> GetList()
        {
            return khdao.GetList();
        }

        public List<string> GetIDList()
        {
            return khdao.GetIDList();
        }
        public bool UpdateDiemTL(string makh, int diemcong)
        {
            return khdao.UpdateDiemTL(makh, diemcong);
        }

        public List<KHACHHANGTT> Search(string input)
        {
            return khdao.Search(x => x.TENKH.Contains(input) || x.DIACHI.Contains(input) || x.SDT.Contains(input) || x.CMND.Contains(input));
        }

       private string getid()
        {
            using (TOYDB db = new TOYDB())
            {
                string return_id = "";
                int max_id = 0;
                string max_id_no = db.KHACHHANGTTs.OrderByDescending(x => x.NGAYCAP).Select(x => x.ID.Substring(5, x.ID.Length)).FirstOrDefault();
                if (max_id_no != "")
                {
                    max_id = int.Parse(max_id_no) + 1;
                }
                if (max_id < 10)
                {
                    return_id = "KHACH00" + max_id.ToString();
                }
                else if (max_id >= 10 && max_id < 100)
                {
                    return_id = "KHACH0" + max_id.ToString();
                }
                else
                {
                    return_id = "KHACH" + max_id.ToString();
                }
                return return_id;
            }
        }

        public bool Update(KHACHHANGTT kh)
        {
            return khdao.Update(kh);
        }

        public bool Delete(string Manv)
        {
            KHACHHANGTT kh = new KHACHHANGTT();
            kh.ID = Manv;
            return khdao.Delete(kh);
        }

        public bool Add(KHACHHANGTT kh)
        {
            kh.ID = getid();
            return khdao.Insert(kh);
        }
    }
}
