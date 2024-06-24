using DiyetProje.BL.Managers.Concrete;
using DiyetProje.DAL.StaticMethods;
using DiyetProje.PL.Properties;
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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserManager userManager = new UserManager();
            var user = userManager.Search(x => x.Email == email && x.Password == password && x.IsAdministrator == true).FirstOrDefault(); // Kullanıcı E-Mail ve Password veritabanında var mı kontrolü yapar. x.IsAdministrator == true Admin olan kullanıcıları kontrol eder.
            if (user == null)
            {
                MessageBox.Show("Girdiğiniz bilgiler hatalıdır veya giriş için yetkiniz yoktur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AdminMainForm adminMainForm = new AdminMainForm(user); // AdminMainForm'un constructor'una "user" bilgierini gönderir.
            adminMainForm.Show();
            this.Close();
        }

        private void llblUserLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
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
