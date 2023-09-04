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
using Shopping_Online.DTO;


namespace Shopping_Online
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void pb_cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            List<SANPHAM> Items = new List<SANPHAM>();
            Items = SANPHAMDAO.Instance.LayTatCaSanPham();
            foreach (SANPHAM item in Items)
            {
                var listViewItem = lv_showitem.Items.Add(item.TenSP+ "\n" + item.Gia.ToString() + "đ");
                listViewItem.ForeColor = Color.Red;
                listViewItem.ImageKey = item.TenSP + ".jpg";
            }

        }

        private void lv_showitem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string[] arrListStr = e.Item.Text.Split('\n');
            Global.current_item = arrListStr[0];
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            List<SANPHAM> Items = new List<SANPHAM>();
            lv_showitem.Clear();
            Items = SANPHAMDAO.Instance.SearchSPByName(tb_search.Text);
            foreach (SANPHAM item in Items)
            {
                var listViewItem = lv_showitem.Items.Add(item.TenSP+ "\n" + item.Gia.ToString() + "đ");
                listViewItem.ForeColor = Color.Red;
                listViewItem.ImageKey = item.TenSP + ".jpg";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<SANPHAM> Items = new List<SANPHAM>();
            lv_showitem.Clear();
            Items = SANPHAMDAO.Instance.SearchSPByName("Iphone");
            foreach (SANPHAM item in Items)
            {
                var listViewItem = lv_showitem.Items.Add(item.TenSP+ "\n" + item.Gia.ToString() + "đ");
                listViewItem.ForeColor = Color.Red;
                listViewItem.ImageKey = item.TenSP + ".jpg";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<SANPHAM> Items = new List<SANPHAM>();
            lv_showitem.Clear();
            Items = SANPHAMDAO.Instance.SearchSPByName("Ipad");
            foreach (SANPHAM item in Items)
            {
                var listViewItem = lv_showitem.Items.Add(item.TenSP+ "\n" + item.Gia.ToString() + "đ");
                listViewItem.ForeColor = Color.Red;
                listViewItem.ImageKey = item.TenSP + ".jpg";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SANPHAM> Items = new List<SANPHAM>();
            lv_showitem.Clear();
            Items = SANPHAMDAO.Instance.SearchSPByName("Airpods");
            foreach (SANPHAM item in Items)
            {
                var listViewItem = lv_showitem.Items.Add(item.TenSP+ "\n" + item.Gia.ToString() + "đ");
                listViewItem.ForeColor = Color.Red;
                listViewItem.ImageKey = item.TenSP + ".jpg";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<SANPHAM> Items = new List<SANPHAM>();
            lv_showitem.Clear();
            Items = SANPHAMDAO.Instance.SearchSPByName("Macbook");
            foreach (SANPHAM item in Items)
            {
                var listViewItem = lv_showitem.Items.Add(item.TenSP+ "\n" + item.Gia.ToString() + "đ");
                listViewItem.ForeColor = Color.Red;
                listViewItem.ImageKey = item.TenSP + ".jpg";
            }
        }

        private void pb_personal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personal per = new Personal();
            per.Show();
        }
    }
}
