namespace DiyetProje.PL
{
    partial class AdminLoginForm
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
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            llblUserLoginForm = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pbPassword = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(90, 216);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 23);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SlateGray;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(107, 261);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 39);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SlateGray;
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(265, 375);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // llblUserLoginForm
            // 
            llblUserLoginForm.AutoSize = true;
            llblUserLoginForm.Location = new Point(18, 382);
            llblUserLoginForm.Name = "llblUserLoginForm";
            llblUserLoginForm.Size = new Size(81, 15);
            llblUserLoginForm.TabIndex = 14;
            llblUserLoginForm.TabStop = true;
            llblUserLoginForm.Text = "Kullanıcı Girişi";
            llblUserLoginForm.LinkClicked += llblUserLoginForm_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 216);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 13;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 170);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 12;
            label1.Text = "E-Posta:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(90, 170);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 135);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SlateGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 7);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 10;
            label3.Text = "Yönetici Girişi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.loginAvatar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.hidepswd;
            pbPassword.Location = new Point(317, 216);
            pbPassword.Margin = new Padding(3, 2, 3, 2);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(33, 21);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 25;
            pbPassword.TabStop = false;
            pbPassword.MouseEnter += pbPassword_MouseEnter;
            pbPassword.MouseLeave += pbPassword_MouseLeave;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 412);
            Controls.Add(pbPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(llblUserLoginForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private LinkLabel llblUserLoginForm;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pbPassword;
    }
}