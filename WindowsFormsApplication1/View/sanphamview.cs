using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.ENTITY;
using Model.BUS;
using Model.DAO;
using System.IO;

namespace WindowsFormsApplication1.View
{
    public partial class sanphamview : UserControl
    {
        public sanphamview()
        {
            InitializeComponent();
            LoadLSP();
            Visible = false;
        }




        private void LoadLSP()
        {
            LOAISPBUS lspbus = new LOAISPBUS();
            List<LOAISP> lsp = new List<LOAISP>();
            lsp = lspbus.GetList();
            cbb_maloai.DataSource = lsp;
            cbb_maloai.ValueMember = "ID";
            cbb_maloai.DisplayMember = "TENLOAI";



            cbb_loaisp_ds.DataSource = cbb_maloai.DataSource;
            cbb_loaisp_ds.ValueMember = "ID";
            cbb_loaisp_ds.DisplayMember = "TENLOAI";

            cbb_lsp_ds_tk.DataSource = cbb_maloai.DataSource;
            cbb_lsp_ds_tk.ValueMember = "ID";
            cbb_lsp_ds_tk.DisplayMember = "TENLOAI";

            //----------------------//

        }




        private void btn_luusp_Click(object sender, EventArgs e)
        {
            SANPHAMBUS spbus = new SANPHAMBUS();
            int giasp = 0;
            bool check_gia_valid = int.TryParse(txt_gia.Text, out giasp);
            if (check_gia_valid && txt_tensp.Text != "")
            {
                SANPHAM sp = new SANPHAM();
                sp.IDLOAISP = int.Parse(cbb_maloai.SelectedValue.ToString());
                sp.SLBAYBAN = (int)cbb_sl_ban.Value;
                sp.SLTON = (int)cbb_sl_kho.Value;
                sp.TENSP = txt_tensp.Text;
                sp.XUATXU = txt_xuatxu.Text;
                if (txt_anh.Text != "")
                {
                    sp.HINHANH = txt_anh.Text;
                }
                else
                {
                    sp.HINHANH = "NoImage.jpg";
                }
                sp.GIATIEN = giasp;
                if (spbus.Add(sp))
                {
                    MessageBox.Show("Đã Lưu");
                    common.ClearTextBoxes(pnnhanvienthem);
                }
                else
                {
                    MessageBox.Show(SANPHAMDAO.error_message);
                }
            }
            else
            {
                if (!check_gia_valid)
                {
                    error_sp.SetError(txt_gia, "Gía tiền không hợp lệ");
                }
                if (txt_tensp.Text == "")
                {
                    error_sp.SetError(txt_tensp, "Tên SP k dc rỗng");
                }
            }
            
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPEG Files|*.jpg|PNG Files|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                txt_anh.Text = Path.GetFileName(op.FileName);
                anhsp.Image = Image.FromFile(Path.GetFullPath(op.FileName));
            }
        }

        private void btn_laydulieu_lsp_Click(object sender, EventArgs e)
        {
            LOAISPBUS lspbus = new LOAISPBUS();
            List<LOAISP> lsp = new List<LOAISP>();
            lsp = lspbus.GetList();
            loaidgv.DataSource = lsp;
            loaidgv.Columns[1].HeaderText = "Tên Loại";

        }
        

        private void btn_themlsp_Click(object sender, EventArgs e)
        {
            LOAISPBUS lspbus = new LOAISPBUS();
            LOAISP lsp = new LOAISP();
            lsp.TENLOAI = txt_tenlsp.Text;
            if (lspbus.Add(lsp))
            {
                MessageBox.Show("Thanh cong");
                btn_laydulieu_lsp.PerformClick();
                LoadLSP();
            }
            else
            {
                MessageBox.Show(GenericDataRepository<LOAISP>.error_message);
            }
        }

        private void btn_sualsp_Click(object sender, EventArgs e)
        {
            LOAISPBUS lspbus = new LOAISPBUS();
            int index = loaidgv.CurrentRow.Index;
            if (txt_tenlsp.Text != "")
            {
                LOAISP lsp = new LOAISP();

                lsp.ID = int.Parse(txt_malsp.Text);
                lsp.TENLOAI = txt_tenlsp.Text;
                if (lspbus.Update(lsp))
                {
                    MessageBox.Show("Đã cập nhật");
                    loaidgv[1, index].Value = lsp.TENLOAI;
                }
            }
            else
            {
                error_lsp.SetError(txt_tenlsp, "Không được để trống tên loại sp");
            }

        }

        private void btn_laydulieu_Click(object sender, EventArgs e)
        {
            SANPHAMBUS spbus = new SANPHAMBUS();
            List<SANPHAM> listsp = new List<SANPHAM>();
            listsp = spbus.GetList();
            dsspgv.DataSource = listsp;
            dsspgv.Columns["HINHANH"].Visible = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int index = dsspgv.CurrentCell.RowIndex;
            if (common.ktint(txt_giaban_ds.Text) != -1 && txt_tensp_ds.Text != "" && index!=-1)
            {
                SANPHAMBUS spbus = new SANPHAMBUS();
                SANPHAM sp = new SANPHAM();
                sp.ID = int.Parse(txt_masp.Text);
                sp.TENSP = txt_tensp_ds.Text;
                sp.XUATXU = txt_xuatxu_ds.Text;
                sp.GIATIEN = int.Parse(txt_giaban_ds.Text);
                sp.SLBAYBAN = (int)sl_ban_ds.Value;
                sp.SLTON = (int)sl_ton_ds.Value;
                sp.IDLOAISP = (int)cbb_loaisp_ds.SelectedValue;
                sp.HINHANH = txt_anh_ds.Text;
                if (spbus.Update(sp))
                {
                    MessageBox.Show("Da Luu");
                }
                else
                {
                    MessageBox.Show(SANPHAMDAO.error_message);
                }
            }
        }

        private void btn_chonanh_ds_Click(object sender, EventArgs e)
        {

        }

        private void dsspgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                txt_anh_ds.Text = dsspgv[7, index].Value.ToString();
                txt_masp.Text = dsspgv[0, index].Value.ToString();
                txt_tensp_ds.Text = dsspgv[1, index].Value.ToString();
                txt_xuatxu_ds.Text = dsspgv[2, index].Value.ToString();
                txt_giaban_ds.Text = dsspgv[5, index].Value.ToString();
                sl_ban_ds.Value = int.Parse(dsspgv[4, index].Value.ToString());
                sl_ton_ds.Value = int.Parse(dsspgv[3, index].Value.ToString());
                cbb_loaisp_ds.SelectedValue = dsspgv[6, index].Value;
                pic_sp.Image = Image.FromFile(common.appPath + dsspgv[7, index].Value.ToString());
            }
        }

        private void dsspgv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu_sp = new ContextMenuStrip();
                context_menu_sp.Items.Add("Xóa",null,new EventHandler(xoasp));
                context_menu_sp.Show(dsspgv, e.X, e.Y);
            }
        }

        private void xoasp(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa Sản Phẩm" + "\n" + "Bạn chắc chắn chứ", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int row = dsspgv.CurrentRow.Index;
                xoasp(int.Parse(dsspgv[0,row].Value.ToString()));
            }
        }


        private void xoasp(int masp)
        {
            SANPHAM sp = new SANPHAM();
            SANPHAMBUS spbus = new SANPHAMBUS();
            sp.ID = masp;
            if (spbus.Delete(sp))
            {
                MessageBox.Show("Xóa Thành công!");
                btn_laydulieu.PerformClick();
            }
        }


        void context_menu_sp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SANPHAMBUS spbus = new SANPHAMBUS();
            int index = dsspgv.CurrentRow.Index;
            SANPHAM sp = new SANPHAM();
            sp.ID = int.Parse(dsspgv[0, index].Value.ToString());
            if (spbus.Delete(sp))
            {
                MessageBox.Show("Đã xóa!");
                common.ClearOnlyTextBoxes(tabloaisanpham);
                btn_laydulieu.PerformClick();
            }
            else
            {
                MessageBox.Show(SANPHAMDAO.error_message);
            }
        }

        private void loaidgv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu_lsp = new ContextMenuStrip();
                context_menu_lsp.Items.Add("Xóa", null, new EventHandler(xoalsp));
                context_menu_lsp.Show(loaidgv, e.X, e.Y);
            }
        }

        private void xoalsp(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa Loại Phẩm" + "\n" + "Bạn chắc chắn chứ", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int row = loaidgv.CurrentRow.Index;
                xoalsp(int.Parse(loaidgv[0, row].Value.ToString()));
            }
        }
        private void xoalsp(int malsp)
        {
            LOAISP lsp = new LOAISP();
            LOAISPBUS lspbus = new LOAISPBUS();
            SANPHAMBUS spbus = new SANPHAMBUS();
            if (spbus.LSPExists(malsp))
            {
                DialogResult dialogResult = MessageBox.Show("Loại Phẩm Bạn Muốn Xóa Hiện có chứa Sản Phẩm. Nếu Bạn xóa Loại SP này, SP thuộc về LSP này sẽ mất đi." + "\n" + "Bạn chắc chắn muốn xóa chứ", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                lsp.ID = malsp;
                spbus.DeleteAllWithLSP(malsp);
                btn_laydulieu.PerformClick();
            }
            }
           if(lspbus.Delete(lsp))
                {
                MessageBox.Show("Xóa Thành công!");
                btn_laydulieu_lsp.PerformClick();
               
                }
            else
            {
                MessageBox.Show("Lỗi:" + GenericDataRepository<LOAISP>.error_message);
            }
            }

        private void tabControl5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
        }
    }

