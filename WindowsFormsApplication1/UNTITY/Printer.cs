using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.UNTITY
{
    class Printer
    {
        // hoi in hoa don
        public void InHoaDonDialog(string makhach,string date)
        {

           
                    PrintDialog _PrintDialog = new PrintDialog();
                    PrintDocument _PrintDocument = new PrintDocument();
                    _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                    _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler((object sender, System.Drawing.Printing.PrintPageEventArgs e) => { _CreateReceipt(sender,e,makhach,date); }); //add an event handler that will do the printing
                    //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                    DialogResult result = _PrintDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        _PrintDocument.Print();
                    }
         

        }

        // tao ra giay in hoa don
        public static void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e,string makhach,string date)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Toy Shop", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            startY = startY + 100;
            graphic.DrawString("Ngày Xuất HĐ : ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString(DateTime.Today.ToString(), new Font("Courier New", 18), new SolidBrush(Color.Black), startX+ offset, startY);
            startY = startY + offset;
            graphic.DrawString("Mã Khách Hàng : ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("", new Font("Courier New", 18), new SolidBrush(Color.Black), startX + offset, startY + offset);
            graphic.DrawString("Điểm tích lũy", new Font("Courier New", 18), new SolidBrush(Color.Black), startX + 100, startY + offset);
            graphic.DrawString("0", new Font("Courier New", 18), new SolidBrush(Color.Black), startX + 180, startY + offset);
            string top = "Sản Phẩm".PadRight(25) + "SL".PadRight(10) + "Đơn giá".PadRight(10) + "Tổng cộng";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            int index = 0;
            //foreach (ListViewItem item in lst_cthdtam.Items)
            //{
            //    graphic.DrawString(item.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            //    graphic.DrawString(item.SubItems[1].Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);
            //    graphic.DrawString(item.SubItems[3].Text, font, new SolidBrush(Color.Black), startX + 350, startY + offset);
            //    graphic.DrawString(item.SubItems[4].Text, font, new SolidBrush(Color.Black), startX + 450, startY + offset);
            //    offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            //}

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Total to pay ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            //graphic.DrawString(txt_tongtien.Text, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

    }
}
