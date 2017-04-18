using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.ENTITY;
using Model.BUS;
using Model.DAO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using WindowsFormsApplication1.View;
using MetroFramework.Forms;
using System.Collections;
namespace WindowsFormsApplication1.View
{
    public partial class khachhangview : UserControl
    {
        public khachhangview()
        {
            InitializeComponent();
            dtpngayhethan.Value = dtpickerngaycap.Value.AddYears(1);
        }




        //button lấy dữ liệu khách hàng
        private void btn_laydulieu_kh_Click(object sender, EventArgs e)
        {
            KHACHHANGBUS bus = new KHACHHANGBUS();
            thanhviendgv.DataSource = bus.GetList();
            thanhviendgv.Columns["ID"].HeaderText = "ID khách hàng";
            thanhviendgv.Columns["TENKH"].HeaderText = "Tên khách hàng";
            thanhviendgv.Columns["CMND"].HeaderText = "CMND";
            thanhviendgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
            thanhviendgv.Columns["SDT"].HeaderText = "Điện thoại";
            thanhviendgv.Columns["DIEMTL"].HeaderText = "Điểm tích lũy";
            thanhviendgv.Columns["NGAYCAP"].Visible = false;
            thanhviendgv.Columns["NGAYHETHAN"].Visible = false;
            thanhviendgv.Columns["ID"].Visible = false;

        }

        //button thêm khách hàng
        private void btnThemkhtt_Click(object sender, EventArgs e)
        {
            KHACHHANGBUS bus = new KHACHHANGBUS();
            KHACHHANGTT entity = new KHACHHANGTT();
            entity.TENKH = txtTenkhachhang.Text;
            entity.CMND = txtCMND.Text;
            entity.DIACHI = txtDiaChi.Text;
            entity.SDT = txtDienthoai.Text;
            entity.NGAYCAP = dtpickerngaycap.Value;
            entity.NGAYHETHAN = dtpngayhethan.Value;
            if (!bus.Add(entity))
            {
                MessageBox.Show(KHACHHANGDAO.error_message);
            }
            else
            {
                MessageBox.Show("THÊM THÀNH CÔNG!!");
                thanhviendgv.DataSource = bus.GetList();
                thanhviendgv.Columns["ID"].HeaderText = "ID khách hàng";
                thanhviendgv.Columns["TENKH"].HeaderText = "Tên khách hàng";
                thanhviendgv.Columns["CMND"].HeaderText = "CMND";
                thanhviendgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
                thanhviendgv.Columns["SDT"].HeaderText = "Điện thoại";
                thanhviendgv.Columns["DIEMTL"].HeaderText = "Điểm tích lũy";
                thanhviendgv.Columns["NGAYCAP"].Visible = false;
                thanhviendgv.Columns["NGAYHETHAN"].Visible = false;
                thanhviendgv.Columns["ID"].Visible = false;  
            }
        }

       
        //button cập nhập KHÁCH HÀNG
        private void btnupdatekh_Click(object sender, EventArgs e)
        {
            KHACHHANGBUS bus = new KHACHHANGBUS();
            KHACHHANGTT entity = new KHACHHANGTT();
            if (txtsuaten.Text != "")
            {
                entity.ID = txtsuaid.Text;
                entity.TENKH = txtsuaten.Text;
                entity.CMND = txtsuacmnd.Text;
                entity.DIACHI = txtsuadiachi.Text;
                entity.SDT = txtsuasdt.Text;
                bool success = bus.Update(entity);
                common.successorerror(success);
                if (success)
                {
                    common.ClearTextBoxes(tabPage17);
                    //thanhviendgv.DataSource = bus.TimKH(textBox19.Text);
                    //thanhviendgv.Columns["ID"].Visible = false;

                }
            }
        }
        //Nhắp đúp để sửa thông tin khách hàng
        private void thanhviendgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.thanhviendgv.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtsuaid.Text = row.Cells["ID"].Value.ToString();
                txtsuaten.Text = row.Cells["TENKH"].Value.ToString();
                txtsuacmnd.Text = row.Cells["CMND"].Value.ToString();
                txtsuadiachi.Text = row.Cells["DIACHI"].Value.ToString();
                txtsuasdt.Text = row.Cells["SDT"].Value.ToString();

            }
        }
        //xóa khách hàng thân thiết
        private void xoakhtt(object sender, EventArgs args)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa thông tin của thành viên" + "\n" + "Bạn chắc chắn chứ", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int row = thanhviendgv.CurrentRow.Index;
                xoakhachhangthanthiet((string)thanhviendgv[0,row].Value);
            }
        }

            private void xoakhachhangthanthiet(string makhachhang)
        {
            KHACHHANGBUS bus = new KHACHHANGBUS();
            if (bus.Delete(makhachhang))
            {
                MessageBox.Show("Xóa Thành công!");
                thanhviendgv.DataSource = bus.GetList();
            }
        }
      

        //Chuột phải để xóa khtt
        private void thanhviendgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                   
                    menu.Items.Add("Xóa", null, new EventHandler(xoakhtt));
                    //Di chuyen den dong hien hanh
                    thanhviendgv.CurrentCell = thanhviendgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = thanhviendgv.PointToClient(Control.MousePosition);
                    menu.Show(thanhviendgv, pt.X, pt.Y);
                }
            }
        }
        //tìm kiếm khách hàng tt
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            KHACHHANGBUS bus = new KHACHHANGBUS();
            thanhviendgv.DataSource = bus.Search(textBox19.Text);
            //thanhviendgv.Columns["THANHVIENs"].Visible = false;
        }

    }
}
