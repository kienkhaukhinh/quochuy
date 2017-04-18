namespace WindowsFormsApplication1
{
    partial class Login
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
            this.lbwelcome = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new MetroFramework.Controls.MetroButton();
            this.lbmatkhau = new MetroFramework.Controls.MetroLabel();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.lbidnhanvien = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Location = new System.Drawing.Point(169, 172);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(346, 19);
            this.lbwelcome.TabIndex = 15;
            this.lbwelcome.Text = "Chào mừng đến với phần mềm quản lý cửa hàng đồ chơi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.login_icon_3058;
            this.pictureBox2.Location = new System.Drawing.Point(94, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(431, 324);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(149, 23);
            this.btndangnhap.TabIndex = 11;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(252, 273);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(63, 19);
            this.lbmatkhau.TabIndex = 13;
            this.lbmatkhau.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(346, 273);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(208, 23);
            this.txtPass.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(346, 230);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(208, 23);
            this.txtID.TabIndex = 9;
            // 
            // lbidnhanvien
            // 
            this.lbidnhanvien.AutoSize = true;
            this.lbidnhanvien.Location = new System.Drawing.Point(252, 230);
            this.lbidnhanvien.Name = "lbidnhanvien";
            this.lbidnhanvien.Size = new System.Drawing.Size(85, 19);
            this.lbidnhanvien.TabIndex = 12;
            this.lbidnhanvien.Text = "ID Nhân Viên";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 565);
            this.Controls.Add(this.lbwelcome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbidnhanvien);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbwelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btndangnhap;
        private MetroFramework.Controls.MetroLabel lbmatkhau;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel lbidnhanvien;


    }
}