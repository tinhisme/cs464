using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            GUI.Category1 cate = new Category1();
            cate.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            GUI.Product pro = new Product();
            pro.Show();
        }

        private void btnSuplier_Click(object sender, EventArgs e)
        {
            GUI.Suplier sup = new Suplier();
            sup.Show();
        }
    }
}
