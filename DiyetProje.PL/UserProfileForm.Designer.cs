namespace DiyetProje.PL
{
    partial class UserProfileForm
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
            lblUserEMail = new Label();
            panel1 = new Panel();
            btnInsertPicture = new Button();
            pbImage = new PictureBox();
            btnBack = new Button();
            btnRegister = new Button();
            txtPassword = new TextBox();
            label8 = new Label();
            txtWeight = new TextBox();
            label6 = new Label();
            txtHeight = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblName = new Label();
            lblSurname = new Label();
            llblPasswordChange = new LinkLabel();
            pbPassword = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            SuspendLayout();
            // 
            // lblUserEMail
            // 
            lblUserEMail.AutoSize = true;
            lblUserEMail.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblUserEMail.Location = new Point(12, 9);
            lblUserEMail.Name = "lblUserEMail";
            lblUserEMail.Size = new Size(0, 19);
            lblUserEMail.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnInsertPicture);
            panel1.Controls.Add(lblUserEMail);
            panel1.Controls.Add(pbImage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 172);
            panel1.TabIndex = 45;
            // 
            // btnInsertPicture
            // 
            btnInsertPicture.Location = new Point(458, 135);
            btnInsertPicture.Name = "btnInsertPicture";
            btnInsertPicture.Size = new Size(103, 34);
            btnInsertPicture.TabIndex = 50;
            btnInsertPicture.Text = "Resim Ekle";
            btnInsertPicture.UseVisualStyleBackColor = true;
            btnInsertPicture.Click += btnInsertPicture_Click;
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Image = Properties.Resources.loginAvatar;
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(573, 172);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(481, 582);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 28);
            btnBack.TabIndex = 44;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnRegister.Location = new Point(150, 507);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(273, 39);
            btnRegister.TabIndex = 43;
            btnRegister.Text = "BİLGİLERİMİ GÜNCELLE";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(290, 381);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 26);
            txtPassword.TabIndex = 39;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 359);
            label8.Name = "label8";
            label8.Size = new Size(38, 19);
            label8.TabIndex = 38;
            label8.Text = "Şifre:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(38, 451);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(209, 26);
            txtWeight.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 429);
            label6.Name = "label6";
            label6.Size = new Size(34, 19);
            label6.TabIndex = 32;
            label6.Text = "Kilo:";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(38, 393);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(209, 26);
            txtHeight.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 371);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 30;
            label3.Text = "Boy (cm):";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(38, 335);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(209, 26);
            txtAge.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 313);
            label4.Name = "label4";
            label4.Size = new Size(32, 19);
            label4.TabIndex = 28;
            label4.Text = "Yaş:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 237);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 26;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 208);
            label1.Name = "label1";
            label1.Size = new Size(29, 19);
            label1.TabIndex = 24;
            label1.Text = "Ad:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(278, 208);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 19);
            lblName.TabIndex = 48;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(278, 237);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(0, 19);
            lblSurname.TabIndex = 49;
            // 
            // llblPasswordChange
            // 
            llblPasswordChange.AutoSize = true;
            llblPasswordChange.Location = new Point(415, 420);
            llblPasswordChange.Name = "llblPasswordChange";
            llblPasswordChange.Size = new Size(86, 19);
            llblPasswordChange.TabIndex = 50;
            llblPasswordChange.TabStop = true;
            llblPasswordChange.Text = "Şifre Değiştir";
            llblPasswordChange.LinkClicked += llblPasswordChange_LinkClicked;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.hidepswd;
            pbPassword.Location = new Point(507, 380);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(38, 27);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 51;
            pbPassword.TabStop = false;
            pbPassword.MouseEnter += pbPassword_MouseEnter;
            pbPassword.MouseLeave += pbPassword_MouseLeave;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 622);
            Controls.Add(pbPassword);
            Controls.Add(llblPasswordChange);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(txtWeight);
            Controls.Add(label6);
            Controls.Add(txtHeight);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfileForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserEMail;
        private Panel panel1;
        private PictureBox pbImage;
        private Button btnBack;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtWeight;
        private Label label6;
        private TextBox txtHeight;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblName;
        private Label lblSurname;
        private Button btnInsertPicture;
        private LinkLabel llblPasswordChange;
        private PictureBox pbPassword;
    }
}