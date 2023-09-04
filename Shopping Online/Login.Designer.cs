namespace Shopping_Online
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Register = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.bShowPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bHidePass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Register);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.bShowPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bHidePass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbPassWord);
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 150);
            this.panel1.TabIndex = 1;
            // 
            // bt_Register
            // 
            this.bt_Register.BackColor = System.Drawing.Color.White;
            this.bt_Register.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Register.ForeColor = System.Drawing.Color.Black;
            this.bt_Register.Location = new System.Drawing.Point(136, 117);
            this.bt_Register.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(106, 29);
            this.bt_Register.TabIndex = 4;
            this.bt_Register.Text = "Đăng kí";
            this.bt_Register.UseVisualStyleBackColor = false;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txbUserName.Location = new System.Drawing.Point(119, 5);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(160, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // bShowPass
            // 
            this.bShowPass.BackgroundImage = global::Shopping_Online.Properties.Resources.rsz_1images;
            this.bShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bShowPass.Location = new System.Drawing.Point(246, 49);
            this.bShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.bShowPass.Name = "bShowPass";
            this.bShowPass.Size = new System.Drawing.Size(30, 20);
            this.bShowPass.TabIndex = 3;
            this.bShowPass.UseVisualStyleBackColor = true;
            this.bShowPass.Click += new System.EventHandler(this.bShowPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // bHidePass
            // 
            this.bHidePass.BackgroundImage = global::Shopping_Online.Properties.Resources.rsz_images_1;
            this.bHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bHidePass.Location = new System.Drawing.Point(247, 49);
            this.bHidePass.Margin = new System.Windows.Forms.Padding(2);
            this.bHidePass.Name = "bHidePass";
            this.bHidePass.Size = new System.Drawing.Size(29, 20);
            this.bHidePass.TabIndex = 3;
            this.bHidePass.UseVisualStyleBackColor = true;
            this.bHidePass.Click += new System.EventHandler(this.bHidePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(116, 49);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '*';
            this.txbPassWord.Size = new System.Drawing.Size(160, 20);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassWord_KeyDown);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.White;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Location = new System.Drawing.Point(136, 84);
            this.bLogin.Margin = new System.Windows.Forms.Padding(2);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(106, 29);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Đăng nhập";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImage = global::Shopping_Online.Properties.Resources.Apple;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Logo.Location = new System.Drawing.Point(12, 6);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(32, 32);
            this.pb_Logo.TabIndex = 9;
            this.pb_Logo.TabStop = false;
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exit.BackgroundImage")));
            this.pb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_exit.Location = new System.Drawing.Point(271, 2);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(24, 24);
            this.pb_exit.TabIndex = 11;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.White;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_Name.Location = new System.Drawing.Point(50, 7);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(152, 31);
            this.lb_Name.TabIndex = 10;
            this.lb_Name.Text = "Ép pồ sì to";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 215);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button bShowPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bHidePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Label lb_Name;
    }
}