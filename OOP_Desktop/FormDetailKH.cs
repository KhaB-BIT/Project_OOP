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
    public partial class FormDetailKH : Form
    {
        public FormDetailKH(FormQuanLy fql)
        {
            InitializeComponent();
            txtSeries.Text = fql.dataKH.CurrentRow.Cells[1].Value.ToString();
            txtMaTL.Text = fql.dataKH.CurrentRow.Cells[2].Value.ToString();
            txtTenSach.Text = fql.dataKH.CurrentRow.Cells[3].Value.ToString();
            txtSoLuong.Text = fql.dataKH.CurrentRow.Cells[4].Value.ToString();
            txtGiaNhap.Text = fql.dataKH.CurrentRow.Cells[5].Value.ToString();
            txtGiaBan.Text = fql.dataKH.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
