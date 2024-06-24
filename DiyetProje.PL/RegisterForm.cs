using DiyetProje.BL.Managers.Concrete;
using DiyetProje.BL.Models;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            cmbGender.Items.AddRange(["Cinsiyet Seçiniz", "Erkek", "Kadın"]); // RegisterForm açıldığında Cinsiyet ComboBox'ın içine bu değerler doldurulur.
            cmbGender.SelectedIndex = 0;
        }
        public void Clear()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
            cmbGender.SelectedIndex = 0;
            txtEMail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPasswordAgain.Text = string.Empty;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string gender = cmbGender.Text;
            string email = txtEMail.Text;
            string password = txtPassword.Text;
            string passwordAgain = txtPasswordAgain.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordAgain) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtHeight.Text) || string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                // TextBox boş mu diye kontrol eder.
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (name.Trim().Length == 0 || name != name.Trim() ||
                surname.Trim().Length == 0 || surname != surname.Trim() ||
                gender.Trim().Length == 0 || gender != gender.Trim() ||
                email.Trim().Length == 0 || email != email.Trim() ||
                password.Trim().Length == 0 || password != password.Trim() ||
                passwordAgain.Trim().Length == 0 || passwordAgain != passwordAgain.Trim() ||
                txtAge.Text.Trim().Length == 0 || txtAge.Text != txtAge.Text.Trim() ||
                txtHeight.Text.Trim().Length == 0 || txtHeight.Text != txtHeight.Text.Trim() ||
                txtWeight.Text.Trim().Length == 0 || txtWeight.Text != txtWeight.Text.Trim())
            {
                // TextBox'ta space karakterinı kontrol eder.
                MessageBox.Show("Lütfen boş metin girmeyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Lütfen yaş bilginizi sayısal bir değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (age <= 17 || age >= 26)
            {
                MessageBox.Show("Sisteme kayıt olabilmeniz için yaşınız 18-25 arasında olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtHeight.Text, out double height))
            {
                MessageBox.Show("Lütfen boy bilginizi sayısal bir değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (height <= 0)
            {
                MessageBox.Show("Boyunuz 0'dan küçük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtWeight.Text, out double weight))
            {
                MessageBox.Show("Lütfen kilo bilginizi sayısal bir değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (weight <= 0)
            {
                MessageBox.Show("Kilonuz 0'dan küçük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gender == "Cinsiyet Seçiniz")
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.EndsWith(".com") || !email.Contains("@") || email.IndexOf('@') == 0)
            {
                MessageBox.Show("Lütfen geçerli bir E-Posta adresi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (information == "DÜŞÜK")
            {
                MessageBox.Show("Şifre Zorluk Derecesi düşük olmamalıdır!\nŞifre 6 karakterden fazla ve en az 2 tip karakter(harf, rakam, özel karakter) içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != passwordAgain)
            {
                MessageBox.Show("Şifre ve Şifre Tekrar'ı uyuşmuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserManager userManager = new UserManager(); // Repository'deki Metotları kullanabilmek için manager kullanılır.
            var user = userManager.Search(x => x.Email == email).FirstOrDefault(); // Bu E-Mail veritabanında kayıtlı mı?
            if (user != null) // Kayıtlıysa hata ver.
            {
                MessageBox.Show("Bu E-Posta adresi kullanılmakta lütfen farklı bir E-Posta adresi girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sifrelenmis = Sha256Hasher.ComputeSha256Hash(password); // Kullanıcının girmiş olduğu şifreyi veritabanına göndermeden önce Static metodumuz olan Sha256Hasher ile şifreyi şifreler.
            UserViewModel userViewModel = new UserViewModel
            {
                FirstName = name,
                LastName = surname,
                Email = email,
                Password = sifrelenmis,
                Age = age,
                Weight = weight,
                Height = height,
                Gender = gender,
            };
            userManager.Insert(userViewModel);
            MessageBox.Show("Kayıt işlemi başarılı..");
            Clear();
        }
        string information;
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pbPassword.Image = Resources.hidepswd;

            /* eğer şifre 6 karakterden az ise düşük,
                6 karakterden fazla ve sadece tek tip karakter içeriyorsa(sadeceharf,sadecerakam,sadecözelkarakter gibi) yine düşük
                eğer şifre 6 karakterden fazla ve 3'lü kombinasyon varsa yüksek
                eğer şifre 6 karakterden fazla ve iki tip karakterden oluşuyorsa orta seviye şifre olcak.
             */
            string password = txtPassword.Text;
            information = string.Empty;
            int length = password.Length;

            bool isLength = length >= 6,
                isAllDigit = password.All(Char.IsDigit),
                isAllLetter = password.All(Char.IsLetter),
                isAllLetterOrDigit = password.All(Char.IsLetterOrDigit),
                isAnyDigit = password.Any(Char.IsDigit),
                isAnyLetter = password.Any(Char.IsLetter),
                isAnyLetterOrDigit = password.Any(Char.IsLetterOrDigit);

            if (!isLength || isAllDigit || isAllLetter || !isAnyLetterOrDigit)
            {
                information = "DÜŞÜK";
            }
            else if (isLength && isAnyDigit && isAnyLetter && !isAllLetterOrDigit)
            {
                information = "YÜKSEK";
            }
            else
            {
                information = "ORTA";
            }
            if (password == string.Empty)
            {
                information = string.Empty;
            }
            lblPasswordLevel.Text = information;
        }
        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            txtPasswordAgain.UseSystemPasswordChar = true;
            pbPassword.Image = Resources.hidepswd;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llblLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            this.Hide();
        }

        // Design kısmındaki şifreyi gör(Göz resmi) eventleri
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

        private void pbPasswordAgain_MouseEnter(object sender, EventArgs e)
        {
            txtPasswordAgain.UseSystemPasswordChar = false;
            pbPasswordAgain.Image = Resources.showpswd;
        }

        private void pbPasswordAgain_MouseLeave(object sender, EventArgs e)
        {
            txtPasswordAgain.UseSystemPasswordChar = true;
            pbPasswordAgain.Image = Resources.hidepswd;
        }
    }
}
