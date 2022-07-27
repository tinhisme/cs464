using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BLL
{
    class CategoryBLL
    {
        DAL.CategoryDAL dalCate;

        public CategoryBLL()
        {
            dalCate = new DAL.CategoryDAL();
        }

        public DataTable getAllCategory()
        {
            return dalCate.getAllCategory();
        }

        public bool insertCategory(DTO.Category cate)
        {
            return dalCate.insertCategory(cate);
        }

        public bool deleteCategory(DTO.Category cate)
        {
            return dalCate.deleteCategory(cate);
        }
        public bool updateCategory(DTO.Category cate)
        {
            return dalCate.updateCategory(cate);
        }
    }
}
