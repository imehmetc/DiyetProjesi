namespace DiyetProje.PL
{
    partial class PasswordChangeForm
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
            lblPasswordLevel = new Label();
            label11 = new Label();
            txtPasswordAgain = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            label8 = new Label();
            btnPasswordChange = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblPasswordLevel
            // 
            lblPasswordLevel.Location = new Point(164, 105);
            lblPasswordLevel.Name = "lblPasswordLevel";
            lblPasswordLevel.Size = new Size(69, 23);
            lblPasswordLevel.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 105);
            label11.Name = "label11";
            label11.Size = new Size(136, 19);
            label11.TabIndex = 28;
            label11.Text = "Şifre Zorluk Derecesi:";
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(34, 165);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.Size = new Size(211, 26);
            txtPasswordAgain.TabIndex = 27;
            txtPasswordAgain.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 143);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 26;
            label7.Text = "Şifre Tekrar:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 26);
            txtPassword.TabIndex = 25;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 47);
            label8.Name = "label8";
            label8.Size = new Size(38, 19);
            label8.TabIndex = 24;
            label8.Text = "Şifre:";
            // 
            // btnPasswordChange
            // 
            btnPasswordChange.Location = new Point(69, 207);
            btnPasswordChange.Name = "btnPasswordChange";
            btnPasswordChange.Size = new Size(141, 35);
            btnPasswordChange.TabIndex = 30;
            btnPasswordChange.Text = "ŞİFRE DEĞİŞTİR";
            btnPasswordChange.UseVisualStyleBackColor = true;
            btnPasswordChange.Click += btnPasswordChange_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(193, 293);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 23);
            btnBack.TabIndex = 31;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 328);
            Controls.Add(btnBack);
            Controls.Add(btnPasswordChange);
            Controls.Add(lblPasswordLevel);
            Controls.Add(label11);
            Controls.Add(txtPasswordAgain);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordChangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPasswordLevel;
        private Label label11;
        private TextBox txtPasswordAgain;
        private Label label7;
        private TextBox txtPassword;
        private Label label8;
        private Button btnPasswordChange;
        private Button btnBack;
    }
}