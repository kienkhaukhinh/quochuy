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
namespace WindowsFormsApplication1
{
    public partial class FormMain : MetroForm
    {
        public static string currentuser ;
        public FormMain()
        {
            InitializeComponent();
            dockingview();

        }

        public FormMain(string manv,short phanquyen)
        {
            InitializeComponent();
            currentuser = manv;
            dockingview();
            idnvlbl.Text = manv;
            if (phanquyen == 0)
            {
                tabform.TabPages.RemoveByKey("tabkhthanthiet");
                tabform.TabPages.RemoveByKey("tabcauhinh");
                tabform.TabPages.RemoveByKey("tabquanlinhapkho");
                tabform.TabPages.RemoveByKey("tabquanlixuatkho");
                tabform.TabPages.RemoveByKey("tabthongketimkiem");
            }
            else if (phanquyen == 1)
            {
                tabform.TabPages.RemoveByKey("tabcauhinh");
                tabform.TabPages.RemoveByKey("tabbanhang");
                tabform.TabPages.RemoveByKey("tabkhthanthiet");
                tabform.TabPages.RemoveByKey("tabthongketimkiem");
            }
           



        }

        //Tao Cac View de su dung

        nhacungcapview nccv = new nhacungcapview();
        nhaphangview dspn = new nhaphangview();
        dathangview dhv = new dathangview();
        nhanvienview nv = new nhanvienview();
        sanphamview spv = new sanphamview();
        khachhangview khv = new khachhangview();        
        thongkeview tkv = new thongkeview();
        banhangview bhv = new banhangview();
        xuatkhoview xkv = new xuatkhoview();
        //Tao Cac DataTable phuc vu cho viec the hien du lieu ra man hinh



    

        //Dock cac view
        #region dockingview
        private void dockingview()
        {
            //pndangnhapuser.Controls.Add(lg);
            //add usercontrols
            tabquanlinhapkho.Controls.Add(dspn);
            tabquanlinhapkho.Controls.Add(dhv);
            tabquanlixuatkho.Controls.Add(xkv);
            tabkhthanthiet.Controls.Add(khv);
            tabthongketimkiem.Controls.Add(tkv);
            tabbanhang.Controls.Add(bhv);
            tabcauhinh.Controls.Add(spv);
            tabcauhinh.Controls.Add(nv);
            tabcauhinh.Controls.Add(nccv);
            dspn.Dock = DockStyle.Fill;
            nv.Dock = DockStyle.Fill;
            nccv.Dock = DockStyle.Fill;
            tkv.Dock = DockStyle.Fill;
            spv.Dock = DockStyle.Fill;
            dhv.Dock = DockStyle.Fill;
            tabform.SelectedIndex = 0;
        }
        #endregion
        
        //context menu de click phai

        

        //private int madonnhap;

        //id của nhân viên đang đăng nhập
        public string manvdangnhap;
        #region dangnhap
        //đăng nhập
       

        #endregion

        #region menu


        //mở panel taodonnhap để tạo phiếu nhập hàng
        

        //mở panel danh sách phiếu nhập hàng
       

        //nút back tất cả mọi thứ
        private void back_Click(object sender, EventArgs e)
        {
            switch (tabform.SelectedIndex)
            {
                case 0:
                    {
                    }
                    break;
                case 1:
                    {

                    }
                    break;
                case 2:
                    {
                        HidePanels(tabkhthanthiet);
                        pnkhachhangtt.Visible = true;
                    }
                    break;
                case 3:
                    {
                        HidePanels(tabquanlinhapkho);
                        dhv.Visible = false;
                        dspn.Visible = false;
                        qlnhapkho.Visible = true;
                    }
                    break;
                case 4:
                    {
                        //HidePanels(tabquanlixuatkho);
                        //qlxuatkho.Visible = true;
                    }
                    break;
                case 5:
                    {
                        //nhanvienbus bus = new nhanvienbus();
                        //if (bus.phanquyen(currentuser.user) == 
                        //    true)
                        //{
                        //    HidePanels(tabkhthanthiet);
                        //    pnkhachhangtt.Visible = true;
                        //}
                        HidePanels(tabthongketimkiem);
                        pnthongke.Visible = true;
                    }
                    break;

                case 6:
                    {
                        HidePanels(tabcauhinh);
                        btn_ncc.Visible = true;
                    }
                    break;
            }
        }
        #endregion

        #region special function
        //ẩn hết panel trong 1 panel
        private void HidePanels(Panel pn)
        {
            foreach (Control c in pn.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }
        }

        #endregion

        public string madnvangnhap { get; set; }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void button6_Click_1(object sender, EventArgs e)
        {
            HidePanels(tabthongketimkiem);
            tkv.Visible = true;
            tkv.tabControl5.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HidePanels(tabthongketimkiem);
            tkv.Visible = true;
            tkv.tabControl5.SelectedIndex = 1;
        }



        private void btn_taikhoannv_Click(object sender, EventArgs e)
        {
            HidePanels(tabcauhinh);
            nv.Visible = true;
        }

        private void btn_nhacc_Click(object sender, EventArgs e)
        {
            HidePanels(tabcauhinh);
            nccv.Visible = true;
            nccv.tabControl2.SelectedIndex = 0;
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            HidePanels(tabcauhinh);
            spv.Visible = true;
            spv.tabControl5.SelectedIndex = 0;
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            HidePanels(tabkhthanthiet);
            khv.Visible = true;
            khv.tabControl5.SelectedIndex = 0;
        }

        private void btn_dskh_Click(object sender, EventArgs e)
        {
            HidePanels(tabkhthanthiet);
            khv.Visible = true;
            khv.tabControl5.SelectedIndex = 1;
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlinhapkho);
            dspn.Visible = true;
            dspn.tabControl4.SelectedIndex = 0;
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlinhapkho);
            dhv.Visible = true;
        }

        private void taodonnhapkho_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlinhapkho);
            dspn.Visible = true;
            dspn.tabControl4.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlinhapkho);
            dhv.Visible = true;
        }

        private void qlnhapkho_Paint(object sender, PaintEventArgs e)
        {

        }
 



        }

       
    }
