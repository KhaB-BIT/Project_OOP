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
    public partial class FormDetailNV : Form
    {
        public FormDetailNV(FormQuanLy fql)
        {
            InitializeComponent();
            txtSeries.Text = fql.dataNV.CurrentRow.Cells[1].Value.ToString();
            txtMaTL.Text = fql.dataNV.CurrentRow.Cells[2].Value.ToString();
            txtTenSach.Text = fql.dataNV.CurrentRow.Cells[3].Value.ToString();
            txtSoLuong.Text = fql.dataNV.CurrentRow.Cells[4].Value.ToString();
            txtGiaNhap.Text = fql.dataNV.CurrentRow.Cells[5].Value.ToString();
            txtGiaBan.Text = fql.dataNV.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
