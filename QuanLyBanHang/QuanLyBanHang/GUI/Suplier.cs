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
    public partial class Suplier : Form
    {
        BLL.SuplierBLL bllSup;

        public Suplier()
        {
            InitializeComponent();
            bllSup = new BLL.SuplierBLL();
        }

        public void showAllSuplier()
        {
            dataGridViewSuplier.DataSource = bllSup.getAllSuplier();
        }

        private void Suplier_Load(object sender, EventArgs e)
        {
            showAllSuplier();
        }

        int id;
        private void dataGridViewSuplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                id = Int32.Parse(dataGridViewSuplier.Rows[index].Cells[0].Value.ToString());
                txtNameSup.Text = dataGridViewSuplier.Rows[index].Cells[1].Value.ToString();
                txtPhoneSup.Text = dataGridViewSuplier.Rows[index].Cells[2].Value.ToString();
                txtAddressSup.Text = dataGridViewSuplier.Rows[index].Cells[3].Value.ToString();
                txtDescriptionSup.Text = dataGridViewSuplier.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            DTO.Suplier sup = new DTO.Suplier();
            sup.name = txtNameSup.Text;
            sup.phone = txtPhoneSup.Text;
            sup.address = txtAddressSup.Text;
            sup.description = txtDescriptionSup.Text;
            if (bllSup.insertSuplier(sup))
                showAllSuplier();
            else
                MessageBox.Show("có lỗi");
        }

        private void btnDeleteSup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá hay không", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DTO.Suplier sup = new DTO.Suplier();
                sup.id = id;
                if (bllSup.deleteCategory(sup))
                {
                    Refresh();
                    showAllSuplier();
                }    
                else
                    MessageBox.Show("Đã có lỗi");
            }
        }

        private void btnUpdateSup_Click(object sender, EventArgs e)
        {
            DTO.Suplier sup = new DTO.Suplier();
            sup.id = id;
            sup.name = txtNameSup.Text;
            sup.phone = txtPhoneSup.Text;
            sup.address = txtAddressSup.Text;
            sup.description = txtDescriptionSup.Text;
            if (bllSup.updateSuplier(sup))
                showAllSuplier();
            else
                MessageBox.Show("có lỗi");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            txtNameSup.Text = "";
            txtDescriptionSup.Text = "";
            txtPhoneSup.Text = "";
            txtAddressSup.Text = "";
        }
    }
}
