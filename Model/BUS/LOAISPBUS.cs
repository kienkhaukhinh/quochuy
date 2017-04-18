using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;
using Model.DAO;
namespace Model.BUS
{
    public class LOAISPBUS
    {
        GenericDataRepository<LOAISP> dao = new GenericDataRepository<LOAISP>();
        public List<LOAISP> GetList()
        {
            return dao.GetList();
        }
        public bool Add(LOAISP ls)
        {
            return dao.Insert(ls);
        }
        public bool Update(LOAISP ls)
        {
            return dao.Update(ls);
        }
        public bool Delete(LOAISP ls)
        {
            return dao.Delete(ls);
        }
    }
}
