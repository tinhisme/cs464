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
    public partial class Category1 : Form
    {
        BLL.CategoryBLL bllCate;
        Core core;
        public Category1()
        {
            InitializeComponent();
            bllCate = new BLL.CategoryBLL();
            core = new Core();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            showAllCate();
        }

        public void showAllCate()
        {
            dataGridViewCategory.DataSource = bllCate.getAllCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            DTO.Category cate = new DTO.Category();
            cate.name = txtNameCategory.Text;
            cate.description = txtDescriptionCategory.Text;

            if (bllCate.insertCategory(cate))
                showAllCate();
            else
                MessageBox.Show("Đã có lỗi");

        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            DTO.Category cate = new DTO.Category();
            cate.name = txtNameCategory.Text;
            cate.description = txtDescriptionCategory.Text;

            if (bllCate.insertCategory(cate))
                showAllCate();
            else
                MessageBox.Show("Đã có lỗi");
        }

        int id;
        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = 
                    Int32.Parse(dataGridViewCategory.Rows[index].Cells[0].Value.ToString());
                txtNameCategory.Text = 
                    dataGridViewCategory.Rows[index].Cells[1].Value.ToString();
                txtDescriptionCategory.Text =
                   dataGridViewCategory.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void txtUpdateCategory_Click(object sender, EventArgs e)
        {
            DTO.Category cate = new DTO.Category();
            cate.id = id;
            cate.name = txtNameCategory.Text;
            cate.description = txtDescriptionCategory.Text;

            if (bllCate.updateCategory(cate))
                showAllCate();
            else
                MessageBox.Show("Đã có lỗi");
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xoá hay không","Cảnh Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DTO.Category cate = new DTO.Category();
                cate.id = id;
                if (bllCate.deleteCategory(cate))
                    showAllCate();
                else
                    MessageBox.Show("Đã có lỗi");
            }
        }
    }
}
