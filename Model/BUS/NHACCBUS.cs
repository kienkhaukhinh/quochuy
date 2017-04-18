using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.ENTITY;
namespace Model.BUS
{
   
     public class NHACCBUS
     {
         GenericDataRepository<NHACC> dao = null;

         public NHACCBUS()

         {
             dao = new GenericDataRepository<NHACC>();
         }
         public List<NHACC> GetList()
         {
             return dao.GetList();
         }
         public bool Add(NHACC ncc)
         {
             return dao.Insert(ncc);
         }
         public bool Update(NHACC ncc)
         {
             return dao.Update(ncc);
         }
         public bool Delete(NHACC ncc)
         {
             return dao.Delete(ncc);
         }

    }

}
