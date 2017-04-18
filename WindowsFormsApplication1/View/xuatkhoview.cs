using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.BUS;
using Model.DAO;
using Model.ENTITY;

namespace WindowsFormsApplication1.View
{
    public partial class xuatkhoview : UserControl
    {
        DataTable data_dssp_xk;
        public xuatkhoview()
        {
            InitializeComponent();
            LoadDSSPvaLoaiSP();
        }
        private void LoadDSSPvaLoaiSP()
        {
            //Khoi tao datatable San Pham
            data_dssp_xk = new DataTable();
            data_dssp_xk.Columns.Add("ID", typeof(int));
            data_dssp_xk.Columns.Add("Tên", typeof(string));
            data_dssp_xk.Columns.Add("SL Tồn ", typeof(int));
            data_dssp_xk.Columns.Add("Loại", typeof(int));



            SANPHAMBUS spbus = new SANPHAMBUS();  //Khoi tao SANPHAMBUS de goi ham duoi controller
            LOAISPBUS lspbus = new LOAISPBUS();
            List<SANPHAM> lst_sp = new List<SANPHAM>();
            lst_sp = spbus.GetList();
            foreach (SANPHAM sp in lst_sp)
            {
                data_dssp_xk.Rows.Add(sp.ID, sp.TENSP, sp.SLTON, sp.IDLOAISP);
            }
            dsspgv_xuatkho.DataSource = data_dssp_xk;
            //dsspgv_xuatkho.Columns["ID"].Width = 50;
            dsspgv_xuatkho.Columns["Loại"].Visible = false;
            //==========================================================//

            List<LOAISP> lst_lsp = new List<LOAISP>();
            lst_lsp = lspbus.GetList();
            cbb_lsp_xk.DataSource = lst_lsp;
            cbb_lsp_xk.DisplayMember = "TENLOAI";
            cbb_lsp_xk.ValueMember = "ID";
        }

        private void btn_xuatkho_Click(object sender, EventArgs e)
        {
            int index = dsspgv_xuatkho.CurrentCell.RowIndex;


            int sl_ton = int.Parse(dsspgv_xuatkho[2, index].Value.ToString());
            if (cbb_sl_xk.Value <= sl_ton)
            {

                if (checkifnotexists_in_xkgv(int.Parse(dsspgv_xuatkho[0, index].Value.ToString())))
                {
                    dgvxk.Rows.Add(dsspgv_xuatkho[1, index].Value, cbb_sl_xk.Value);
                    dgvxk.Rows[dgvxk.Rows.Count - 1].Tag = dsspgv_xuatkho[0, index].Value;

                }
                dsspgv_xuatkho[2, index].Value = sl_ton - cbb_sl_xk.Value;
            }
            else
            {
                MessageBox.Show("Không đủ SL cần!");
            }
        }

        void MergeRows_XK(int current_row, int sl_moi)
        {
            dgvxk[1, current_row].Value = sl_moi;
        }
        bool checkifnotexists_in_xkgv(int masp)
        {
            bool check = true;
            foreach (DataGridViewRow row in dgvxk.Rows)
            {
                if (int.Parse(row.Tag.ToString()) == masp)
                {
                    check = false;
                    int sl_moi = (int)cbb_sl_xk.Value + int.Parse(row.Cells[1].Value.ToString());
                    int current_row = row.Index;
                    MergeRows_XK(current_row, sl_moi);
                    break;
                }
            }
            return check;
        }

        private void cbb_lsp_xk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!cbb_lsp_xk.SelectedValue.ToString().Equals("0"))
            {
                data_dssp_xk.DefaultView.RowFilter = "Loại = " + int.Parse(cbb_lsp_xk.SelectedValue.ToString());
            }
            else
            {
                data_dssp_xk.DefaultView.RowFilter = string.Empty;
            }
        }

        private void txt_tensp_xk_TextChanged(object sender, EventArgs e)
        {
            data_dssp_xk.DefaultView.RowFilter = string.Format("Tên LIKE '%{0}%'",txt_tensp_xk.Text);
        }

        //Tim ra dong dau tien co MASP tuong ung
        private int getindexofdsspwithvalue(int value)
        {
            var find_row = dsspgv_xuatkho.Rows.Cast<DataGridViewRow>().First(row => row.Cells[0].Value.ToString() == value.ToString());
            return find_row.Index;
        }

        private void dgvxk_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {


                int index = e.RowIndex;
                int new_sl = common.ktint(e.FormattedValue.ToString());
                if (new_sl==-1)  // IsNumeric will be your method where you will check for numebrs 
                {
                    MessageBox.Show("Enter valid numeric data");
                    dgvxk.CancelEdit();
                }
                else
                {
                    int index_dssp = getindexofdsspwithvalue((int)dgvxk.Rows[index].Tag);
    
                    if (int.Parse(dsspgv_xuatkho[2, index_dssp].Value.ToString()) + int.Parse(dgvxk[1, index].Value.ToString()) - new_sl >= 0)
                    {
                        dsspgv_xuatkho[2, index_dssp].Value = int.Parse(dsspgv_xuatkho[2, index_dssp].Value.ToString()) + int.Parse(dgvxk[1, index].Value.ToString()) - new_sl;
                    }
                    else
                    {
                        MessageBox.Show("Khong du SL can thiet!");
                        dgvxk.CancelEdit();
                    }
                }

            }
        }

        private void btn_hoantat_xk_Click(object sender, EventArgs e)
        {
            int success_count = 0;
            int rowcount = dgvxk.Rows.Count;

            foreach (DataGridViewRow row in dgvxk.Rows)
            {

                 SANPHAMBUS spbus = new SANPHAMBUS();
                 int masp = int.Parse(row.Tag.ToString());
                 int sl = int.Parse(row.Cells[1].Value.ToString());
                 if (!spbus.CapNhatSLTonSP(masp, sl))
                 {
                     MessageBox.Show("Lỗi:" + SANPHAMDAO.error_message);
                 }
                 else
                 {
                     success_count += 1;
                 }
            }
            if (success_count == rowcount)
            {
                MessageBox.Show("Xuất kho thành công!");
                btnxoa.PerformClick();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            dgvxk.Rows.Clear();
        }

        private void dgvxk_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu = new ContextMenuStrip();
                context_menu.Items.Add("Xóa");
                context_menu.ItemClicked += context_menu_ItemClicked;
                context_menu.Show(dgvxk, e.X, e.Y);
            }
        }

        void context_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Xóa")
            {
                int index = dgvxk.CurrentCell.RowIndex;
                int index_dssp = getindexofdsspwithvalue((int)dgvxk.Rows[index].Tag);
                dsspgv_xuatkho[2, index_dssp].Value = int.Parse(dsspgv_xuatkho[2, index_dssp].Value.ToString()) + int.Parse(dgvxk[1, index].Value.ToString());
                dgvxk.Rows.RemoveAt(index);
            }
        }





    }
}
