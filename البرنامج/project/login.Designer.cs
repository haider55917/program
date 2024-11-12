namespace project
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Exit = new Bunifu.Framework.UI.BunifuTileButton();
            this.Enter = new Guna.UI2.WinForms.Guna2Button();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.pass = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.picBox1.Image = ((System.Drawing.Image)(resources.GetObject("picBox1.Image")));
            this.picBox1.Location = new System.Drawing.Point(-100, -6);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(745, 570);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.Exit.TabIndex = 3;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter
            // 
            this.Enter.Animated = true;
            this.Enter.AutoRoundedCorners = true;
            this.Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.Enter.BorderRadius = 16;
            this.Enter.CheckedState.Parent = this.Enter;
            this.Enter.CustomImages.Parent = this.Enter;
            this.Enter.FillColor = System.Drawing.Color.Teal;
            this.Enter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.ForeColor = System.Drawing.Color.White;
            this.Enter.HoverState.Parent = this.Enter;
            this.Enter.Location = new System.Drawing.Point(217, 405);
            this.Enter.Name = "Enter";
            this.Enter.ShadowDecoration.Parent = this.Enter;
            this.Enter.Size = new System.Drawing.Size(116, 34);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "تسجيل الدخول";
            this.Enter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Enter.Click += new System.EventHandler(this.Enter_Click_1);
            // 
            // username
            // 
            this.username.AcceptsTab = true;
            this.username.AutoRoundedCorners = true;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.username.BorderRadius = 15;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.HoverState.Parent = this.username;
            this.username.IconRight = global::project.Properties.Resources.User;
            this.username.IconRightOffset = new System.Drawing.Point(5, 0);
            this.username.Location = new System.Drawing.Point(203, 329);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "اسم المستخدم";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(143, 32);
            this.username.TabIndex = 0;
            this.username.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // pass
            // 
            this.pass.AcceptsTab = true;
            this.pass.AutoRoundedCorners = true;
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.pass.BorderRadius = 15;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultText = "";
            this.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.DisabledState.Parent = this.pass;
            this.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.FocusedState.Parent = this.pass;
            this.pass.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.HoverState.Parent = this.pass;
            this.pass.IconRight = global::project.Properties.Resources.Password;
            this.pass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.pass.Location = new System.Drawing.Point(202, 366);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.PlaceholderText = "كلمة المرور";
            this.pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pass.SelectedText = "";
            this.pass.ShadowDecoration.Parent = this.pass;
            this.pass.Size = new System.Drawing.Size(144, 32);
            this.pass.TabIndex = 1;
            this.pass.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(553, 546);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Exit);
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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton Exit;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private new Guna.UI2.WinForms.Guna2Button Enter;
        private Guna.UI2.WinForms.Guna2TextBox pass;
    }
}

