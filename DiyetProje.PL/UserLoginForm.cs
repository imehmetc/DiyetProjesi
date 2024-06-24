using DiyetProje.BL.Managers.Concrete;
using DiyetProje.DAL.StaticMethods;
using DiyetProje.PL.Properties;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProje.PL
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void llblRegisterForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string sifrelenmis = Sha256Hasher.ComputeSha256Hash(password); // Kullanıcının girmiş olduğu şifreyi şifreler.
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserManager userManager = new UserManager();

            var user = userManager.Search(x => x.Email == email && x.Password == sifrelenmis && x.IsAdministrator == false).FirstOrDefault(); // Kullanıcı E-Mail ve Password veritabanında var mı kontrolü yapar. x.IsAdministrator == false Admin olmayan kullanıcıları kontrol eder. 

            if (user == null)
            {
                MessageBox.Show("E-Posta veya Şifre Yanlış..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MainForm mainForm = new MainForm(user); // Giriş başarılıysa MainForm'a gider. Giderken user bilgilerini Form'un constructor'una gönderir.
            mainForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llblAdminLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            form.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pbPassword.Image = Resources.hidepswd;
        }

        private void pbPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pbPassword.Image = Resources.showpswd;
        }

        private void pbPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pbPassword.Image = Resources.hidepswd;
        }
    }
}
