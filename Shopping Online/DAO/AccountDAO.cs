using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Online.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public bool IDExist(string userName)
        {
            string query = "Select * from NGUOIDUNG where TenDangNhap ='" + userName + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public void InsertUser(string ID, string Pass, string Name)
        {
            string query = "Insert into NGUOIDUNG values('" + ID + "', '" + Pass + "', '" + Name + "')";
            DataProvider.Instance.ExecuteQuery(query);
        }
        
    }
}
