using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    class Core
    {
        string stringConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\CS464\DACN\QuanLyBanHang\QuanLyBanHang\BanHang.mdf;Integrated Security=True";
        SqlConnection connection;
        public Core()
        {
            connection = new SqlConnection(stringConnect);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(stringConnect);
        }

        public void Open()
        {
            connection = new SqlConnection(stringConnect);
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public int Scalar(string sql)
        {
            connection.Open();
            SqlCommand comm = new SqlCommand(sql, connection);
            int result = (int)comm.ExecuteScalar();
            connection.Close();
            return result;
        }

        public DataTable ShowDataInGridView(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                Close();
            }
            return dt;
        }

        public DataTable showCombobox(string query)
        {
            connection.Open();
            Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
