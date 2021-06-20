using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Desktop
{
    public partial class FormInHoaDon : Form
    {
        public FormInHoaDon()
        {
            InitializeComponent();
        }
        string address = "279 Nguyen Tri Phuong, p10, q3, HoChiMinh city";
        string email = "BookSmart.real279@gmail.com";
        string idnhanvien = "NV009";
        string tennhanvien = "Bui Minh Kha";
        string mahoadon = "1962021000";
        string ngayhoadon = "19/6/2021";
        string tensp1 = "Lap trinh c#", tensp2 = "Mat biec", tensp3 = "alo code met qua", slg1 = "2", slg2 = "3", slg3 = "1", gia1 = "40000", gia2 = "50000", gia3 = "10000";

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprmn", 285,600);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BookSmart", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(350, 70));
            e.Graphics.DrawString("Dia chi: " + address, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(100, 150));
            e.Graphics.DrawString("Email: " + email, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(100, 200));
            e.Graphics.DrawString("Ma nhan vien: " + idnhanvien, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(100, 250));
            e.Graphics.DrawString("Ten nhan vien: " + tennhanvien, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(100, 300));
            e.Graphics.DrawString("Ma hoa don: " + mahoadon, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(100, 350));
            e.Graphics.DrawString("Ngay xuat: " + ngayhoadon, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(400, 350));
            e.Graphics.DrawString("===================================================================", new Font("Century Gothic", 14, FontStyle.Regular), Brushes.DarkRed, new Point(10, 400));
            e.Graphics.DrawString("Ten san pham                               So luong            Don gia     ", new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(100, 450));
            int vitridong = 500;
            // vòng lập để in danh sách sản phẩm, in xong tăng vitridong 50;
            //in sản phẩm 1
            e.Graphics.DrawString(tensp1, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(100, vitridong));
            e.Graphics.DrawString(slg1, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(430, vitridong));
            e.Graphics.DrawString(gia1, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(560, vitridong));
            vitridong += 50;
            //in sản phẩm 2
            e.Graphics.DrawString(tensp2, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(100, vitridong));
            e.Graphics.DrawString(slg2, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(430, vitridong));
            e.Graphics.DrawString(gia2, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(560, vitridong));
            vitridong += 50;
            //in sản phẩm 3
            e.Graphics.DrawString(tensp3, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(100, vitridong));
            e.Graphics.DrawString(slg3, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(430, vitridong));
            e.Graphics.DrawString(gia3, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(560, vitridong));

            e.Graphics.DrawString("===================================================================", new Font("Century Gothic", 14, FontStyle.Regular), Brushes.DarkRed, new Point(10, 900));
            e.Graphics.DrawString("Thanh tien: " + 200000 + "VND", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Blue, new Point(450, 950));
            e.Graphics.DrawString("BookSmart xin cam on va hen gap lai", new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(200, 1000));
        }

    }
}
