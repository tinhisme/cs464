using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    class Product
    {
        public int id { get; set; }
        public string nameProduct { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public string image { get; set; }
        public int category_id { get; set; }
        public int suplier_id { get; set; }
    }
}
