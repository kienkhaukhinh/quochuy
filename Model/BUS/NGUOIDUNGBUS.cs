using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using Model.ENTITY;
using Model.DAO;

namespace Model.BUS
{
    public class NGUOIDUNGBUS
    {
        

        NGUOIDUNGDAO ngdungdao = null;
        public NGUOIDUNGBUS()
        {
            ngdungdao = new NGUOIDUNGDAO();

        }
        public List<NGDUNG> GetList() 
        {
            return ngdungdao.GetList();
        }
        

       
        public bool Update(NGDUNG entity)
        {
            return ngdungdao.Update(entity);
        }
        public bool Delete(NGDUNG entity)
        {
            return ngdungdao.Delete(entity);
        }
        public bool Add(NGDUNG ngd)
        {
            return ngdungdao.Insert(ngd);
        }
        public List<NGDUNG> Search(string input)
        {
            return ngdungdao.Search(x => x.ID.Contains(input) || x.TENNGDUNG.Contains(input));
        }

       

        public short dangnhap(string id, string pass)
        {
            NGDUNG login = new NGDUNG();
            short phanquyen;
            login = ngdungdao.GetSingle(x=>x.ID == id && x.PASSWD == pass);
            if (login != null)
            {
                phanquyen = login.PHANQUYEN;
            }
            else
            {
                phanquyen = -1;
            }
            return phanquyen;
        }

 
    }
}
