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
    public partial class Cart : Form
    {
        public Cart()
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

        private void Cart_Load(object sender, EventArgs e)
        {
            dgv_cart.DataSource = Global.dt;
            int temp = 0;
            for (int i = 0; i < dgv_cart.Rows.Count; i++)
            {
                temp += Convert.ToInt32(dgv_cart[3, i].Value) * Convert.ToInt32(dgv_cart[2, i].Value);
            }
            txtTongTien.Text = temp.ToString();
            clicked_row = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.dt.Clear();
            Cart_Load(sender, e);
        }

        int clicked_row = -1;


        private void dgv_cart_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked_row = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count == 0)
                return;
            if(dgv_cart.Rows.Count == 1)
            {
                Global.dt.Clear();
                Cart_Load(sender, e);
                return;
            }
            if (clicked_row == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Cảnh báo!");
                return;
            }
            for (int i = 0; i < Global.dt.Rows.Count; i++)
            {
                if (Global.dt.Rows[i][0] == dgv_cart[0, clicked_row])
                    Global.dt.Rows.RemoveAt(i);
            }
            dgv_cart.Rows.RemoveAt(clicked_row);
            Cart_Load(sender, e);
        }

        private void bt_cart_Click(object sender, EventArgs e)
        {
            string query = "insert into HOADON (ID, TongTien) values (N'" + Global.current_user + "', " + txtTongTien.Text +")";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dgv_cart.Rows.Count-1; i++)
            {
                string query_temp = "NhapCTHD " + dgv_cart[0, i].Value + ", " + dgv_cart[3, i].Value;
                DataTable temp = DataProvider.Instance.ExecuteQuery(query_temp);
            }  
            
            MessageBox.Show("Đặt hàng thành công!", "Thông báo");
            Global.dt.Clear();
            Cart_Load(sender, e);
        }
    }
}
