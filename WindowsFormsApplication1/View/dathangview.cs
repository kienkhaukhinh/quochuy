using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.BUS;
using Model.ENTITY;
using Model.DAO;
namespace WindowsFormsApplication1.View
{
    public partial class dathangview : UserControl
    {
         public dathangview()
        {
            InitializeComponent();
            GetListNCC();
            GetDSSPandLoaiSP();
        }
        SANPHAMBUS spbus = new SANPHAMBUS();
        LOAISPBUS lspbus = new LOAISPBUS();
        DataTable data_dssp;
        NHACCBUS nccbus = new NHACCBUS();
        private void GetListNCC()
        {
            cbbncc.DataSource = nccbus.GetList();
            cbbncc.ValueMember = "ID";
            cbbncc.DisplayMember = "TENNCC";
        }
        private void GetDSSPandLoaiSP()
        {

            data_dssp = new DataTable();
            data_dssp.Columns.Add("Mã SP", typeof(int));
            data_dssp.Columns.Add("Tên", typeof(string));
            data_dssp.Columns.Add("Loại", typeof(int));
            spbus = new SANPHAMBUS();  //Khoi tao SANPHAMBUS de goi ham duoi controller
            List<SANPHAM> lst_sp = new List<SANPHAM>();
            lst_sp = spbus.GetList();
            foreach (SANPHAM sp in lst_sp)
            {
                data_dssp.Rows.Add(sp.ID, sp.TENSP,sp.IDLOAISP); // Add tung sanpham co trong DSSP vao data table
            }

            dsspgv_dh.DataSource = data_dssp; //gan du lieu cho data gridview cho dssp
            dsspgv_dh.Columns["Loại"].Visible = false;
            //==========================================================//

            List<LOAISP> lst_lsp = new List<LOAISP>();
            lst_lsp = lspbus.GetList();
            LOAISP tatca = new LOAISP();
            tatca.ID = 0;
            tatca.TENLOAI = "Tất Cả";
            lst_lsp.Add(tatca);
            cbb_lsp_dh.DataSource = lst_lsp;
            cbb_lsp_dh.DisplayMember = "TENLOAI";
            cbb_lsp_dh.ValueMember = "ID";
            cbb_lsp_dh.SelectedValue = 0;
        }
        

        private void btn_themsp_dh_Click(object sender, EventArgs e)
        {

            int index = dsspgv_dh.CurrentRow.Index;
            if (index != -1 && txtdongia_dh.Text != "")
            {
                if (checknotexists_in_dtgv(int.Parse(dsspgv_dh[0, index].Value.ToString())))
                {
                    dgvphieudat.Rows.Add(dsspgv_dh[1, index].Value, cbb_sl.Value, txtdongia_dh.Text, int.Parse(txtdongia_dh.Text) * cbb_sl.Value);
                    dgvphieudat.Rows[dgvphieudat.Rows.Count - 1].Tag = dsspgv_dh[0, index].Value;
                    dgvphieudat.Rows[dgvphieudat.Rows.Count - 1].Cells[1].ReadOnly = false;
                    int tientang = int.Parse(dgvphieudat.Rows[dgvphieudat.Rows.Count - 1].Cells[3].Value.ToString());
                    TangTien(tientang);
                }

            }
        }

        private void txtdongia_dh_Validating(object sender, CancelEventArgs e)
        {
            if (txtdongia_dh.Text != "")
            {
                int dongia;
                bool check = int.TryParse(txtdongia_dh.Text, out dongia);
                if (!check)
                {
                    MessageBox.Show("So tien vua nhap khong hop le");
                    txtdongia_dh.Text = "";
                }
            }
        }



        private void TangTien(int tientang)
        {
            txt_tongtien.Text = (Int32.Parse(txt_tongtien.Text) + tientang).ToString();
        }
        private void GiamTien(int tiengiam)
        {
            txt_tongtien.Text = (Int32.Parse(txt_tongtien.Text) - tiengiam).ToString();
        }
        private void SuaTien(int tongtiencu, int tongtienmoi)
        {
            txt_tongtien.Text = (int.Parse(txt_tongtien.Text) - tongtiencu + tongtienmoi).ToString();
        }
        private void MergeRows_va_SuaTien(int tongtiencu, int tongtienmoi, int index, int sl_moi)
        {
            dgvphieudat[1, index].Value = sl_moi;
            dgvphieudat[3, index].Value = tongtienmoi;
            SuaTien(tongtiencu, tongtienmoi);
        }

        private void dgvphieudat_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int index = e.RowIndex;
                int new_sl = common.ktint(e.FormattedValue.ToString());
                if (new_sl<0)
                {
                    MessageBox.Show("Enter valid numeric data");
                    dgvphieudat.CancelEdit();
                }
                else
                {
                    int tongtiencu = int.Parse(dgvphieudat[3, index].Value.ToString());
                    dgvphieudat[3, index].Value = (new_sl * Int32.Parse(dgvphieudat[2, index].Value.ToString())).ToString();
                    SuaTien(tongtiencu, int.Parse(dgvphieudat[3, index].Value.ToString()));
                }
            }
            if (e.ColumnIndex == 2)
            {
                int index = e.RowIndex;
                int new_dongia = common.ktint(e.FormattedValue.ToString());

                if (new_dongia<0)
                {
                    MessageBox.Show("Enter valid numeric data");
                    dgvphieudat.CancelEdit();
                }
                else
                {
                    int tongtiencu = int.Parse(dgvphieudat[3, index].Value.ToString());
                    dgvphieudat[3, index].Value = (new_dongia * Int32.Parse(dgvphieudat[1, index].Value.ToString())).ToString();
                    SuaTien(tongtiencu, int.Parse(dgvphieudat[3, index].Value.ToString()));
                }
            }

        }

        private bool checknotexists_in_dtgv(int masp)
        {
            bool check = true;
            foreach (DataGridViewRow row in dgvphieudat.Rows)
            {

                if (int.Parse(row.Tag.ToString()) == masp)
                {
                    check = false;
                    int tongtiencu = int.Parse(row.Cells[3].Value.ToString());
                    int sl_moi = (int)cbb_sl.Value + int.Parse(row.Cells[1].Value.ToString());
                    int tongtienmoi = sl_moi * int.Parse(dgvphieudat.CurrentRow.Cells[2].Value.ToString());
                    int current_row = row.Index;
                    MergeRows_va_SuaTien(tongtiencu, tongtienmoi, current_row, sl_moi);
                    break;
                }
            }
            return check;
        }
        private void dgvphieudat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu = new ContextMenuStrip();
                context_menu.Items.Add("Xóa");
                context_menu.ItemClicked += context_menu_ItemClicked;
                context_menu.Show(dgvphieudat, e.X, e.Y);
            }

        }

        void context_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = dgvphieudat.CurrentRow.Index;
            int tiengiam = int.Parse(dgvphieudat[3, index].Value.ToString());
            dgvphieudat.Rows.RemoveAt(index);
            GiamTien(tiengiam);
        }

        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            DONDATHANG dh = new DONDATHANG();
            dh.IDNCC = int.Parse(cbbncc.SelectedValue.ToString());
            dh.NGAYDAT = DateTime.Today;
            dh.IDNGUOIDAT = FormMain.currentuser;
            dh.TONGCONG = int.Parse(txt_tongtien.Text.ToString());
            dh.TRANGTHAI = false;
            DONDATHANGBUS bus = new DONDATHANGBUS();
            List<CT_DONDATHANG> ctddh = new List<CT_DONDATHANG>();
            foreach (DataGridViewRow row in dgvphieudat.Rows)
            {
                CT_DONDATHANG ct = new CT_DONDATHANG();
                ct.IDSANPHAM = int.Parse(row.Tag.ToString());
                ct.SL = int.Parse(row.Cells[1].Value.ToString());
                ct.DONGIA = int.Parse(row.Cells[2].Value.ToString());
                ct.TONG = int.Parse(row.Cells[3].Value.ToString());
                ct.SL_NHAP = 0;
                ctddh.Add(ct);

            }
            if (bus.Insert(dh, ctddh))
            {
                MessageBox.Show("đã lưu đơn hàng");

            }
            else
            {
                MessageBox.Show(DONDATHANGDAO.error_message);
            }
           
        }

        private void cbb_lsp_dh_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (!cbb_lsp_dh.SelectedValue.ToString().Equals("0"))
            {
                data_dssp.DefaultView.RowFilter = "Loại = " + int.Parse(cbb_lsp_dh.SelectedValue.ToString());
            }
            else
            {
                data_dssp.DefaultView.RowFilter = string.Empty;
            }

        }

        private void txt_tensp_dh_TextChanged(object sender, EventArgs e)
        {
            data_dssp.DefaultView.RowFilter = string.Format("Tên LIKE '%{0}%'", txt_tensp_dh.Text);
        }



    }
    }


