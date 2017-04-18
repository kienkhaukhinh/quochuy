namespace WindowsFormsApplication1.View
{
    partial class dathangview
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
            this.cbb_lsp_dh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_themsp_dh = new MetroFramework.Controls.MetroButton();
            this.dsspgv_dh = new System.Windows.Forms.DataGridView();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_tongtien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdongia_dh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_sl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvphieudat = new System.Windows.Forms.DataGridView();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tensp_dh = new System.Windows.Forms.TextBox();
            this.btn_hoantat = new MetroFramework.Controls.MetroButton();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.tabControl5.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.pnnhanvienthem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsspgv_dh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieudat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage16);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(830, 528);
            this.tabControl5.TabIndex = 15;
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.Transparent;
            this.tabPage16.Controls.Add(this.pnnhanvienthem);
            this.tabPage16.HorizontalScrollbarBarColor = true;
            this.tabPage16.Location = new System.Drawing.Point(4, 35);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(822, 489);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Tạo đơn đặt hàng";
            this.tabPage16.VerticalScrollbarBarColor = true;
            // 
            // pnnhanvienthem
            // 
            this.pnnhanvienthem.Controls.Add(this.cbb_lsp_dh);
            this.pnnhanvienthem.Controls.Add(this.label4);
            this.pnnhanvienthem.Controls.Add(this.btn_themsp_dh);
            this.pnnhanvienthem.Controls.Add(this.dsspgv_dh);
            this.pnnhanvienthem.Controls.Add(this.metroLabel6);
            this.pnnhanvienthem.Controls.Add(this.txt_tongtien);
            this.pnnhanvienthem.Controls.Add(this.label5);
            this.pnnhanvienthem.Controls.Add(this.txtdongia_dh);
            this.pnnhanvienthem.Controls.Add(this.label1);
            this.pnnhanvienthem.Controls.Add(this.cbb_sl);
            this.pnnhanvienthem.Controls.Add(this.label3);
            this.pnnhanvienthem.Controls.Add(this.dgvphieudat);
            this.pnnhanvienthem.Controls.Add(this.label2);
            this.pnnhanvienthem.Controls.Add(this.txt_tensp_dh);
            this.pnnhanvienthem.Controls.Add(this.btn_hoantat);
            this.pnnhanvienthem.Controls.Add(this.cbbncc);
            this.pnnhanvienthem.Controls.Add(this.label58);
            this.pnnhanvienthem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnnhanvienthem.Location = new System.Drawing.Point(0, 0);
            this.pnnhanvienthem.Name = "pnnhanvienthem";
            this.pnnhanvienthem.Size = new System.Drawing.Size(822, 489);
            this.pnnhanvienthem.TabIndex = 15;
            // 
            // cbb_lsp_dh
            // 
            this.cbb_lsp_dh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lsp_dh.FormattingEnabled = true;
            this.cbb_lsp_dh.Items.AddRange(new object[] {
            "AMISU",
            "IMEX",
            "Green Dragon Trade"});
            this.cbb_lsp_dh.Location = new System.Drawing.Point(30, 38);
            this.cbb_lsp_dh.Name = "cbb_lsp_dh";
            this.cbb_lsp_dh.Size = new System.Drawing.Size(237, 21);
            this.cbb_lsp_dh.TabIndex = 49;
            this.cbb_lsp_dh.SelectionChangeCommitted += new System.EventHandler(this.cbb_lsp_dh_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Loại SP";
            // 
            // btn_themsp_dh
            // 
            this.btn_themsp_dh.Location = new System.Drawing.Point(289, 274);
            this.btn_themsp_dh.Name = "btn_themsp_dh";
            this.btn_themsp_dh.Size = new System.Drawing.Size(68, 23);
            this.btn_themsp_dh.TabIndex = 48;
            this.btn_themsp_dh.Text = "Thêm";
            this.btn_themsp_dh.Click += new System.EventHandler(this.btn_themsp_dh_Click);
            // 
            // dsspgv_dh
            // 
            this.dsspgv_dh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsspgv_dh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsspgv_dh.Location = new System.Drawing.Point(30, 108);
            this.dsspgv_dh.Name = "dsspgv_dh";
            this.dsspgv_dh.ReadOnly = true;
            this.dsspgv_dh.RowHeadersVisible = false;
            this.dsspgv_dh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsspgv_dh.Size = new System.Drawing.Size(237, 293);
            this.dsspgv_dh.TabIndex = 47;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(768, 420);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "VNĐ";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.AutoSize = true;
            this.txt_tongtien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tongtien.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.ForeColor = System.Drawing.Color.Red;
            this.txt_tongtien.Location = new System.Drawing.Point(580, 414);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(23, 25);
            this.txt_tongtien.TabIndex = 45;
            this.txt_tongtien.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tổng tiền:";
            // 
            // txtdongia_dh
            // 
            this.txtdongia_dh.AutoCompleteCustomSource.AddRange(new string[] {
            "Cà chua",
            "Cà tím",
            "Khoai Tây",
            "Khoai Lang",
            "Nước mắm"});
            this.txtdongia_dh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdongia_dh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtdongia_dh.Location = new System.Drawing.Point(273, 248);
            this.txtdongia_dh.Name = "txtdongia_dh";
            this.txtdongia_dh.Size = new System.Drawing.Size(108, 20);
            this.txtdongia_dh.TabIndex = 42;
            this.txtdongia_dh.Validating += new System.ComponentModel.CancelEventHandler(this.txtdongia_dh_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Đơn giá";
            // 
            // cbb_sl
            // 
            this.cbb_sl.Location = new System.Drawing.Point(273, 205);
            this.cbb_sl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbb_sl.Name = "cbb_sl";
            this.cbb_sl.Size = new System.Drawing.Size(108, 20);
            this.cbb_sl.TabIndex = 36;
            this.cbb_sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Số lượng";
            // 
            // dgvphieudat
            // 
            this.dgvphieudat.AllowUserToAddRows = false;
            this.dgvphieudat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphieudat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieudat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENSP,
            this.Column1,
            this.DG,
            this.TONGC});
            this.dgvphieudat.Location = new System.Drawing.Point(387, 83);
            this.dgvphieudat.Name = "dgvphieudat";
            this.dgvphieudat.RowHeadersVisible = false;
            this.dgvphieudat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvphieudat.Size = new System.Drawing.Size(417, 318);
            this.dgvphieudat.TabIndex = 34;
            this.dgvphieudat.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvphieudat_CellValidating);
            this.dgvphieudat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvphieudat_MouseClick);
            // 
            // TENSP
            // 
            this.TENSP.HeaderText = "Tên SP";
            this.TENSP.Name = "TENSP";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SL";
            this.Column1.Name = "Column1";
            // 
            // DG
            // 
            this.DG.HeaderText = "Đơn giá nhập";
            this.DG.Name = "DG";
            // 
            // TONGC
            // 
            this.TONGC.HeaderText = "Tổng";
            this.TONGC.Name = "TONGC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txt_tensp_dh
            // 
            this.txt_tensp_dh.AutoCompleteCustomSource.AddRange(new string[] {
            "Cà chua",
            "Cà tím",
            "Khoai Tây",
            "Khoai Lang",
            "Nước mắm"});
            this.txt_tensp_dh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_tensp_dh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_tensp_dh.Location = new System.Drawing.Point(30, 80);
            this.txt_tensp_dh.Name = "txt_tensp_dh";
            this.txt_tensp_dh.Size = new System.Drawing.Size(237, 20);
            this.txt_tensp_dh.TabIndex = 32;
            this.txt_tensp_dh.TextChanged += new System.EventHandler(this.txt_tensp_dh_TextChanged);
            // 
            // btn_hoantat
            // 
            this.btn_hoantat.Location = new System.Drawing.Point(705, 442);
            this.btn_hoantat.Name = "btn_hoantat";
            this.btn_hoantat.Size = new System.Drawing.Size(99, 23);
            this.btn_hoantat.TabIndex = 31;
            this.btn_hoantat.Text = "Hoàn tất";
            this.btn_hoantat.Click += new System.EventHandler(this.btn_hoantat_Click);
            // 
            // cbbncc
            // 
            this.cbbncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Items.AddRange(new object[] {
            "AMISU",
            "IMEX",
            "Green Dragon Trade"});
            this.cbbncc.Location = new System.Drawing.Point(618, 38);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(186, 21);
            this.cbbncc.TabIndex = 29;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(729, 22);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(75, 13);
            this.label58.TabIndex = 30;
            this.label58.Text = "Nhà cung cấp";
            // 
            // dathangview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl5);
            this.Name = "dathangview";
            this.Size = new System.Drawing.Size(830, 528);
            this.tabControl5.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.pnnhanvienthem.ResumeLayout(false);
            this.pnnhanvienthem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsspgv_dh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieudat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl5;
        private MetroFramework.Controls.MetroTabPage tabPage16;
        private System.Windows.Forms.Panel pnnhanvienthem;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Label txt_tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdongia_dh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cbb_sl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvphieudat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tensp_dh;
        private MetroFramework.Controls.MetroButton btn_hoantat;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.DataGridView dsspgv_dh;
        private MetroFramework.Controls.MetroButton btn_themsp_dh;
        private System.Windows.Forms.ComboBox cbb_lsp_dh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGC;
    }
}
