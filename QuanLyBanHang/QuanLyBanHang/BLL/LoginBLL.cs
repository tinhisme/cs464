using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BLL
{
    class LoginBLL
    {
        DAL.LoginDAL dalLogin;

        public LoginBLL()
        {
            dalLogin = new DAL.LoginDAL();
        }
        public int Login(string username, string password)
        {
            return dalLogin.Login(username, password);
        }
    }
}

