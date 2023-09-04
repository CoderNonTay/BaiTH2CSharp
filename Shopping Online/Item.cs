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
    public partial class Item : Form
    {
        public Item()
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

        

        private void bt_increase_Click(object sender, EventArgs e)
        {
            tb_count.Text = Convert.ToString(Convert.ToInt32(tb_count.Text)+1);
        }

        private void bt_decrease_Click(object sender, EventArgs e)
        {
            if (tb_count.Text == "1")
                return;
            tb_count.Text = Convert.ToString(Convert.ToInt32(tb_count.Text)-1);
        }

        private void Item_Load(object sender, EventArgs e)
        { 
            pb_item.BackgroundImage =  imageList1.Images[Global.current_item + ".jpg"];
            SANPHAM tmp = SANPHAMDAO.Instance.ChiTietSanPham(Global.current_item);
            lb_Gia.Text = Global.current_item + "\n" + tmp.Gia.ToString() + "đ";
            lb_ram.Text = tmp.Ram;
            lb_rom.Text = tmp.Rom;
            lb_chip.Text = tmp.Chip;
            lb_camera.Text = tmp.Camera;
            lb_year.Text = tmp.NamSX;
            lb_country.Text = tmp.QuocGia;
        }

        private void bt_buy_Click(object sender, EventArgs e)
        {
            SANPHAM tmp = SANPHAMDAO.Instance.ChiTietSanPham(Global.current_item);
            for(int i = 0; i < Global.dt.Rows.Count; i++)
            {
                if (Global.dt.Rows[i][1].ToString() == Global.current_item)
                {
                    string a = Global.dt.Rows[i][3].ToString();
                    Global.dt.Rows.RemoveAt(i);
                    Global.dt.Rows.Add(tmp.MaSP ,Global.current_item, tmp.Gia , Convert.ToInt32(a) + Convert.ToInt32(tb_count.Text));
                    MessageBox.Show("Thêm thành công!", "Thành công");
                    tb_count.Text = "1";
                    return;
                }    
            }    
            MessageBox.Show("Thêm thành công!", "Thành công");
            Global.dt.Rows.Add(tmp.MaSP ,Global.current_item, tmp.Gia, Convert.ToInt32(tb_count.Text));
            tb_count.Text = "1";
        }
    }
}
