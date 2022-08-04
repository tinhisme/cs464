using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class Product : Form
    {
        BLL.ProductBLL bllPro;
        public Product()
        {
            InitializeComponent();
            bllPro = new BLL.ProductBLL();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadcbCategory();
            LoadcbSuplier();
            showAllProduct();
        }

        public void showAllProduct()
        {
            dataGridViewProduct.DataSource = bllPro.getAllProduct();
        }

        public void LoadcbCategory()
        {
            cbCategory.DataSource = bllPro.getcbCategory();
            cbCategory.DisplayMember = "namecategory";
            cbCategory.ValueMember = "Id";
        }

        public void LoadcbSuplier()
        {
            cbSuplier.DataSource = bllPro.getcbSuplier();
            cbSuplier.DisplayMember = "namesuplier";
            cbSuplier.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO.Product pro = new DTO.Product();
            pro.nameProduct = txtName.Text;
            pro.quantity = int.Parse(txtQuantity.Text);
            pro.price = float.Parse(txtPrice.Text);
            pro.category_id = int.Parse(cbCategory.SelectedValue.ToString());
            pro.suplier_id = int.Parse(cbSuplier.SelectedValue.ToString());

            if (bllPro.insertProduct(pro))
                showAllProduct();
            else
                MessageBox.Show("có lỗi");
        }
        int id;
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //if (index >= 0)
            //{
            //    id = Int32.Parse(dataGridViewProduct.Rows[index].Cells["id"].Value.ToString());
            //    txtName.Text = dataGridViewProduct.Rows[index].Cells["nameproduct"].Value.ToString();
            //    txtQuantity.Text = dataGridViewProduct.Rows[index].Cells["quantity"].Value.ToString();
            //    txtPrice.Text = dataGridViewProduct.Rows[index].Cells["price"].Value.ToString();
            //    cbCategory.Text = dataGridViewProduct.Rows[index].Cells["category_id"].Value.ToString();
            //    cbSuplier.Text = dataGridViewProduct.Rows[index].Cells["suplier_id"].Value.ToString();
            //}
            id = Int32.Parse(dataGridViewProduct.CurrentRow.Cells["id"].Value.ToString());
            txtName.Text = dataGridViewProduct.CurrentRow.Cells["nameproduct"].Value.ToString();
            txtQuantity.Text = dataGridViewProduct.CurrentRow.Cells["quantity"].Value.ToString();
            txtPrice.Text = dataGridViewProduct.CurrentRow.Cells["price"].Value.ToString();
            cbCategory.SelectedValue = dataGridViewProduct.CurrentRow.Cells["category_id"].Value.ToString();
            cbSuplier.SelectedValue = dataGridViewProduct.CurrentRow.Cells["suplier_id"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá hay không", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DTO.Product sup = new DTO.Product();
                sup.id = id;
                if (bllPro.deleteProduct(sup))
                {
                    Refresh();
                    showAllProduct();
                }
                else
                    MessageBox.Show("Đã có lỗi");
            }
        }

        public void Refresh()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DTO.Product pro = new DTO.Product();
            pro.id = id;
            pro.nameProduct = txtName.Text;
            pro.quantity = int.Parse(txtQuantity.Text);
            pro.price = float.Parse(txtPrice.Text);
            pro.category_id = int.Parse(cbCategory.SelectedValue.ToString());
            pro.suplier_id = int.Parse(cbSuplier.SelectedValue.ToString());
            if (bllPro.updateProduct(pro))
                showAllProduct();
            else
                MessageBox.Show("có lỗi");
        }
    }
}
