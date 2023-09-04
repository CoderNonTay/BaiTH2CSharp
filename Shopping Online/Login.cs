using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Online.DAO;

namespace Shopping_Online
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bShowPass_Click(object sender, EventArgs e)
        {
            if (txbPassWord.PasswordChar=='*')
            {
                bHidePass.BringToFront();
                txbPassWord.PasswordChar = '\0';
            }
        }

        private void bHidePass_Click(object sender, EventArgs e)
        {
            if (txbPassWord.PasswordChar == '\0')
            {
                bShowPass.BringToFront();
                txbPassWord.PasswordChar = '*';
            }
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            const string message =
   "Do you want to exit?";
            const string caption = "Exit App!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register Register = new Register();
            Register.ShowDialog();
        }

        bool Login_Check(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);

        }
        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;


            if (Login_Check(username, password))
            {
                Global.dt.Columns.Add("Mã sản phẩm", typeof(int));
                Global.dt.Columns.Add("Sản phẩm", typeof(string));
                Global.dt.Columns.Add("Giá", typeof(int));
                Global.dt.Columns.Add("Số lượng", typeof(int));
                Global.current_user = username;
                Home f = new Home();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void txbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bLogin_Click(this, new EventArgs());
            }
        }
    }
}
