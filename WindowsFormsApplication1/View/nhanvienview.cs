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
using Model.BUS;
using Model.ENTITY;
using Model.DAO;
using WindowsFormsApplication1.View;
using MetroFramework.Forms;
using System.Collections;
namespace WindowsFormsApplication1.View
{
    public partial class nhanvienview : UserControl
    {
        public nhanvienview()
        {
            InitializeComponent();
            
            Visible = false;
        }
        NGUOIDUNGBUS bus = new NGUOIDUNGBUS();
 
        //Thêm nhân viên
        private void btnsavenhanvien_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                NGDUNG entity = new NGDUNG();
                entity.ID = txtID.Text;
                entity.TENNGDUNG = txttennhanvien.Text;
                entity.SDT = txtsdt.Text;
                entity.PASSWD = txtpass.Text;
                if (comboBox1.SelectedItem.Equals("Quản lý"))
                {
                    entity.PHANQUYEN = 2;
                }
                else if (comboBox1.SelectedItem.Equals("Nhân viên"))
                {
                    entity.PHANQUYEN = 1;
                }
                else entity.PHANQUYEN = 0;

                if (txtpass.Text != txtrepass.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool success = bus.Add(entity);
                    if (success)
                    {
                        common.successorerror(success);
                    }
                    /*
                else
                {
                    ViewErrors(bus.validatedictionary);
                } */
                }


                if (!bus.Add(entity))
                {
                    MessageBox.Show(NGUOIDUNGDAO.error_message);
                }
                else
                {
                    MessageBox.Show("THÊM THÀNH CÔNG!!");
                    nhanviendgv.DataSource = bus.GetList();
                    nhanviendgv.Columns["ID"].HeaderText = "ID người dùng";
                    nhanviendgv.Columns["TENGDUNG"].HeaderText = "Tên";


                    nhanviendgv.Columns["SDT"].HeaderText = "Điện thoại";
                    nhanviendgv.Columns["PHANQUYEN"].Visible = false;
                    nhanviendgv.Columns["PASSWD"].Visible = false;

                    nhanviendgv.Columns["ID"].Visible = false;
                }
            }
        }

        private void btnGetdata_Click(object sender, EventArgs e)
        {
            nhanviendgv.DataSource = bus.GetList();
            nhanviendgv.Columns["ID"].HeaderText = "ID ";
            nhanviendgv.Columns["TENNGDUNG"].HeaderText = "Tên nhân viên";
            nhanviendgv.Columns["SDT"].HeaderText = "SĐT";
            nhanviendgv.Columns["PHANQUYEN"].HeaderText = "Phân Quyền";


            nhanviendgv.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            nhanviendgv.Columns["PASSWD"].Visible = false;
           
        }
        //xóa thành viên
        private void xoanv(object sender, EventArgs args)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa thông tin của thành viên" + "\n" + "Bạn chắc chắn chứ", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int row = nhanviendgv.CurrentRow.Index;
                xoathanhvien((string)nhanviendgv[0, row].Value);
            }
        }

        private void xoathanhvien(string manv)
        {
            NGDUNG ngdung = new NGDUNG();
            ngdung.ID = manv;
            if (bus.Delete(ngdung))
            {
                MessageBox.Show("Xóa Thành công!");
                nhanviendgv.DataSource = bus.GetList();
            }
        }
        //Chuột phải để xóa thàn viên
        private void nhanviendgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Items.Add("Xóa", null, new EventHandler(xoanv));
                    //Di chuyen den dong hien hanh
                    nhanviendgv.CurrentCell = nhanviendgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = nhanviendgv.PointToClient(Control.MousePosition);
                    menu.Show(nhanviendgv, pt.X, pt.Y);
                }
            }
        }
        //Nhắp đúp để load thông tin lên
        private void nhanviendgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.nhanviendgv.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtsuaidnhanvien.Text = row.Cells["ID"].Value.ToString();
                suatxtten.Text = row.Cells["TENNGDUNG"].Value.ToString();
                suatxtmatkhau.Text = row.Cells["PASSWD"].Value.ToString();
                txtsuasdt.Text = row.Cells["SDT"].Value.ToString();
                if (row.Cells["PHANQUYEN"].Value.ToString().Equals("2"))
                {
                    cbphanquyen.Text = "Quản lý";
                }
                else if (row.Cells["PHANQUYEN"].Value.ToString().Equals("1"))
                {
                    cbphanquyen.Text = "Nhân viên";
                }
                if (row.Cells["PHANQUYEN"].Value.ToString().Equals("0"))
                {
                    cbphanquyen.Text = "Thủ kho";
                }
            }
        }

        private void btnCapnhap_Click(object sender, EventArgs e)
        {
            
            NGDUNG entity = new NGDUNG();
            entity.ID = txtsuaidnhanvien.Text;
            entity.TENNGDUNG = suatxtten.Text;
            entity.PASSWD = suatxtmatkhau.Text;
            entity.NGAYSINH = dateTimePicker1.Value.Date;

            entity.SDT = txtsuasdt.Text;
          //  entity.PHANQUYEN = cbphanquyen..;
            if (cbphanquyen.SelectedItem.Equals("Quản lý"))
            {
                entity.PHANQUYEN = 2;
            }
            else if (cbphanquyen.SelectedItem.Equals("Nhân viên"))
            {
                entity.PHANQUYEN = 1;
            }
            else if (cbphanquyen.SelectedItem.Equals("Thủ kho"))
            {
                entity.PHANQUYEN = 0;
            }
           

            bool success = bus.Update(entity);
            
            common.successorerror(success);
            if (success)
            {
                common.ClearTextBoxes(tabPage17);
             //   nhanviendgv.DataSource = bus.findall(textBox19.Text);
                nhanviendgv.Columns["PASSWD"].Visible = false;
            }
           /* else
            {
                ViewErrors(bus.validatedictionary);
            } */
        }

        
    }
}
