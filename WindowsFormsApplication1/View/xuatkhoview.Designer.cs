namespace WindowsFormsApplication1.View
{
    partial class xuatkhoview
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_tensp_xk = new System.Windows.Forms.TextBox();
            this.cbb_lsp_xk = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.dsspgv_xuatkho = new System.Windows.Forms.DataGridView();
            this.btn_xuatkho = new MetroFramework.Controls.MetroButton();
            this.cbb_sl_xk = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvxk = new System.Windows.Forms.DataGridView();
            this.btn_hoantat_xk = new MetroFramework.Controls.MetroButton();
            this.TênSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoa = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsspgv_xuatkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sl_xk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxk)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 72;
            this.metroLabel3.Text = "Tên sản phẩm";
            // 
            // txt_tensp_xk
            // 
            this.txt_tensp_xk.Location = new System.Drawing.Point(38, 78);
            this.txt_tensp_xk.Name = "txt_tensp_xk";
            this.txt_tensp_xk.Size = new System.Drawing.Size(321, 20);
            this.txt_tensp_xk.TabIndex = 71;
            this.txt_tensp_xk.TextChanged += new System.EventHandler(this.txt_tensp_xk_TextChanged);
            // 
            // cbb_lsp_xk
            // 
            this.cbb_lsp_xk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lsp_xk.FormattingEnabled = true;
            this.cbb_lsp_xk.Location = new System.Drawing.Point(37, 34);
            this.cbb_lsp_xk.Name = "cbb_lsp_xk";
            this.cbb_lsp_xk.Size = new System.Drawing.Size(322, 21);
            this.cbb_lsp_xk.TabIndex = 69;
            this.cbb_lsp_xk.SelectionChangeCommitted += new System.EventHandler(this.cbb_lsp_xk_SelectionChangeCommitted);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(34, 18);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(76, 13);
            this.label58.TabIndex = 70;
            this.label58.Text = "Loại sản phẩm";
            // 
            // dsspgv_xuatkho
            // 
            this.dsspgv_xuatkho.AllowUserToAddRows = false;
            this.dsspgv_xuatkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsspgv_xuatkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsspgv_xuatkho.Location = new System.Drawing.Point(37, 113);
            this.dsspgv_xuatkho.Name = "dsspgv_xuatkho";
            this.dsspgv_xuatkho.ReadOnly = true;
            this.dsspgv_xuatkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsspgv_xuatkho.Size = new System.Drawing.Size(322, 374);
            this.dsspgv_xuatkho.TabIndex = 68;
            // 
            // btn_xuatkho
            // 
            this.btn_xuatkho.Location = new System.Drawing.Point(368, 279);
            this.btn_xuatkho.Name = "btn_xuatkho";
            this.btn_xuatkho.Size = new System.Drawing.Size(60, 23);
            this.btn_xuatkho.TabIndex = 67;
            this.btn_xuatkho.Text = "Xuất";
            this.btn_xuatkho.Click += new System.EventHandler(this.btn_xuatkho_Click);
            // 
            // cbb_sl_xk
            // 
            this.cbb_sl_xk.Location = new System.Drawing.Point(368, 253);
            this.cbb_sl_xk.Name = "cbb_sl_xk";
            this.cbb_sl_xk.Size = new System.Drawing.Size(60, 20);
            this.cbb_sl_xk.TabIndex = 66;
            this.cbb_sl_xk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số lượng";
            // 
            // dgvxk
            // 
            this.dgvxk.AllowUserToAddRows = false;
            this.dgvxk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvxk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvxk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TênSP,
            this.SLX});
            this.dgvxk.Location = new System.Drawing.Point(434, 63);
            this.dgvxk.Name = "dgvxk";
            this.dgvxk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvxk.Size = new System.Drawing.Size(478, 424);
            this.dgvxk.TabIndex = 63;
            this.dgvxk.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvxk_CellValidating);
            this.dgvxk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvxk_MouseClick);
            // 
            // btn_hoantat_xk
            // 
            this.btn_hoantat_xk.Location = new System.Drawing.Point(797, 493);
            this.btn_hoantat_xk.Name = "btn_hoantat_xk";
            this.btn_hoantat_xk.Size = new System.Drawing.Size(115, 33);
            this.btn_hoantat_xk.TabIndex = 62;
            this.btn_hoantat_xk.Text = "Hoàn Tất";
            this.btn_hoantat_xk.Click += new System.EventHandler(this.btn_hoantat_xk_Click);
            // 
            // TênSP
            // 
            this.TênSP.FillWeight = 150.2538F;
            this.TênSP.HeaderText = "Tên SP";
            this.TênSP.Name = "TênSP";
            this.TênSP.ReadOnly = true;
            // 
            // SLX
            // 
            this.SLX.FillWeight = 49.74619F;
            this.SLX.HeaderText = "SL Xuất";
            this.SLX.Name = "SLX";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(664, 493);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(115, 33);
            this.btnxoa.TabIndex = 73;
            this.btnxoa.Text = "Xóa Toàn Bộ";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // xuatkhoview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_tensp_xk);
            this.Controls.Add(this.cbb_lsp_xk);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.dsspgv_xuatkho);
            this.Controls.Add(this.btn_xuatkho);
            this.Controls.Add(this.cbb_sl_xk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvxk);
            this.Controls.Add(this.btn_hoantat_xk);
            this.Name = "xuatkhoview";
            this.Size = new System.Drawing.Size(946, 546);
            ((System.ComponentModel.ISupportInitialize)(this.dsspgv_xuatkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sl_xk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txt_tensp_xk;
        private System.Windows.Forms.ComboBox cbb_lsp_xk;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.DataGridView dsspgv_xuatkho;
        private MetroFramework.Controls.MetroButton btn_xuatkho;
        private System.Windows.Forms.NumericUpDown cbb_sl_xk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvxk;
        private MetroFramework.Controls.MetroButton btn_hoantat_xk;
        private System.Windows.Forms.DataGridViewTextBoxColumn TênSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLX;
        private MetroFramework.Controls.MetroButton btnxoa;
    }
}
