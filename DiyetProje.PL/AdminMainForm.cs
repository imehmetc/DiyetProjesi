using DiyetProje.BL.Managers.Concrete;
using DiyetProje.BL.Models;
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
using static System.Net.Mime.MediaTypeNames;

namespace DiyetProje.PL
{
    public partial class AdminMainForm : Form
    {
        private readonly UserViewModel _user; // AdminLoginForm'dan gelen "user" bilgisinin tutulduğu field.
        private ProductViewModel _productView; // Ürün ekleme işlemi için globalde tanımlanmış ProductViewModel field'ı
        MealManager mealManager = new MealManager(); // MealViewModel'in CRUD işlemleri için kullanılan Manager
        ProductManager productManager = new ProductManager(); // ProductViewModel'in CRUD işlemleri için kullanılan Manager
        CategoryManager categoryManager = new CategoryManager(); // CategoryViewModel'in CRUD işlemleri için kullanılan Manager
        public AdminMainForm(UserViewModel user)
        {
            InitializeComponent();
            _user = user;

            lblUserName.Text = _user.FirstName + " " + _user.LastName;

            // DataError eventi'nin form açıldığında çalışması için gerekli kod parçası.
            dgvProductList.DataError += new DataGridViewDataErrorEventHandler(dgvProductList_DataError);

            btnProductAdd.Enabled = false;
            
            // Öğün, Kategori ve Ürün DataGridView'larına veritabanındaki bilgiler doldurulur.
            MealList();
            CategoryList();
            ProductList();

            // Category combobox'ına veritabanındaki bilgiler doldurulur.
            CategoryCmbList();
        }
        public void MealResetItems()
        {
            // Öğün panelindeki kontrollerin Ekleme, Silme, Güncelleme işlemlerinden sonra temizlenmesi için yazılmış metot.
            selectedMeal = null;
            lblSelectedMeal.Text = "Seçilen: ";
            txtMealName.Text = string.Empty;
            txtMealDescription.Text = string.Empty;
        }
        public void CategoryResetItems()
        {
            // Kategori panelindeki kontrollerin Ekleme, Silme, Güncelleme işlemlerinden sonra temizlenmesi için yazılmış metot.
            selectedCategory = null;
            lblSelectedCategory.Text = "Seçilen: ";
            txtCategoryName.Text = string.Empty;
            txtCategoryDescription.Text = string.Empty;
        }
        public void ProductResetItems()
        {
            // Ürün panelindeki kontrollerin Ekleme, Silme, Güncelleme işlemlerinden sonra temizlenmesi için yazılmış metot.
            selectedProduct = null;
            lblSelectedProduct.Text = "Seçilen: ";
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtPortionUnit.Text = string.Empty;
            cmbProductCategory.SelectedIndex = 0;
        }
        public void MealList()
        {
            // Öğün bilgilerini veritabanından alıp DataGridView'a aktarılması için yazılmış metot.
            var meals = mealManager.GetAll().ToList();
            dgvMealList.DataSource = meals;

            // DataGridView kolon isimlerini değiştirme
            dgvMealList.Columns["Id"].HeaderText = "Öğün ID";
            dgvMealList.Columns["MealName"].HeaderText = "Öğün Adı";
            dgvMealList.Columns["Description"].HeaderText = "Açıklama";

            // Daha sonrasında bu metot AdminMainForm constructor'u içinde veya Form_Load eventi içinde çağırılarak form ilk başlatıldığında bu metodun çalışılması sağlanır.
        }
        public void CategoryList()
        {
            var categories = categoryManager.GetAll().ToList();
            dgvCategoryList.DataSource = categories;

            // DataGridView kolon isimlerini değiştirme
            dgvCategoryList.Columns["Id"].HeaderText = "Kategori ID";
            dgvCategoryList.Columns["CategoryName"].HeaderText = "Kategori Adı";
            dgvCategoryList.Columns["Description"].HeaderText = "Açıklama";
           
            // Daha sonrasında bu metot AdminMainForm constructor'u içinde veya Form_Load eventi içinde çağırılarak form ilk başlatıldığında bu metodun çalışılması sağlanır.
        }
        public void ProductList()
        {
            // 'productManager' üzerinden tüm ürünleri ilişkili tablolar (Category, UserMealProducts) ile birlikte alır.
            var products = productManager.GetAllWithIncludes(["Category", "UserMealProducts"]).ToList();

            // Oluşan ürün listesini DataGridView'e (dgvProductList) veri kaynağı olarak atar.
            dgvProductList.DataSource = products;

            // CategoryId kolonunu gizler.
            dgvProductList.Columns["CategoryId"].Visible = false;

            // DataGridView kolon sıralarını değiştirme
            dgvProductList.Columns["Id"].DisplayIndex = 0;
            dgvProductList.Columns["ProductName"].DisplayIndex = 1;
            dgvProductList.Columns["PortionUnit"].DisplayIndex = 2;
            dgvProductList.Columns["Description"].DisplayIndex = 3;
            dgvProductList.Columns["Picture"].DisplayIndex = 4;
            dgvProductList.Columns["Category"].DisplayIndex = 5;

            // DataGridView kolon isimlerini değiştirme
            dgvProductList.Columns["Id"].HeaderText = "Ürün ID";
            dgvProductList.Columns["ProductName"].HeaderText = "Ürün Adı";
            dgvProductList.Columns["PortionUnit"].HeaderText = "Porsiyon Birimi";
            dgvProductList.Columns["Description"].HeaderText = "Açıklama";
            dgvProductList.Columns["Picture"].HeaderText = "Ürün Resmi";
            dgvProductList.Columns["Category"].HeaderText = "Kategorisi";

            // Daha sonrasında bu metot AdminMainForm constructor'u içinde veya Form_Load eventi içinde çağırılarak form ilk başlatıldığında bu metodun çalışılması sağlanır.
        }
        public void CategoryCmbList()
        {
            // AdminMainForm açıldığında oluşturduğumuz cmbProductCategory'a veritabanındaki Kategori bilgilerini atamak için bu metot oluşturulmuştur.
            var categories = categoryManager.GetAll().ToArray();
            cmbProductCategory.Items.Clear();
            cmbProductCategory.Items.Add("Kategori Seçiniz");
            cmbProductCategory.Items.AddRange(categories);
            cmbProductCategory.SelectedIndex = 0;

            // Daha sonrasında bu metot AdminMainForm constructor'u içinde veya Form_Load eventi içinde çağırılarak form ilk başlatıldığında bu metodun çalışılması sağlanır.
        }

        private void btnMealAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string mealName = txtMealName.Text;
                string mealDescription = txtMealDescription.Text;
                if (string.IsNullOrWhiteSpace(mealName) || string.IsNullOrWhiteSpace(mealDescription))
                {
                    MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MealViewModel mealViewModel = new MealViewModel
                {
                    MealName = mealName,
                    Description = mealDescription
                };
                mealManager.Insert(mealViewModel);
                MessageBox.Show("Ekleme başarılı.");
                MealResetItems();
                MealList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        MealViewModel selectedMeal;
        private void dgvMealList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMeal = (MealViewModel)dgvMealList.SelectedRows[0].DataBoundItem;

            if (selectedMeal != null)
            {
                txtMealName.Text = selectedMeal.MealName;
                txtMealDescription.Text = selectedMeal.Description;
                lblSelectedMeal.Text = "Seçilen: " + selectedMeal.MealName + " ==> " + selectedMeal.Description;
            }
            else
            {
                lblSelectedMeal.Text = "Seçilen: ";
            }
        }

        private void btnMealDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMeal != null)
                {
                    mealManager.Delete(selectedMeal);
                    MessageBox.Show("Silme işlemi başarılı");

                    MealResetItems();
                    MealList();
                }
                else
                {
                    MessageBox.Show("Lütfen önce Öğün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen çok hızlı işlem yapmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMealUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMeal != null)
                {
                    string mealName = txtMealName.Text;
                    string mealDescription = txtMealDescription.Text;
                    if (string.IsNullOrWhiteSpace(mealName) || string.IsNullOrWhiteSpace(mealDescription))
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    selectedMeal.MealName = mealName;
                    selectedMeal.Description = mealDescription;
                    mealManager.Update(selectedMeal);
                    MessageBox.Show("Güncelleme başarılı.");
                    MealResetItems();
                    MealList();
                }
                else
                    MessageBox.Show("Lütfen bir öğün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = txtCategoryName.Text;
                string categoryDescription = txtCategoryDescription.Text;
                if (string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(categoryDescription))
                {
                    MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CategoryViewModel categoryViewModel = new CategoryViewModel
                {
                    CategoryName = categoryName,
                    Description = categoryDescription
                };
                categoryManager.Insert(categoryViewModel);
                MessageBox.Show("Ekleme başarılı.");
                CategoryCmbList();
                CategoryResetItems();
                CategoryList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        CategoryViewModel selectedCategory;
        private void dgvCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = (CategoryViewModel)dgvCategoryList.SelectedRows[0].DataBoundItem;

            if (selectedCategory != null)
            {
                txtCategoryName.Text = selectedCategory.CategoryName;
                txtCategoryDescription.Text = selectedCategory.Description;
                lblSelectedCategory.Text = "Seçilen: " + selectedCategory.CategoryName + " ==> " + selectedCategory.Description;
            }
            else
            {
                lblSelectedCategory.Text = "Seçilen: ";
            }
        }
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCategory != null)
                {
                    categoryManager.Delete(selectedCategory);
                    var products = productManager.Search(x=>x.CategoryId==selectedCategory.Id).ToList();
                    foreach (var product in products)
                    {
                        productManager.Delete(product);
                    }

                    MessageBox.Show("Silme işlemi başarılı.");
                    ProductList();
                    CategoryCmbList();
                    CategoryResetItems();
                    CategoryList();
                }
                else
                {
                    MessageBox.Show("Lütfen önce Kategori seçiniz.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCategory != null)
                {
                    string categoryName = txtCategoryName.Text;
                    string categoryDescription = txtCategoryDescription.Text;
                    if (string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(categoryDescription))
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    selectedCategory.CategoryName = categoryName;
                    selectedCategory.Description = categoryDescription;
                    categoryManager.Update(selectedCategory);
                    MessageBox.Show("Güncelleme başarılı.");
                    CategoryCmbList();
                    CategoryResetItems();
                    CategoryList();
                }
                else
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = txtProductName.Text;
                string productDescription = txtProductDescription.Text;
                int portionUnit;
                string productCategory = cmbProductCategory.Text;
                if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(productDescription) || string.IsNullOrWhiteSpace(productCategory) || string.IsNullOrWhiteSpace(txtPortionUnit.Text) || pbProductImage.Image == null)
                {
                    MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbProductCategory.SelectedIndex == 0)
                {
                    MessageBox.Show("Lütfen kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtPortionUnit.Text, out portionUnit))
                {
                    MessageBox.Show("Lütfen porsiyon birimine tam sayı bir değer girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (portionUnit <= 0)
                {
                    MessageBox.Show("Porsiyon birimi 0'dan küçük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Ekleme başarılı.");
                ProductResetItems();
                ProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        ProductViewModel selectedProduct;
        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProduct = (ProductViewModel)dgvProductList.SelectedRows[0].DataBoundItem;

            if (selectedProduct != null)
            {
                txtProductName.Text = selectedProduct.ProductName;
                txtProductDescription.Text = selectedProduct.Description;
                txtPortionUnit.Text = selectedProduct.PortionUnit.ToString();
                cmbProductCategory.SelectedItem = selectedProduct.Category;

                if (selectedProduct.Picture != null && selectedProduct.Picture.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(selectedProduct.Picture))
                        {
                            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
                            pbProductImage.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata mesajını göster veya logla
                        MessageBox.Show($"Görüntü yüklenirken hata oluştu: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Profil fotoğrafı yoksa yapılacak işlemler
                    pbProductImage.Image = Properties.Resources.loginAvatar;
                    pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
                }


                lblSelectedProduct.Text = "Seçilen: " + selectedProduct.ProductName + " ==> " + selectedProduct.Description;
            }
            else
            {
                lblSelectedProduct.Text = "Seçilen: ";
            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct != null)
                {
                    productManager.Delete(selectedProduct);
                    MessageBox.Show("Silme işlemi başarılı.");

                    ProductResetItems();
                    ProductList();
                }
                else
                {
                    MessageBox.Show("Lütfen önce Ürün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct != null)
                {
                    string productName = txtProductName.Text;
                    string productDescription = txtProductDescription.Text;
                    int portionUnit;
                    string productCategory = cmbProductCategory.Text;
                    if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(productDescription) || string.IsNullOrWhiteSpace(productCategory) || string.IsNullOrWhiteSpace(txtPortionUnit.Text))
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!int.TryParse(txtPortionUnit.Text, out portionUnit))
                    {
                        MessageBox.Show("Lütfen porsiyon birimine tam sayı bir değer girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (portionUnit <= 0)
                    {
                        MessageBox.Show("Porsiyon birimi 0'dan küçük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    selectedProduct.ProductName = productName;
                    selectedProduct.Description = productDescription;
                    selectedProduct.PortionUnit = portionUnit;
                    selectedProduct.CategoryId = ((CategoryViewModel)cmbProductCategory.SelectedItem).Id;
                    productManager.Update(selectedProduct);
                    MessageBox.Show("Güncelleme başarılı.");
                    ProductResetItems();
                    ProductList();
                }
                else
                {
                    MessageBox.Show("Lütfen bir ürün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            AdminReportForm adminReportForm = new AdminReportForm();
            adminReportForm.ShowDialog();
        }

        private void btnProductImageAdd_Click(object sender, EventArgs e)
        {
            try
            {
                btnProductAdd.Enabled = true;

                _productView = new ProductViewModel
                {
                    ProductName = txtProductName.Text,
                    PortionUnit = Convert.ToInt32(txtPortionUnit.Text),
                    Description = txtProductDescription.Text,
                    CategoryId = ((CategoryViewModel)cmbProductCategory.SelectedItem).Id
                };


                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        using (System.Drawing.Image selectedImage = System.Drawing.Image.FromFile(filePath))
                        {
                            // Resmin boyutunu kontrol et
                            if (selectedImage.Width <= 64 && selectedImage.Height <= 64)
                            {
                                // Resim boyutu uygunsa resmi byte dizisine dönüştür
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    byte[] imageData = ms.ToArray();
                                    _productView.Picture = imageData;

                                    // Resmi PictureBox'a yükle
                                    pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
                                    pbProductImage.Image = selectedImage;
                                }
                            }
                            else
                            {
                                // Uyarı mesajı göster
                                MessageBox.Show("Resim boyutu 64x64 veya daha küçük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }

                productManager.Insert(_productView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CellBeginEdit event'leri proje çalıştırıldığında DataGridView'lerin üzerinde düzenleme yapılıp yapılmamasını ayarlamak için kullanılır. 
        private void dgvMealList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true; // Proje çalıştırıldığında DataGridView'i düzenlenmesini engeller.
        }

        private void dgvCategoryList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvProductList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        // DataError event'i DataGridView'de eklenmeyen resimlerin olduğu hücrelerdeki hatayı engellemek için kullanılır.
        private void dgvProductList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
