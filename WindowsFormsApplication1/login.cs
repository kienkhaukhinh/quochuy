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
    public partial class Login : MetroForm
    {
        public string tendangnhap
        {
            get { return txtID.Text; }

        }

        public string matkhau
        {
            get { return txtPass.Text; }
        }
     


        public Login()
        {
            InitializeComponent();
        }
        public EventHandler dangnhap;
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
            NGUOIDUNGBUS bus = new NGUOIDUNGBUS();
            short phquyen = bus.dangnhap(tendangnhap,matkhau);
            if (bus.dangnhap(tendangnhap, matkhau)!=-1)
            {
                FormMain f1 = new FormMain(tendangnhap, phquyen);
                
                f1.ShowDialog(); // Shows Form1               
            }
            else
            {
                MessageBox.Show("Sai ID hoặc mật khẩu");
            }
        }
    }
}
