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
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien(FormQuanLy ql)
        {
            InitializeComponent();
            this.FormPrivious = ql;
        }

        FormQuanLy FormPrivious;

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                FormPrivious.SQLConnector.ExcuteQuery("Insert dbo.NhanVien Values (N'" + txtTaiKhoan.Text + "',N'" + txtMatKhau.Text
                    + "',N'" + txtTenNV.Text + "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "')");
                MessageBox.Show("Thao tác được thực hiện");
                FormPrivious.dataNV.DataSource = FormPrivious.SQLConnector.Select(FormPrivious.NV.Query).Tables[0];
                this.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNV_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "Nhập tên nhân viên") txtTenNV.Text = "";
        }

        private void txtTenNV_Leave(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "") txtTenNV.Text = "Nhập tên nhân viên";
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tài khoản") txtTaiKhoan.Text = "";
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "") txtTaiKhoan.Text = "Nhập tài khoản";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu") txtMatKhau.Text = "";
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "") txtMatKhau.Text = "Nhập mật khẩu";
        }

        private void txtSDT_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Nhập số điện thoại") txtSDT.Text = "";
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "") txtSDT.Text = "Nhập số điện thoại";
        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Nhập số địa chỉ") txtDiaChi.Text = "";
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "") txtDiaChi.Text = "Nhập số địa chỉ";
        }

        //Effects -----------------------------

    }
}
