using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL
{
    class ProductDAL
    {
        Core core;
        SqlCommand cmd;
        public ProductDAL()
        {
            core = new Core();
        }

        public DataTable getcbCategory()
        {
            string sql = "select id,namecategory from category";
            return core.ShowDataInGridView(sql);
        }

        public DataTable getcbSuplier()
        {
            string sql = "select * from suplier";
            return core.ShowDataInGridView(sql);
        }

        public DataTable getAllProduct()
        {
            string sql = "select * from product";
            return core.ShowDataInGridView(sql);
        }

        public bool insertProduct(DTO.Product pro)
        {
            string sql = "insert into product(Nameproduct,quantity,price,category_id,suplier_id) values(@name,@quantity,@price,@category_id,@suplier_id)";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = pro.nameProduct;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = pro.quantity;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = pro.price;
                cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = pro.category_id;
                cmd.Parameters.Add("@suplier_id", SqlDbType.Int).Value = pro.suplier_id;
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool updateProduct(DTO.Product pro)
        {
            string sql = "UPDATE  product set nameproduct = @name, quantity = @quantity, price = @price, category_id = @category_id, suplier_id =@suplier_id where id = @id";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = pro.id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = pro.nameProduct;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = pro.quantity;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = pro.price;
                cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = pro.category_id;
                cmd.Parameters.Add("@suplier_id", SqlDbType.Int).Value = pro.suplier_id;
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public bool deleteProduct(DTO.Product pro)
        {
            string sql = "Delete from product where id = @id";
            SqlConnection conn = core.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = pro.id;
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
