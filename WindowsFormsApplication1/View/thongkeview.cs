using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.ENTITY;
using Model.BUS;
using Model.DAO;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApplication1.View
{
    public partial class thongkeview : UserControl
    {
        public thongkeview()
        {
            InitializeComponent();
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "dd/MM/yyyy";
            dateTimePicker5.ShowUpDown = true; 
        }
        private void btnthongke_Click_1(object sender, EventArgs e)
        {
            chart1.Visible = true;

            // chart2.Visible = false;
            chart1.Series["Doanh số"].ChartType = SeriesChartType.Column;
            // chart1.Series["Tổng giá xuất"].ChartType = SeriesChartType.Column;
            loaddulieulenchart();
        }
        private void pnnhanvienthem_Paint(object sender, PaintEventArgs e)
        {

        }
      
        public SelectionRange SelectionRange { get; set; }
        public void loaddulieulenchart()
        {
            HOADONBUS bus = new HOADONBUS();
            SANPHAMBUS bus1 = new SANPHAMBUS();
            dateTimePicker5.MinDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
          

            Axis XA = chart1.ChartAreas[0].AxisX;

            List<DateTime> dates = new List<DateTime>();
            for (int i = 1; i <= 12; i++)
                dates.Add(new DateTime(dateTimePicker5.Value.Date.Year, i, 1));

            chart1.Series["Doanh số"].XValueType = ChartValueType.Date;
          //  chart1.Series["Tổng giá xuất"].XValueType = ChartValueType.Date;


            XA.MajorGrid.Enabled = false;         // no gridlines
            XA.LabelStyle.Format = "MMM";         // show months as names

            XA.IntervalType = DateTimeIntervalType.Months;  // show axis labels.. 
            XA.Interval = 1;

            int y = 1;
            int year = dateTimePicker1.Value.Date.Year;
            foreach (DateTime d in dates)
            {
                chart1.Series["Doanh số"].Points.AddXY(d, bus.tonggianhaptheothang(y, year));
              //  chart1.Series["Tổng giá xuất"].Points.AddXY(d, bus1.tonggiaxuattheothang(y, year));
                y++;
            }
            if (y == 12) y = 1;
        }
        /*
        public void loaddulieulenpie()
        {
            HOADONBUS bus = new HOADONBUS();
            SANPHAMBUS bus1 = new SANPHAMBUS();
            DateTime dt = DateTime.Now;
            chart2.Series[0].Points.AddXY("Tổng giá nhập", bus.tonggianhaptheonam(dateTimePicker1.Value.Date.Year));
            decimal? a = bus1.tonggiaxuattheonam(dt.Year);
            chart2.Series[0].Points.AddXY("Tổng giá xuất", bus1.tonggiaxuattheonam(dateTimePicker1.Value.Date.Year));
        }

        public void clear()
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
        }
         * */


      

        private void chart1_Click(object sender, EventArgs e)
        {

        }

       

     
    }
}
