using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace OOP_Desktop
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
            formQlySPLoad();
            
        }


        //Các hàm chức năng------------------------------------

        //Hàm kết nối SQL
        public DataSet SQLConnector(string connectlink, string query)
        {
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectlink))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        //Hàm chuyển đổi màu button
        public void ChangebtnEffect(string btn)
        {
            int[] color1 = new int[] {33,31,45};
            int[] color2 = new int[] { 11,8,20};
            int[] color3 = new int[] { 67, 231, 192 };
            int[] color4 = new int[] { 255,255,255 };
            //Fill background
            btnDashboard.BackColor = Color.FromArgb(11, 8, 20);
            btnQlySach.BackColor = Color.FromArgb(11, 8, 20);
            btnQlyKH.BackColor = Color.FromArgb(11, 8, 20);
            btnQlyNV.BackColor = Color.FromArgb(11, 8, 20);
            btnQlyDoanhThu.BackColor = Color.FromArgb(11, 8, 20);
            btnDangXuat.BackColor = Color.FromArgb(11, 8, 20);
            //Fill text
            btnDashboard.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlySach.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlyKH.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlyNV.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlyDoanhThu.ForeColor = Color.FromArgb(255, 255, 255);
            btnDangXuat.ForeColor = Color.FromArgb(255, 255, 255);
            //Font Style
            btnDashboard.Font = new Font(btnDashboard.Font, FontStyle.Regular);
            btnQlySach.Font = new Font(btnQlySach.Font, FontStyle.Regular);
            btnQlyKH.Font = new Font(btnQlyKH.Font, FontStyle.Regular);
            btnQlyNV.Font = new Font(btnQlyNV.Font, FontStyle.Regular);
            btnQlyDoanhThu.Font = new Font(btnQlyDoanhThu.Font, FontStyle.Regular);
            btnDangXuat.Font = new Font(btnDangXuat.Font, FontStyle.Regular);
            //Unvisible
            pnlDashboard.Visible = false;
            pnlQlyKH.Visible = false;
            pnlQlySach.Visible = false;
            pnlQlyNV.Visible = false;

            switch (btn)
            {
                case "btnDashboard":
                    {
                        btnDashboard.BackColor = Color.FromArgb(33, 31, 45);
                        btnDashboard.ForeColor = Color.FromArgb(67, 231, 192);
                        btnDashboard.Font = new Font(btnDashboard.Font, FontStyle.Bold);
                        pnlDashboard.Visible = true;
                    };
                    break;
                case "btnQlySach":
                    {
                        btnQlySach.BackColor = Color.FromArgb(33, 31, 45);
                        btnQlySach.ForeColor = Color.FromArgb(67, 231, 192);
                        btnQlySach.Font = new Font(btnQlySach.Font, FontStyle.Bold);
                        pnlQlySach.Visible = true;
                    }
                    break;
                case "btnQlyKH":
                    {
                        pnlQlyKH.Visible = true;
                        btnQlyKH.BackColor = Color.FromArgb(33, 31, 45);
                        btnQlyKH.ForeColor = Color.FromArgb(67, 231, 192);
                        btnQlyKH.Font = new Font(btnQlyKH.Font, FontStyle.Bold);
                    }
                    break;
                case "btnQlyNV":
                    {
                        btnQlyNV.BackColor = Color.FromArgb(33, 31, 45);
                        btnQlyNV.ForeColor = Color.FromArgb(67, 231, 192);
                        btnQlyNV.Font = new Font(btnQlyNV.Font, FontStyle.Bold);
                        pnlQlyNV.Visible = true;
                    }
                    break;
                case "btnQlyDoanhThu":
                    {
                        btnQlyDoanhThu.BackColor = Color.FromArgb(33, 31, 45);
                        btnQlyDoanhThu.ForeColor = Color.FromArgb(67, 231, 192);
                        btnQlyDoanhThu.Font = new Font(btnQlyDoanhThu.Font, FontStyle.Bold);
                    }
                    break;
                case "btnDangXuat":
                    {
                        btnDangXuat.BackColor = Color.FromArgb(33, 31, 45);
                        btnDangXuat.ForeColor = Color.FromArgb(67, 231, 192);
                        btnDangXuat.Font = new Font(btnDangXuat.Font, FontStyle.Bold);
                    }
                    break;

            }
        }


        //Các event chức năng của Form-------------------------

        public void formQlySPLoad()
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnDashboard");

        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnQlySach");
            dataSach.DataSource = SQLConnector(@"Data Source=BI\SQLEXPRESS;Initial Catalog=SQL_EndOfTerm;Integrated Security=True", "select MaSach,MaTL,TenSach,SoLuong,GiaBan from dbo.SanPham").Tables[0];

        }

        private void btnQlyKH_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnQlyKH");
            dataKH.DataSource = SQLConnector(@"Data Source=BI\SQLEXPRESS;Initial Catalog=SQL_EndOfTerm;Integrated Security=True", "select TenKH,GioiTinh,Phone,DiaChi,Email from dbo.KhachHang").Tables[0];
        }

        private void btnQlyNV_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnQlyNV");
            dataNV.DataSource = SQLConnector(@"Data Source=BI\SQLEXPRESS;Initial Catalog=SQL_EndOfTerm;Integrated Security=True", "select MaNV,TenNV,TaiKhoan,MatKhau,Phone,DiaChi from dbo.NhanVien").Tables[0];
        }

        private void btnQlyDoanhThu_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnQlyDoanhThu");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnDangXuat"); 
        }
        //Tạo số thứ tự cho Bảng
        private void dataSach_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataSach.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataKH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataNV.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }
    }
}
