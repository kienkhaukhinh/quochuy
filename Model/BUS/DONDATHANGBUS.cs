using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.ENTITY;
using Model.VIEWMODEL;
namespace Model.BUS
{
    public class DONDATHANGBUS
    {
        DONDATHANGDAO dao;
        GenericDataRepository<CT_DONDATHANG> ctdh_dao;
        public DONDATHANGBUS()
        {
            dao = new DONDATHANGDAO();
            ctdh_dao = new GenericDataRepository<CT_DONDATHANG>();
        }

        public List<DONDATHANG> GetList()
        {
            return dao.GetList();
        }
        public bool Insert(DONDATHANG dh,List<CT_DONDATHANG> ct)
        {
            return dao.Insert(dh, ct);
        }
        public bool Update(int maddh,List<CT_DONDATHANG> ctdh)
        {
            return dao.Update(maddh,ctdh);
        }
        public List<ViewCTDDH> GetList(int ma)
        {
            return dao.GetList(ma);
        }
    }
}
