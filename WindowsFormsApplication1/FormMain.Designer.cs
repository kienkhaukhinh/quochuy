namespace WindowsFormsApplication1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pndangnhap = new System.Windows.Forms.Panel();
            this.pndangnhapuser = new System.Windows.Forms.Panel();
            this.tabform = new MetroFramework.Controls.MetroTabControl();
            this.tabtrangchinh = new MetroFramework.Controls.MetroTabPage();
            this.trchinh = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout = new MetroFramework.Controls.MetroButton();
            this.idnvlbl = new System.Windows.Forms.Label();
            this.chaolbl = new System.Windows.Forms.Label();
            this.trchinhlbl = new System.Windows.Forms.Label();
            this.tabbanhang = new MetroFramework.Controls.MetroTabPage();
            this.tabkhthanthiet = new MetroFramework.Controls.MetroTabPage();
            this.pnkhachhangtt = new System.Windows.Forms.Panel();
            this.btn_themkh = new System.Windows.Forms.Button();
            this.btn_dskh = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tabquanlinhapkho = new MetroFramework.Controls.MetroTabPage();
            this.qlnhapkho = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.taodonnhapkho = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabthongketimkiem = new MetroFramework.Controls.MetroTabPage();
            this.pnthongke = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tknxtk = new System.Windows.Forms.Button();
            this.btn_tkdt = new System.Windows.Forms.Button();
            this.tabcauhinh = new MetroFramework.Controls.MetroTabPage();
            this.btn_ncc = new System.Windows.Forms.Panel();
            this.btn_nhacc = new System.Windows.Forms.Button();
            this.btn_sp = new System.Windows.Forms.Button();
            this.btn_taikhoannv = new System.Windows.Forms.Button();
            this.tabquanlixuatkho = new MetroFramework.Controls.MetroTabPage();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pndangnhap.SuspendLayout();
            this.tabform.SuspendLayout();
            this.tabtrangchinh.SuspendLayout();
            this.trchinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabkhthanthiet.SuspendLayout();
            this.pnkhachhangtt.SuspendLayout();
            this.tabquanlinhapkho.SuspendLayout();
            this.qlnhapkho.SuspendLayout();
            this.tabthongketimkiem.SuspendLayout();
            this.pnthongke.SuspendLayout();
            this.tabcauhinh.SuspendLayout();
            this.btn_ncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pndangnhap
            // 
            this.pndangnhap.Controls.Add(this.pndangnhapuser);
            this.pndangnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndangnhap.Location = new System.Drawing.Point(20, 60);
            this.pndangnhap.Name = "pndangnhap";
            this.pndangnhap.Size = new System.Drawing.Size(960, 620);
            this.pndangnhap.TabIndex = 9;
            // 
            // pndangnhapuser
            // 
            this.pndangnhapuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndangnhapuser.Location = new System.Drawing.Point(0, 0);
            this.pndangnhapuser.Name = "pndangnhapuser";
            this.pndangnhapuser.Size = new System.Drawing.Size(960, 620);
            this.pndangnhapuser.TabIndex = 9;
            // 
            // tabform
            // 
            this.tabform.Controls.Add(this.tabtrangchinh);
            this.tabform.Controls.Add(this.tabkhthanthiet);
            this.tabform.Controls.Add(this.tabquanlinhapkho);
            this.tabform.Controls.Add(this.tabthongketimkiem);
            this.tabform.Controls.Add(this.tabcauhinh);
            this.tabform.Controls.Add(this.tabbanhang);
            this.tabform.Controls.Add(this.tabquanlixuatkho);
            this.tabform.Location = new System.Drawing.Point(20, 60);
            this.tabform.Name = "tabform";
            this.tabform.SelectedIndex = 0;
            this.tabform.Size = new System.Drawing.Size(960, 620);
            this.tabform.TabIndex = 1;
            // 
            // tabtrangchinh
            // 
            this.tabtrangchinh.BackColor = System.Drawing.Color.Transparent;
            this.tabtrangchinh.Controls.Add(this.trchinh);
            this.tabtrangchinh.HorizontalScrollbarBarColor = true;
            this.tabtrangchinh.Location = new System.Drawing.Point(4, 35);
            this.tabtrangchinh.Name = "tabtrangchinh";
            this.tabtrangchinh.Size = new System.Drawing.Size(952, 581);
            this.tabtrangchinh.TabIndex = 0;
            this.tabtrangchinh.Text = "Trang chính";
            this.tabtrangchinh.VerticalScrollbarBarColor = true;
            // 
            // trchinh
            // 
            this.trchinh.BackColor = System.Drawing.Color.Transparent;
            this.trchinh.Controls.Add(this.pictureBox2);
            this.trchinh.Controls.Add(this.logout);
            this.trchinh.Controls.Add(this.idnvlbl);
            this.trchinh.Controls.Add(this.chaolbl);
            this.trchinh.Controls.Add(this.trchinhlbl);
            this.trchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trchinh.Location = new System.Drawing.Point(0, 0);
            this.trchinh.Name = "trchinh";
            this.trchinh.Size = new System.Drawing.Size(952, 581);
            this.trchinh.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(212, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(553, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(690, 386);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 22);
            this.logout.TabIndex = 31;
            this.logout.Text = "Đăng xuất";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // idnvlbl
            // 
            this.idnvlbl.AutoSize = true;
            this.idnvlbl.Location = new System.Drawing.Point(212, 383);
            this.idnvlbl.Name = "idnvlbl";
            this.idnvlbl.Size = new System.Drawing.Size(41, 13);
            this.idnvlbl.TabIndex = 6;
            this.idnvlbl.Text = "label25";
            // 
            // chaolbl
            // 
            this.chaolbl.AutoSize = true;
            this.chaolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaolbl.Location = new System.Drawing.Point(209, 71);
            this.chaolbl.Name = "chaolbl";
            this.chaolbl.Size = new System.Drawing.Size(454, 31);
            this.chaolbl.TabIndex = 1;
            this.chaolbl.Text = "Chào mừng bạn đến với TOYZONE!!";
            // 
            // trchinhlbl
            // 
            this.trchinhlbl.AutoSize = true;
            this.trchinhlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trchinhlbl.Location = new System.Drawing.Point(19, 11);
            this.trchinhlbl.Name = "trchinhlbl";
            this.trchinhlbl.Size = new System.Drawing.Size(487, 33);
            this.trchinhlbl.TabIndex = 0;
            this.trchinhlbl.Text = "Phần mềm quản lí cửa hàng đồ chơi ";
            // 
            // tabbanhang
            // 
            this.tabbanhang.HorizontalScrollbarBarColor = true;
            this.tabbanhang.Location = new System.Drawing.Point(4, 35);
            this.tabbanhang.Name = "tabbanhang";
            this.tabbanhang.Size = new System.Drawing.Size(952, 581);
            this.tabbanhang.TabIndex = 6;
            this.tabbanhang.Text = "Bán hàng";
            this.tabbanhang.VerticalScrollbarBarColor = true;
            // 
            // tabkhthanthiet
            // 
            this.tabkhthanthiet.Controls.Add(this.pnkhachhangtt);
            this.tabkhthanthiet.HorizontalScrollbarBarColor = true;
            this.tabkhthanthiet.Location = new System.Drawing.Point(4, 35);
            this.tabkhthanthiet.Name = "tabkhthanthiet";
            this.tabkhthanthiet.Size = new System.Drawing.Size(952, 581);
            this.tabkhthanthiet.TabIndex = 5;
            this.tabkhthanthiet.Text = "Quản lý khách hàng thân thiết";
            this.tabkhthanthiet.VerticalScrollbarBarColor = true;
            // 
            // pnkhachhangtt
            // 
            this.pnkhachhangtt.BackColor = System.Drawing.Color.Transparent;
            this.pnkhachhangtt.Controls.Add(this.btn_themkh);
            this.pnkhachhangtt.Controls.Add(this.btn_dskh);
            this.pnkhachhangtt.Controls.Add(this.label20);
            this.pnkhachhangtt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnkhachhangtt.Location = new System.Drawing.Point(0, 0);
            this.pnkhachhangtt.Name = "pnkhachhangtt";
            this.pnkhachhangtt.Size = new System.Drawing.Size(952, 581);
            this.pnkhachhangtt.TabIndex = 7;
            // 
            // btn_themkh
            // 
            this.btn_themkh.BackColor = System.Drawing.Color.Gray;
            this.btn_themkh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_themkh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_themkh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_themkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themkh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_themkh.Image = ((System.Drawing.Image)(resources.GetObject("btn_themkh.Image")));
            this.btn_themkh.Location = new System.Drawing.Point(136, 105);
            this.btn_themkh.Name = "btn_themkh";
            this.btn_themkh.Size = new System.Drawing.Size(313, 233);
            this.btn_themkh.TabIndex = 6;
            this.btn_themkh.Text = "Thêm khách hàng thân thiết";
            this.btn_themkh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_themkh.UseVisualStyleBackColor = false;
            this.btn_themkh.Click += new System.EventHandler(this.btn_themkh_Click);
            // 
            // btn_dskh
            // 
            this.btn_dskh.BackColor = System.Drawing.Color.Gray;
            this.btn_dskh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dskh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dskh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dskh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dskh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dskh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dskh.Image = ((System.Drawing.Image)(resources.GetObject("btn_dskh.Image")));
            this.btn_dskh.Location = new System.Drawing.Point(486, 105);
            this.btn_dskh.Name = "btn_dskh";
            this.btn_dskh.Size = new System.Drawing.Size(313, 233);
            this.btn_dskh.TabIndex = 5;
            this.btn_dskh.Text = "Danh sách khách hàng thân thiết";
            this.btn_dskh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dskh.UseVisualStyleBackColor = false;
            this.btn_dskh.Click += new System.EventHandler(this.btn_dskh_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(401, 33);
            this.label20.TabIndex = 1;
            this.label20.Text = "Quản lý khách hàng thân thiết";
            // 
            // tabquanlinhapkho
            // 
            this.tabquanlinhapkho.Controls.Add(this.qlnhapkho);
            this.tabquanlinhapkho.HorizontalScrollbarBarColor = true;
            this.tabquanlinhapkho.Location = new System.Drawing.Point(4, 35);
            this.tabquanlinhapkho.Name = "tabquanlinhapkho";
            this.tabquanlinhapkho.Size = new System.Drawing.Size(952, 581);
            this.tabquanlinhapkho.TabIndex = 1;
            this.tabquanlinhapkho.Text = "Quản lý nhập kho";
            this.tabquanlinhapkho.VerticalScrollbarBarColor = true;
            // 
            // qlnhapkho
            // 
            this.qlnhapkho.BackColor = System.Drawing.Color.Transparent;
            this.qlnhapkho.Controls.Add(this.button7);
            this.qlnhapkho.Controls.Add(this.taodonnhapkho);
            this.qlnhapkho.Controls.Add(this.label5);
            this.qlnhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlnhapkho.Location = new System.Drawing.Point(0, 0);
            this.qlnhapkho.Name = "qlnhapkho";
            this.qlnhapkho.Size = new System.Drawing.Size(952, 581);
            this.qlnhapkho.TabIndex = 5;
            this.qlnhapkho.Paint += new System.Windows.Forms.PaintEventHandler(this.qlnhapkho_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(488, 110);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(359, 212);
            this.button7.TabIndex = 5;
            this.button7.Text = "Đặt hàng";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_dathang_Click);
            // 
            // taodonnhapkho
            // 
            this.taodonnhapkho.BackColor = System.Drawing.Color.Gray;
            this.taodonnhapkho.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.taodonnhapkho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.taodonnhapkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taodonnhapkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taodonnhapkho.ForeColor = System.Drawing.Color.White;
            this.taodonnhapkho.Image = ((System.Drawing.Image)(resources.GetObject("taodonnhapkho.Image")));
            this.taodonnhapkho.Location = new System.Drawing.Point(87, 110);
            this.taodonnhapkho.Name = "taodonnhapkho";
            this.taodonnhapkho.Size = new System.Drawing.Size(359, 212);
            this.taodonnhapkho.TabIndex = 2;
            this.taodonnhapkho.Text = "Nhập hàng";
            this.taodonnhapkho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taodonnhapkho.UseVisualStyleBackColor = false;
            this.taodonnhapkho.Click += new System.EventHandler(this.btn_nhaphang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quản lí nhập kho";
            // 
            // tabthongketimkiem
            // 
            this.tabthongketimkiem.Controls.Add(this.pnthongke);
            this.tabthongketimkiem.HorizontalScrollbarBarColor = true;
            this.tabthongketimkiem.Location = new System.Drawing.Point(4, 35);
            this.tabthongketimkiem.Name = "tabthongketimkiem";
            this.tabthongketimkiem.Size = new System.Drawing.Size(952, 581);
            this.tabthongketimkiem.TabIndex = 3;
            this.tabthongketimkiem.Text = "Thống kê";
            this.tabthongketimkiem.VerticalScrollbarBarColor = true;
            // 
            // pnthongke
            // 
            this.pnthongke.BackColor = System.Drawing.Color.Transparent;
            this.pnthongke.Controls.Add(this.label1);
            this.pnthongke.Controls.Add(this.btn_tknxtk);
            this.pnthongke.Controls.Add(this.btn_tkdt);
            this.pnthongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnthongke.Location = new System.Drawing.Point(0, 0);
            this.pnthongke.Name = "pnthongke";
            this.pnthongke.Size = new System.Drawing.Size(952, 581);
            this.pnthongke.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thống kê";
            // 
            // btn_tknxtk
            // 
            this.btn_tknxtk.BackColor = System.Drawing.Color.Gray;
            this.btn_tknxtk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tknxtk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_tknxtk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tknxtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tknxtk.ForeColor = System.Drawing.Color.White;
            this.btn_tknxtk.Image = ((System.Drawing.Image)(resources.GetObject("btn_tknxtk.Image")));
            this.btn_tknxtk.Location = new System.Drawing.Point(498, 134);
            this.btn_tknxtk.Name = "btn_tknxtk";
            this.btn_tknxtk.Size = new System.Drawing.Size(359, 212);
            this.btn_tknxtk.TabIndex = 7;
            this.btn_tknxtk.Text = "Thống kê tồn kho";
            this.btn_tknxtk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tknxtk.UseVisualStyleBackColor = false;
            this.btn_tknxtk.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_tkdt
            // 
            this.btn_tkdt.BackColor = System.Drawing.Color.Gray;
            this.btn_tkdt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tkdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_tkdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tkdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tkdt.ForeColor = System.Drawing.Color.White;
            this.btn_tkdt.Image = ((System.Drawing.Image)(resources.GetObject("btn_tkdt.Image")));
            this.btn_tkdt.Location = new System.Drawing.Point(98, 134);
            this.btn_tkdt.Name = "btn_tkdt";
            this.btn_tkdt.Size = new System.Drawing.Size(359, 212);
            this.btn_tkdt.TabIndex = 6;
            this.btn_tkdt.Text = "Thống kê doanh thu";
            this.btn_tkdt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tkdt.UseVisualStyleBackColor = false;
            this.btn_tkdt.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tabcauhinh
            // 
            this.tabcauhinh.Controls.Add(this.btn_ncc);
            this.tabcauhinh.HorizontalScrollbarBarColor = true;
            this.tabcauhinh.Location = new System.Drawing.Point(4, 35);
            this.tabcauhinh.Name = "tabcauhinh";
            this.tabcauhinh.Size = new System.Drawing.Size(952, 581);
            this.tabcauhinh.TabIndex = 7;
            this.tabcauhinh.Text = "Cấu hình";
            this.tabcauhinh.VerticalScrollbarBarColor = true;
            // 
            // btn_ncc
            // 
            this.btn_ncc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ncc.Controls.Add(this.btn_nhacc);
            this.btn_ncc.Controls.Add(this.btn_sp);
            this.btn_ncc.Controls.Add(this.btn_taikhoannv);
            this.btn_ncc.Location = new System.Drawing.Point(4, 3);
            this.btn_ncc.Name = "btn_ncc";
            this.btn_ncc.Size = new System.Drawing.Size(945, 551);
            this.btn_ncc.TabIndex = 8;
            // 
            // btn_nhacc
            // 
            this.btn_nhacc.BackColor = System.Drawing.Color.Gray;
            this.btn_nhacc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_nhacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_nhacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhacc.ForeColor = System.Drawing.Color.White;
            this.btn_nhacc.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhacc.Image")));
            this.btn_nhacc.Location = new System.Drawing.Point(536, 24);
            this.btn_nhacc.Name = "btn_nhacc";
            this.btn_nhacc.Size = new System.Drawing.Size(318, 212);
            this.btn_nhacc.TabIndex = 5;
            this.btn_nhacc.Text = "Nhà cung cấp";
            this.btn_nhacc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nhacc.UseVisualStyleBackColor = false;
            this.btn_nhacc.Click += new System.EventHandler(this.btn_nhacc_Click);
            // 
            // btn_sp
            // 
            this.btn_sp.BackColor = System.Drawing.Color.Gray;
            this.btn_sp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sp.ForeColor = System.Drawing.Color.White;
            this.btn_sp.Image = ((System.Drawing.Image)(resources.GetObject("btn_sp.Image")));
            this.btn_sp.Location = new System.Drawing.Point(313, 253);
            this.btn_sp.Name = "btn_sp";
            this.btn_sp.Size = new System.Drawing.Size(318, 212);
            this.btn_sp.TabIndex = 6;
            this.btn_sp.Text = "Sản phẩm";
            this.btn_sp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sp.UseVisualStyleBackColor = false;
            this.btn_sp.Click += new System.EventHandler(this.btn_sp_Click);
            // 
            // btn_taikhoannv
            // 
            this.btn_taikhoannv.BackColor = System.Drawing.Color.Gray;
            this.btn_taikhoannv.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_taikhoannv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_taikhoannv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_taikhoannv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taikhoannv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taikhoannv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_taikhoannv.Image = ((System.Drawing.Image)(resources.GetObject("btn_taikhoannv.Image")));
            this.btn_taikhoannv.Location = new System.Drawing.Point(152, 24);
            this.btn_taikhoannv.Name = "btn_taikhoannv";
            this.btn_taikhoannv.Size = new System.Drawing.Size(318, 212);
            this.btn_taikhoannv.TabIndex = 7;
            this.btn_taikhoannv.Text = "Tài Khỏan nhân viên";
            this.btn_taikhoannv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_taikhoannv.UseVisualStyleBackColor = false;
            this.btn_taikhoannv.Click += new System.EventHandler(this.btn_taikhoannv_Click);
            // 
            // tabquanlixuatkho
            // 
            this.tabquanlixuatkho.HorizontalScrollbarBarColor = true;
            this.tabquanlixuatkho.Location = new System.Drawing.Point(4, 35);
            this.tabquanlixuatkho.Name = "tabquanlixuatkho";
            this.tabquanlixuatkho.Size = new System.Drawing.Size(952, 581);
            this.tabquanlixuatkho.TabIndex = 2;
            this.tabquanlixuatkho.Text = "Quản lý xuất kho";
            this.tabquanlixuatkho.VerticalScrollbarBarColor = true;
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(27, 19);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(37, 35);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 13;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tabform);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pndangnhap);
            this.Name = "FormMain";
            this.Text = "       Quản lí cửa hàng đồ chơi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pndangnhap.ResumeLayout(false);
            this.tabform.ResumeLayout(false);
            this.tabtrangchinh.ResumeLayout(false);
            this.trchinh.ResumeLayout(false);
            this.trchinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabkhthanthiet.ResumeLayout(false);
            this.pnkhachhangtt.ResumeLayout(false);
            this.pnkhachhangtt.PerformLayout();
            this.tabquanlinhapkho.ResumeLayout(false);
            this.qlnhapkho.ResumeLayout(false);
            this.qlnhapkho.PerformLayout();
            this.tabthongketimkiem.ResumeLayout(false);
            this.pnthongke.ResumeLayout(false);
            this.pnthongke.PerformLayout();
            this.tabcauhinh.ResumeLayout(false);
            this.btn_ncc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pndangnhap;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel pndangnhapuser;
        private MetroFramework.Controls.MetroTabControl tabform;
        private MetroFramework.Controls.MetroTabPage tabtrangchinh;
        private System.Windows.Forms.Panel trchinh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton logout;
        private System.Windows.Forms.Label chaolbl;
        private System.Windows.Forms.Label trchinhlbl;
        private MetroFramework.Controls.MetroTabPage tabbanhang;
        private MetroFramework.Controls.MetroTabPage tabkhthanthiet;
        private System.Windows.Forms.Panel pnkhachhangtt;
        private System.Windows.Forms.Button btn_themkh;
        private System.Windows.Forms.Button btn_dskh;
        private System.Windows.Forms.Label label20;
        private MetroFramework.Controls.MetroTabPage tabquanlinhapkho;
        private MetroFramework.Controls.MetroTabPage tabquanlixuatkho;
        private MetroFramework.Controls.MetroTabPage tabthongketimkiem;
        private System.Windows.Forms.Panel pnthongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tknxtk;
        private System.Windows.Forms.Button btn_tkdt;
        private MetroFramework.Controls.MetroTabPage tabcauhinh;
        private System.Windows.Forms.Panel btn_ncc;
        private System.Windows.Forms.Button btn_nhacc;
        private System.Windows.Forms.Button btn_sp;
        private System.Windows.Forms.Button btn_taikhoannv;
        private System.Windows.Forms.Panel qlnhapkho;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button taodonnhapkho;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label idnvlbl;
    }
}

