namespace WindowsFormsApplication1.View
{
    partial class thongkeview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl5 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage16 = new MetroFramework.Controls.MetroTabPage();
            this.pnnhanvienthem = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnthongke = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbrematkhau = new System.Windows.Forms.Label();
            this.tabPage17 = new MetroFramework.Controls.MetroTabPage();
            this.pndanhsachnv = new System.Windows.Forms.Panel();
            this.btnthongkekho = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl5.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.pnnhanvienthem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage17.SuspendLayout();
            this.pndanhsachnv.SuspendLayout();
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
            this.tabControl5.Size = new System.Drawing.Size(783, 512);
            this.tabControl5.TabIndex = 16;
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.Transparent;
            this.tabPage16.Controls.Add(this.pnnhanvienthem);
            this.tabPage16.HorizontalScrollbarBarColor = true;
            this.tabPage16.Location = new System.Drawing.Point(4, 35);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(775, 473);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Thống kê Doanh thu";
            this.tabPage16.VerticalScrollbarBarColor = true;
            // 
            // pnnhanvienthem
            // 
            this.pnnhanvienthem.Controls.Add(this.chart1);
            this.pnnhanvienthem.Controls.Add(this.dateTimePicker2);
            this.pnnhanvienthem.Controls.Add(this.label8);
            this.pnnhanvienthem.Controls.Add(this.btnthongke);
            this.pnnhanvienthem.Controls.Add(this.dateTimePicker5);
            this.pnnhanvienthem.Controls.Add(this.lbngaysinh);
            this.pnnhanvienthem.Controls.Add(this.lbrematkhau);
            this.pnnhanvienthem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnnhanvienthem.Location = new System.Drawing.Point(0, 0);
            this.pnnhanvienthem.Name = "pnnhanvienthem";
            this.pnnhanvienthem.Size = new System.Drawing.Size(775, 473);
            this.pnnhanvienthem.TabIndex = 15;
            this.pnnhanvienthem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnnhanvienthem_Paint);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(137, 122);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh số";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(452, 300);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(349, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày kết thúc";
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(624, 46);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(125, 23);
            this.btnthongke.TabIndex = 15;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click_1);
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(53, 46);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker5.TabIndex = 7;
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(50, 33);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(72, 13);
            this.lbngaysinh.TabIndex = 12;
            this.lbngaysinh.Text = "Ngày bắt đầu";
            // 
            // lbrematkhau
            // 
            this.lbrematkhau.AutoSize = true;
            this.lbrematkhau.Location = new System.Drawing.Point(86, 188);
            this.lbrematkhau.Name = "lbrematkhau";
            this.lbrematkhau.Size = new System.Drawing.Size(0, 13);
            this.lbrematkhau.TabIndex = 7;
            // 
            // tabPage17
            // 
            this.tabPage17.BackColor = System.Drawing.Color.Transparent;
            this.tabPage17.Controls.Add(this.pndanhsachnv);
            this.tabPage17.HorizontalScrollbarBarColor = true;
            this.tabPage17.Location = new System.Drawing.Point(4, 35);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(775, 473);
            this.tabPage17.TabIndex = 4;
            this.tabPage17.Text = "Thống kê nhập-xuất-tồn";
            this.tabPage17.VerticalScrollbarBarColor = true;
            // 
            // pndanhsachnv
            // 
            this.pndanhsachnv.Controls.Add(this.btnthongkekho);
            this.pndanhsachnv.Controls.Add(this.dateTimePicker1);
            this.pndanhsachnv.Controls.Add(this.label1);
            this.pndanhsachnv.Controls.Add(this.dateTimePicker3);
            this.pndanhsachnv.Controls.Add(this.label2);
            this.pndanhsachnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndanhsachnv.Location = new System.Drawing.Point(0, 0);
            this.pndanhsachnv.Name = "pndanhsachnv";
            this.pndanhsachnv.Size = new System.Drawing.Size(775, 473);
            this.pndanhsachnv.TabIndex = 33;
            // 
            // btnthongkekho
            // 
            this.btnthongkekho.Location = new System.Drawing.Point(580, 31);
            this.btnthongkekho.Name = "btnthongkekho";
            this.btnthongkekho.Size = new System.Drawing.Size(125, 23);
            this.btnthongkekho.TabIndex = 24;
            this.btnthongkekho.Text = "Thống kê kho";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ngày kết thúc";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(26, 28);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // thongkeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl5);
            this.Name = "thongkeview";
            this.Size = new System.Drawing.Size(783, 512);
            this.tabControl5.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.pnnhanvienthem.ResumeLayout(false);
            this.pnnhanvienthem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage17.ResumeLayout(false);
            this.pndanhsachnv.ResumeLayout(false);
            this.pndanhsachnv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTabControl tabControl5;
        private MetroFramework.Controls.MetroTabPage tabPage16;
        private System.Windows.Forms.Panel pnnhanvienthem;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton btnthongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbrematkhau;
        private MetroFramework.Controls.MetroTabPage tabPage17;
        private System.Windows.Forms.Panel pndanhsachnv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnthongkekho;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
