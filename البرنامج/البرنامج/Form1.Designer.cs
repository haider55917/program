namespace البرنامج
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.username = new Bunifu.Framework.UI.BunifuTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuTextbox();
            this.Enter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Exit = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.Image = ((System.Drawing.Image)(resources.GetObject("picBox1.Image")));
            this.picBox1.Location = new System.Drawing.Point(-96, -4);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(731, 559);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("username.BackgroundImage")));
            this.username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Icon = ((System.Drawing.Image)(resources.GetObject("username.Icon")));
            this.username.Location = new System.Drawing.Point(207, 321);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(134, 32);
            this.username.TabIndex = 1;
            this.username.text = "";
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pass.BackgroundImage")));
            this.pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.Icon = ((System.Drawing.Image)(resources.GetObject("pass.Icon")));
            this.pass.Location = new System.Drawing.Point(207, 364);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(134, 32);
            this.pass.TabIndex = 2;
            this.pass.text = "";
            // 
            // Enter
            // 
            this.Enter.ActiveBorderThickness = 1;
            this.Enter.ActiveCornerRadius = 20;
            this.Enter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Enter.ActiveForecolor = System.Drawing.Color.White;
            this.Enter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Enter.BackgroundImage")));
            this.Enter.ButtonText = "الدخول";
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.ForeColor = System.Drawing.Color.SeaGreen;
            this.Enter.IdleBorderThickness = 1;
            this.Enter.IdleCornerRadius = 20;
            this.Enter.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(118)))), ((int)(((byte)(75)))));
            this.Enter.IdleForecolor = System.Drawing.Color.Black;
            this.Enter.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Enter.Location = new System.Drawing.Point(214, 399);
            this.Enter.Margin = new System.Windows.Forms.Padding(5);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(114, 40);
            this.Enter.TabIndex = 3;
            this.Enter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.color = System.Drawing.Color.Transparent;
            this.Exit.colorActive = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = null;
            this.Exit.ImagePosition = 20;
            this.Exit.ImageZoom = 50;
            this.Exit.LabelPosition = 41;
            this.Exit.LabelText = "";
            this.Exit.Location = new System.Drawing.Point(3, 7);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 43);
            this.Exit.TabIndex = 4;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(553, 546);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.picBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private Bunifu.Framework.UI.BunifuTextbox username;
        private Bunifu.Framework.UI.BunifuTextbox pass;
        private Bunifu.Framework.UI.BunifuThinButton2 Enter;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton Exit;
    }
}

