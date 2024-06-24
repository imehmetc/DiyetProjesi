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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiyetProje.PL
{
    public partial class UserProfileForm : Form
    {
        private readonly UserViewModel _user; // MainForm'dan gelen giriş yapmış olan kullanıcının bilgilerinin tutulduğu field
        private readonly MainForm _mainForm; // MainForm'un bilgilerinin tutulduğu field.
        public UserProfileForm(UserViewModel user, MainForm mainForm)
        {
            InitializeComponent();

            _user = user; // MainForm'dan gönderilen "user" bilgilerini "_user" field'ına aktarır.
            _mainForm = mainForm; // MainForm'dan gönderilen "mainForm" bilgilerini "_mainForm" field'ına aktarır.
            RetrieveAllData(); // Kullanıcının bilgileri form açıldığında ilgili kontrollere aktarılması için bu metot, form'un constructor'unda veya form_load eventinde çağırılır.
        }

        public void RetrieveAllData()
        {
            // ilgili textbox, label, picturebox'lara kullanıcının bilgilerinin aktarıldığı metottur.
            lblUserEMail.Text = _user.Email;
            lblName.Text = _user.FirstName;
            lblSurname.Text = _user.LastName;
            txtAge.Text = _user.Age.ToString();
            txtHeight.Text = _user.Height.ToString();
            txtWeight.Text = _user.Weight.ToString();

            // Kullanıcının resmi var ise gösterir yoksa loginAvatar resmi gösterilir.
            if (_user.Picture != null && _user.Picture.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(_user.Picture))
                    {
                        pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                        pbImage.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajını göster
                    MessageBox.Show($"Görüntü yüklenirken hata oluştu: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Profil fotoğrafı yoksa yapılacak işlemler
                pbImage.Image = Properties.Resources.loginAvatar;
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtHeight.Text) || string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Değişiklikler için şifrenizi girmeniz gereklidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAge.Text.Trim().Length == 0 || txtAge.Text != txtAge.Text.Trim() ||
                txtHeight.Text.Trim().Length == 0 || txtHeight.Text != txtHeight.Text.Trim() ||
                txtWeight.Text.Trim().Length == 0 || txtWeight.Text != txtWeight.Text.Trim())
            {
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

            // Kullanıcının bilgilerinde değişiklik yapabilmesi için mevcut şifresini doğru girmesi gerekli.
            // Eğer bu kontrol olmazsa (Kullanıcı şifresini girmezse) güncellenmiş bilgiler veritabanına aktarılırken şifre bilgisi gönderilmediğinden kullanıcın şifresi string'in default'u olan "null" değer olur.
            UserManager userManager = new UserManager();

            string sifrelenmis = Sha256Hasher.ComputeSha256Hash(password);
            if (_user.Password != sifrelenmis)
            {
                MessageBox.Show("Hatalı şifre girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kontroller tamamlandıktan sonra Yapılan değişikliklerin kaydedilmesi.
            _user.Password = sifrelenmis;
            _user.Age = age;
            _user.Weight = weight;
            _user.Height = height;


            userManager.Update(_user);
            MessageBox.Show("Güncelleme işlemi başarılı..");

            // Değişikliklerin geçerli olabilmesi için kullanıcının tekrar giriş yapması gerekli. Bu sebeple UserLoginForm'a yönlendirilir.
            UserLoginForm userLoginForm = new UserLoginForm(); 
            userLoginForm.Show();

            // UserLoginForm açıldıktan sonra şuanki form(UserProfileForm) ve showdialog ile açıldığından arkada açık olan MainForm formlarını gizler.
            this.Hide();
            _mainForm.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    byte[] imageData = File.ReadAllBytes(filePath);
                    _user.Picture = imageData;
                }
            }
            if (_user.Picture != null)
            {
                using (MemoryStream ms = new MemoryStream(_user.Picture))
                {
                    pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pbImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void llblPasswordChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı şifresini değiştirmek istediği zaman ilgili Link Label'a tıklayıp "PasswordChangeForm" a gider.
            // Bu durumu ayrı bir Form'da tutmamızın sebebi kullanıcı şifresinde değişiklik yapmak istemeyebilir. Bu durumda şifre değiştirmediğinden diğer bilgiler güncellendiğinde şifre bilgisi gönderilmez bu sebeple bu durumu ayrı bir Form'da gerçekleştirdik.
            PasswordChangeForm passwordChangeForm = new PasswordChangeForm(_user, _mainForm, this); // PasswordChangeForm'un constructor'una kullanıcının bilgilieri (_user), MainForm'un bilgileri (_mainForm) ve bu formun bilgileri (this) gönderilir.
            passwordChangeForm.ShowDialog();
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
