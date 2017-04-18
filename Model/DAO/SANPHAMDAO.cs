using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;
namespace Model.DAO
{
    public class SANPHAMDAO : GenericDataRepository<SANPHAM>
    {
        public bool CapNhatSLBayBanSP(int masp, int sl)
        {
            bool capnhat = false;
            try
            {
                SANPHAM sp = db.SANPHAMs.Where(x => x.ID == masp).FirstOrDefault();
                sp.SLBAYBAN = sp.SLBAYBAN - sl;
                db.SaveChanges();
                capnhat = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return capnhat;
        }

        public bool CapNhatSLTonSP(int masp, int sl)
        {
            bool capnhat = false;
            try
            {
                SANPHAM sp = db.SANPHAMs.Where(x => x.ID == masp).FirstOrDefault();
                sp.SLTON = sp.SLTON - sl;
                db.SaveChanges();
                capnhat = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return capnhat;
        }



        public bool DeleteAllWithLSP(int lsp)
        {
            bool delete = false;
            try
            {
                var list_with_lsp = db.SANPHAMs.Where(x => x.IDLOAISP == lsp);
                db.SANPHAMs.RemoveRange(list_with_lsp);
                db.SaveChanges();
                delete = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return delete;
        }
    }
    }