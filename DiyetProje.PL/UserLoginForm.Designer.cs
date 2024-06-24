namespace DiyetProje.PL
{
    partial class UserLoginForm
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
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            llblAdminLoginForm = new LinkLabel();
            llblRegisterForm = new LinkLabel();
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            pbPassword = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 135);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SlateGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(10, 7);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 10;
            label3.Text = "Kullanıcı Girişi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.loginAvatar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(89, 189);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 189);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "E-Posta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 235);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // llblAdminLoginForm
            // 
            llblAdminLoginForm.AutoSize = true;
            llblAdminLoginForm.Location = new Point(10, 404);
            llblAdminLoginForm.Name = "llblAdminLoginForm";
            llblAdminLoginForm.Size = new Size(78, 15);
            llblAdminLoginForm.TabIndex = 5;
            llblAdminLoginForm.TabStop = true;
            llblAdminLoginForm.Text = "Yönetici Girişi";
            llblAdminLoginForm.LinkClicked += llblAdminLoginForm_LinkClicked;
            // 
            // llblRegisterForm
            // 
            llblRegisterForm.AutoSize = true;
            llblRegisterForm.Location = new Point(278, 266);
            llblRegisterForm.Name = "llblRegisterForm";
            llblRegisterForm.Size = new Size(48, 15);
            llblRegisterForm.TabIndex = 6;
            llblRegisterForm.TabStop = true;
            llblRegisterForm.Text = "Kayıt Ol";
            llblRegisterForm.LinkClicked += llblRegisterForm_LinkClicked;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SlateGray;
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(278, 401);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 36);
            btnExit.TabIndex = 7;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SlateGray;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(106, 279);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 39);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(89, 235);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.hidepswd;
            pbPassword.Location = new Point(316, 235);
            pbPassword.Margin = new Padding(3, 2, 3, 2);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(33, 21);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 26;
            pbPassword.TabStop = false;
            pbPassword.MouseEnter += pbPassword_MouseEnter;
            pbPassword.MouseLeave += pbPassword_MouseLeave;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 448);
            Controls.Add(pbPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(llblRegisterForm);
            Controls.Add(llblAdminLoginForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private LinkLabel llblAdminLoginForm;
        private LinkLabel llblRegisterForm;
        private Button btnExit;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox pbPassword;
    }
}