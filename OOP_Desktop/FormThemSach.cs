using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Desktop
{
    public partial class FormThemSach : Form
    {
        public FormThemSach(FormQuanLy ql)
        {
            InitializeComponent();
            this.FormPrivious = ql;
            cbbTheLoai.DataSource = FormPrivious.SQLConnector.Select("Select * from dbo.TheLoaiSach").Tables[0];
            cbbTheLoai.DisplayMember = "TenTL";
        }

        FormQuanLy FormPrivious;

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaTL = FormPrivious.SQLConnector.MotGiaTri("Select MaTL from dbo.TheLoaiSach where TenTL =N'" + cbbTheLoai.Text + "'").ToString();
                FormPrivious.SQLConnector.ExcuteQuery("Insert dbo.SanPham Values (N'" + txtSeries.Text + "',N'" + MaTL
                    + "',N'" + txtTenSach.Text + "',N'" + txtSoLuong.Text + "',N'" + txtGiaBan.Text + "',N'" + txtGiaNhap.Text + "')");
                MessageBox.Show("Thao tác được thực hiện");
                FormPrivious.dataSach.DataSource = FormPrivious.SQLConnector.Select(FormPrivious.Sach.Query).Tables[0];
                this.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormPrivious.dataSach.DataSource = FormPrivious.SQLConnector.Select(FormPrivious.Sach.Query).Tables[0];
            this.Close();
        }

        //Effect ---------------------
        #region Effect
        private void txtSeries_Click(object sender, EventArgs e)
        {
            if (txtSeries.Text == "Nhập Series") txtSeries.Text = "";
        }

        private void txtSeries_Leave(object sender, EventArgs e)
        {
            if (txtSeries.Text == "") txtSeries.Text = "Nhập Series";
        }

        private void txtTenSach_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "Nhập tên sách") txtTenSach.Text = "";
        }

        private void txtTenSach_Leave(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "") txtTenSach.Text = "Nhập tên sách";
        }

        private void txtSoLuong_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "Nhập số lượng") txtSoLuong.Text = "";
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "") txtSoLuong.Text = "Nhập số lượng";
        }

        private void txtGiaNhap_Click(object sender, EventArgs e)
        {
            if (txtGiaNhap.Text == "Nhập giá nhập") txtGiaNhap.Text = "";
        }
        private void txtGiaNhap_Leave(object sender, EventArgs e)
        {
            if (txtGiaNhap.Text == "") txtGiaNhap.Text = "Nhập giá nhập";

        }
        private void txtGiaBan_Click(object sender, EventArgs e)
        {
            if (txtGiaBan.Text == "Nhập giá bán") txtGiaBan.Text = "";
        }
        private void txtGiaBan_Leave(object sender, EventArgs e)
        {
            if (txtGiaBan.Text == "") txtGiaBan.Text = "Nhập giá bán";
        }





        #endregion

        
    }
}
