namespace Shopping_Online
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lv_showitem = new System.Windows.Forms.ListView();
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglist_items = new System.Windows.Forms.ImageList(this.components);
            this.tb_search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.pb_personal = new System.Windows.Forms.PictureBox();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pb_cart = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_personal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_showitem
            // 
            this.lv_showitem.BackColor = System.Drawing.Color.White;
            this.lv_showitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenSP,
            this.GiaSP});
            this.lv_showitem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lv_showitem.HideSelection = false;
            this.lv_showitem.LargeImageList = this.imglist_items;
            this.lv_showitem.Location = new System.Drawing.Point(12, 77);
            this.lv_showitem.Name = "lv_showitem";
            this.lv_showitem.Size = new System.Drawing.Size(936, 451);
            this.lv_showitem.TabIndex = 5;
            this.lv_showitem.UseCompatibleStateImageBehavior = false;
            this.lv_showitem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_showitem_ItemSelectionChanged);
            // 
            // imglist_items
            // 
            this.imglist_items.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist_items.ImageStream")));
            this.imglist_items.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist_items.Images.SetKeyName(0, "Macbook Air M1.jpg");
            this.imglist_items.Images.SetKeyName(1, "Macbook Air M2.jpg");
            this.imglist_items.Images.SetKeyName(2, "Macbook Pro 14 inch (M1 Max).jpg");
            this.imglist_items.Images.SetKeyName(3, "Macbook Pro 14 inch (M1 Pro).jpg");
            this.imglist_items.Images.SetKeyName(4, "Macbook Pro 16 inch (M1 Max).jpg");
            this.imglist_items.Images.SetKeyName(5, "Macbook Pro 16 inch (M1 Pro).jpg");
            this.imglist_items.Images.SetKeyName(6, "Macbook Pro M1.jpg");
            this.imglist_items.Images.SetKeyName(7, "Iphone 14 Pro Max.jpg");
            this.imglist_items.Images.SetKeyName(8, "Iphone 14 Pro.jpg");
            this.imglist_items.Images.SetKeyName(9, "Iphone 14.jpg");
            this.imglist_items.Images.SetKeyName(10, "Iphone SE 2020.jpg");
            this.imglist_items.Images.SetKeyName(11, "Iphone SE 2022.jpg");
            this.imglist_items.Images.SetKeyName(12, "Airpods 2.jpg");
            this.imglist_items.Images.SetKeyName(13, "Airpods 3.jpg");
            this.imglist_items.Images.SetKeyName(14, "Airpods Max.jpg");
            this.imglist_items.Images.SetKeyName(15, "Airpods Pro 2.jpg");
            this.imglist_items.Images.SetKeyName(16, "Airpods Pro.jpg");
            this.imglist_items.Images.SetKeyName(17, "Ipad Air 4.jpg");
            this.imglist_items.Images.SetKeyName(18, "Ipad Air 5 M1.jpg");
            this.imglist_items.Images.SetKeyName(19, "Ipad Gen 9.jpg");
            this.imglist_items.Images.SetKeyName(20, "Ipad Gen 10.jpg");
            this.imglist_items.Images.SetKeyName(21, "Ipad Pro 11 inch 2020.jpg");
            this.imglist_items.Images.SetKeyName(22, "Ipad Pro 11 inch 2021 (M1).jpg");
            this.imglist_items.Images.SetKeyName(23, "Ipad Pro 11 inch 2022 (M2).jpg");
            this.imglist_items.Images.SetKeyName(24, "Ipad Pro 12.9 inch 2021 (M1).jpg");
            this.imglist_items.Images.SetKeyName(25, "Ipad Pro 12.9 inch 2022 (M2).jpg");
            this.imglist_items.Images.SetKeyName(26, "Iphone 11 Pro Max.jpg");
            this.imglist_items.Images.SetKeyName(27, "Iphone 11.jpg");
            this.imglist_items.Images.SetKeyName(28, "Iphone 12 Mini.jpg");
            this.imglist_items.Images.SetKeyName(29, "Iphone 12 Pro Max.jpg");
            this.imglist_items.Images.SetKeyName(30, "Iphone 12 Pro.jpg");
            this.imglist_items.Images.SetKeyName(31, "Iphone 12.jpg");
            this.imglist_items.Images.SetKeyName(32, "Iphone 13 Mini.jpg");
            this.imglist_items.Images.SetKeyName(33, "Iphone 13 Pro Max.jpg");
            this.imglist_items.Images.SetKeyName(34, "Iphone 13 Pro.jpg");
            this.imglist_items.Images.SetKeyName(35, "Iphone 13.jpg");
            this.imglist_items.Images.SetKeyName(36, "Iphone 14 Plus.jpg");
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(342, 23);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(464, 40);
            this.tb_search.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(112, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 33;
            this.button2.Text = "Iphone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(112, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 29);
            this.button3.TabIndex = 33;
            this.button3.Text = "Ipad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.OrangeRed;
            this.button4.Location = new System.Drawing.Point(225, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 29);
            this.button4.TabIndex = 33;
            this.button4.Text = "Airpods";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.OrangeRed;
            this.button5.Location = new System.Drawing.Point(225, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 29);
            this.button5.TabIndex = 33;
            this.button5.Text = "Macbook";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.White;
            this.btnKiemTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.Image = ((System.Drawing.Image)(resources.GetObject("btnKiemTra.Image")));
            this.btnKiemTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTra.Location = new System.Drawing.Point(812, 25);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(40, 40);
            this.btnKiemTra.TabIndex = 31;
            this.btnKiemTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // pb_personal
            // 
            this.pb_personal.BackgroundImage = global::Shopping_Online.Properties.Resources._1564534_customer_man_user_account_profile_icon;
            this.pb_personal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_personal.Location = new System.Drawing.Point(855, 2);
            this.pb_personal.Name = "pb_personal";
            this.pb_personal.Size = new System.Drawing.Size(30, 30);
            this.pb_personal.TabIndex = 10;
            this.pb_personal.TabStop = false;
            this.pb_personal.Click += new System.EventHandler(this.pb_personal_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImage = global::Shopping_Online.Properties.Resources.Apple;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Logo.Location = new System.Drawing.Point(17, 9);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(60, 60);
            this.pb_Logo.TabIndex = 7;
            this.pb_Logo.TabStop = false;
            // 
            // pb_cart
            // 
            this.pb_cart.BackColor = System.Drawing.Color.Transparent;
            this.pb_cart.BackgroundImage = global::Shopping_Online.Properties.Resources._326700_cart_shopping_icon;
            this.pb_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_cart.Location = new System.Drawing.Point(891, 2);
            this.pb_cart.Name = "pb_cart";
            this.pb_cart.Size = new System.Drawing.Size(30, 30);
            this.pb_cart.TabIndex = 6;
            this.pb_cart.TabStop = false;
            this.pb_cart.Click += new System.EventHandler(this.pb_cart_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.BackgroundImage = global::Shopping_Online.Properties.Resources._1564506_close_exit_logout_power_icon;
            this.pb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_exit.Location = new System.Drawing.Point(927, 2);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.TabIndex = 4;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.pb_personal);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.pb_cart);
            this.Controls.Add(this.lv_showitem);
            this.Controls.Add(this.pb_exit);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_personal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.ListView lv_showitem;
        private System.Windows.Forms.ImageList imglist_items;
        private System.Windows.Forms.PictureBox pb_cart;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pb_personal;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader GiaSP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

