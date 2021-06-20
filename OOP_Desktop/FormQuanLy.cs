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
using System.Drawing.Text;

namespace OOP_Desktop
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy(FormDangNhap fdn)
        {
            InitializeComponent();
            formQlySPLoad();
            this.formDangNhap = fdn;
            this.SQLConnector = formDangNhap.SQLConnector;
            GetKHVaDoanhThu();
            
        }

        //Khai báo biến--------------------------------------
        #region Khai báo biến
        FormDangNhap formDangNhap;
        internal BookSmart Sach = new BookSmart("Select MaSach as 'Mã sách', Series as 'Series', MaTL as 'Mã thể loại', TenSach as 'Tên sách', SoLuong as 'Số lượng', GiaNhap as 'Giá nhập', GiaBan as 'Giá bán' from dbo.SanPham");
        internal BookSmart KH = new BookSmart("Select MaKH as 'Mã KH', TenKH as 'Tên khách hàng', GioiTinh as 'Giới tính', Phone as 'SĐT', DiaChi as 'Địa chỉ', Email from dbo.KhachHang");
        internal BookSmart NV = new BookSmart("Select MaNV as 'Mã NV', TenNV as 'Tên nhân viên', TaiKhoan as 'Tài khoản', MatKhau as 'Mật khẩu', Phone as 'SĐT', DiaChi as 'Địa chỉ' from dbo.NhanVien");
        internal SQL SQLConnector;// = new SQL(@"Data Source=BI\SQLEXPRESS;Initial Catalog=SQL_EndOfTerm;Integrated Security=True");
        object[] CellPrivous= new object[3];
        PrivateFontCollection embedfont = new PrivateFontCollection();
        #endregion

        //Các hàm chức năng------------------------------------
        #region Hàm hiệu ứng
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
            //btnDangXuat.BackColor = Color.FromArgb(11, 8, 20);
            //Fill text
            btnDashboard.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlySach.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlyKH.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlyNV.ForeColor = Color.FromArgb(255, 255, 255);
            btnQlyDoanhThu.ForeColor = Color.FromArgb(255, 255, 255);
            //btnDangXuat.ForeColor = Color.FromArgb(255, 255, 255);
            //Font Style
            btnDashboard.Font = new Font(btnDashboard.Font, FontStyle.Regular);
            btnQlySach.Font = new Font(btnQlySach.Font, FontStyle.Regular);
            btnQlyKH.Font = new Font(btnQlyKH.Font, FontStyle.Regular);
            btnQlyNV.Font = new Font(btnQlyNV.Font, FontStyle.Regular);
            btnQlyDoanhThu.Font = new Font(btnQlyDoanhThu.Font, FontStyle.Regular);
            //btnDangXuat.Font = new Font(btnDangXuat.Font, FontStyle.Regular);
            //Unvisible
            pnlDashboard.Visible = false;
            pnlQlyKH.Visible = false;
            pnlQlySach.Visible = false;
            pnlQlyNV.Visible = false;
            pnlDoanhThu.Visible = false;

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
                        pnlDoanhThu.Visible = true;
                    }
                    break;
                case "btnDangXuat":
                    {
                        //btnDangXuat.BackColor = Color.FromArgb(33, 31, 45);
                        //btnDangXuat.ForeColor = Color.FromArgb(67, 231, 192);
                        //btnDangXuat.Font = new Font(btnDangXuat.Font, FontStyle.Bold);
                    }
                    break;

            }
        }
        #endregion

        public void XoaDuLieu(BookSmart varible, DataGridView data)
        {
            CellPrivous[1] = data.CurrentCell.RowIndex;
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng đã chọn", "BookSmart", button);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = varible.DeleteQuery(data.Rows[(int)CellPrivous[1]].Cells[1].Value.ToString());
                    SQLConnector.ExcuteQuery(query);
                    data.Rows.RemoveAt((int)CellPrivous[1]);
                    MessageBox.Show("Thao tác đã được thực hiện");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        public void SuaDuLieu(BookSmart varible, DataGridView data)
        {
            if ((string)CellPrivous[0] != data.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value.ToString())
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi", "BookSmart", button);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = varible.EditQuery(data.Rows[(int)CellPrivous[1]].Cells[1].Value.ToString(), varible.Field()[(int)CellPrivous[2] - 1], data.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value.ToString());
                        SQLConnector.ExcuteQuery(query);
                        MessageBox.Show("Thao tác đã được thực hiện");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thành công");
                    }

                }
                else data.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value = CellPrivous[0];
            }
        }

        private void GetKHVaDoanhThu()
        {
            object check = SQLConnector.Count("dbo.KhachHang");
            if (check != null)
                txtKhachHang.Text = check.ToString() + " Users";
            else txtKhachHang.Text = "-";

            check = SQLConnector.MotGiaTri("SELECT SUM(TongTien) FROM dbo.DonHang");
            if (check != null)
            {
                int main = int.Parse(check.ToString());
                txtDoanhThu.Text = String.Format("{0:0,0}", main) + " VNĐ";

            }
            else txtDoanhThu.Text = "- VNĐ";
        }

        //Các event chức năng của Form-------------------------
        public void formQlySPLoad()
        {

        }

        //Event khi chuyển giữa các chức năng
        #region Event khi chuyển qua các chức năng
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Fill và định dạng bảng
            ChangebtnEffect("btnDashboard");
            GetKHVaDoanhThu();
            
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            // Fill và định dạng bảng
            ChangebtnEffect("btnQlySach");
            dataSach.DataSource = SQLConnector.Select(Sach.Query).Tables[0];
        }

        private void btnQlyKH_Click(object sender, EventArgs e)
        {
            // Fill và định dạng bảng
            ChangebtnEffect("btnQlyKH");
            dataKH.DataSource = SQLConnector.Select(KH.Query).Tables[0];
            
        }

        private void btnQlyNV_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnQlyNV");
            dataNV.DataSource = SQLConnector.Select(NV.Query).Tables[0];
        }

        private void btnQlyDoanhThu_Click(object sender, EventArgs e)
        {
            ChangebtnEffect("btnQlyDoanhThu");
        }

        #endregion

        //Tạo số thứ tự tự động cho bảng datagridview
        #region Tạo số thứ tự cho Bảng
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
        private void dataHoaDonDT_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataHoaDonDT.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        #endregion

        //Event định dạng layout bảng
        #region Event định dạng layout bảng
        private void dataKH_DataSourceChanged(object sender, EventArgs e)
        {
            dataKH.Columns[2].FillWeight = 140;
            dataKH.Columns[3].FillWeight = 70;
            dataKH.Columns[6].FillWeight = 200;
        }
        #endregion


        //Event tìm kiếm
        #region Event tìm kiếm sách
        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            if(btnTimKiemSach.Text == "Tìm kiếm")
            {
                btnTimKiemSach.Text = "Hủy";
                dataSach.DataSource = SQLConnector.Select(Sach.SearchQuery(txtTimKiemSach.Text)).Tables[0];
            }
            else
            {
                btnTimKiemSach.Text = "Tìm kiếm";
                txtTimKiemSach.Text = "Tìm kiếm";
                dataSach.DataSource = SQLConnector.Select(Sach.Query).Tables[0];
            }    
        }

        private void txtTimKiemSach_Click(object sender, EventArgs e)
        {
            txtTimKiemSach.Text = "";
        }
        private void txtTimKiemSach_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemSach.Text == "") txtTimKiemSach.Text = "Tìm kiếm";
        }

        #endregion

        #region Event Tìm kiếm Khách hàng
        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (btnTimKiemKH.Text == "Tìm kiếm")
            {
                btnTimKiemKH.Text = "Hủy";
                dataKH.DataSource = SQLConnector.Select(KH.SearchQuery(txtTimKiemKH.Text)).Tables[0];
            }
            else
            {
                btnTimKiemKH.Text = "Tìm kiếm";
                txtTimKiemKH.Text = "Tìm kiếm";
                dataKH.DataSource = SQLConnector.Select(KH.Query).Tables[0];
            }
        }

        private void txtTimKiemKH_Click(object sender, EventArgs e)
        {
            txtTimKiemKH.Text = "";
        }

        private void txtTimKiemKH_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemKH.Text == "") txtTimKiemKH.Text = "Tìm kiếm";
        }


        #endregion

        #region Event tìm kiếm nhân viên
        private void txtTimKiemNV_Click(object sender, EventArgs e)
        {
            if (txtTimKiemNV.Text == "Tìm kiếm") txtTimKiemNV.Text = "";
        }

        private void txtTimKiemNV_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemNV.Text == "") txtTimKiemNV.Text = "Tìm kiếm";

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            if (btnTimKiemNV.Text == "Tìm kiếm")
            {
                btnTimKiemNV.Text = "Hủy";
                dataNV.DataSource = SQLConnector.Select(NV.SearchQuery(txtTimKiemNV.Text)).Tables[0];
            }
            else
            {
                btnTimKiemNV.Text = "Tìm kiếm";
                txtTimKiemNV.Text = "Tìm kiếm";
                dataNV.DataSource = SQLConnector.Select(NV.Query).Tables[0];
            }
        }
        #endregion


        // Event thêm, sửa xóa
        #region Thêm, sửa, xóa Sách
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            FormThemSach formThemSach = new FormThemSach(this);
            formThemSach.Show();
            dataSach.ClearSelection();
            dataSach.Rows[dataSach.RowCount - 1].Selected = true;

        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            XoaDuLieu(Sach, dataSach); 
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (btnSuaSach.Text == "Sửa")
            {
                CellPrivous[0] = dataSach.CurrentCell.Value.ToString();
                CellPrivous[1] = dataSach.CurrentCell.RowIndex;
                CellPrivous[2] = dataSach.CurrentCell.ColumnIndex;
                dataSach.ReadOnly = false;
                dataSach.Columns[1].ReadOnly = true;
                dataSach.Columns[0].ReadOnly = true;
                dataSach.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                btnSuaSach.Text = "Hủy";
            }
            else
            {
                dataSach.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value = CellPrivous[0];
                dataSach.ReadOnly = true;
                btnSuaSach.Text = "Sửa";
            }

        }

        private void dataSach_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataSach.ReadOnly = true;
            if (btnSuaSach.Text == "Hủy")
            {
                btnSuaSach.Text = "Sửa";
                SuaDuLieu(Sach, dataSach);
            }
        }
        private void dataSach_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataSach.ReadOnly = true;
            if (btnSuaSach.Text == "Hủy")
            {
                btnSuaSach.Text = "Sửa";
                SuaDuLieu(Sach, dataSach);
            }
        }
        #endregion

        #region Thêm, sửa xóa Khách hàng
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            FormThemKhachHang formKH = new FormThemKhachHang(this);
            formKH.Show();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (btnSuaKH.Text == "Sửa")
            {
                CellPrivous[0] = dataKH.CurrentCell.Value.ToString();
                CellPrivous[1] = dataKH.CurrentCell.RowIndex;
                CellPrivous[2] = dataKH.CurrentCell.ColumnIndex;
                dataKH.ReadOnly = false;
                dataKH.Columns[1].ReadOnly = true;
                dataKH.Columns[0].ReadOnly = true;
                dataKH.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                btnSuaKH.Text = "Hủy";
            }
            else
            {
                dataKH.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value = CellPrivous[0];
                dataKH.ReadOnly = true;
                btnSuaKH.Text = "Sửa";
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            XoaDuLieu(KH, dataKH);
        }

        private void dataKH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataKH.ReadOnly = true;
            if (btnSuaKH.Text == "Hủy")
            {
                btnSuaKH.Text = "Sửa";
                SuaDuLieu(KH, dataKH);
            }
        }

        private void dataKH_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataKH.ReadOnly = true;
            if (btnSuaKH.Text == "Hủy")
            {
                btnSuaKH.Text = "Sửa";
                SuaDuLieu(KH, dataKH);
            }
        }


        #endregion

        #region Thêm, sửa xóa Nhân Viên
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formNV = new FormThemNhanVien(this);
            formNV.Show();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (btnSuaNV.Text == "Sửa")
            {
                CellPrivous[0] = dataNV.CurrentCell.Value.ToString();
                CellPrivous[1] = dataNV.CurrentCell.RowIndex;
                CellPrivous[2] = dataNV.CurrentCell.ColumnIndex;
                dataNV.ReadOnly = false;
                dataNV.Columns[1].ReadOnly = true;
                dataNV.Columns[0].ReadOnly = true;
                dataNV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                btnSuaNV.Text = "Hủy";
            }
            else
            {
                dataNV.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value = CellPrivous[0];
                dataNV.ReadOnly = true;
                btnSuaNV.Text = "Sửa";
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            XoaDuLieu(NV, dataNV);
        }

        private void dataNV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataNV.ReadOnly = true;
            if (btnSuaNV.Text == "Hủy")
            {
                btnSuaNV.Text = "Sửa";
                SuaDuLieu(NV, dataNV);
            }
        }

        private void dataNV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataNV.ReadOnly = true;
            if (btnSuaNV.Text == "Hủy")
            {
                btnSuaNV.Text = "Sửa";
                SuaDuLieu(NV, dataNV);
            }
        }



        #endregion

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnChiTietSach_Click(object sender, EventArgs e)
        {
            FormDetailSach dtS = new FormDetailSach(this);
            dtS.Show();
        }

        private void btnDetailKH_Click(object sender, EventArgs e)
        {
            FormDetailKH dtS = new FormDetailKH(this);
            dtS.Show();
        }

        private void btnDetailNV_Click(object sender, EventArgs e)
        {
            FormDetailNV dtS = new FormDetailNV(this);
            dtS.Show();
        }

        //Quản lý doanh thu
        #region Quản lý doanh thu
        private void btnXemDT_Click(object sender, EventArgs e)
        {
            string query = "Select MaDH as 'Mã đơn hàng', NgayXuat as 'Ngày xuất', TongTien as 'Tổng tiền', PTTT, MaKH as 'Mã KH', MaNV as 'Mã NV' From dbo.DonHang ";
            try
            {
                if (cbbFilter.SelectedItem == "Năm")
                {
                    object check = SQLConnector.MotGiaTri("Select SUM(TongTien) From dbo.DonHang where NgayXuat like '" + txtYear.Text + "%'");
                    if (check != null)
                    {
                        int main = int.Parse(check.ToString());
                        txtDTF.Text = String.Format("{0:0,0}", main) + " VNĐ";
                        dataHoaDonDT.DataSource = SQLConnector.Select(query + "where NgayXuat like '" + txtYear.Text + "%'").Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai dữ liệu, vui lòng kiểm tra lại!");
                    }

                }
                if (cbbFilter.SelectedItem == "Tháng")
                {
                    object check = SQLConnector.MotGiaTri("Select SUM(TongTien) From dbo.DonHang where NgayXuat like '" + txtYear.Text + "-" + txtMoth.Text + "%'");
                    if (check != null)
                    {
                        int main = int.Parse(check.ToString());
                        txtDTF.Text = String.Format("{0:0,0}", main) + " VNĐ";
                        dataHoaDonDT.DataSource = SQLConnector.Select(query + "where NgayXuat like '" + txtYear.Text + "-" + txtMoth.Text + "%'").Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai dữ liệu, vui lòng kiểm tra lại!");
                    }

                }
                if (cbbFilter.SelectedItem == "Ngày")
                {
                    object check = SQLConnector.MotGiaTri("Select SUM(TongTien) From dbo.DonHang where NgayXuat like '" + txtYear.Text + "-" + txtMoth.Text + "-" + txtDay.Text + "'");
                    if (check != null)
                    {
                        int main = int.Parse(check.ToString());
                        txtDTF.Text = String.Format("{0:0,0}", main) + " VNĐ";
                        dataHoaDonDT.DataSource = SQLConnector.Select(query + "where NgayXuat like '" + txtYear.Text + "-" + txtMoth.Text + "-" + txtDay.Text + "'").Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai dữ liệu, vui lòng kiểm tra lại!");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Lỗi, xin vui lòng thử lại");
            }
        }

        private void txtYear_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "Năm") txtYear.Text = "";
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text == "") txtYear.Text = "Năm";

        }

        private void txtMoth_Click(object sender, EventArgs e)
        {
            if (txtMoth.Text == "Tháng") txtMoth.Text = "";

        }
        private void txtMoth_Leave(object sender, EventArgs e)
        {
            if (txtMoth.Text == "") txtMoth.Text = "Tháng";

        }

        private void txtDay_Click(object sender, EventArgs e)
        {
            if (txtDay.Text == "Ngày") txtDay.Text = "";

        }

        private void txtDay_Leave(object sender, EventArgs e)
        {
            if (txtDay.Text == "") txtDay.Text = "Ngày";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormXemChiTiet xct = new FormXemChiTiet();
                xct.dataThongTin.DataSource = SQLConnector.Select("Select MaDH as 'Mã đơn hàng', MaSach as 'Mã sách', SoLuong as 'Số lượng', DonGia as 'Đơn giá' from dbo.ChiTietDonHang " +
                    "where MaDH = N'"+dataHoaDonDT.CurrentRow.Cells[1].Value.ToString()+"'").Tables[0];
                xct.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi, xin vui lòng thử lại");
            }
        }


    }
    #endregion



}
