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
    public partial class ThemTheLoai : Form
    {
        public ThemTheLoai(FormThemSach formThemSach)
        {
            InitializeComponent();
            this.fts = formThemSach;
        }

        FormThemSach fts;

        private void txtSeries_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "Nhập mã thể loại") txtMaTL.Text = "";
        }

        private void txtSeries_Leave(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "") txtMaTL.Text = "Nhập mã thể loại";

        }

        private void txtTenSach_Click(object sender, EventArgs e)
        {
            if (txtTenTL.Text == "Nhập tên thể loại") txtTenTL.Text = "";
        }

        private void txtTenSach_Leave(object sender, EventArgs e)
        {
            if (txtTenTL.Text == "") txtTenTL.Text = "Nhập tên thể loại";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                fts.FormPrivious.SQLConnector.ExcuteQuery("Insert dbo.TheLoaiSach values(N'" + txtMaTL.Text + "',N'" + txtTenTL.Text + "')");
                MessageBox.Show("Thao tác đã được thực hiện");
                fts.cbbTheLoai.DataSource = fts.FormPrivious.SQLConnector.Select("Select * from dbo.TheLoaiSach").Tables[0];
                fts.cbbTheLoai.DisplayMember = "TenTL";
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Không thành công, xin vui lòng thử lại!");
            }
        }
    }
}
