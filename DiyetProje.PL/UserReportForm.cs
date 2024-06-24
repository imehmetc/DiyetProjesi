using DiyetProje.BL.Managers.Concrete;
using DiyetProje.BL.Models;
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
    public partial class UserReportForm : Form
    {
        private readonly UserViewModel _user; // MainForm'dan gelen "user" bilgisinin tutulduğu field.
        UserMealProductManager userMealProductManager = new UserMealProductManager(); // UserMealProductViewModel'in CRUD işlemleri için kullanılan Manager
        MealManager mealManager = new MealManager(); // MealViewModel'in CRUD işlemleri için kullanılan Manager
        CategoryManager categoryManager = new CategoryManager(); // CategoryViewModel'in CRUD işlemleri için kullanılan Manager
        ProductManager productManager = new ProductManager(); // ProductViewModel'in CRUD işlemleri için kullanılan Manager
        public UserReportForm(UserViewModel user)
        {
            InitializeComponent();
            
            _user = user; // MainForm'dan gönderilen "user" bilgilerini "_user" field'ına aktarır.

            // Öğün ve Ürün combobox'larına veritabanındaki bilgiler doldurulur.
            MealList();
            CategoryList();

            // DataError eventi'nin form açıldığında çalışması için gerekli kod parçası.
            dgvReports.DataError += new DataGridViewDataErrorEventHandler(dgvReports_DataError_1);
        }
        public void MealList()
        {
            // ReportForm açıldığında oluşturduğumuz cmbMealList'e veritabanındaki Öğün bilgilerini atamak için bu metot oluşturulmuştur.
            var meals = mealManager.GetAll().ToArray();
            cmbMealList.Items.Clear();
            cmbMealList.Items.Add("Öğün Seçiniz");
            cmbMealList.Items.AddRange(meals);
            cmbMealList.SelectedIndex = 0;
        }
        public void CategoryList()
        {
            // ReportForm açıldığında oluşturduğumuz cmbCategoryList'e veritabanındaki Kategori bilgilerini atamak için bu metot oluşturulmuştur.
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

            int dateTime = dtpCalendar.Value.Day; // bu değişken DateTimePicker'dan seçilmiş olan tarihin gün bilgisini tutar.

            txtTotalCalorie.Text = userMealProductManager.GetAll().Where(x => x.UserId == _user.Id && x.CreatedDate.Day == dateTime).Sum(x => x.Amount * 100).ToString(); // İlgili kullanıcının DateTimePicker'dan seçilen günkü öğünlerinin toplam kalori miktarı hesaplanır ve "txtTotalCalorie.Text" alanına atanır.

            txtTotalCalorie.BackColor = Color.YellowGreen;
            txtTotalCalorie.Font = new Font(txtTotalCalorie.Font, FontStyle.Bold);

            // 'userMealProductManager' üzerinden tüm kullanıcı yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır.
            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.UserId == _user.Id && x.CreatedDate.Day == dateTime)// Alınan tüm kullanıcı yemek ürünleri arasından, ilgili kullanıcıya (_user) ve seçilen tarihe (CreatedDate.Day == dateTime) ait olanları filtreler.
                .Select(x => new // Filtrelenen verileri yeni bir anonim tipe dönüştürür.
                {
                    Ad = x.User.FirstName, // Kullanıcının adı
                    Soyad = x.User.LastName, // Kullanıcının soyadı
                    Tarih = x.CreatedDate, // Oluşturulma tarihi
                    Öğün = x.Meal.MealName, // Öğünün adı
                    Ürün = x.Product.ProductName, // Ürünün adı
                    ÜrünResmi = x.Product.Picture, // Ürünün resmi
                    Açıklama = x.Product.Description, // Ürünün açıklaması
                    PorsiyonAdedi = x.Amount, // Porsiyon adedi
                    Kalori = x.Amount * 100 // Kalori (Porsiyon adedi * 100)
                })
                .ToList(); // Sonuçları bir listeye dönüştürür

            // Oluşan kullanıcı yemek ürünleri listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
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

            string meal = cmbMealList.Text; // ComboBox'tan seçilen Öğün bilgisinin tutulduğu değişken
            string category = cmbCategoryList.Text; // ComboBox'tan seçilen Kategori bilgisinin tutulduğu değişken

            DateTime nowDay = DateTime.Now; // Şimdiki zaman
            DateTime oneWeekAgo = nowDay.AddDays(-7); // Şimdiki zamanının 7 gün öncesi

            // Belirli bir kullanıcının son bir haftadaki belirli öğünün toplam kalori miktarını hesaplar ve 'txtTotalCalorie.Text' alanına atanır.
            txtTotalCalorie.Text = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.UserId == _user.Id && x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay)
                .Sum(x => x.Amount * 100).ToString();

            // 'txtTotalCalorie' arka plan rengini Sarı-Yeşil yapar.
            txtTotalCalorie.BackColor = Color.YellowGreen;

            // 'txtTotalCalorie' yazı tipini Kalın (Bold) yapar.
            txtTotalCalorie.Font = new Font(txtTotalCalorie.Font, FontStyle.Bold);

            // Belirli bir kullanıcının son bir haftadaki belirli öğüne ait yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır.
            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.UserId == _user.Id && x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay).ToList();

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
                          }).ToList(); // Sonuçları bir listeye dönüştürür

            // Oluşan sonuç listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = result;

        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = null;
            txtTotalCalorie.Text = string.Empty;

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

            string meal = cmbMealList.Text; // ComboBox'tan seçilen Öğün bilgisinin tutulduğu değişken
            string category = cmbCategoryList.Text; // ComboBox'tan seçilen Kategori bilgisinin tutulduğu değişken

            DateTime nowDay = DateTime.Now; // Şimdiki zaman
            DateTime oneWeekAgo = nowDay.AddDays(-30); // Şimdiki zamanın 30 gün öncesi

            // Belirli bir kullanıcının son bir haftadaki belirli öğünün toplam kalori miktarını hesaplar ve 'txtTotalCalorie.Text' alanına atanır.
            txtTotalCalorie.Text = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.UserId == _user.Id && x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay)
                .Sum(x => x.Amount * 100).ToString();

            // 'txtTotalCalorie' arka plan rengini Sarı-Yeşil yapar.
            txtTotalCalorie.BackColor = Color.YellowGreen;

            // 'txtTotalCalorie' yazı tipini Kalın (Bold) yapar.
            txtTotalCalorie.Font = new Font(txtTotalCalorie.Font, FontStyle.Bold);

            // Belirli bir kullanıcının son bir haftadaki belirli öğüne ait yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır.
            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                .Where(x => x.UserId == _user.Id && x.Meal.MealName == meal && x.CreatedDate >= oneWeekAgo && x.CreatedDate <= nowDay).ToList();

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
                          }).ToList(); // Sonuçları bir listeye dönüştürür

            // Oluşan sonuç listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = result;

        }

        private void btnMostEaten_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = null;
            txtTotalCalorie.Text = string.Empty;
            txtTotalCalorie.BackColor = Color.White;

            // İlgili kullanıcının (_user) tüm yemek ürünlerini ilişkili tablolar (User, Product, Meal) ile birlikte alır.
            var userMealProducts = userMealProductManager.GetAllWithIncludes(["User", "Product", "Meal"])
                // Alınan tüm kullanıcı yemek ürünleri arasından sadece ilgili kullanıcıya (_user) ait olanları filtreler.
                .Where(x => x.UserId == _user.Id)
                // Filtrelenen verileri ürün adına göre gruplar.
                .GroupBy(x => x.Product.ProductName)
                // Gruplar üzerinden her ürün için yeni bir anonim tip oluşturur. Bu tip, ürün adı ve toplam porsiyon adedini içerir.
                .Select(x => new
                {
                    Ürün = x.Key, // Ürün adı (gruplandırma anahtarı)
                    ToplamPorsiyonAdedi = x.Sum(p => p.Amount), // Toplam porsiyon adedi (gruptaki öğelerin miktarlarının toplamı)
                })
                .ToList();

            // Oluşan kullanıcı yemek ürünleri listesini DataGridView'e (dgvReports) veri kaynağı olarak atar.
            dgvReports.DataSource = userMealProducts;

            // DataGridView'da "ToplamPorsiyonAdedi" adlı kolonun ismini "Toplam Porsiyon Adedi" olarak değiştirir.
            dgvReports.Columns["ToplamPorsiyonAdedi"].HeaderText = "Toplam Porsiyon Adedi";
        }

        // Kullanıcının DataGridView'daki hücreye iki kere tıklayıp düzenleme yapabilmesini önler.
        private void dgvReports_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        // DataGridView'de ürünün resmi olmadığında oluşan hata mesajını gizlemek için kullanılır
        private void dgvReports_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
