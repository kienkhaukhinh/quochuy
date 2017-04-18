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
    public partial class banhangview : UserControl
    {
        DataTable data_dssp;
        public banhangview()
        {
            InitializeComponent();
            data_dssp = new DataTable();
            LoadDSSPvaLoaiSP();
            LoadDataKhachHang();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_tientra.Text != "" && cthdgv.Rows.Count != 0)
            {
                SANPHAMBUS spbus = new SANPHAMBUS();
                HOADON hd = new HOADON();
                HOADONBUS hdbus = new HOADONBUS();
                KHACHHANGBUS khbus = new KHACHHANGBUS();
                List<CT_HOADON> list_cthd = new List<CT_HOADON>();
                hd.MAKHTT = txt_makhach.Text;
                hd.NGAYXUAT = DateTime.Today;
                hd.THANHTIEN = Int32.Parse(txt_tongtiensaugiam.Text.ToString());
                foreach (DataGridViewRow row in cthdgv.Rows)
                {
                    CT_HOADON CTHD = new CT_HOADON();
                    CTHD.IDSANPHAM = int.Parse(row.Tag.ToString());
                    CTHD.SL = int.Parse(row.Cells[1].Value.ToString());
                    CTHD.TONG = int.Parse(row.Cells[3].Value.ToString());
                    list_cthd.Add(CTHD);
                    spbus.CapNhatSLBayBanSP(CTHD.IDSANPHAM, CTHD.SL);
                }
                if (hdbus.ThemHoaDon(hd, list_cthd))
                {
                    if (txt_makhach.Text != "")
                    {
                        int diemcong = (int)(hd.THANHTIEN / 200000);
                        if (khbus.UpdateDiemTL(txt_makhach.Text, diemcong))
                        {
                            if (KHACHHANGDAO.trudiemtichluy)
                            {
                                MessageBox.Show("Khách hàng đã đủ số điểm tích lũy cần thiết để nhận Voucher. Hãy cấp Voucher trị giá 200.000 đồng cho khách hàng. Điểm tích lũy sẽ được trừ đi.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi:" + KHACHHANGDAO.error_message);
                        }
                    }
                    MessageBox.Show("Thanh toán thành công!");

                    btnxoa.PerformClick();
                }

                else
                {
                    MessageBox.Show("Lỗi:" + HOADONDAO.error_message);
                }
            }
        }

        private void voucher_CheckedChanged(object sender, EventArgs e)
        {
            

            if (voucher.Checked)
            {
                txt_tongtiensaugiam.Text = (Int32.Parse(txt_tongtien.Text) - 100000).ToString();
            }
            else
            {
                txt_tongtiensaugiam.Text = txt_tongtien.Text;
            }
        

        }

        private void LoadDSSPvaLoaiSP()
        {
            //Khoi tao datatable San Pham
            data_dssp = new DataTable();
            data_dssp.Columns.Add("ID", typeof(int));
            data_dssp.Columns.Add("Tên", typeof(string));
            data_dssp.Columns.Add("Đơn giá", typeof(int));
            data_dssp.Columns.Add("SL bán", typeof(int));
            data_dssp.Columns.Add("Loại", typeof(int));


            //data_dssp_xk = new DataTable();
            //data_dssp_xk.Columns.Add("ID", typeof(int));
            //data_dssp_xk.Columns.Add("Tên", typeof(string));
            //data_dssp_xk.Columns.Add("SL Tồn ", typeof(int));
            //data_dssp_xk.Columns.Add("Loại", typeof(int));



            SANPHAMBUS spbus = new SANPHAMBUS();  //Khoi tao SANPHAMBUS de goi ham duoi controller
            LOAISPBUS lspbus = new LOAISPBUS();
            List<SANPHAM> lst_sp = new List<SANPHAM>();
            lst_sp = spbus.GetList();
            foreach (SANPHAM sp in lst_sp)
            {
                data_dssp.Rows.Add(sp.ID, sp.TENSP, sp.GIATIEN, sp.SLBAYBAN, sp.IDLOAISP);// Add tung sanpham co trong DSSP vao data table
                //data_dssp_xk.Rows.Add(sp.ID, sp.TENSP, sp.SLTON, sp.IDLOAISP);
            }
            dsspgv.DataSource = data_dssp; //gan du lieu cho data gridview cho dssp

            dsspgv.Columns["Loại"].Visible = false;


            //dsspgv_xuatkho.DataSource = data_dssp_xk;
            ////dsspgv_xuatkho.Columns["ID"].Width = 50;
            //dsspgv_xuatkho.Columns["Loại"].Visible = false;
            //==========================================================//

            List<LOAISP> lst_lsp = new List<LOAISP>();
            lst_lsp = lspbus.GetList();
            LOAISP tatca = new LOAISP();
            tatca.ID = 0;
            tatca.TENLOAI = "Tất Cả";
            lst_lsp.Add(tatca);
            cbloaisp.DataSource = lst_lsp;
            cbloaisp.DisplayMember = "TENLOAI";
            cbloaisp.ValueMember = "ID";

        }


        public void LoadDataKhachHang()
        {
            KHACHHANGBUS khbus = new KHACHHANGBUS();
            AutoCompleteStringCollection idkh_collection = new AutoCompleteStringCollection();
            List<string> list_idkh = new List<string>();
            list_idkh = khbus.GetIDList();
            foreach (string id in list_idkh)
            {
                idkh_collection.Add(id);
            }

            txt_makhach.AutoCompleteCustomSource = idkh_collection;
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            int index = dsspgv.CurrentCell.RowIndex;
            int sl = int.Parse(cbb_sl.Value.ToString());
            if (index != -1)
            {
                if (cbb_sl.Value <= (int)dsspgv[3, index].Value)
                {
                    dsspgv[3, index].Value = (int)dsspgv[3, index].Value - cbb_sl.Value;
                    if (checknotexists_in_dtgv(int.Parse(dsspgv[0, index].Value.ToString())))
                    {
                        cthdgv.Rows.Add(dsspgv[1, index].Value, sl, dsspgv[2, index].Value, sl * int.Parse(dsspgv[2, index].Value.ToString()));
                        cthdgv.Rows[cthdgv.Rows.Count - 1].Tag = dsspgv[0, index].Value;
                        cthdgv[1, cthdgv.Rows.Count - 1].ReadOnly = false;
                        TangTien(int.Parse(cthdgv[3, cthdgv.Rows.Count - 1].Value.ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("Không đủ SL cần để bán!");
                }
            }


        }

        private bool checknotexists_in_dtgv(int masp)
        {
            bool check = true;
            foreach (DataGridViewRow row in cthdgv.Rows)
            {

                if (int.Parse(row.Tag.ToString()) == masp)
                {
                    check = false;
                    int tongtiencu = int.Parse(row.Cells[3].Value.ToString());
                    int sl_moi = (int)cbb_sl.Value + int.Parse(row.Cells[1].Value.ToString());
                    int tongtienmoi = sl_moi * int.Parse(dsspgv.CurrentRow.Cells[2].Value.ToString());
                    int current_row = row.Index;
                    MergeRows_va_SuaTien(tongtiencu, tongtienmoi, current_row, sl_moi);
                    break;
                }
            }
            return check;
        }


        private void TangTien(int tientang)
        {
            txt_tongtien.Text = (Int32.Parse(txt_tongtien.Text) + tientang).ToString();
            txt_tongtiensaugiam.Text = txt_tongtien.Text;
        }
        private void GiamTien(int tiengiam)
        {
            txt_tongtien.Text = (Int32.Parse(txt_tongtien.Text) - tiengiam).ToString();
            txt_tongtiensaugiam.Text = txt_tongtien.Text;
        }
        private void SuaTien(int tongtiencu, int tongtienmoi)
        {
            txt_tongtien.Text = (int.Parse(txt_tongtien.Text) - tongtiencu + tongtienmoi).ToString();
            txt_tongtiensaugiam.Text = txt_tongtien.Text;
        }
        private void MergeRows_va_SuaTien(int tongtiencu, int tongtienmoi, int index, int sl_moi)
        {
            cthdgv[1, index].Value = sl_moi;
            cthdgv[3, index].Value = tongtienmoi;
            SuaTien(tongtiencu, tongtienmoi);
        }



        private void cbloaisp_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (!cbloaisp.SelectedValue.ToString().Equals("0"))
            {
                data_dssp.DefaultView.RowFilter = "Loại = " + int.Parse(cbloaisp.SelectedValue.ToString());
            }
            else
            {
                data_dssp.DefaultView.RowFilter = string.Empty;
            }


        }

        private void cthdgv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu = new ContextMenuStrip();
                context_menu.Items.Add("Xóa");
                context_menu.ItemClicked += context_menu_ItemClicked;
                context_menu.Show(cthdgv, e.X, e.Y);
            }
        }

        void context_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Xóa")
            {
                int index = cthdgv.CurrentCell.RowIndex;
                int tiengiam = int.Parse(cthdgv.Rows[index].Cells[3].Value.ToString());
                int index_dssp = getindexofdsspwithvalue((int)cthdgv.Rows[index].Tag);
                dsspgv[3, index_dssp].Value = int.Parse(dsspgv[3, index_dssp].Value.ToString()) + int.Parse(cthdgv[1, index].Value.ToString());
                cthdgv.Rows.RemoveAt(index);
                GiamTien(tiengiam);
            }
        }

        private void cthdgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                int new_sl;
                int index = e.RowIndex;
                bool check = int.TryParse(e.FormattedValue.ToString(), out new_sl);
                if (!check)  // IsNumeric will be your method where you will check for numebrs 
                {
                    MessageBox.Show("Enter valid numeric data");
                    cthdgv.CancelEdit();
                }
                else
                {
                    int index_dssp = getindexofdsspwithvalue((int)cthdgv.Rows[index].Tag);
                    if (int.Parse(dsspgv[3, index_dssp].Value.ToString()) + int.Parse(cthdgv[1, index].Value.ToString()) - new_sl >= 0)
                    {
                        int tongtiencu = int.Parse(cthdgv[3, index].Value.ToString());
                        cthdgv[3, index].Value = (new_sl * Int32.Parse(cthdgv[2, index].Value.ToString())).ToString();
                        dsspgv[3, index_dssp].Value = int.Parse(dsspgv[3, index_dssp].Value.ToString()) + int.Parse(cthdgv[1, index].Value.ToString()) - new_sl;
                        SuaTien(tongtiencu, int.Parse(cthdgv[3, index].Value.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Khong du SL can thiet!");
                        cthdgv.CancelEdit();
                    }
                }

            }
        }

        //Tim ra dong dau tien co MASP tuong ung
        private int getindexofdsspwithvalue(int value)
        {
            var find_row = dsspgv.Rows.Cast<DataGridViewRow>().First(row => row.Cells[0].Value.ToString() == value.ToString());
            return find_row.Index;
        }
        private void txtsearchten_TextChanged(object sender, EventArgs e)
        {
            data_dssp.DefaultView.RowFilter = string.Format("Tên LIKE '%{0}%'", txtsearchten.Text);
        }

        private void txt_tientra_Validating(object sender, CancelEventArgs e)
        {
            int tientra;
            bool check = int.TryParse(txt_tientra.Text, out tientra);
            if (check)
            {
                if (tientra >= int.Parse(txt_tongtiensaugiam.Text))
                {
                    txt_tienthua.Text = (tientra - int.Parse(txt_tongtiensaugiam.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("So tien vua nhap khong du de thanh toan!");
                    txt_tientra.Text = "";
                }
            }
            else
            {
                MessageBox.Show("So tien vua nhap khong hop le");
                txt_tientra.Text = "";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cthdgv.Rows.Clear();
            txt_tongtien.Text = "0";
            txt_tongtiensaugiam.Text = txt_tongtien.Text;
            txt_tienthua.Text = "";
            txt_tientra.Text = "";
            txt_makhach.Text = "";
        }


        
    






    }
}
