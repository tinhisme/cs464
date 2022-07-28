using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL
{
    class LoginDAL
    {
        Core core;
        SqlCommand cmd;
        public LoginDAL()
        {
            core = new Core();
        }

        public int Login(string username, string password)
        {
            string sql = "select count(*) from account where username = '" + username + "' and password = '" + password + "' ";
            return core.Scalar(sql);
        }
    }
}
