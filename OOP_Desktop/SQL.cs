using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Desktop
{
    public class SQL
    {
        public SQL(string server)
        {
            this.sQLlink = server;
        }

        private string sQLlink;

        public string SQLlink { get => sQLlink; set => sQLlink = value; }

        public object MotGiaTri(string query)
        {
            object data =null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.SQLlink))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    data = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch(Exception)
            {

            }       
            return data;
        }



        public DataSet Select(string query)
        {
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(this.SQLlink))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }


        public void ExcuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(this.SQLlink))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        public double Count(string TableName)
        {
            double data = -1;
            string query = "select COUNT(*) from " + TableName;
            using (SqlConnection connection = new SqlConnection(this.sQLlink))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = (int)command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public double Sum(string TableName, string Column)
        {
            double data = -1;
            string query = "select SUM(Column) from " + TableName;
            using (SqlConnection connection = new SqlConnection(this.sQLlink))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = (int)command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}
