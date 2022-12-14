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
    public partial class Login : Form
    {
        BLL.LoginBLL bllLogin;
        Core core;
        public Login()
        {
            InitializeComponent();
            bllLogin = new BLL.LoginBLL();
            core = new Core();
        }

        int dem = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DTO.Account acc = new DTO.Account();
            acc.username = txtUsername.Text;
            acc.password = txtPassword.Text;

            if (bllLogin.Login(acc.username, acc.password) >= 1)
            {
                this.Hide();
                GUI.Index index = new Index();
                index.Show();
            }    
            else
            {
                dem++;
                MessageBox.Show("Lỗi đăng nhập lần " + dem);
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần. Thoát chương trình");
                    Application.Exit();
                }
            }    
        }
    }
}
