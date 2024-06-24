namespace DiyetProje.PL
{
    partial class AdminMainForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            lblSelectedMeal = new Label();
            txtMealDescription = new TextBox();
            btnMealUpdate = new Button();
            btnMealDelete = new Button();
            btnMealAdd = new Button();
            label5 = new Label();
            panel3 = new Panel();
            dgvMealList = new DataGridView();
            txtMealName = new TextBox();
            label1 = new Label();
            btnExit = new Button();
            btnRaporlar = new Button();
            pictureBox4 = new PictureBox();
            panel7 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            lblUserName = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            dgvCategoryList = new DataGridView();
            txtCategoryName = new TextBox();
            label3 = new Label();
            lblSelectedCategory = new Label();
            txtCategoryDescription = new TextBox();
            btnCategoryUpdate = new Button();
            btnCategoryDelete = new Button();
            label6 = new Label();
            btnCategoryAdd = new Button();
            panel4 = new Panel();
            dgvProductList = new DataGridView();
            btnProductImageAdd = new Button();
            pbProductImage = new PictureBox();
            label8 = new Label();
            cmbProductCategory = new ComboBox();
            txtPortionUnit = new TextBox();
            label4 = new Label();
            txtProductName = new TextBox();
            label7 = new Label();
            btnProductAdd = new Button();
            lblSelectedProduct = new Label();
            btnProductUpdate = new Button();
            txtProductDescription = new TextBox();
            btnProductDelete = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMealList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // lblSelectedMeal
            // 
            lblSelectedMeal.BackColor = SystemColors.ActiveCaption;
            lblSelectedMeal.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedMeal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelectedMeal.Location = new Point(7, 394);
            lblSelectedMeal.Name = "lblSelectedMeal";
            lblSelectedMeal.Size = new Size(305, 23);
            lblSelectedMeal.TabIndex = 6;
            lblSelectedMeal.Text = "Seçilen: ";
            // 
            // txtMealDescription
            // 
            txtMealDescription.BorderStyle = BorderStyle.FixedSingle;
            txtMealDescription.Location = new Point(63, 84);
            txtMealDescription.Name = "txtMealDescription";
            txtMealDescription.Size = new Size(194, 23);
            txtMealDescription.TabIndex = 5;
            // 
            // btnMealUpdate
            // 
            btnMealUpdate.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMealUpdate.Location = new Point(198, 118);
            btnMealUpdate.Name = "btnMealUpdate";
            btnMealUpdate.Size = new Size(76, 59);
            btnMealUpdate.TabIndex = 4;
            btnMealUpdate.Text = "Güncelle";
            btnMealUpdate.UseVisualStyleBackColor = true;
            btnMealUpdate.Click += btnMealUpdate_Click;
            // 
            // btnMealDelete
            // 
            btnMealDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMealDelete.Location = new Point(126, 118);
            btnMealDelete.Name = "btnMealDelete";
            btnMealDelete.Size = new Size(66, 59);
            btnMealDelete.TabIndex = 4;
            btnMealDelete.Text = "Sil";
            btnMealDelete.UseVisualStyleBackColor = true;
            btnMealDelete.Click += btnMealDelete_Click;
            // 
            // btnMealAdd
            // 
            btnMealAdd.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMealAdd.Location = new Point(54, 118);
            btnMealAdd.Name = "btnMealAdd";
            btnMealAdd.Size = new Size(66, 59);
            btnMealAdd.TabIndex = 4;
            btnMealAdd.Text = "Ekle";
            btnMealAdd.UseVisualStyleBackColor = true;
            btnMealAdd.Click += btnMealAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(63, 64);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 0;
            label5.Text = "Öğün Açıklaması:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dgvMealList);
            panel3.Controls.Add(txtMealName);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblSelectedMeal);
            panel3.Controls.Add(txtMealDescription);
            panel3.Controls.Add(btnMealUpdate);
            panel3.Controls.Add(btnMealDelete);
            panel3.Controls.Add(btnMealAdd);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(4, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 422);
            panel3.TabIndex = 5;
            // 
            // dgvMealList
            // 
            dgvMealList.AllowUserToAddRows = false;
            dgvMealList.AllowUserToDeleteRows = false;
            dgvMealList.AllowUserToResizeColumns = false;
            dgvMealList.AllowUserToResizeRows = false;
            dgvMealList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMealList.BackgroundColor = Color.White;
            dgvMealList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Gray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvMealList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvMealList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 217, 173);
            dataGridViewCellStyle8.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvMealList.DefaultCellStyle = dataGridViewCellStyle8;
            dgvMealList.EnableHeadersVisualStyles = false;
            dgvMealList.GridColor = Color.FromArgb(224, 224, 224);
            dgvMealList.Location = new Point(7, 204);
            dgvMealList.MultiSelect = false;
            dgvMealList.Name = "dgvMealList";
            dgvMealList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMealList.RowHeadersVisible = false;
            dgvMealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMealList.Size = new Size(305, 187);
            dgvMealList.TabIndex = 9;
            dgvMealList.CellBeginEdit += dgvMealList_CellBeginEdit;
            dgvMealList.CellClick += dgvMealList_CellClick;
            // 
            // txtMealName
            // 
            txtMealName.BorderStyle = BorderStyle.FixedSingle;
            txtMealName.Location = new Point(63, 34);
            txtMealName.Name = "txtMealName";
            txtMealName.Size = new Size(194, 23);
            txtMealName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(63, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 7;
            label1.Text = "Öğün Adı:";
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1075, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(35, 30);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.Transparent;
            btnRaporlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRaporlar.Location = new Point(106, 3);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(110, 41);
            btnRaporlar.TabIndex = 1;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btnRaporlar);
            panel7.Controls.Add(pictureBox4);
            panel7.Location = new Point(228, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(221, 49);
            panel7.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(146, 232, 189);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 72);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(0, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 71);
            panel5.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Stay Fit";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 13F);
            lblUserName.Location = new Point(486, 23);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 25);
            lblUserName.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(115, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dgvCategoryList);
            panel1.Controls.Add(txtCategoryName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblSelectedCategory);
            panel1.Controls.Add(txtCategoryDescription);
            panel1.Controls.Add(btnCategoryUpdate);
            panel1.Controls.Add(btnCategoryDelete);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnCategoryAdd);
            panel1.Location = new Point(328, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 422);
            panel1.TabIndex = 6;
            // 
            // dgvCategoryList
            // 
            dgvCategoryList.AllowUserToAddRows = false;
            dgvCategoryList.AllowUserToDeleteRows = false;
            dgvCategoryList.AllowUserToResizeColumns = false;
            dgvCategoryList.AllowUserToResizeRows = false;
            dgvCategoryList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategoryList.BackgroundColor = Color.White;
            dgvCategoryList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Gray;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvCategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvCategoryList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 217, 173);
            dataGridViewCellStyle10.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvCategoryList.DefaultCellStyle = dataGridViewCellStyle10;
            dgvCategoryList.EnableHeadersVisualStyles = false;
            dgvCategoryList.GridColor = Color.FromArgb(224, 224, 224);
            dgvCategoryList.Location = new Point(7, 204);
            dgvCategoryList.MultiSelect = false;
            dgvCategoryList.Name = "dgvCategoryList";
            dgvCategoryList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCategoryList.RowHeadersVisible = false;
            dgvCategoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryList.Size = new Size(305, 187);
            dgvCategoryList.TabIndex = 10;
            dgvCategoryList.CellBeginEdit += dgvCategoryList_CellBeginEdit;
            dgvCategoryList.CellClick += dgvCategoryList_CellClick;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(63, 34);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(194, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(63, 15);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 7;
            label3.Text = "Kategori Adı:";
            // 
            // lblSelectedCategory
            // 
            lblSelectedCategory.BackColor = SystemColors.ActiveCaption;
            lblSelectedCategory.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelectedCategory.Location = new Point(7, 394);
            lblSelectedCategory.Name = "lblSelectedCategory";
            lblSelectedCategory.Size = new Size(305, 23);
            lblSelectedCategory.TabIndex = 6;
            lblSelectedCategory.Text = "Seçilen: ";
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryDescription.Location = new Point(63, 84);
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(194, 23);
            txtCategoryDescription.TabIndex = 5;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCategoryUpdate.Location = new Point(199, 118);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(76, 59);
            btnCategoryUpdate.TabIndex = 4;
            btnCategoryUpdate.Text = "Güncelle";
            btnCategoryUpdate.UseVisualStyleBackColor = true;
            btnCategoryUpdate.Click += btnCategoryUpdate_Click;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCategoryDelete.Location = new Point(127, 118);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.Size = new Size(66, 59);
            btnCategoryDelete.TabIndex = 4;
            btnCategoryDelete.Text = "Sil";
            btnCategoryDelete.UseVisualStyleBackColor = true;
            btnCategoryDelete.Click += btnCategoryDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(63, 64);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 0;
            label6.Text = "Kategori Açıklaması:";
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCategoryAdd.Location = new Point(55, 118);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(66, 59);
            btnCategoryAdd.TabIndex = 4;
            btnCategoryAdd.Text = "Ekle";
            btnCategoryAdd.UseVisualStyleBackColor = true;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label12);
            panel4.Controls.Add(dgvProductList);
            panel4.Controls.Add(btnProductImageAdd);
            panel4.Controls.Add(pbProductImage);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(cmbProductCategory);
            panel4.Controls.Add(txtPortionUnit);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtProductName);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btnProductAdd);
            panel4.Controls.Add(lblSelectedProduct);
            panel4.Controls.Add(btnProductUpdate);
            panel4.Controls.Add(txtProductDescription);
            panel4.Controls.Add(btnProductDelete);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(653, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(452, 422);
            panel4.TabIndex = 9;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.AllowUserToResizeColumns = false;
            dgvProductList.AllowUserToResizeRows = false;
            dgvProductList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductList.BackgroundColor = Color.White;
            dgvProductList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.Gray;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle11.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvProductList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.DimGray;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 217, 173);
            dataGridViewCellStyle12.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvProductList.DefaultCellStyle = dataGridViewCellStyle12;
            dgvProductList.EnableHeadersVisualStyles = false;
            dgvProductList.GridColor = Color.FromArgb(224, 224, 224);
            dgvProductList.Location = new Point(7, 204);
            dgvProductList.MultiSelect = false;
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProductList.RowHeadersVisible = false;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(305, 187);
            dgvProductList.TabIndex = 11;
            dgvProductList.CellBeginEdit += dgvProductList_CellBeginEdit;
            dgvProductList.CellClick += dgvProductList_CellClick;
            dgvProductList.DataError += dgvProductList_DataError;
            // 
            // btnProductImageAdd
            // 
            btnProductImageAdd.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnProductImageAdd.Location = new Point(331, 310);
            btnProductImageAdd.Margin = new Padding(3, 2, 3, 2);
            btnProductImageAdd.Name = "btnProductImageAdd";
            btnProductImageAdd.Size = new Size(106, 46);
            btnProductImageAdd.TabIndex = 14;
            btnProductImageAdd.Text = "Ürün Resmi Ekle";
            btnProductImageAdd.UseVisualStyleBackColor = true;
            btnProductImageAdd.Click += btnProductImageAdd_Click;
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(318, 225);
            pbProductImage.Margin = new Padding(3, 2, 3, 2);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(127, 80);
            pbProductImage.TabIndex = 13;
            pbProductImage.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(22, 65);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 12;
            label8.Text = "Kategorisi:";
            // 
            // cmbProductCategory
            // 
            cmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductCategory.FormattingEnabled = true;
            cmbProductCategory.Location = new Point(22, 87);
            cmbProductCategory.Margin = new Padding(3, 2, 3, 2);
            cmbProductCategory.Name = "cmbProductCategory";
            cmbProductCategory.Size = new Size(194, 23);
            cmbProductCategory.TabIndex = 11;
            // 
            // txtPortionUnit
            // 
            txtPortionUnit.BorderStyle = BorderStyle.FixedSingle;
            txtPortionUnit.Location = new Point(237, 34);
            txtPortionUnit.Name = "txtPortionUnit";
            txtPortionUnit.Size = new Size(194, 23);
            txtPortionUnit.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(237, 15);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 9;
            label4.Text = "Porsiyon Birimi:";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(22, 34);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(194, 23);
            txtProductName.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(22, 15);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 7;
            label7.Text = "Ürün Adı:";
            // 
            // btnProductAdd
            // 
            btnProductAdd.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnProductAdd.Location = new Point(122, 118);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(66, 59);
            btnProductAdd.TabIndex = 4;
            btnProductAdd.Text = "Ekle";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // lblSelectedProduct
            // 
            lblSelectedProduct.BackColor = SystemColors.ActiveCaption;
            lblSelectedProduct.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelectedProduct.Location = new Point(7, 394);
            lblSelectedProduct.Name = "lblSelectedProduct";
            lblSelectedProduct.Size = new Size(438, 23);
            lblSelectedProduct.TabIndex = 6;
            lblSelectedProduct.Text = "Seçilen: ";
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnProductUpdate.Location = new Point(264, 118);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(83, 59);
            btnProductUpdate.TabIndex = 4;
            btnProductUpdate.Text = "Güncelle";
            btnProductUpdate.UseVisualStyleBackColor = true;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // txtProductDescription
            // 
            txtProductDescription.BorderStyle = BorderStyle.FixedSingle;
            txtProductDescription.Location = new Point(237, 86);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(194, 23);
            txtProductDescription.TabIndex = 5;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnProductDelete.Location = new Point(193, 118);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(66, 59);
            btnProductDelete.TabIndex = 4;
            btnProductDelete.Text = "Sil";
            btnProductDelete.UseVisualStyleBackColor = true;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(237, 64);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 0;
            label9.Text = "Porsiyon Açıklaması:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 186);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 10;
            label10.Text = "Öğün Bilgileri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 186);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 10;
            label11.Text = "Kategori Bilgileri";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 186);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 10;
            label12.Text = "Ürün Bilgileri";
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 507);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMealList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSelectedMeal;
        private TextBox txtMealDescription;
        private Button btnMealUpdate;
        private Button btnMealDelete;
        private Button btnMealAdd;
        private Label label5;
        private Panel panel3;
        private Button btnExit;
        private Button btnRaporlar;
        private PictureBox pictureBox4;
        private Panel panel7;
        private Panel panel2;
        private Panel panel5;
        private Label label2;
        private Label lblUserName;
        private PictureBox pictureBox2;
        private DataGridView dgvMealList;
        private TextBox txtMealName;
        private Label label1;
        private Panel panel1;
        private TextBox txtCategoryName;
        private Label label3;
        private Label lblSelectedCategory;
        private TextBox txtCategoryDescription;
        private Button btnCategoryUpdate;
        private Button btnCategoryDelete;
        private Button btnCategoryAdd;
        private Label label6;
        private Panel panel4;
        private TextBox txtProductName;
        private Label label7;
        private Label lblSelectedProduct;
        private TextBox txtProductDescription;
        private Button btnProductUpdate;
        private Button btnProductDelete;
        private Button btnProductAdd;
        private Label label9;
        private TextBox txtPortionUnit;
        private Label label4;
        private ComboBox cmbProductCategory;
        private Label label8;
        private Button btnProductImageAdd;
        private PictureBox pbProductImage;
        private DataGridView dgvCategoryList;
        private DataGridView dgvProductList;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}