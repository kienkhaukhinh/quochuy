using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;
using Model.VIEWMODEL;

namespace Model.DAO
{
    public class CTDONHANGDAO : GenericDataRepository<CT_DONDATHANG>
    {
        public bool UpdateSLNhap(CT_DONDATHANG ctiet)
        {
            bool update = false;
            try
            {

                CT_DONDATHANG ct = GetSingle(x => x.IDDONDAT == ctiet.IDDONDAT && x.IDSANPHAM == ctiet.IDSANPHAM);
                if (ct != null)
                {
                    ct.SL_NHAP = ctiet.SL_NHAP;
                    db.SaveChanges();
                    update = true;
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
