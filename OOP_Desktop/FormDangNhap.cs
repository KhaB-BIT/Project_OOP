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
    public partial class FormDangNhap : Form
    {
        //Khai báo biến
        internal BookSmart NV = new BookSmart("Select MaNV as 'Mã NV', TenNV as 'Tên nhân viên', TaiKhoan as 'Tài khoản', MatKhau as 'Mật khẩu', Phone as 'SĐT', DiaChi as 'Địa chỉ' from dbo.NhanVien");
        internal SQL SQLConnector = new SQL(@"Data Source=BI\SQLEXPRESS;Initial Catalog=SQL_EndOfTerm;Integrated Security=True");

        public FormDangNhap()
        {
            InitializeComponent();            
        }

        internal void ResetTxt()
        {
            this.txtTaiKhoan.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                object main = SQLConnector.MotGiaTri("Select MatKhau from dbo.Admin where TaiKhoan = N'" + txtTaiKhoan.Text + "'");
                if (main != null)
                {
                    if (txtMatKhau.Text == main.ToString())
                    {
                        FormQuanLy formQL = new FormQuanLy(this);
                        formQL.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (txtMatKhau.Text == main.ToString())
                        {
                            FormNhanVien formNV = new FormNhanVien(this);
                            formNV.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Tài khoản hoặc Mật khẩu không chính xác");
                    }
                }
                else MessageBox.Show("Tài khoản không tồn tại");       
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi đăng nhập");
            }
                
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Tài khoản") txtTaiKhoan.Text = "";
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "") txtTaiKhoan.Text = "Tài khoản";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";

            }    
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true ;
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
