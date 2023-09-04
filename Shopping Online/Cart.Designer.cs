namespace Shopping_Online
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.lb_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_cart = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
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
            this.lb_Name.TabIndex = 9;
            this.lb_Name.Text = "Ép pồ sì to";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_cart);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 338);
            this.panel1.TabIndex = 10;
            // 
            // dgv_cart
            // 
            this.dgv_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cart.Location = new System.Drawing.Point(0, 0);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.Size = new System.Drawing.Size(936, 338);
            this.dgv_cart.TabIndex = 0;
            this.dgv_cart.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_cart_CellMouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 33);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(156, 485);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(317, 38);
            this.txtTongTien.TabIndex = 17;
            this.txtTongTien.TabStop = false;
            this.txtTongTien.Text = "0";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Shopping_Online.Properties.Resources._326606_delete_icon1;
            this.button1.Location = new System.Drawing.Point(706, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 19;
            this.button1.Text = "Xóa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_cart
            // 
            this.bt_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cart.Image = global::Shopping_Online.Properties.Resources._326700_cart_shopping_icon;
            this.bt_cart.Location = new System.Drawing.Point(569, 448);
            this.bt_cart.Name = "bt_cart";
            this.bt_cart.Size = new System.Drawing.Size(80, 80);
            this.bt_cart.TabIndex = 19;
            this.bt_cart.Text = "Thanh toán";
            this.bt_cart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_cart.UseVisualStyleBackColor = true;
            this.bt_cart.Click += new System.EventHandler(this.bt_cart_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImage = global::Shopping_Online.Properties.Resources.Apple;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Logo.Location = new System.Drawing.Point(17, 9);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(60, 60);
            this.pb_Logo.TabIndex = 8;
            this.pb_Logo.TabStop = false;
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exit.BackgroundImage")));
            this.pb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_exit.Location = new System.Drawing.Point(928, 2);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.TabIndex = 5;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Shopping_Online.Properties.Resources._326606_delete_icon1;
            this.button2.Location = new System.Drawing.Point(835, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 19;
            this.button2.Text = "Xóa hết";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Giỏ hàng";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_cart);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.pb_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button bt_cart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cart;
    }
}