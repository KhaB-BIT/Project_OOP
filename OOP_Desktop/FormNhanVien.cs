using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace OOP_Desktop
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien(FormDangNhap fdn)
        {
            InitializeComponent();
            this.formDangNhap = fdn;
            this.SQLConnector = fdn.SQLConnector;

            //Thời gian lập hóa đơn
            DateTime date = DateTime.Now;
            txtDate.Text = date.ToString("yyyy-MM-dd");

            //Thông tin nhân viên
            txtMaNV.Text = SQLConnector.MotGiaTri("Select MaNV from dbo.NhanVien where TaiKhoan =N'" + formDangNhap.txtTaiKhoan.Text + "'").ToString();
            txtTenNV.Text = SQLConnector.MotGiaTri("Select TenNV from dbo.NhanVien where TaiKhoan =N'" + formDangNhap.txtTaiKhoan.Text + "'").ToString();

            //Get mã hóa đơn
            GetMaHD();
        }

        FormDangNhap formDangNhap;

        //Khai báo biến----------------------------
        #region Khai báo biến
        internal BookSmart Sach = new BookSmart("Select MaSach as 'Mã sách', TenSach as 'Tên sách', GiaBan as 'Đơn giá' from dbo.SanPham");
        internal BookSmart KH = new BookSmart("Select MaKH as 'Mã KH', TenKH as 'Tên khách hàng', GioiTinh as 'Giới tính', Phone as 'SĐT', DiaChi as 'Địa chỉ', Email from dbo.KhachHang");
        internal BookSmart NV = new BookSmart("Select MaNV as 'Mã NV', TenNV as 'Tên nhân viên', Phone as 'SĐT', DiaChi as 'Địa chỉ' from dbo.NhanVien");
        internal SQL SQLConnector;// = new SQL(@"Data Source=BI\SQLEXPRESS;Initial Catalog=SQL_EndOfTerm;Integrated Security=True");
        object[] CellPrivous = new object[3];
        DataTable hi = null;
        double Total;
        int vitridong = 275;
        #endregion  

        //Formload---------------------------------
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            #region Khởi tạo thiết bị BarCode
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in filterInfoCollection)
                cbbDevices.Items.Add(item.Name);
            cbbDevices.SelectedIndex = 0;
            BarCodeFunc();
            #endregion
            
        }


        //Các Event------------------------------

        #region Effects
        private void txtMaSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
        }
        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") txtMaSP.Text = "Nhập mã sản phẩm hoặc series*";
        }

        private void txtSoDienThoai_Click(object sender, EventArgs e)
        {
            txtSoDienThoai.Text = "";
        }
        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "") txtSoDienThoai.Text = "Nhập số điện thoại khách hàng*";
        }

        #endregion

        #region Nhập thông tin Khách hàng
        private void btnNhapSDT_Click(object sender, EventArgs e)
        {
            try
            {
                if (SQLConnector.MotGiaTri("Select TenKH from dbo.KhachHang where Phone =N'" + txtSoDienThoai.Text + "'") != null)
                {
                    txtMaKH.Text = SQLConnector.MotGiaTri("Select MaKH from dbo.KhachHang where Phone =N'" + txtSoDienThoai.Text + "'").ToString();
                    txtTenKH.Text = SQLConnector.MotGiaTri("Select TenKH from dbo.KhachHang where Phone =N'" + txtSoDienThoai.Text + "'").ToString();
                }
                else MessageBox.Show("Không tìm thấy");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi, vui lòng thử lại!");
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            FormThemKhachHang formTKH = new FormThemKhachHang(this);
            formTKH.Show();
        }
        #endregion

        #region Nhập số series hoặc mã SP
        private void btnNhapMaSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (SQLConnector.MotGiaTri(Sach.Query + " where Series = '" + txtMaSP.Text + "'") != null)
                {
                    int check = int.Parse(SQLConnector.MotGiaTri("Select SoLuong from dbo.SanPham" + " where Series = '" + txtMaSP.Text + "'").ToString());
                    if(check > 0)
                    {
                        if (hi == null)
                        {
                            hi = SQLConnector.Select(Sach.Query + " where Series = '" + txtMaSP.Text + "'").Tables[0];
                            dataHoaDon.DataSource = hi;
                            dataHoaDon.Columns.Add("SoLuong", "Số lượng");
                            dataHoaDon.ReadOnly = false;
                            dataHoaDon.Columns[0].ReadOnly = true;
                            dataHoaDon.Columns[1].ReadOnly = true;
                            dataHoaDon.Columns[2].ReadOnly = true;
                            Total = 0;
                            dataHoaDon.Rows[dataHoaDon.Rows.Count - 1].Cells[3].Value = "1";
                            ThanhTien();
                        }
                        else
                        {
                            //Kiểm tra SP trùng
                            string checkSP = SQLConnector.MotGiaTri("Select MaSach from dbo.SanPham" + " where Series = '" + txtMaSP.Text + "'").ToString();
                            bool checkbool = true;
                            for (int i = 0; i < dataHoaDon.Rows.Count; i++)
                            {
                                if (dataHoaDon.Rows[i].Cells[0].Value.ToString() == checkSP)
                                {
                                    dataHoaDon.Rows[i].Cells[3].Value = (int.Parse(dataHoaDon.Rows[i].Cells[3].Value.ToString()) + 1).ToString();
                                    if (int.Parse(dataHoaDon.Rows[i].Cells[3].Value.ToString()) > check)
                                    {
                                        MessageBox.Show("Không đủ số lượng sản phẩm");
                                        dataHoaDon.Rows[i].Cells[3].Value = "1";
                                    }
                                    TinhLaiTien();
                                    checkbool = false;
                                    break;
                                }    
                            }    
                            if (checkbool == true)
                            {
                                hi.ImportRow(SQLConnector.Select(Sach.Query + " where Series = '" + txtMaSP.Text + "'").Tables[0].Rows[0]);
                                dataHoaDon.DataSource = hi; 
                                dataHoaDon.Rows[dataHoaDon.Rows.Count - 1].Cells[3].Value = "1";
                                ThanhTien();
                            }    
                        }
                    }
                    else MessageBox.Show("Sản phẩm hết hàng");
                }
                else MessageBox.Show("Không tìm thấy");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi, vui lòng thử lại!");
            }

        }
        #endregion

        #region Xem chi tiết KH, NV

        private void btnChiTietNV_Click(object sender, EventArgs e)
        {
            FormXemChiTiet formCT = new FormXemChiTiet();
            formCT.dataThongTin.DataSource = SQLConnector.Select(NV.Query + "where TaiKhoan=N'" + formDangNhap.txtTaiKhoan.Text + "'").Tables[0];
            formCT.Show();
        }

        private void btnChiTietKH_Click(object sender, EventArgs e)
        {
            FormXemChiTiet formCT = new FormXemChiTiet();
            formCT.dataThongTin.DataSource = SQLConnector.Select(KH.Query + "where MaKH=N'" + txtMaKH.Text + "'").Tables[0];
            formCT.Show();
        }
        #endregion

        #region Xử lí BarCode
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void BarCodeFunc()
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbDevices.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }
        
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptbCheck.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            Application.Exit();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            if (ptbCheck.Image != null)
            {
                
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)ptbCheck.Image);
                if (result != null)
                {
                    timer1.Interval = 3000;
                    txtCheck.Invoke(new MethodInvoker(delegate ()
                    {
                        txtCheck.Text = result.Text;
                    }));
                    try
                    {
                        if (SQLConnector.MotGiaTri(Sach.Query + " where Series = '" + result.ToString() + "'") != null)
                        {
                            int check = int.Parse(SQLConnector.MotGiaTri("Select SoLuong from dbo.SanPham" + " where Series = '" + result.ToString() + "'").ToString());
                            if (check > 0)
                            {
                                if (hi == null)
                                {
                                    hi = SQLConnector.Select(Sach.Query + " where Series = '" + result.ToString() + "'").Tables[0];
                                    dataHoaDon.DataSource = hi;
                                    dataHoaDon.Columns.Add("SoLuong", "Số lượng");
                                    dataHoaDon.ReadOnly = false;
                                    dataHoaDon.Columns[0].ReadOnly = true;
                                    dataHoaDon.Columns[1].ReadOnly = true;
                                    dataHoaDon.Columns[2].ReadOnly = true;
                                    Total = 0;
                                    dataHoaDon.Rows[dataHoaDon.Rows.Count - 1].Cells[3].Value = "1";
                                    ThanhTien();
                                }
                                else
                                {
                                    string checkSP = SQLConnector.MotGiaTri("Select MaSach from dbo.SanPham" + " where Series = '" + result.ToString() + "'").ToString();
                                    bool checkbool = true;
                                    for (int i = 0; i < dataHoaDon.Rows.Count; i++)
                                    {
                                        if (dataHoaDon.Rows[i].Cells[0].Value.ToString() == checkSP)
                                        {
                                            dataHoaDon.Rows[i].Cells[3].Value = (int.Parse(dataHoaDon.Rows[i].Cells[3].Value.ToString()) + 1).ToString();
                                            if (int.Parse(dataHoaDon.Rows[i].Cells[3].Value.ToString()) > check)
                                            {
                                                MessageBox.Show("Không đủ số lượng sản phẩm");
                                                dataHoaDon.Rows[i].Cells[3].Value = "1";
                                            }
                                            TinhLaiTien();
                                            checkbool = false;
                                            break;
                                        }
                                    }
                                    if (checkbool == true)
                                    {
                                        hi.ImportRow(SQLConnector.Select(Sach.Query + " where Series = '" + result.ToString() + "'").Tables[0].Rows[0]);
                                        dataHoaDon.DataSource = hi;
                                        dataHoaDon.Rows[dataHoaDon.Rows.Count - 1].Cells[3].Value = "1";
                                        ThanhTien();
                                    }
                                }
                            }
                            else MessageBox.Show("Sản phẩm hết hàng");
                        }
                        else MessageBox.Show("Không tìm thấy");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi, vui lòng thử lại!");
                    }

                    
                }    
            }
        }
        private void cbbDevices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            BarCodeFunc();
        }
        #endregion

        #region Tạo thứ tự cho bảng
        private void dataHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dataHoaDon.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void dataHoaDon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {


        }
        #endregion

        #region Xóa SP
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dataHoaDon.Rows.Count > 0)
            {
                dataHoaDon.Rows.RemoveAt(dataHoaDon.CurrentRow.Index);
                if (dataHoaDon.Rows.Count < 1)
                {
                    txtThanhTien.Text = "0 VNĐ";
                }
                else
                {
                    TinhLaiTien();
                }
            }
            else MessageBox.Show("Không có sản phẩm nào để xóa");

        }
        #endregion

        #region Sửa số lượng
        private void dataHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string query = "Select SoLuong from dbo.SanPham" + " where MaSach = '" + dataHoaDon.Rows[(int)CellPrivous[1]].Cells[0].Value + "'";
            int check = int.Parse(dataHoaDon.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value.ToString());
            if (int.Parse(SQLConnector.MotGiaTri(query).ToString()) < check)
            {
                dataHoaDon.Rows[(int)CellPrivous[1]].Cells[(int)CellPrivous[2]].Value = "1";
                MessageBox.Show("Không còn đủ số lượng sản phẩm");
            }
            TinhLaiTien();

        }
        private void dataHoaDon_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellPrivous[1] = e.RowIndex;
            CellPrivous[2] = e.ColumnIndex;
        }
        #endregion

        #region Thành tiền
        private void ThanhTien()
        {
            double gia = double.Parse(dataHoaDon.Rows[dataHoaDon.Rows.Count - 1].Cells[2].Value.ToString());
            int soluong = int.Parse(dataHoaDon.Rows[dataHoaDon.Rows.Count - 1].Cells[3].Value.ToString());
            Total += (int)gia * (int)soluong;
            txtThanhTien.Text = String.Format("{0:0,0}", Total) + " VNĐ";
        }

        private void TinhLaiTien()
        {
            Total = 0;
            for (int i = 0; i < dataHoaDon.Rows.Count; i++)
            {
                double gia = double.Parse(dataHoaDon.Rows[i].Cells[2].Value.ToString());
                int soluong = int.Parse(dataHoaDon.Rows[i].Cells[3].Value.ToString());
                Total += (int)gia * (int)soluong;
            }
            txtThanhTien.Text = String.Format("{0:0,0}", Total) + " VNĐ";
        }
        #endregion

        #region Xuất hóa đơn
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (dataHoaDon.Rows.Count > 0)
            {
                try
                {
                    InHoaDon();
                    vitridong = 275;
                    SQLConnector.ExcuteQuery("Update dbo.DonHang Set NgayXuat=N'" + txtDate.Text + "',TongTien=N'" + Total
                        + "',PTTT=N'" + "Tiền mặt" + "',MaKH=N'" + txtMaKH.Text + "',MaNV=N'" + txtMaNV.Text + "' where PTTT=N'"+ txtMaNV.Text + "GetBillCode'");
                    for (int i = 0; i < dataHoaDon.Rows.Count; i++)
                    {
                        string query = "Insert dbo.ChiTietDonHang values (N'"+txtMaHD.Text+"',N'"+ dataHoaDon.Rows[i].Cells[0].Value.ToString() 
                            + "',N'"+ dataHoaDon.Rows[i].Cells[3].Value.ToString() + "',N'"+ dataHoaDon.Rows[i].Cells[2].Value.ToString() + "')";
                        SQLConnector.ExcuteQuery(query);
                        query = "UPDATE dbo.SanPham SET Soluong = Soluong - " + dataHoaDon.Rows[i].Cells[3].Value.ToString()
                            + " WHERE MaSach = N'" + dataHoaDon.Rows[i].Cells[0].Value.ToString() + "'";
                        SQLConnector.ExcuteQuery(query);
                    }
                    hi = null;
                    dataHoaDon.DataSource = null;
                    dataHoaDon.Columns.RemoveAt(0);
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    TinhLaiTien();
                    GetMaHD();
                    MessageBox.Show("Thao tác được thực hiện");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else MessageBox.Show("Không thể xuất hóa đơn vì chưa có sản phẩm được chọn");
        }
        #endregion

        #region In hóa linh
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BookSmart", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(70, 25));
            e.Graphics.DrawString("Địa: Cửa hàng sách BookSmart HCM", new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Blue, new Point(10, 75));
            e.Graphics.DrawString("Email: booksmart@gmail.com", new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Mã nhân viên: " + txtMaNV.Text, new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Blue, new Point(10, 125));
            e.Graphics.DrawString("Tên nhân viên: " + txtTenNV.Text, new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Blue, new Point(10, 150));
            e.Graphics.DrawString("Mã hóa đơn: " + txtMaHD.Text, new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Blue, new Point(10, 175));
            e.Graphics.DrawString("Ngày xuất: " + txtDate.Text, new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Blue, new Point(10, 200));
            e.Graphics.DrawString("===================================================================", new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.DarkRed, new Point(10, 225));
            e.Graphics.DrawString("Tên sản phẩm                Số lượng            Đơn giá     ", new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Blue, new Point(10, 250));
            for(int i=0; i < dataHoaDon.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataHoaDon.Rows[i].Cells[1].Value.ToString(), new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Black, new Point(10, vitridong));
                e.Graphics.DrawString(dataHoaDon.Rows[i].Cells[3].Value.ToString(), new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Black, new Point(150, vitridong));
                e.Graphics.DrawString(String.Format("{0:0,0}",int.Parse(dataHoaDon.Rows[i].Cells[2].Value.ToString())), new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Black, new Point(210, vitridong));
                vitridong += 25;
            }    

            e.Graphics.DrawString("===================================================================", new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.DarkRed, new Point(10, vitridong));
            e.Graphics.DrawString("Thành tiền:   " + String.Format("{0:0,0}", Total) + " VNĐ", new Font("Microsoft Sans Serif", 8, FontStyle.Bold), Brushes.Blue, new Point(115, vitridong+25));
            e.Graphics.DrawString("BookSmart xin cảm ơn và hẹn gặp lại", new Font("Microsoft Sans Serif", 8, FontStyle.Italic), Brushes.Blue, new Point(40, vitridong+70));
        }

        private void InHoaDon()
        {
            int lenght = 0;
            for (int i = 0; i < dataHoaDon.Rows.Count; i++)
                lenght += 25;
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprmn", 280, vitridong + lenght + 140);
            printPreviewDialog1.ShowDialog();
        }
        #endregion

        //Cập nhật thời gian tạo hóa đơn------------
        private void TimeNgay_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtDate.Text = date.ToString("yyyy-MM-dd");
        }
        //Get mã hóa đơn
        private void GetMaHD()
        {
            object main = SQLConnector.MotGiaTri("Select MaDH from dbo.DonHang where PTTT=N'" + txtMaNV.Text + "GetBillCode'");
            if(main != null)
            {
                txtMaHD.Text = main.ToString();
            }  
            else
            {
                SQLConnector.ExcuteQuery("INSERT dbo.DonHang (NgayXuat,TongTien,PTTT) VALUES (N'" + txtDate.Text + "',N'" + 0 + "',N'" + txtMaNV.Text + "GetBillCode')");
                main = SQLConnector.MotGiaTri("Select MaDH from dbo.DonHang where PTTT=N'" + txtMaNV.Text + "GetBillCode'");
                txtMaHD.Text = main.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
        }
    }
}
