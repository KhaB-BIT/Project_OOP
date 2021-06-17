using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace OOP_Desktop
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        //Khai báo biến
        internal BookSmart Sach = new BookSmart("Select MaSach as 'Mã sách', Series as 'Series', TenSach as 'Tên sách', GiaBan as 'Đơn giá' from dbo.SanPham");
        internal BookSmart KH = new BookSmart("Select MaKH as 'Mã KH', TenKH as 'Tên khách hàng', GioiTinh as 'Giới tính', Phone as 'SĐT', DiaChi as 'Địa chỉ', Email from dbo.KhachHang");
        internal BookSmart NV = new BookSmart("Select MaNV as 'Mã NV', TenNV as 'Tên nhân viên', TaiKhoan as 'Tài khoản', MatKhau as 'Mật khẩu', Phone as 'SĐT', DiaChi as 'Địa chỉ' from dbo.NhanVien");
        internal SQL SQLConnector = new SQL(@"Data Source=BI\SQLEXPRESS;Initial Catalog=SQL_EndOfTerm;Integrated Security=True");

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in filterInfoCollection)
                cbbDevices.Items.Add(item.Name);
            cbbDevices.SelectedIndex = 0;
            BarCodeFunc();
        }

        //Các Event

        #region Nhập thông tin Khách hàng

        #endregion

        #region Nhập số series hoặc mã SP

        #endregion

        #region In hóa linh

        #endregion

        #region Xuất hóa đơn

        #endregion


        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Bitmap bitmap;
        DataTable hi = null;

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
                    try
                    {
                        if (hi == null)
                        {
                            hi = SQLConnector.Select(Sach.Query + " where Series = '" + result.ToString() + "'").Tables[0];
                        }
                        else
                        {
                            hi.ImportRow(SQLConnector.Select(Sach.Query + " where Series = '" + result.ToString() + "'").Tables[0].Rows[0]);
                        }
                        dataHoaDon.DataSource = hi;
                        timer1.Interval = 3000;
                        txtCheck.Invoke(new MethodInvoker(delegate ()
                        {
                            txtCheck.Text = result.Text;
                        }));
                    }
                    catch(Exception)
                    { }
                }    
            }
        }

        //Tạo thứ tự cho bảng------------------
        private void dataHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dataHoaDon.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void cbbDevices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            BarCodeFunc();
        }
    }
}
