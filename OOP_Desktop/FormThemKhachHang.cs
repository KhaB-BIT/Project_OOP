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
    public partial class FormThemKhachHang : Form
    {

        public FormThemKhachHang(FormQuanLy ql)
        {
            InitializeComponent();
            this.FormPrivious = ql;
        }
        public FormThemKhachHang(FormNhanVien ql)
        {
            InitializeComponent();
            this.FormPrivious2 = ql;
        }

        FormQuanLy FormPrivious =null;
        FormNhanVien FormPrivious2 = null;

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormPrivious != null)
                {
                    FormPrivious.SQLConnector.ExcuteQuery("Insert dbo.KhachHang Values (N'" + txtTenKH.Text + "',N'" + cbbGioiTinh.Text
                    + "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "',N'" + txtEmail.Text + "')");
                    MessageBox.Show("Thao tác được thực hiện");
                    FormPrivious.dataKH.DataSource = FormPrivious.SQLConnector.Select(FormPrivious.KH.Query).Tables[0];
                    this.Close();
                }
                else
                {
                    FormPrivious2.SQLConnector.ExcuteQuery("Insert dbo.KhachHang Values (N'" + txtTenKH.Text + "',N'" + cbbGioiTinh.Text
                    + "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "',N'" + txtEmail.Text + "')");
                    MessageBox.Show("Thao tác được thực hiện");
                    this.Close();
                }    
                    
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

        //Effects -------------
        #region Effects
        private void txtTenKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "Nhập tên khách hàng") txtTenKH.Text = "";

        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "") txtTenKH.Text = "Nhập tên khách hàng";
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
            if (txtDiaChi.Text == "Nhập địa chỉ") txtDiaChi.Text = "";
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "") txtDiaChi.Text = "Nhập địa chỉ";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập Email") txtEmail.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") txtEmail.Text = "Nhập Email";
        }

        #endregion


    }
}
