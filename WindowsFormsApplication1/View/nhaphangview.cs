using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using Model.BUS;
using Model.ENTITY;
using System.Text;
using Model.VIEWMODEL;
using System.Windows.Forms;

namespace WindowsFormsApplication1.View
{
    public partial class nhaphangview : UserControl
    {

        public nhaphangview()
        {
            InitializeComponent();
            Visible = false;
        }

        private void btn_laydulieu_Click(object sender, EventArgs e)
        {
 
            if (donnhapgv.Rows.Count > 0)
            {
                donnhapgv.Rows.Clear();
            }

            DONDATHANGBUS bus = new DONDATHANGBUS();
            List<DONDATHANG> lst_ddh = bus.GetList();
            
            foreach (DONDATHANG dh in lst_ddh)
            {
                if (dh.TRANGTHAI == false)
                {
                    donnhapgv.Rows.Add(dh.ID, dh.NGAYDAT, dh.IDNCC, dh.IDNGUOIDAT, dh.TONGCONG, "Chưa Xử Lý");
                    donnhapgv[5, donnhapgv.Rows.Count - 1].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    donnhapgv.Rows.Add(dh.ID, dh.NGAYDAT, dh.IDNCC, dh.IDNGUOIDAT, dh.TONGCONG, "Đã Xử Lý");
                    donnhapgv[5, donnhapgv.Rows.Count - 1].Style.BackColor = Color.Green;
                }
            }
        }

        private void cbb_trangthai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string tt = cbb_trangthai.SelectedText;
            if (tt == "Chưa Xử Lý")
            {
               

            }
            else
            {
                donnhapgv.Rows.Cast<DataGridViewRow>().Where(row => row.Cells[5].Value.ToString() == "Đã Xử Lý");
            }
        }

        private void donnhapgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = int.Parse(donnhapgv[0, e.RowIndex].Value.ToString());
            DONDATHANGBUS bus = new DONDATHANGBUS();
            List<ViewCTDDH> ct = bus.GetList(ma);

            nhapkhogv.DataSource = ct;
            nhapkhogv.Columns["TENSP"].HeaderText = "Tên SP";
            nhapkhogv.Columns["SL_Nhap"].HeaderText = "SL Nhập";
            nhapkhogv.Columns["SL"].HeaderText = "SL Đặt";
            nhapkhogv.Columns["DonGia"].HeaderText = "Đơn giá";
            nhapkhogv.Columns["TongTien"].HeaderText = "Tổng";
            nhapkhogv.Columns["MASP"].Visible = false;
        }

        private void nhapkhogv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhapkhogv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                int index = e.RowIndex;
                int sl_dat = int.Parse(nhapkhogv[2,index].Value.ToString());
                int new_sl = common.ktint(e.FormattedValue.ToString());
                
                if (new_sl<0 || new_sl>sl_dat)  // IsNumeric will be your method where you will check for numebrs 
                {
                    MessageBox.Show("Enter valid numeric data");
                    nhapkhogv.CancelEdit();
                }
            }
        }

        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            int index = donnhapgv.CurrentCell.RowIndex;
            int madh = int.Parse(donnhapgv[0,index].Value.ToString());
            int index_ct = nhapkhogv.CurrentCell.RowIndex;
            List<CT_DONDATHANG> ctddh = new List<CT_DONDATHANG>();
            foreach (DataGridViewRow row in nhapkhogv.Rows)
            {
                CT_DONDATHANG ct = new CT_DONDATHANG();
                ct.IDDONDAT = madh;
                ct.IDSANPHAM = int.Parse(nhapkhogv[5,index_ct].Value.ToString());
                ct.SL_NHAP = int.Parse(nhapkhogv[1, index_ct].Value.ToString());
                ctddh.Add(ct);
            }
            DONDATHANGBUS bus = new DONDATHANGBUS();
            if (bus.Update(madh, ctddh))
           {
               MessageBox.Show("Cập nhật thành công!");
               btn_laydulieu.PerformClick();
           }
        }

        
    }
}
