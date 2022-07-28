using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BLL
{
    class ProductBLL
    {
        DAL.ProductDAL dalPro;

        public ProductBLL()
        {
            dalPro = new DAL.ProductDAL();
        }

        public DataTable getAllProduct()
        {
            return dalPro.getAllProduct();
        }

        public DataTable getcbCategory()
        {
            return dalPro.getcbCategory();
        }

        public DataTable getcbSuplier()
        {
            return dalPro.getcbSuplier();
        }

        public bool insertProduct(DTO.Product pro)
        {
            return dalPro.insertProduct(pro);
        }
        public bool updateProduct(DTO.Product pro)
        {
            return dalPro.updateProduct(pro);
        }

        public bool deleteProduct(DTO.Product pro)
        {
            return dalPro.deleteProduct(pro);
        }
    }
}
