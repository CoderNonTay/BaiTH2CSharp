namespace Shopping_Online
{
    partial class Item
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
            System.Windows.Forms.Button bt_buy;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_item = new System.Windows.Forms.PictureBox();
            this.pa_info = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_country = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_camera = new System.Windows.Forms.Label();
            this.lb_chip = new System.Windows.Forms.Label();
            this.lb_rom = new System.Windows.Forms.Label();
            this.lb_ram = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_decrease = new System.Windows.Forms.Button();
            this.bt_increase = new System.Windows.Forms.Button();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            bt_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item)).BeginInit();
            this.pa_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_buy
            // 
            bt_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt_buy.ForeColor = System.Drawing.Color.Red;
            bt_buy.Location = new System.Drawing.Point(135, 68);
            bt_buy.Margin = new System.Windows.Forms.Padding(2);
            bt_buy.Name = "bt_buy";
            bt_buy.Size = new System.Drawing.Size(239, 38);
            bt_buy.TabIndex = 7;
            bt_buy.Text = "Thêm vào giỏ hàng";
            bt_buy.UseVisualStyleBackColor = true;
            bt_buy.Click += new System.EventHandler(this.bt_buy_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exit.BackgroundImage")));
            this.pb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_exit.Location = new System.Drawing.Point(928, 2);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.TabIndex = 6;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_item
            // 
            this.pb_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_item.Location = new System.Drawing.Point(28, 119);
            this.pb_item.Name = "pb_item";
            this.pb_item.Size = new System.Drawing.Size(279, 389);
            this.pb_item.TabIndex = 7;
            this.pb_item.TabStop = false;
            // 
            // pa_info
            // 
            this.pa_info.Controls.Add(this.label7);
            this.pa_info.Controls.Add(this.label6);
            this.pa_info.Controls.Add(this.label5);
            this.pa_info.Controls.Add(this.label4);
            this.pa_info.Controls.Add(this.label2);
            this.pa_info.Controls.Add(this.lb_country);
            this.pa_info.Controls.Add(this.lb_year);
            this.pa_info.Controls.Add(this.lb_camera);
            this.pa_info.Controls.Add(this.lb_chip);
            this.pa_info.Controls.Add(this.lb_rom);
            this.pa_info.Controls.Add(this.lb_ram);
            this.pa_info.Controls.Add(this.label1);
            this.pa_info.Controls.Add(this.label3);
            this.pa_info.Controls.Add(bt_buy);
            this.pa_info.Controls.Add(this.bt_decrease);
            this.pa_info.Controls.Add(this.bt_increase);
            this.pa_info.Controls.Add(this.tb_count);
            this.pa_info.Controls.Add(this.lb_Gia);
            this.pa_info.Location = new System.Drawing.Point(349, 118);
            this.pa_info.Name = "pa_info";
            this.pa_info.Size = new System.Drawing.Size(579, 390);
            this.pa_info.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sản xuất tại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Năm sản xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Camera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rom:";
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_country.Location = new System.Drawing.Point(116, 330);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(47, 20);
            this.lb_country.TabIndex = 9;
            this.lb_country.Text = "None";
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_year.Location = new System.Drawing.Point(129, 297);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(47, 20);
            this.lb_year.TabIndex = 9;
            this.lb_year.Text = "None";
            // 
            // lb_camera
            // 
            this.lb_camera.AutoSize = true;
            this.lb_camera.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_camera.Location = new System.Drawing.Point(84, 266);
            this.lb_camera.Name = "lb_camera";
            this.lb_camera.Size = new System.Drawing.Size(47, 20);
            this.lb_camera.TabIndex = 9;
            this.lb_camera.Text = "None";
            // 
            // lb_chip
            // 
            this.lb_chip.AutoSize = true;
            this.lb_chip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_chip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chip.Location = new System.Drawing.Point(66, 234);
            this.lb_chip.Name = "lb_chip";
            this.lb_chip.Size = new System.Drawing.Size(47, 20);
            this.lb_chip.TabIndex = 9;
            this.lb_chip.Text = "None";
            // 
            // lb_rom
            // 
            this.lb_rom.AutoSize = true;
            this.lb_rom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_rom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rom.Location = new System.Drawing.Point(66, 204);
            this.lb_rom.Name = "lb_rom";
            this.lb_rom.Size = new System.Drawing.Size(47, 20);
            this.lb_rom.TabIndex = 9;
            this.lb_rom.Text = "None";
            // 
            // lb_ram
            // 
            this.lb_ram.AutoSize = true;
            this.lb_ram.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ram.Location = new System.Drawing.Point(66, 173);
            this.lb_ram.Name = "lb_ram";
            this.lb_ram.Size = new System.Drawing.Size(47, 20);
            this.lb_ram.TabIndex = 9;
            this.lb_ram.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ram:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thông số kĩ thuật:";
            // 
            // bt_decrease
            // 
            this.bt_decrease.Location = new System.Drawing.Point(8, 73);
            this.bt_decrease.Margin = new System.Windows.Forms.Padding(2);
            this.bt_decrease.Name = "bt_decrease";
            this.bt_decrease.Size = new System.Drawing.Size(26, 28);
            this.bt_decrease.TabIndex = 6;
            this.bt_decrease.Text = "-";
            this.bt_decrease.UseVisualStyleBackColor = true;
            this.bt_decrease.Click += new System.EventHandler(this.bt_decrease_Click);
            // 
            // bt_increase
            // 
            this.bt_increase.Location = new System.Drawing.Point(60, 73);
            this.bt_increase.Margin = new System.Windows.Forms.Padding(2);
            this.bt_increase.Name = "bt_increase";
            this.bt_increase.Size = new System.Drawing.Size(26, 28);
            this.bt_increase.TabIndex = 5;
            this.bt_increase.Text = "+";
            this.bt_increase.UseVisualStyleBackColor = true;
            this.bt_increase.Click += new System.EventHandler(this.bt_increase_Click);
            // 
            // tb_count
            // 
            this.tb_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_count.ForeColor = System.Drawing.Color.Red;
            this.tb_count.Location = new System.Drawing.Point(34, 73);
            this.tb_count.Margin = new System.Windows.Forms.Padding(2);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(26, 28);
            this.tb_count.TabIndex = 4;
            this.tb_count.Text = "1";
            this.tb_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Gia.Location = new System.Drawing.Point(2, 1);
            this.lb_Gia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(271, 31);
            this.lb_Gia.TabIndex = 2;
            this.lb_Gia.Text = "Sản phẩm - Giá bán";
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImage = global::Shopping_Online.Properties.Resources.Apple;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Logo.Location = new System.Drawing.Point(17, 9);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(60, 60);
            this.pb_Logo.TabIndex = 9;
            this.pb_Logo.TabStop = false;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.White;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_Name.Location = new System.Drawing.Point(85, 13);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(238, 52);
            this.lb_Name.TabIndex = 10;
            this.lb_Name.Text = "Ép pồ sì to";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Airpods 2.jpg");
            this.imageList1.Images.SetKeyName(1, "Airpods 3.jpg");
            this.imageList1.Images.SetKeyName(2, "Airpods Max.jpg");
            this.imageList1.Images.SetKeyName(3, "Airpods Pro 2.jpg");
            this.imageList1.Images.SetKeyName(4, "Airpods Pro.jpg");
            this.imageList1.Images.SetKeyName(5, "Ipad Air 4.jpg");
            this.imageList1.Images.SetKeyName(6, "Ipad Air 5 M1.jpg");
            this.imageList1.Images.SetKeyName(7, "Ipad Gen 9.jpg");
            this.imageList1.Images.SetKeyName(8, "Ipad Gen 10.jpg");
            this.imageList1.Images.SetKeyName(9, "Ipad Pro 11 inch 2020.jpg");
            this.imageList1.Images.SetKeyName(10, "Ipad Pro 11 inch 2021 (M1).jpg");
            this.imageList1.Images.SetKeyName(11, "Ipad Pro 11 inch 2022 (M2).jpg");
            this.imageList1.Images.SetKeyName(12, "Ipad Pro 12.9 inch 2021 (M1).jpg");
            this.imageList1.Images.SetKeyName(13, "Ipad Pro 12.9 inch 2022 (M2).jpg");
            this.imageList1.Images.SetKeyName(14, "Iphone 11 Pro Max.jpg");
            this.imageList1.Images.SetKeyName(15, "Iphone 11.jpg");
            this.imageList1.Images.SetKeyName(16, "Iphone 12 Mini.jpg");
            this.imageList1.Images.SetKeyName(17, "Iphone 12 Pro Max.jpg");
            this.imageList1.Images.SetKeyName(18, "Iphone 12 Pro.jpg");
            this.imageList1.Images.SetKeyName(19, "Iphone 12.jpg");
            this.imageList1.Images.SetKeyName(20, "Iphone 13 Mini.jpg");
            this.imageList1.Images.SetKeyName(21, "Iphone 13 Pro Max.jpg");
            this.imageList1.Images.SetKeyName(22, "Iphone 13 Pro.jpg");
            this.imageList1.Images.SetKeyName(23, "Iphone 13.jpg");
            this.imageList1.Images.SetKeyName(24, "Iphone 14 Plus.jpg");
            this.imageList1.Images.SetKeyName(25, "Iphone 14 Pro Max.jpg");
            this.imageList1.Images.SetKeyName(26, "Iphone 14 Pro.jpg");
            this.imageList1.Images.SetKeyName(27, "Iphone 14.jpg");
            this.imageList1.Images.SetKeyName(28, "Iphone SE 2020.jpg");
            this.imageList1.Images.SetKeyName(29, "Iphone SE 2022.jpg");
            this.imageList1.Images.SetKeyName(30, "Macbook Air M1.jpg");
            this.imageList1.Images.SetKeyName(31, "Macbook Air M2.jpg");
            this.imageList1.Images.SetKeyName(32, "Macbook Pro 14 inch (M1 Max).jpg");
            this.imageList1.Images.SetKeyName(33, "Macbook Pro 14 inch (M1 Pro).jpg");
            this.imageList1.Images.SetKeyName(34, "Macbook Pro 16 inch (M1 Max).jpg");
            this.imageList1.Images.SetKeyName(35, "Macbook Pro 16 inch (M1 Pro).jpg");
            this.imageList1.Images.SetKeyName(36, "Macbook Pro M1.jpg");
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.pa_info);
            this.Controls.Add(this.pb_item);
            this.Controls.Add(this.pb_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item)).EndInit();
            this.pa_info.ResumeLayout(false);
            this.pa_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.PictureBox pb_item;
        private System.Windows.Forms.Panel pa_info;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button bt_decrease;
        private System.Windows.Forms.Button bt_increase;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_ram;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_camera;
        private System.Windows.Forms.Label lb_chip;
        private System.Windows.Forms.Label lb_rom;
    }
}