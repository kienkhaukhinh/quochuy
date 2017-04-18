namespace WindowsFormsApplication1.View
{
    partial class banhangview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.voucher = new System.Windows.Forms.CheckBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_tongtien = new System.Windows.Forms.Label();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cbb_sl = new System.Windows.Forms.NumericUpDown();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.btn_themsp = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_tienthua = new System.Windows.Forms.TextBox();
            this.txt_tientra = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnthanhtoan = new MetroFramework.Controls.MetroButton();
            this.btnxoa = new MetroFramework.Controls.MetroButton();
            this.txt_tongtiensaugiam = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cthdgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsspgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtsearchten = new System.Windows.Forms.TextBox();
            this.cbloaisp = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_makhach = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cthdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsspgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voucher
            // 
            this.voucher.AutoSize = true;
            this.voucher.BackColor = System.Drawing.SystemColors.Window;
            this.voucher.Location = new System.Drawing.Point(473, 434);
            this.voucher.Name = "voucher";
            this.voucher.Size = new System.Drawing.Size(95, 17);
            this.voucher.TabIndex = 71;
            this.voucher.Text = "Dùng Voucher";
            this.voucher.UseVisualStyleBackColor = false;
            this.voucher.CheckedChanged += new System.EventHandler(this.voucher_CheckedChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(898, 434);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(36, 19);
            this.metroLabel14.TabIndex = 70;
            this.metroLabel14.Text = "VNĐ";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.AutoSize = true;
            this.txt_tongtien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tongtien.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.ForeColor = System.Drawing.Color.Black;
            this.txt_tongtien.Location = new System.Drawing.Point(770, 430);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(22, 25);
            this.txt_tongtien.TabIndex = 69;
            this.txt_tongtien.Text = "0";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(727, 434);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(42, 19);
            this.metroLabel15.TabIndex = 68;
            this.metroLabel15.Text = "Tổng:";
            // 
            // cbb_sl
            // 
            this.cbb_sl.Location = new System.Drawing.Point(354, 257);
            this.cbb_sl.Name = "cbb_sl";
            this.cbb_sl.Size = new System.Drawing.Size(62, 20);
            this.cbb_sl.TabIndex = 67;
            this.cbb_sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(354, 235);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(25, 19);
            this.metroLabel13.TabIndex = 66;
            this.metroLabel13.Text = "SL:";
            // 
            // btn_themsp
            // 
            this.btn_themsp.Location = new System.Drawing.Point(354, 208);
            this.btn_themsp.Name = "btn_themsp";
            this.btn_themsp.Size = new System.Drawing.Size(62, 23);
            this.btn_themsp.TabIndex = 65;
            this.btn_themsp.Text = "Thêm > ";
            this.btn_themsp.Click += new System.EventHandler(this.btn_themsp_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(898, 477);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(36, 19);
            this.metroLabel10.TabIndex = 64;
            this.metroLabel10.Text = "VNĐ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(898, 505);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(36, 19);
            this.metroLabel9.TabIndex = 63;
            this.metroLabel9.Text = "VNĐ";
            // 
            // txt_tienthua
            // 
            this.txt_tienthua.Enabled = false;
            this.txt_tienthua.Location = new System.Drawing.Point(775, 504);
            this.txt_tienthua.Name = "txt_tienthua";
            this.txt_tienthua.ReadOnly = true;
            this.txt_tienthua.Size = new System.Drawing.Size(127, 20);
            this.txt_tienthua.TabIndex = 53;
            // 
            // txt_tientra
            // 
            this.txt_tientra.Location = new System.Drawing.Point(775, 478);
            this.txt_tientra.Name = "txt_tientra";
            this.txt_tientra.Size = new System.Drawing.Size(127, 20);
            this.txt_tientra.TabIndex = 54;
            this.txt_tientra.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tientra_Validating);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(676, 479);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(93, 19);
            this.metroLabel8.TabIndex = 62;
            this.metroLabel8.Text = "Tiền khách trả:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(676, 504);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 61;
            this.metroLabel7.Text = "Tiền thừa:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(898, 456);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 60;
            this.metroLabel6.Text = "VNĐ";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(432, 459);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(75, 23);
            this.btnthanhtoan.TabIndex = 59;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(516, 459);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 58;
            this.btnxoa.Text = "Xóa tất cả";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txt_tongtiensaugiam
            // 
            this.txt_tongtiensaugiam.AutoSize = true;
            this.txt_tongtiensaugiam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tongtiensaugiam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtiensaugiam.ForeColor = System.Drawing.Color.Red;
            this.txt_tongtiensaugiam.Location = new System.Drawing.Point(770, 450);
            this.txt_tongtiensaugiam.Name = "txt_tongtiensaugiam";
            this.txt_tongtiensaugiam.Size = new System.Drawing.Size(23, 25);
            this.txt_tongtiensaugiam.TabIndex = 57;
            this.txt_tongtiensaugiam.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(638, 456);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 19);
            this.metroLabel4.TabIndex = 56;
            this.metroLabel4.Text = "Tổng (Sau giảm giá):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cthdgv);
            this.panel2.Location = new System.Drawing.Point(422, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 336);
            this.panel2.TabIndex = 55;
            // 
            // cthdgv
            // 
            this.cthdgv.AllowUserToAddRows = false;
            this.cthdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cthdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cthdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.cthdgv.Location = new System.Drawing.Point(0, 0);
            this.cthdgv.MultiSelect = false;
            this.cthdgv.Name = "cthdgv";
            this.cthdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cthdgv.Size = new System.Drawing.Size(518, 333);
            this.cthdgv.TabIndex = 36;
            this.cthdgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.cthdgv_CellValidating);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên SP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SL";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng";
            this.Column4.Name = "Column4";
            // 
            // dsspgv
            // 
            this.dsspgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dsspgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dsspgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsspgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dsspgv.Location = new System.Drawing.Point(35, 137);
            this.dsspgv.Name = "dsspgv";
            this.dsspgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsspgv.Size = new System.Drawing.Size(309, 381);
            this.dsspgv.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.metroLabel2);
            this.panel3.Controls.Add(this.txtsearchten);
            this.panel3.Controls.Add(this.cbloaisp);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Location = new System.Drawing.Point(38, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 102);
            this.panel3.TabIndex = 73;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Tên sản phẩm";
            // 
            // txtsearchten
            // 
            this.txtsearchten.Location = new System.Drawing.Point(7, 67);
            this.txtsearchten.Name = "txtsearchten";
            this.txtsearchten.Size = new System.Drawing.Size(287, 20);
            this.txtsearchten.TabIndex = 2;
            this.txtsearchten.TextChanged += new System.EventHandler(this.txtsearchten_TextChanged);
            // 
            // cbloaisp
            // 
            this.cbloaisp.FormattingEnabled = true;
            this.cbloaisp.Location = new System.Drawing.Point(6, 27);
            this.cbloaisp.Name = "cbloaisp";
            this.cbloaisp.Size = new System.Drawing.Size(288, 21);
            this.cbloaisp.TabIndex = 1;
            this.cbloaisp.SelectionChangeCommitted += new System.EventHandler(this.cbloaisp_SelectionChangeCommitted);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Loại sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_makhach);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Location = new System.Drawing.Point(418, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 57);
            this.panel1.TabIndex = 72;
            // 
            // txt_makhach
            // 
            this.txt_makhach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_makhach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_makhach.Location = new System.Drawing.Point(222, 16);
            this.txt_makhach.Name = "txt_makhach";
            this.txt_makhach.Size = new System.Drawing.Size(247, 20);
            this.txt_makhach.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(61, 17);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(104, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Mã Khách Hàng:";
            // 
            // banhangview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voucher);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.cbb_sl);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.btn_themsp);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_tienthua);
            this.Controls.Add(this.txt_tientra);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txt_tongtiensaugiam);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dsspgv);
            this.Name = "banhangview";
            this.Size = new System.Drawing.Size(1005, 571);
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sl)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cthdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsspgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox voucher;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.Label txt_tongtien;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.NumericUpDown cbb_sl;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton btn_themsp;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox txt_tienthua;
        private System.Windows.Forms.TextBox txt_tientra;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnthanhtoan;
        private MetroFramework.Controls.MetroButton btnxoa;
        private System.Windows.Forms.Label txt_tongtiensaugiam;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView cthdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dsspgv;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtsearchten;
        private System.Windows.Forms.ComboBox cbloaisp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_makhach;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}
