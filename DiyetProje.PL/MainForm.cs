using DiyetProje.BL.Managers.Concrete;
using DiyetProje.BL.Models;
using DiyetProje.DAL.Context;
using DiyetProje.DAL.Entities;
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
    public partial class MainForm : Form
    {
        private readonly UserViewModel _user; // UserLoginForm'dan gelen "user" bilgisinin tutulduğu field.
        UserMealProductManager userMealProductManager = new UserMealProductManager(); // UserMealProductViewModel'in CRUD işlemleri için kullanılan Manager
        MealManager mealManager = new MealManager(); // MealViewModel'in CRUD işlemleri için kullanılan Manager
        ProductManager productManager = new ProductManager(); // ProductViewModel'in CRUD işlemleri için kullanılan Manager
        UserMealProductViewModel secilen;

        public MainForm(UserViewModel user)
        {
            InitializeComponent();
            _user = user; // UserLoginForm'dan gönderilen "user" bilgilerini "_user" field'ına aktarır.

            lblUserName.Text = _user.FirstName + " " + _user.LastName;

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
                    MessageBox.Show($"Görüntü yüklenirken hata oluştu: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                pbImage.Image = Properties.Resources.loginAvatar;
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // Öğün ve Ürün combobox'larına veritabanındaki bilgiler doldurulur.
            MealList();
            ProductList();

            // DataGridView içine O kullanıcıya ait UserMealProduct bilgileri doldurulur.
            FillDgv();
        }

        private void btnMealAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtPortionAmount.Text) <= 0)
                {
                    MessageBox.Show("Porsiyon adedi 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Combobox'larda herhangi bir öğün veya ürün seçilmiş mi kontrolü yapar. Aynı zamanda porsiyon adedi boş mu kontrolü yapar.
                if (cmbMeal.SelectedIndex != 0 && cmbProduct.SelectedIndex != 0 && !string.IsNullOrWhiteSpace(txtPortionAmount.Text))
                {
                    int mealId = ((MealViewModel)cmbMeal.SelectedItem).Id; // cmbMeal'da seçilmiş öğünün(Sabah, Öğle, Akşam vs.) Id bilgisini tutar.
                    int productId = ((ProductViewModel)cmbProduct.SelectedItem).Id; // cmbProduct'da seçilmiş ürünün(Kayısı, Elma, Çikolata vs.) Id bilgisini tutar.
                    double portionAmount = Convert.ToDouble(txtPortionAmount.Text);
                    int userId = _user.Id; 

                    UserMealProductViewModel userMealProductViewModel = new UserMealProductViewModel() // Yeni bir UserMealProduct oluşturur.
                    {
                        UserId = userId,
                        MealId = mealId,
                        ProductId = productId,
                        Amount = portionAmount
                    };

                    userMealProductManager.Insert(userMealProductViewModel);
                    MessageBox.Show("Ekleme başarılı.");

                    ResetSelectedItems(); // Ekleme başarılı olduktan sonra combobox, textbox gibi bilgileri sıfırlar.
                    FillDgv(); // DataGridView'ı tekrar günceller.
                }
                else
                {
                    MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnMealDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilen != null) // DataGridView'da seçilen satır var mı kontorlü yapar.
                {
                    // Seçilmiş bir satır varsa
                    userMealProductManager.Delete(secilen);
                    MessageBox.Show("Silme işlemi başarılı");

                    ResetSelectedItems();
                    FillDgv();
                }
                else
                {
                    MessageBox.Show("Lütfen önce Öğün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMealUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilen != null)
                {
                    if (Convert.ToDouble(txtPortionAmount.Text) <= 0)
                    {
                        MessageBox.Show("Porsiyon adedi 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (cmbMeal.SelectedIndex != 0 && cmbProduct.SelectedIndex != 0 && !string.IsNullOrWhiteSpace(txtPortionAmount.Text))
                    {
                        int mealId = ((MealViewModel)cmbMeal.SelectedItem).Id;
                        int productId = ((ProductViewModel)cmbProduct.SelectedItem).Id;
                        double portionAmount = Convert.ToDouble(txtPortionAmount.Text);
                        int userId = _user.Id;

                        // secilen satırdaki bilgileri kullanıcının tekrar girmiş olduğu bilgiler ile değiştirir.
                        secilen.UserId = userId;
                        secilen.MealId = mealId;
                        secilen.ProductId = productId;
                        secilen.Amount = portionAmount;

                        userMealProductManager.Update(secilen);
                        MessageBox.Show("Güncelleme başarılı.");

                        ResetSelectedItems();
                        FillDgv();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen önce Öğün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void dgvMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = (UserMealProductViewModel)dgvMeals.SelectedRows[0].DataBoundItem; // DataGridView'da seçilen satırın bilgilerini "secilen" değişkeninde tutar.

            if (secilen != null)
            {
                cmbMeal.SelectedItem = secilen.Meal; // secilen satırın öğün bilgisini cmbMeal combobox'ına atar.
                cmbProduct.SelectedItem = secilen.Product; // secilen satırın ürün bilgisini cmbProduct combobox'ına atar.
                txtPortionAmount.Text = secilen.Amount.ToString(); // secilen satırın porsiyon bilgisini txtPortionAmount textbox'ına atar.
                lblSecilen.Text = "Seçilen: " + secilen.Meal.MealName + " " + secilen.Product.ProductName + " " + secilen.Amount; // hangi satır seçildiğini belirtmek için oluşturulmuş olan "lblSecilen" adındaki Label'a belirtilen özellikleri yazar.
            }
            else
            {
                // eğer seçilen satır yoksa.
                lblSecilen.Text = "Seçilen: ";
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm(_user, this); // Kullanıcı Profil butonuna tıkladığında UserProfileForm açılır ve UserProfileForm'a "user" bilgilerini ve bu formun bilgilerini gönderir.
            userProfileForm.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            UserReportForm userReportForm = new UserReportForm(_user); // Kullanıcı Raporlar butonuna tıkladığında UserReportForm açılır ve UserReportForm'a user'ın bilgilerini gönderir.
            userReportForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MealList()
        {
            // Kullanıcı giriş yaptıktan sonra MainForm açıldığında oluşturduğumuz cmbMeal'a veritabanındaki Öğün bilgilerini atamak için bu metot oluşturulmuştur.
            var meals = mealManager.GetAll().ToArray(); // mealManager.GetAll().ToArray() => veritabanındaki öğün bilgilerini (DataStatus'u deleted olmayan öğünler) Array dizisi şeklinde getirir ve "meals" değişkenine atar.
            cmbMeal.Items.Clear(); // combobox'ın içindeki bilgileri temizler.
            cmbMeal.Items.Add("Öğün Seçiniz"); // combobox'ın item'ına "Öğün Seçiniz" ekler.
            cmbMeal.Items.AddRange(meals); // daha öncesinde veritabanından getirtiğimiz öğün bilgilerini(216. satır meals değişkeni) cmbMeal'ın item'larına ekler.
            cmbMeal.SelectedIndex = 0; // Form ilk açıldığında cmbMeal'da görünecek ilk değer default olarak 0 atanır. (Öğün Seçiniz)

            // Daha sonrasında bu metot MainForm constructor'u içinde veya Form_Load eventi içinde çağırılarak form ilk başlatıldığında bu metodun çalışılması sağlanır.
        }

        public void ProductList()
        {
            var products = productManager.GetAll().ToArray();
            cmbProduct.Items.Clear();
            cmbProduct.Items.Add("Ürün Seçiniz");
            cmbProduct.Items.AddRange(products);
            cmbProduct.SelectedIndex = 0;
        }

        public void FillDgv()
        {
            // Design kısmında oluşturulmuş olan DataGridView'ı doldurmak için bu metot yazılmıştır. 

            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
            .Where(x => x.UserId == _user.Id).ToList();
            // 'userMealProductManager' üzerinden tüm kullanıcı yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır.
            // Alınan tüm kullanıcı yemek ürünleri arasından giriş yapmış kullanıcıya ait olanları filtreler. (x.UserId == _user.Id)

            dgvMeals.DataSource = userMealProducts; // DataGridView'ın DataSource'una "userMealProducts" değişkeninde liste halinde tutulmuş bilgileri ekler.

            // İstenmeyen kolonların kaldırılması.
            dgvMeals.Columns[0].Visible = dgvMeals.Columns[1].Visible = dgvMeals.Columns[2].Visible = dgvMeals.Columns[3].Visible = false;

            // DataGridView kolon sıralarını değiştirme
            dgvMeals.Columns["User"].DisplayIndex = 0;
            dgvMeals.Columns["Meal"].DisplayIndex = 1;
            dgvMeals.Columns["Product"].DisplayIndex = 2;
            dgvMeals.Columns["Amount"].DisplayIndex = 3;
            dgvMeals.Columns["CreatedDate"].DisplayIndex = 4;

            // DataGridView kolon isimlerini değiştirme
            dgvMeals.Columns["User"].HeaderText = "Kullanıcı";
            dgvMeals.Columns["Meal"].HeaderText = "Öğün";
            dgvMeals.Columns["Product"].HeaderText = "Ürün";
            dgvMeals.Columns["Amount"].HeaderText = "Miktar";
            dgvMeals.Columns["CreatedDate"].HeaderText = "Tarih";

            // Daha sonrasında bu metot MainForm constructor'u içinde veya Form_Load eventi içinde çağırılarak form ilk başlatıldığında bu metodun çalışılması sağlanır.
        }

        public void ResetSelectedItems()
        {
            // Bu metot Ekleme, Silme, Güncelleme işlemlerinden sonra combobox, textbox gibi nesnelerin boşaltılması için kullanılır.
            
            secilen = null;
            cmbMeal.SelectedIndex = 0;
            cmbProduct.SelectedIndex = 0;
            txtPortionAmount.Text = string.Empty;
            lblSecilen.Text = "Seçilen: ";
        }

        // Kullanıcının DataGridView'daki hücreye iki kere tıklayıp düzenleme yapabilmesini önler.
        private void dgvMeals_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
