
namespace QuanLyBanHang.GUI
{
    partial class Category1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.txtDescriptionCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô Tả";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(281, 65);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(240, 26);
            this.txtNameCategory.TabIndex = 3;
            // 
            // txtDescriptionCategory
            // 
            this.txtDescriptionCategory.Location = new System.Drawing.Point(281, 125);
            this.txtDescriptionCategory.Name = "txtDescriptionCategory";
            this.txtDescriptionCategory.Size = new System.Drawing.Size(240, 26);
            this.txtDescriptionCategory.TabIndex = 4;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(103, 181);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(94, 50);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Thêm Mới";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(12, 237);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 62;
            this.dataGridViewCategory.RowTemplate.Height = 28;
            this.dataGridViewCategory.Size = new System.Drawing.Size(776, 253);
            this.dataGridViewCategory.TabIndex = 6;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(254, 181);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(94, 50);
            this.btnUpdateCategory.TabIndex = 7;
            this.btnUpdateCategory.Text = "Sửa";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.txtUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(416, 181);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(94, 50);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "Xoá";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // Category1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtDescriptionCategory);
            this.Controls.Add(this.txtNameCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Category1";
            this.Text = "Danh Mục";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.TextBox txtDescriptionCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
    }
}