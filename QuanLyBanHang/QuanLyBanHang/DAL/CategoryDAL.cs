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
    class CategoryDAL 
    {
        Core core;
        SqlCommand cmd;
        public CategoryDAL()
        {
            core = new Core();
        }

        public DataTable getAllCategory()
        {
            string sql = "select * from category";
            return core.ShowDataInGridView(sql);
        }

        public bool insertCategory(DTO.Category cate)
        {
            string sql = "insert into Category(Namecategory, description) values(@name,@description)";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cate.name;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = cate.description;
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool updateCategory(DTO.Category cate)
        {
            string sql = "UPDATE  Category set Namecategory = @name, description = @description where id = @id";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cate.id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cate.name;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = cate.description;
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool deleteCategory(DTO.Category cate)
        {
            string sql = "Delete from Category where id = @id";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cate.id;
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
