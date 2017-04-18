namespace WindowsFormsApplication1.View
{
    partial class nhacungcapview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.btn_luu = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_them = new MetroFramework.Controls.MetroButton();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_dchi = new System.Windows.Forms.TextBox();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.tabPage9 = new MetroFramework.Controls.MetroTabPage();
            this.btn_laydulieu = new System.Windows.Forms.Panel();
            this.btn_capnhat = new MetroFramework.Controls.MetroButton();
            this.btn_laydulieu_ncc = new MetroFramework.Controls.MetroButton();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.txt_tenncc_ds = new System.Windows.Forms.TextBox();
            this.txt_diachi_ds = new System.Windows.Forms.TextBox();
            this.txt_dienthoai_ds = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.nhacungcapdgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email_ds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error_ncc = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.btn_luu.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.btn_laydulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ncc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 1;
            this.tabControl2.Size = new System.Drawing.Size(993, 700);
            this.tabControl2.TabIndex = 13;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Transparent;
            this.tabPage8.Controls.Add(this.btn_luu);
            this.tabPage8.HorizontalScrollbarBarColor = true;
            this.tabPage8.Location = new System.Drawing.Point(4, 35);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(985, 661);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Thêm nhà cung cấp";
            this.tabPage8.VerticalScrollbarBarColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Controls.Add(this.label3);
            this.btn_luu.Controls.Add(this.label1);
            this.btn_luu.Controls.Add(this.txt_email);
            this.btn_luu.Controls.Add(this.label30);
            this.btn_luu.Controls.Add(this.label33);
            this.btn_luu.Controls.Add(this.label23);
            this.btn_luu.Controls.Add(this.btn_them);
            this.btn_luu.Controls.Add(this.txt_ten);
            this.btn_luu.Controls.Add(this.txt_dchi);
            this.btn_luu.Controls.Add(this.txt_dienthoai);
            this.btn_luu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_luu.Location = new System.Drawing.Point(0, 0);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(985, 661);
            this.btn_luu.TabIndex = 23;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(82, 192);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(40, 13);
            this.label30.TabIndex = 7;
            this.label30.Text = "Địa chỉ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(82, 138);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "Tên nhà cung cấp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(82, 241);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Điện thoại";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(88, 333);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(89, 23);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Lưu";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(202, 135);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(166, 20);
            this.txt_ten.TabIndex = 1;
            // 
            // txt_dchi
            // 
            this.txt_dchi.Location = new System.Drawing.Point(202, 189);
            this.txt_dchi.Name = "txt_dchi";
            this.txt_dchi.Size = new System.Drawing.Size(166, 20);
            this.txt_dchi.TabIndex = 2;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(202, 241);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(166, 20);
            this.txt_dienthoai.TabIndex = 3;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Transparent;
            this.tabPage9.Controls.Add(this.btn_laydulieu);
            this.tabPage9.HorizontalScrollbarBarColor = true;
            this.tabPage9.Location = new System.Drawing.Point(4, 35);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(985, 661);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Danh sách nhà cung cấp";
            this.tabPage9.VerticalScrollbarBarColor = true;
            // 
            // btn_laydulieu
            // 
            this.btn_laydulieu.Controls.Add(this.label4);
            this.btn_laydulieu.Controls.Add(this.label2);
            this.btn_laydulieu.Controls.Add(this.txt_email_ds);
            this.btn_laydulieu.Controls.Add(this.btn_capnhat);
            this.btn_laydulieu.Controls.Add(this.btn_laydulieu_ncc);
            this.btn_laydulieu.Controls.Add(this.label36);
            this.btn_laydulieu.Controls.Add(this.label35);
            this.btn_laydulieu.Controls.Add(this.label37);
            this.btn_laydulieu.Controls.Add(this.label38);
            this.btn_laydulieu.Controls.Add(this.txt_mancc);
            this.btn_laydulieu.Controls.Add(this.txt_tenncc_ds);
            this.btn_laydulieu.Controls.Add(this.txt_diachi_ds);
            this.btn_laydulieu.Controls.Add(this.txt_dienthoai_ds);
            this.btn_laydulieu.Controls.Add(this.txt_search);
            this.btn_laydulieu.Controls.Add(this.nhacungcapdgv);
            this.btn_laydulieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_laydulieu.Location = new System.Drawing.Point(0, 0);
            this.btn_laydulieu.Name = "btn_laydulieu";
            this.btn_laydulieu.Size = new System.Drawing.Size(985, 661);
            this.btn_laydulieu.TabIndex = 23;
      
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(547, 364);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat.TabIndex = 21;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_laydulieu_ncc
            // 
            this.btn_laydulieu_ncc.Location = new System.Drawing.Point(399, 89);
            this.btn_laydulieu_ncc.Name = "btn_laydulieu_ncc";
            this.btn_laydulieu_ncc.Size = new System.Drawing.Size(109, 23);
            this.btn_laydulieu_ncc.TabIndex = 20;
            this.btn_laydulieu_ncc.Text = "Lấy dữ liệu";
            this.btn_laydulieu_ncc.Click += new System.EventHandler(this.btn_laydulieu_ncc_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(548, 230);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(40, 13);
            this.label36.TabIndex = 16;
            this.label36.Text = "Địa chỉ";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(548, 282);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(55, 13);
            this.label35.TabIndex = 17;
            this.label35.Text = "Điện thoại";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(544, 173);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(95, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "Tên nhà cung cấp";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(548, 134);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(91, 13);
            this.label38.TabIndex = 14;
            this.label38.Text = "Mã nhà cung cấp";
            // 
            // txt_mancc
            // 
            this.txt_mancc.Enabled = false;
            this.txt_mancc.Location = new System.Drawing.Point(648, 127);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(298, 20);
            this.txt_mancc.TabIndex = 9;
            // 
            // txt_tenncc_ds
            // 
            this.txt_tenncc_ds.Location = new System.Drawing.Point(648, 173);
            this.txt_tenncc_ds.Name = "txt_tenncc_ds";
            this.txt_tenncc_ds.Size = new System.Drawing.Size(298, 20);
            this.txt_tenncc_ds.TabIndex = 11;
            // 
            // txt_diachi_ds
            // 
            this.txt_diachi_ds.Location = new System.Drawing.Point(648, 227);
            this.txt_diachi_ds.Name = "txt_diachi_ds";
            this.txt_diachi_ds.Size = new System.Drawing.Size(298, 20);
            this.txt_diachi_ds.TabIndex = 10;
            // 
            // txt_dienthoai_ds
            // 
            this.txt_dienthoai_ds.Location = new System.Drawing.Point(648, 278);
            this.txt_dienthoai_ds.Name = "txt_dienthoai_ds";
            this.txt_dienthoai_ds.Size = new System.Drawing.Size(298, 20);
            this.txt_dienthoai_ds.TabIndex = 12;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(19, 92);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(374, 20);
            this.txt_search.TabIndex = 2;
            // 
            // nhacungcapdgv
            // 
            this.nhacungcapdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhacungcapdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhacungcapdgv.Location = new System.Drawing.Point(19, 127);
            this.nhacungcapdgv.MultiSelect = false;
            this.nhacungcapdgv.Name = "nhacungcapdgv";
            this.nhacungcapdgv.ReadOnly = true;
            this.nhacungcapdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhacungcapdgv.Size = new System.Drawing.Size(489, 515);
            this.nhacungcapdgv.TabIndex = 0;
            this.nhacungcapdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhacungcapdgv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(202, 288);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(166, 20);
            this.txt_email.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email";
            // 
            // txt_email_ds
            // 
            this.txt_email_ds.Location = new System.Drawing.Point(648, 316);
            this.txt_email_ds.Name = "txt_email_ds";
            this.txt_email_ds.Size = new System.Drawing.Size(298, 20);
            this.txt_email_ds.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 37);
            this.label3.TabIndex = 42;
            this.label3.Text = "Thêm Nhà Cung Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 37);
            this.label4.TabIndex = 43;
            this.label4.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // error_ncc
            // 
            this.error_ncc.ContainerControl = this;
            // 
            // nhacungcapview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl2);
            this.Name = "nhacungcapview";
            this.Size = new System.Drawing.Size(993, 700);
            this.tabControl2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.btn_luu.ResumeLayout(false);
            this.btn_luu.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.btn_laydulieu.ResumeLayout(false);
            this.btn_laydulieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ncc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTabControl tabControl2;
        private MetroFramework.Controls.MetroTabPage tabPage8;
        private System.Windows.Forms.Panel btn_luu;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label23;
        private MetroFramework.Controls.MetroButton btn_them;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_dchi;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private MetroFramework.Controls.MetroTabPage tabPage9;
        private System.Windows.Forms.Panel btn_laydulieu;
        private MetroFramework.Controls.MetroButton btn_capnhat;
        private MetroFramework.Controls.MetroButton btn_laydulieu_ncc;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.TextBox txt_tenncc_ds;
        private System.Windows.Forms.TextBox txt_diachi_ds;
        private System.Windows.Forms.TextBox txt_dienthoai_ds;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView nhacungcapdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email_ds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider error_ncc;
    }
}
