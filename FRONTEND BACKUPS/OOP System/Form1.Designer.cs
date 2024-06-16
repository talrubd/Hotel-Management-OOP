namespace OOP_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            hotelLogo = new PictureBox();
            Base = new Panel();
            LoginPanel = new Panel();
            lblErrorCredentials = new Label();
            txtPassword = new MaskedTextBox();
            btnLogin = new Button();
            lblForgotPassword = new LinkLabel();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblAdmin = new Label();
            HotelPanel = new Panel();
            hotelName = new Label();
            ((System.ComponentModel.ISupportInitialize)hotelLogo).BeginInit();
            Base.SuspendLayout();
            LoginPanel.SuspendLayout();
            HotelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // hotelLogo
            // 
            hotelLogo.BackgroundImage = (Image)resources.GetObject("hotelLogo.BackgroundImage");
            hotelLogo.Location = new Point(39, 126);
            hotelLogo.Name = "hotelLogo";
            hotelLogo.Size = new Size(467, 464);
            hotelLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            hotelLogo.TabIndex = 0;
            hotelLogo.TabStop = false;
            // 
            // Base
            // 
            Base.BackColor = SystemColors.ActiveCaption;
            Base.Controls.Add(LoginPanel);
            Base.Controls.Add(HotelPanel);
            Base.Dock = DockStyle.Fill;
            Base.Location = new Point(0, 0);
            Base.Name = "Base";
            Base.Size = new Size(1518, 817);
            Base.TabIndex = 1;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.WhiteSmoke;
            LoginPanel.Controls.Add(lblErrorCredentials);
            LoginPanel.Controls.Add(txtPassword);
            LoginPanel.Controls.Add(btnLogin);
            LoginPanel.Controls.Add(lblForgotPassword);
            LoginPanel.Controls.Add(txtUsername);
            LoginPanel.Controls.Add(lblPassword);
            LoginPanel.Controls.Add(lblUsername);
            LoginPanel.Controls.Add(lblAdmin);
            LoginPanel.Location = new Point(794, 239);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(546, 330);
            LoginPanel.TabIndex = 0;
            // 
            // lblErrorCredentials
            // 
            lblErrorCredentials.AutoSize = true;
            lblErrorCredentials.ForeColor = Color.Red;
            lblErrorCredentials.Location = new Point(106, 249);
            lblErrorCredentials.Name = "lblErrorCredentials";
            lblErrorCredentials.Size = new Size(347, 20);
            lblErrorCredentials.TabIndex = 8;
            lblErrorCredentials.Text = "You have entered an invalid username or password.\r\n";
            lblErrorCredentials.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(216, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Location = new Point(225, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.LinkColor = Color.RoyalBlue;
            lblForgotPassword.Location = new Point(341, 216);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(125, 20);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Forgot Password?";
            lblForgotPassword.LinkClicked += lblForgotPassword_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(216, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(96, 177);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(89, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "username:";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.FlatStyle = FlatStyle.System;
            lblAdmin.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(144, 12);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(271, 45);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "Administrator";
            lblAdmin.TextAlign = ContentAlignment.TopCenter;
            // 
            // HotelPanel
            // 
            HotelPanel.BackColor = Color.WhiteSmoke;
            HotelPanel.Controls.Add(hotelName);
            HotelPanel.Controls.Add(hotelLogo);
            HotelPanel.Dock = DockStyle.Left;
            HotelPanel.Location = new Point(0, 0);
            HotelPanel.Name = "HotelPanel";
            HotelPanel.Size = new Size(573, 817);
            HotelPanel.TabIndex = 1;
            // 
            // hotelName
            // 
            hotelName.AutoSize = true;
            hotelName.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hotelName.Location = new Point(28, 611);
            hotelName.Name = "hotelName";
            hotelName.Size = new Size(520, 45);
            hotelName.TabIndex = 1;
            hotelName.Text = "Hotel Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1518, 817);
            Controls.Add(Base);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management System";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)hotelLogo).EndInit();
            Base.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            HotelPanel.ResumeLayout(false);
            HotelPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox hotelLogo;
        private Panel Base;
        private Panel HotelPanel;
        private Label hotelName;
        private Panel LoginPanel;
        private Label lblAdmin;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Button btnLogin;
        private LinkLabel lblForgotPassword;
        private MaskedTextBox txtPassword;
        private Label lblErrorCredentials;
    }
}
