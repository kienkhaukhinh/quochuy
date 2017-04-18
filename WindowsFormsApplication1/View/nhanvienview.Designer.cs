namespace WindowsFormsApplication1.View
{
    partial class nhanvienview
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
            this.tabControl5 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage16 = new MetroFramework.Controls.MetroTabPage();
            this.pnnhanvienthem = new System.Windows.Forms.Panel();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsavenhanvien = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.lbphanquyen = new System.Windows.Forms.Label();
            this.lbtennhanvien = new System.Windows.Forms.Label();
            this.lbrematkhau = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.tabPage17 = new MetroFramework.Controls.MetroTabPage();
            this.pndanhsachnv = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetdata = new MetroFramework.Controls.MetroButton();
            this.txtsuasdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapnhap = new MetroFramework.Controls.MetroButton();
            this.cbphanquyen = new System.Windows.Forms.ComboBox();
            this.suatxtten = new System.Windows.Forms.TextBox();
            this.labeltennv = new System.Windows.Forms.Label();
            this.labelphanquyen = new System.Windows.Forms.Label();
            this.lbsuathongtin = new System.Windows.Forms.Label();
            this.labelmatkhau = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtsuaidnhanvien = new System.Windows.Forms.TextBox();
            this.suatxtmatkhau = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.nhanviendgv = new System.Windows.Forms.DataGridView();
            this.tabControl5.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.pnnhanvienthem.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.pndanhsachnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanviendgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage16);
            this.tabControl5.Controls.Add(this.tabPage17);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(869, 513);
            this.tabControl5.TabIndex = 14;
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.Transparent;
            this.tabPage16.Controls.Add(this.pnnhanvienthem);
            this.tabPage16.HorizontalScrollbarBarColor = true;
            this.tabPage16.Location = new System.Drawing.Point(4, 35);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(861, 474);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Thêm nhân viên";
            this.tabPage16.VerticalScrollbarBarColor = true;
            // 
            // pnnhanvienthem
            // 
            this.pnnhanvienthem.Controls.Add(this.txtsdt);
            this.pnnhanvienthem.Controls.Add(this.lbsdt);
            this.pnnhanvienthem.Controls.Add(this.txtID);
            this.pnnhanvienthem.Controls.Add(this.label2);
            this.pnnhanvienthem.Controls.Add(this.btnsavenhanvien);
            this.pnnhanvienthem.Controls.Add(this.comboBox1);
            this.pnnhanvienthem.Controls.Add(this.txttennhanvien);
            this.pnnhanvienthem.Controls.Add(this.lbphanquyen);
            this.pnnhanvienthem.Controls.Add(this.lbtennhanvien);
            this.pnnhanvienthem.Controls.Add(this.lbrematkhau);
            this.pnnhanvienthem.Controls.Add(this.lbmatkhau);
            this.pnnhanvienthem.Controls.Add(this.txtpass);
            this.pnnhanvienthem.Controls.Add(this.txtrepass);
            this.pnnhanvienthem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnnhanvienthem.Location = new System.Drawing.Point(0, 0);
            this.pnnhanvienthem.Name = "pnnhanvienthem";
            this.pnnhanvienthem.Size = new System.Drawing.Size(861, 474);
            this.pnnhanvienthem.TabIndex = 15;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(202, 128);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(166, 20);
            this.txtsdt.TabIndex = 19;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(89, 128);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(70, 13);
            this.lbsdt.TabIndex = 18;
            this.lbsdt.Text = "Số điện thoại";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(202, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(166, 20);
            this.txtID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // btnsavenhanvien
            // 
            this.btnsavenhanvien.Location = new System.Drawing.Point(89, 347);
            this.btnsavenhanvien.Name = "btnsavenhanvien";
            this.btnsavenhanvien.Size = new System.Drawing.Size(125, 23);
            this.btnsavenhanvien.TabIndex = 15;
            this.btnsavenhanvien.Text = "Lưu";
            this.btnsavenhanvien.Click += new System.EventHandler(this.btnsavenhanvien_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Quản lý",
            "Nhân Viên",
            "Thủ kho"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên",
            "Thủ kho"});
            this.comboBox1.Location = new System.Drawing.Point(202, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(202, 93);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(166, 20);
            this.txttennhanvien.TabIndex = 4;
            // 
            // lbphanquyen
            // 
            this.lbphanquyen.AutoSize = true;
            this.lbphanquyen.Location = new System.Drawing.Point(86, 262);
            this.lbphanquyen.Name = "lbphanquyen";
            this.lbphanquyen.Size = new System.Drawing.Size(64, 13);
            this.lbphanquyen.TabIndex = 13;
            this.lbphanquyen.Text = "Phân quyền";
            // 
            // lbtennhanvien
            // 
            this.lbtennhanvien.AutoSize = true;
            this.lbtennhanvien.Location = new System.Drawing.Point(86, 96);
            this.lbtennhanvien.Name = "lbtennhanvien";
            this.lbtennhanvien.Size = new System.Drawing.Size(76, 13);
            this.lbtennhanvien.TabIndex = 9;
            this.lbtennhanvien.Text = "Tên nhân viên";
            // 
            // lbrematkhau
            // 
            this.lbrematkhau.AutoSize = true;
            this.lbrematkhau.Location = new System.Drawing.Point(86, 217);
            this.lbrematkhau.Name = "lbrematkhau";
            this.lbrematkhau.Size = new System.Drawing.Size(93, 13);
            this.lbrematkhau.TabIndex = 7;
            this.lbrematkhau.Text = "Nhập lại mật khẩu";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(86, 169);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(52, 13);
            this.lbmatkhau.TabIndex = 6;
            this.lbmatkhau.Text = "Mật khẩu";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(202, 166);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(166, 20);
            this.txtpass.TabIndex = 1;
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(202, 214);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.PasswordChar = '*';
            this.txtrepass.Size = new System.Drawing.Size(166, 20);
            this.txtrepass.TabIndex = 2;
            // 
            // tabPage17
            // 
            this.tabPage17.BackColor = System.Drawing.Color.Transparent;
            this.tabPage17.Controls.Add(this.pndanhsachnv);
            this.tabPage17.HorizontalScrollbarBarColor = true;
            this.tabPage17.Location = new System.Drawing.Point(4, 35);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(861, 474);
            this.tabPage17.TabIndex = 4;
            this.tabPage17.Text = "Danh sách nhân viên";
            this.tabPage17.VerticalScrollbarBarColor = true;
            // 
            // pndanhsachnv
            // 
            this.pndanhsachnv.Controls.Add(this.dateTimePicker1);
            this.pndanhsachnv.Controls.Add(this.label4);
            this.pndanhsachnv.Controls.Add(this.btnGetdata);
            this.pndanhsachnv.Controls.Add(this.txtsuasdt);
            this.pndanhsachnv.Controls.Add(this.label3);
            this.pndanhsachnv.Controls.Add(this.label1);
            this.pndanhsachnv.Controls.Add(this.btnCapnhap);
            this.pndanhsachnv.Controls.Add(this.cbphanquyen);
            this.pndanhsachnv.Controls.Add(this.suatxtten);
            this.pndanhsachnv.Controls.Add(this.labeltennv);
            this.pndanhsachnv.Controls.Add(this.labelphanquyen);
            this.pndanhsachnv.Controls.Add(this.lbsuathongtin);
            this.pndanhsachnv.Controls.Add(this.labelmatkhau);
            this.pndanhsachnv.Controls.Add(this.labelID);
            this.pndanhsachnv.Controls.Add(this.txtsuaidnhanvien);
            this.pndanhsachnv.Controls.Add(this.suatxtmatkhau);
            this.pndanhsachnv.Controls.Add(this.textBox19);
            this.pndanhsachnv.Controls.Add(this.nhanviendgv);
            this.pndanhsachnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndanhsachnv.Location = new System.Drawing.Point(0, 0);
            this.pndanhsachnv.Name = "pndanhsachnv";
            this.pndanhsachnv.Size = new System.Drawing.Size(861, 474);
            this.pndanhsachnv.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(617, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày sinh";
            // 
            // btnGetdata
            // 
            this.btnGetdata.Location = new System.Drawing.Point(394, 61);
            this.btnGetdata.Name = "btnGetdata";
            this.btnGetdata.Size = new System.Drawing.Size(75, 23);
            this.btnGetdata.TabIndex = 37;
            this.btnGetdata.Text = "Lấy dữ liệu";
            this.btnGetdata.Click += new System.EventHandler(this.btnGetdata_Click);
            // 
            // txtsuasdt
            // 
            this.txtsuasdt.Location = new System.Drawing.Point(617, 187);
            this.txtsuasdt.Name = "txtsuasdt";
            this.txtsuasdt.Size = new System.Drawing.Size(166, 20);
            this.txtsuasdt.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm nhân viên";
            // 
            // btnCapnhap
            // 
            this.btnCapnhap.Location = new System.Drawing.Point(499, 338);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhap.TabIndex = 31;
            this.btnCapnhap.Text = "Cập nhật";
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapnhap_Click);
            // 
            // cbphanquyen
            // 
            this.cbphanquyen.FormattingEnabled = true;
            this.cbphanquyen.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên",
            "Thủ kho"});
            this.cbphanquyen.Location = new System.Drawing.Point(617, 281);
            this.cbphanquyen.Name = "cbphanquyen";
            this.cbphanquyen.Size = new System.Drawing.Size(166, 21);
            this.cbphanquyen.TabIndex = 29;
            // 
            // suatxtten
            // 
            this.suatxtten.Location = new System.Drawing.Point(617, 158);
            this.suatxtten.Name = "suatxtten";
            this.suatxtten.Size = new System.Drawing.Size(166, 20);
            this.suatxtten.TabIndex = 27;
            // 
            // labeltennv
            // 
            this.labeltennv.AutoSize = true;
            this.labeltennv.Location = new System.Drawing.Point(496, 158);
            this.labeltennv.Name = "labeltennv";
            this.labeltennv.Size = new System.Drawing.Size(76, 13);
            this.labeltennv.TabIndex = 26;
            this.labeltennv.Text = "Tên nhân viên";
            // 
            // labelphanquyen
            // 
            this.labelphanquyen.AutoSize = true;
            this.labelphanquyen.Location = new System.Drawing.Point(496, 281);
            this.labelphanquyen.Name = "labelphanquyen";
            this.labelphanquyen.Size = new System.Drawing.Size(64, 13);
            this.labelphanquyen.TabIndex = 20;
            this.labelphanquyen.Text = "Phân quyền";
            // 
            // lbsuathongtin
            // 
            this.lbsuathongtin.AutoSize = true;
            this.lbsuathongtin.Location = new System.Drawing.Point(593, 68);
            this.lbsuathongtin.Name = "lbsuathongtin";
            this.lbsuathongtin.Size = new System.Drawing.Size(120, 13);
            this.lbsuathongtin.TabIndex = 18;
            this.lbsuathongtin.Text = "Sửa thông tin nhân viên";
            // 
            // labelmatkhau
            // 
            this.labelmatkhau.AutoSize = true;
            this.labelmatkhau.Location = new System.Drawing.Point(497, 248);
            this.labelmatkhau.Name = "labelmatkhau";
            this.labelmatkhau.Size = new System.Drawing.Size(52, 13);
            this.labelmatkhau.TabIndex = 15;
            this.labelmatkhau.Text = "Mật khẩu";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(497, 130);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(68, 13);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID nhân viên";
            // 
            // txtsuaidnhanvien
            // 
            this.txtsuaidnhanvien.Enabled = false;
            this.txtsuaidnhanvien.Location = new System.Drawing.Point(617, 128);
            this.txtsuaidnhanvien.Name = "txtsuaidnhanvien";
            this.txtsuaidnhanvien.Size = new System.Drawing.Size(166, 20);
            this.txtsuaidnhanvien.TabIndex = 9;
            // 
            // suatxtmatkhau
            // 
            this.suatxtmatkhau.Location = new System.Drawing.Point(617, 245);
            this.suatxtmatkhau.Name = "suatxtmatkhau";
            this.suatxtmatkhau.Size = new System.Drawing.Size(166, 20);
            this.suatxtmatkhau.TabIndex = 11;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(19, 61);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(364, 20);
            this.textBox19.TabIndex = 2;
            // 
            // nhanviendgv
            // 
            this.nhanviendgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhanviendgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanviendgv.Location = new System.Drawing.Point(19, 98);
            this.nhanviendgv.Name = "nhanviendgv";
            this.nhanviendgv.ReadOnly = true;
            this.nhanviendgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhanviendgv.Size = new System.Drawing.Size(450, 373);
            this.nhanviendgv.TabIndex = 0;
            this.nhanviendgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhanviendgv_CellContentDoubleClick);
            this.nhanviendgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.nhanviendgv_CellMouseUp);
            // 
            // nhanvienview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl5);
            this.Name = "nhanvienview";
            this.Size = new System.Drawing.Size(869, 513);
            this.tabControl5.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.pnnhanvienthem.ResumeLayout(false);
            this.pnnhanvienthem.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.pndanhsachnv.ResumeLayout(false);
            this.pndanhsachnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanviendgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl5;
        private MetroFramework.Controls.MetroTabPage tabPage16;
        private System.Windows.Forms.Panel pnnhanvienthem;
        private MetroFramework.Controls.MetroButton btnsavenhanvien;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Label lbphanquyen;
        private System.Windows.Forms.Label lbtennhanvien;
        private System.Windows.Forms.Label lbrematkhau;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtrepass;
        private MetroFramework.Controls.MetroTabPage tabPage17;
        private System.Windows.Forms.Panel pndanhsachnv;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnCapnhap;
        private System.Windows.Forms.ComboBox cbphanquyen;
        private System.Windows.Forms.TextBox suatxtten;
        private System.Windows.Forms.Label labeltennv;
        private System.Windows.Forms.Label labelphanquyen;
        private System.Windows.Forms.Label lbsuathongtin;
        private System.Windows.Forms.Label labelmatkhau;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtsuaidnhanvien;
        private System.Windows.Forms.TextBox suatxtmatkhau;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.DataGridView nhanviendgv;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox txtsuasdt;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnGetdata;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;

    }
}
