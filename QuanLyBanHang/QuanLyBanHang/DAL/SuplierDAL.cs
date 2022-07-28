using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.DAL
{
    class SuplierDAL
    {
        Core core;
        SqlCommand cmd;
        public SuplierDAL()
        {
            core = new Core();
        }

        public DataTable getAllSuplier()
        {
            string sql = "select * from suplier";
            return core.ShowDataInGridView(sql);
        }

        public bool insertSuplier(DTO.Suplier sup)
        {
            string sql = "insert into suplier(namesuplier,phone,address, description) values(@name,@phone,@address,@description)";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = sup.name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = sup.address;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = sup.phone;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = sup.description;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool updateSuplier(DTO.Suplier sup)
        {
            string sql = "UPDATE  suplier set namesuplier = @name,address = @address, phone = @phone ,description = @description where id = @id";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = sup.id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = sup.name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = sup.address;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = sup.phone;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = sup.description;
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool deleteSuplier(DTO.Suplier sup)
        {
            string sql = "Delete from suplier where id = @id";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = sup.id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
