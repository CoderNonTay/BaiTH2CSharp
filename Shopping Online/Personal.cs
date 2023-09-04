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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            const string message =
   "Do you want to return home?";
            const string caption = "Return home!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Home home = new Home();
                home.Show();
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HOADON WHERE ID = N'" + Global.current_user +"'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            dgv_don.DataSource = Data;
        }
    }
}
