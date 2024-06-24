using DiyetProje.BL.Managers.Concrete;
using DiyetProje.BL.Models;
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
    public partial class PasswordChangeForm : Form
    {
        private readonly UserViewModel _user; // UserProfileForm'dan gelen giriş yapmış olan kullanıcının bilgilerinin tutulduğu field
        private readonly MainForm _mainForm; // MainForm'un bilgilerinin tutulduğu field.
        private readonly UserProfileForm _userProfileForm; // UserProfileForm'un bilgilerinin tutulduğu field.

        public PasswordChangeForm(UserViewModel user, MainForm mainForm, UserProfileForm userProfileForm)
        {
            InitializeComponent();

            _user = user; // UserProfileForm'dan gönderilen "user" bilgilerini "_user" field'ına aktarır.
            _mainForm = mainForm; // UserProfileForm'dan gönderilen "mainForm" bilgilerini "_mainForm" field'ına aktarır.
            _userProfileForm = userProfileForm; // UserProfileForm'dan gönderilen "userProfileForm" bilgilerini "_userProfileForm" field'ına aktarır.
        }

        string information;
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
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

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string passwordAgain = txtPasswordAgain.Text;

            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordAgain))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Trim().Length == 0 || password != password.Trim() ||
                passwordAgain.Trim().Length == 0 || passwordAgain != passwordAgain.Trim())
            {
                MessageBox.Show("Lütfen boş metin girmeyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string sifrelenmis = Sha256Hasher.ComputeSha256Hash(password);
            UserManager userManager = new UserManager();
            _user.Password = sifrelenmis; // kullanıcının yeni şifresini günceller.
            
            userManager.Update(_user);
            MessageBox.Show("Şifre değişikliği başarıyla tamamlandı.");

            // Değişikliklerin geçerli olabilmesi için kullanıcının tekrar giriş yapması gerekli. Bu sebeple UserLoginForm'a yönlendirilir.
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            
            // UserLoginForm açıldıktan sonra şuanki form(PasswordChangeForm) ve showdialog ile açıldığından arkada açık olan MainForm ve UserProfileForm formlarını gizler.
            this.Close();
            _userProfileForm.Close();
            _mainForm.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
