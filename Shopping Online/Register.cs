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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }



        private void pb_exit_Click(object sender, EventArgs e)
        {
            const string message =
"Do you want to exit?";
            const string caption = "Exit register!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login form = new Login();
                form.ShowDialog();
            }
        }
        bool IDExist(string ID)
        {
            return AccountDAO.Instance.IDExist(ID);
        }
        private void bt_Register_Click(object sender, EventArgs e)
        {
            string ID = tb_ID.Text;

            if (IDExist(ID))
            {
                MessageBox.Show("ID already exists!");
            }
            else
            {
                AccountDAO.Instance.InsertUser(tb_ID.Text, tb_Pass.Text, tb_Name.Text);
                MessageBox.Show("Register success!");
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void bShowPass_Click(object sender, EventArgs e)
        {
            if (tb_Pass.PasswordChar=='*')
            {
                bHidePass.BringToFront();
                tb_Pass.PasswordChar = '\0';
            }
        }

        private void bHidePass_Click(object sender, EventArgs e)
        {
            if (tb_Pass.PasswordChar == '\0')
            {
                bShowPass.BringToFront();
                tb_Pass.PasswordChar = '*';
            }
        }
    }
}
