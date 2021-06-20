using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Desktop
{
    public partial class FormSQLCheck : Form
    {
        public FormSQLCheck(FormDangNhap fdn)
        {
            InitializeComponent();
            txtDataSource.Text = string.Format(@"{0}\SQLEXPRESS",Environment.MachineName);
            txtInitial.Text = "SQL_EndOfTerm";
            this.formDangNhap = fdn;
        }
        FormDangNhap formDangNhap;
        string SqlLink;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlLink = string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True",txtDataSource.Text,txtInitial.Text);          
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlLink))
                {
                    if (connection.State == System.Data.ConnectionState.Closed);
                    connection.Open();
                }
                MessageBox.Show("Kết nối thành công");
                formDangNhap.SQLConnector = new SQL(SqlLink);
                formDangNhap.Enabled = true;
                formDangNhap.WindowState = FormWindowState.Normal;
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Kết nối thất bại, xin vui lòng kiểm tra lại!");
            }
        }

        private void FormSQLCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formDangNhap.Enabled == false) Application.Exit();
        }
    }
}
