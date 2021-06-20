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
    public partial class FormDetailSach : Form
    {
        public FormDetailSach(FormQuanLy fql)
        {
            InitializeComponent();
            txtMaSach.Text = fql.dataSach.CurrentRow.Cells[1].Value.ToString();
            txtSeries.Text = fql.dataSach.CurrentRow.Cells[2].Value.ToString();
            txtMaTL.Text = fql.dataSach.CurrentRow.Cells[3].Value.ToString();
            txtTenSach.Text = fql.dataSach.CurrentRow.Cells[4].Value.ToString();
            txtSoLuong.Text = fql.dataSach.CurrentRow.Cells[5].Value.ToString();
            txtGiaNhap.Text = fql.dataSach.CurrentRow.Cells[6].Value.ToString();
            txtGiaBan.Text = fql.dataSach.CurrentRow.Cells[7].Value.ToString();
        }

    }
    
}
