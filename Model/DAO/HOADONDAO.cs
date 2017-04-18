using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;
namespace Model.DAO
{
    public class HOADONDAO : GenericDataRepository<HOADON>
    {
        //public static string error = "";


        public  bool Insert(HOADON hd,List<CT_HOADON> lcthd)
        {
            bool insert = false;
            try
            {
                db.HOADONs.Add(hd);
                db.SaveChanges();
                foreach (CT_HOADON ct in lcthd)
                {
                    ct.IDHOADON = hd.ID;
                    db.CT_HOADON.Add(ct);
                    db.SaveChanges();
                    
                }
                insert = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return insert;


        }
      
        
    }
}
