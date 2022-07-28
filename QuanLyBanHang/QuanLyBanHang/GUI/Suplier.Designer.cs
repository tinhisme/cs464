
namespace QuanLyBanHang.GUI
{
    partial class Suplier
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSup = new System.Windows.Forms.Button();
            this.btnDeleteSup = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.txtPhoneSup = new System.Windows.Forms.TextBox();
            this.txtNameSup = new System.Windows.Forms.TextBox();
            this.txtDescriptionSup = new System.Windows.Forms.RichTextBox();
            this.txtAddressSup = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSuplier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(864, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 49);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdateSup
            // 
            this.btnUpdateSup.Location = new System.Drawing.Point(734, 49);
            this.btnUpdateSup.Name = "btnUpdateSup";
            this.btnUpdateSup.Size = new System.Drawing.Size(75, 49);
            this.btnUpdateSup.TabIndex = 47;
            this.btnUpdateSup.Text = "Sửa";
            this.btnUpdateSup.UseVisualStyleBackColor = true;
            this.btnUpdateSup.Click += new System.EventHandler(this.btnUpdateSup_Click);
            // 
            // btnDeleteSup
            // 
            this.btnDeleteSup.Location = new System.Drawing.Point(609, 49);
            this.btnDeleteSup.Name = "btnDeleteSup";
            this.btnDeleteSup.Size = new System.Drawing.Size(75, 49);
            this.btnDeleteSup.TabIndex = 46;
            this.btnDeleteSup.Text = "Xoá";
            this.btnDeleteSup.UseVisualStyleBackColor = true;
            this.btnDeleteSup.Click += new System.EventHandler(this.btnDeleteSup_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Location = new System.Drawing.Point(482, 49);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(75, 49);
            this.btnAddSup.TabIndex = 45;
            this.btnAddSup.Text = "Thêm";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // txtPhoneSup
            // 
            this.txtPhoneSup.Location = new System.Drawing.Point(198, 99);
            this.txtPhoneSup.Name = "txtPhoneSup";
            this.txtPhoneSup.Size = new System.Drawing.Size(247, 26);
            this.txtPhoneSup.TabIndex = 44;
            // 
            // txtNameSup
            // 
            this.txtNameSup.Location = new System.Drawing.Point(198, 48);
            this.txtNameSup.Name = "txtNameSup";
            this.txtNameSup.Size = new System.Drawing.Size(247, 26);
            this.txtNameSup.TabIndex = 43;
            // 
            // txtDescriptionSup
            // 
            this.txtDescriptionSup.Location = new System.Drawing.Point(198, 164);
            this.txtDescriptionSup.Name = "txtDescriptionSup";
            this.txtDescriptionSup.Size = new System.Drawing.Size(247, 74);
            this.txtDescriptionSup.TabIndex = 42;
            this.txtDescriptionSup.Text = "";
            // 
            // txtAddressSup
            // 
            this.txtAddressSup.Location = new System.Drawing.Point(198, 253);
            this.txtAddressSup.Name = "txtAddressSup";
            this.txtAddressSup.Size = new System.Drawing.Size(247, 69);
            this.txtAddressSup.TabIndex = 41;
            this.txtAddressSup.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mô Tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // dataGridViewSuplier
            // 
            this.dataGridViewSuplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuplier.Location = new System.Drawing.Point(12, 355);
            this.dataGridViewSuplier.Name = "dataGridViewSuplier";
            this.dataGridViewSuplier.RowHeadersWidth = 62;
            this.dataGridViewSuplier.RowTemplate.Height = 28;
            this.dataGridViewSuplier.Size = new System.Drawing.Size(959, 223);
            this.dataGridViewSuplier.TabIndex = 49;
            this.dataGridViewSuplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuplier_CellClick);
            // 
            // Suplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 590);
            this.Controls.Add(this.dataGridViewSuplier);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdateSup);
            this.Controls.Add(this.btnDeleteSup);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.txtPhoneSup);
            this.Controls.Add(this.txtNameSup);
            this.Controls.Add(this.txtDescriptionSup);
            this.Controls.Add(this.txtAddressSup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Suplier";
            this.Text = "Suplier";
            this.Load += new System.EventHandler(this.Suplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSup;
        private System.Windows.Forms.Button btnDeleteSup;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.TextBox txtPhoneSup;
        private System.Windows.Forms.TextBox txtNameSup;
        private System.Windows.Forms.RichTextBox txtDescriptionSup;
        private System.Windows.Forms.RichTextBox txtAddressSup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSuplier;
    }
}