using DiyetProje.BL.Managers.Concrete;
using DiyetProje.BL.Models;
using DiyetProje.DAL.Entities;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminReportForm : Form
    {

        UserMealProductManager userMealProductManager = new();
        MealManager mealManager = new();
        CategoryManager categoryManager = new();
        ProductManager productManager = new();
        UserManager userManager = new UserManager();
        public AdminReportForm()
        {
            InitializeComponent();


            MealList();
            CategoryList();

            dgvReports.DataError += new DataGridViewDataErrorEventHandler(dgvReports_DataError);
        }

        public void MealList()
        {
            var meals = mealManager.GetAll().ToArray();
            cmbMealList.Items.Clear();
            cmbMealList.Items.Add("Öğün Seçiniz");
            cmbMealList.Items.AddRange(meals);
            cmbMealList.SelectedIndex = 0;
        }
        public void CategoryList()
        {
            var categories = categoryManager.GetAll().ToArray();
            cmbCategoryList.Items.Clear();
            cmbCategoryList.Items.Add("Kategori Seçiniz");
            cmbCategoryList.Items.AddRange(categories);
            cmbCategoryList.SelectedIndex = 0;
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            txtTotalCalorie.Text = string.Empty;
            dgvReports.DataSource = null;

            // Kullanıcının DateTimePicker'dan seçtiği günün gün değerini alır.
            int dateTime = dtpCalendar.Value.Day;

            // Seçilen günde oluşturulan tüm kullanıcı yemek ürünlerinin toplam kalori miktarını hesaplar ve 'txtTotalCalorie.Text' alanına atar.
            txtTotalCalorie.Text = userMealProductManager.GetAll()
                .Where(x => x.CreatedDate.Day == dateTime)
                .Sum(x => x.Amount * 100).ToString(); // Toplam kalori hesaplanır ve metin olarak atanır.

            // 'txtTotalCalorie' arka plan rengini Sarı-Yeşil yapar.
            txtTotalCalorie.BackColor = Color.YellowGreen;

            // 'txtTotalCalorie' yazı tipini Kalın (Bold) yapar.
            txtTotalCalorie.Font = new Font(txtTotalCalorie.Font, FontStyle.Bold);

            // Seçilen günde oluşturulan kullanıcı yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır ve yeni bir anonim tip oluşturur.
            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.CreatedDate.Day == dateTime)
                .Select(x => new
                {
                    Ad = x.User.FirstName, // Kullanıcının adı
                    Soyad = x.User.LastName, // Kullanıcının soyadı
                    Tarih = x.CreatedDate, // Oluşturulma tarihi
                    Öğün = x.Meal.MealName, // Öğünün adı
                    Ürün = x.Product.ProductName, // Ürün adı
                    ÜrünResmi = x.Product.Picture, // Ürün resmi
                    Açıklama = x.Product.Description, // Ürün açıklaması
                    PorsiyonAdedi = x.Amount, // Porsiyon adedi
                    Kalori = x.Amount * 100 // Kalori (Porsiyon adedi * 100)
                }).ToList(); // Sonuçları bir listeye dönüştürür

            // Oluşan sonuç listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = userMealProducts;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            txtTotalCalorie.Text = string.Empty;
            dgvReports.DataSource = null;

            if (cmbMealList.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen öğün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCategoryList.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı tarafından seçilen öğün adını (meal) ve kategori adını (category) alır.
            string meal = cmbMealList.Text;
            string category = cmbCategoryList.Text;

            // Şu anki tarih ve saati alır.
            DateTime nowDay = DateTime.Now;

            // Şu anki tarihten 7 gün öncesini hesaplar.
            DateTime oneWeekAgo = nowDay.AddDays(-7);

            // Belirli bir öğünün son 7 gündeki toplam kalori miktarını hesaplar ve 'txtTotalCalorie.Text' alanına atar.
            txtTotalCalorie.Text = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay)
                .Sum(x => x.Amount * 100).ToString(); // Toplam kalori hesaplanır ve metin olarak atanır.

            // 'txtTotalCalorie' arka plan rengini Sarı-Yeşil yapar.
            txtTotalCalorie.BackColor = Color.YellowGreen;

            // 'txtTotalCalorie' yazı tipini Kalın (Bold) yapar.
            txtTotalCalorie.Font = new Font(txtTotalCalorie.Font, FontStyle.Bold);

            // Belirli bir öğüne ait son 7 gündeki yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır.
            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay)
                .ToList();

            // Tüm ürünleri (Product) alır ve listeye dönüştürür.
            var products = productManager.GetAll().ToList();

            // Tüm kategorileri (Category) alır ve listeye dönüştürür.
            var categories = categoryManager.GetAll().ToList();

            // Kullanıcı yemek ürünleri, ürünler ve kategoriler arasındaki ilişkiyi belirli bir kategoriye göre birleştirir ve yeni bir anonim tip oluşturur.
            var result = (from ump in userMealProducts
                          join p in products on ump.ProductId equals p.Id // Ürün ve kullanıcı yemek ürünleri eşleştirilir.
                          join c in categories on p.CategoryId equals c.Id // Kategoriler ve ürünler eşleştirilir.
                          where c.CategoryName == category // Belirli bir kategoriye göre filtrelenir.
                          select new
                          {
                              Ad = ump.User.FirstName, // Kullanıcının adı
                              Soyad = ump.User.LastName, // Kullanıcının soyadı
                              Tarih = ump.CreatedDate, // Oluşturulma tarihi
                              Öğün = ump.Meal.MealName, // Öğünün adı
                              Kategori = c.CategoryName, // Kategori adı
                              Ürün = p.ProductName, // Ürün adı
                              ÜrünResmi = p.Picture, // Ürün resmi
                              Açıklama = p.Description, // Ürün açıklaması
                              PorsiyonAdedi = ump.Amount, // Porsiyon adedi
                              Kalori = ump.Amount * 100 // Kalori (Porsiyon adedi * 100)
                          }).ToList();

            // Oluşan sonuç listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = result;

        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            txtTotalCalorie.Text = string.Empty;
            dgvReports.DataSource = null;

            if (cmbMealList.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen öğün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCategoryList.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı tarafından seçilen öğün adını (meal) ve kategori adını (category) alır.
            string meal = cmbMealList.Text;
            string category = cmbCategoryList.Text;

            // Şu anki tarih ve saati alır.
            DateTime nowDay = DateTime.Now;

            // Şu anki tarihten 30 gün öncesini hesaplar.
            DateTime oneWeekAgo = nowDay.AddDays(-30);

            // Belirli bir öğünün son 30 gündeki toplam kalori miktarını hesaplar ve 'txtTotalCalorie.Text' alanına atar.
            txtTotalCalorie.Text = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay)
                .Sum(x => x.Amount * 100).ToString();

            // 'txtTotalCalorie' arka plan rengini Sarı-Yeşil yapar.
            txtTotalCalorie.BackColor = Color.YellowGreen;

            // 'txtTotalCalorie' yazı tipini Kalın (Bold) yapar.
            txtTotalCalorie.Font = new Font(txtTotalCalorie.Font, FontStyle.Bold);

            // Belirli bir öğüne ait son 30 gündeki yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır.
            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay)
                .ToList();

            // Tüm ürünleri (Product) alır ve listeye dönüştürür.
            var products = productManager.GetAll().ToList();

            // Tüm kategorileri (Category) alır ve listeye dönüştürür.
            var categories = categoryManager.GetAll().ToList();

            // Kullanıcı yemek ürünleri, ürünler ve kategoriler arasındaki ilişkiyi belirli bir kategoriye göre birleştirir ve yeni bir anonim tip oluşturur.
            var result = (from ump in userMealProducts
                          join p in products on ump.ProductId equals p.Id // Ürün ve kullanıcı yemek ürünleri eşleştirilir.
                          join c in categories on p.CategoryId equals c.Id // Kategoriler ve ürünler eşleştirilir.
                          where c.CategoryName == category // Belirli bir kategoriye göre filtrelenir.
                          select new
                          {
                              Ad = ump.User.FirstName, // Kullanıcının adı
                              Soyad = ump.User.LastName, // Kullanıcının soyadı
                              Tarih = ump.CreatedDate, // Oluşturulma tarihi
                              Öğün = ump.Meal.MealName, // Öğünün adı
                              Kategori = c.CategoryName, // Kategori adı
                              Ürün = p.ProductName, // Ürün adı
                              ÜrünResmi = p.Picture, // Ürün resmi
                              Açıklama = p.Description, // Ürün açıklaması
                              PorsiyonAdedi = ump.Amount, // Porsiyon adedi
                              Kalori = ump.Amount * 100 // Kalori (Porsiyon adedi * 100)
                          }).ToList();

            // Oluşan sonuç listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = result;

        }

        private void btnMostEaten_Click(object sender, EventArgs e)
        {
            // DataGridView (dgvReports) kontrolünün veri kaynağını sıfırlar (mevcut verileri temizler).
            dgvReports.DataSource = null;

            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                // Alınan tüm kullanıcı yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır ve ürün adına göre gruplar.
                .GroupBy(x => x.Product.ProductName)
                // Gruplar üzerinden her ürün için yeni bir anonim tip oluşturur. Bu tip, ürün adı ve toplam porsiyon adedini içerir.
                .Select(x => new
                {
                    Ürün = x.Key, // Ürün adı (gruplandırma anahtarı)
                    ToplamPorsiyonAdedi = x.Sum(p => p.Amount), // Toplam porsiyon adedi (gruptaki öğelerin miktarlarının toplamı)
                })
                .ToList(); // Sonuçları bir listeye dönüştürür

            // Oluşan kullanıcı yemek ürünleri listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = userMealProducts;

            // DataGridView'da "ToplamPorsiyonAdedi" adlı kolonun ismini "Toplam Porsiyon Adedi" olarak değiştirir.
            dgvReports.Columns["ToplamPorsiyonAdedi"].HeaderText = "Toplam Porsiyon Adedi";

        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            // 'userManager' üzerinden tüm kullanıcıları alır.
            var users = userManager.GetAll()
                .Select(x => new
                {
                    x.FirstName, // Kullanıcının adı
                    x.LastName, // Kullanıcının soyadı
                    x.Email, // Kullanıcının e-posta adresi
                    x.Password, // Kullanıcının şifresi
                    x.Age, // Kullanıcının yaşı
                    x.Picture, // Kullanıcının resmi
                    x.Height, // Kullanıcının boyu
                    x.Weight, // Kullanıcının kilosu
                    x.Gender, // Kullanıcının cinsiyeti
                    x.IsAdministrator // Kullanıcının yönetici olup olmadığı bilgisi
                })
                .ToList();

            // Oluşan kullanıcı listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = users;

        }

        // Resmi olmayan ürün olduğunda çıkan hata mesajını kaldırma
        private void dgvReports_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        
        // DataGridView'i düzenlemeyi engelleme
        private void dgvReports_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

