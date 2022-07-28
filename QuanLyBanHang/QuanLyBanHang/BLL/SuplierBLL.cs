using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BLL
{
    class SuplierBLL
    {
        DAL.SuplierDAL dalSup;

        public SuplierBLL()
        {
            dalSup = new DAL.SuplierDAL();
        }
        public DataTable getAllSuplier()
        {
            return dalSup.getAllSuplier();
        }

        public bool insertSuplier(DTO.Suplier sup)
        {
            return dalSup.insertSuplier(sup);
        }

        public bool deleteCategory(DTO.Suplier sup)
        {
            return dalSup.deleteSuplier(sup);
        }
        public bool updateSuplier(DTO.Suplier sup)
        {
            return dalSup.updateSuplier(sup);
        }
    }
}
