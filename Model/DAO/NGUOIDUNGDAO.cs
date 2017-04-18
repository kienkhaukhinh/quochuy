using Model.BUS;
using Model.DAO;
using Model.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Model.DAO
{
    public class NGUOIDUNGDAO : GenericDataRepository<NGDUNG>
    {

      
        public int? phanquyen(string id)
        {
            return db.NGDUNGs.Where(x => x.ID == id).Select(c => c.PHANQUYEN).FirstOrDefault();
        }

       
    }
}
