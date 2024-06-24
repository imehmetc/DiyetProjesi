namespace DiyetProje.PL
{
    partial class AdminReportForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReportForm));
            label1 = new Label();
            txtTotalCalorie = new TextBox();
            panel3 = new Panel();
            btnViewUsers = new Button();
            btnMostEaten = new Button();
            panel2 = new Panel();
            btnMonthlyReport = new Button();
            label3 = new Label();
            btnWeeklyReport = new Button();
            cmbCategoryList = new ComboBox();
            label2 = new Label();
            cmbMealList = new ComboBox();
            panel1 = new Panel();
            label7 = new Label();
            dtpCalendar = new DateTimePicker();
            btnDailyReport = new Button();
            btnBack = new Button();
            dgvReports = new DataGridView();
            panel4 = new Panel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label4 = new Label();
            lblUserName = new Label();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(406, 299);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 12;
            label1.Text = "Toplam Kalori";
            // 
            // txtTotalCalorie
            // 
            txtTotalCalorie.BorderStyle = BorderStyle.FixedSingle;
            txtTotalCalorie.Enabled = false;
            txtTotalCalorie.Location = new Point(406, 318);
            txtTotalCalorie.Margin = new Padding(3, 2, 3, 2);
            txtTotalCalorie.Name = "txtTotalCalorie";
            txtTotalCalorie.Size = new Size(176, 23);
            txtTotalCalorie.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnViewUsers);
            panel3.Controls.Add(btnMostEaten);
            panel3.Location = new Point(631, 93);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 195);
            panel3.TabIndex = 15;
            // 
            // btnViewUsers
            // 
            btnViewUsers.Location = new Point(38, 20);
            btnViewUsers.Margin = new Padding(3, 2, 3, 2);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(127, 31);
            btnViewUsers.TabIndex = 17;
            btnViewUsers.Text = "Kullanıcıları Gör";
            btnViewUsers.UseVisualStyleBackColor = true;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // btnMostEaten
            // 
            btnMostEaten.Location = new Point(38, 109);
            btnMostEaten.Margin = new Padding(3, 2, 3, 2);
            btnMostEaten.Name = "btnMostEaten";
            btnMostEaten.Size = new Size(127, 46);
            btnMostEaten.TabIndex = 2;
            btnMostEaten.Text = "En Çok Yenen Yemekler";
            btnMostEaten.UseVisualStyleBackColor = true;
            btnMostEaten.Click += btnMostEaten_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnMonthlyReport);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnWeeklyReport);
            panel2.Controls.Add(cmbCategoryList);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbMealList);
            panel2.Location = new Point(393, 93);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 195);
            panel2.TabIndex = 14;
            // 
            // btnMonthlyReport
            // 
            btnMonthlyReport.Location = new Point(113, 128);
            btnMonthlyReport.Margin = new Padding(3, 2, 3, 2);
            btnMonthlyReport.Name = "btnMonthlyReport";
            btnMonthlyReport.Size = new Size(64, 46);
            btnMonthlyReport.TabIndex = 1;
            btnMonthlyReport.Text = "Aylık Rapor";
            btnMonthlyReport.UseVisualStyleBackColor = true;
            btnMonthlyReport.Click += btnMonthlyReport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 69);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Kategori Seç:";
            // 
            // btnWeeklyReport
            // 
            btnWeeklyReport.Location = new Point(16, 128);
            btnWeeklyReport.Margin = new Padding(3, 2, 3, 2);
            btnWeeklyReport.Name = "btnWeeklyReport";
            btnWeeklyReport.Size = new Size(68, 46);
            btnWeeklyReport.TabIndex = 1;
            btnWeeklyReport.Text = "Haftalık Rapor";
            btnWeeklyReport.UseVisualStyleBackColor = true;
            btnWeeklyReport.Click += btnWeeklyReport_Click;
            // 
            // cmbCategoryList
            // 
            cmbCategoryList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryList.FormattingEnabled = true;
            cmbCategoryList.Location = new Point(26, 92);
            cmbCategoryList.Margin = new Padding(3, 2, 3, 2);
            cmbCategoryList.Name = "cmbCategoryList";
            cmbCategoryList.Size = new Size(151, 23);
            cmbCategoryList.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 13);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Öğün Seç:";
            // 
            // cmbMealList
            // 
            cmbMealList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMealList.FormattingEnabled = true;
            cmbMealList.Location = new Point(26, 36);
            cmbMealList.Margin = new Padding(3, 2, 3, 2);
            cmbMealList.Name = "cmbMealList";
            cmbMealList.Size = new Size(151, 23);
            cmbMealList.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpCalendar);
            panel1.Controls.Add(btnDailyReport);
            panel1.Location = new Point(159, 93);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 195);
            panel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.Location = new Point(19, 13);
            label7.Name = "label7";
            label7.Size = new Size(162, 25);
            label7.TabIndex = 3;
            label7.Text = "Gün Sonu Raporu";
            // 
            // dtpCalendar
            // 
            dtpCalendar.Location = new Point(12, 89);
            dtpCalendar.Margin = new Padding(3, 2, 3, 2);
            dtpCalendar.Name = "dtpCalendar";
            dtpCalendar.Size = new Size(176, 23);
            dtpCalendar.TabIndex = 2;
            // 
            // btnDailyReport
            // 
            btnDailyReport.Location = new Point(39, 147);
            btnDailyReport.Margin = new Padding(3, 2, 3, 2);
            btnDailyReport.Name = "btnDailyReport";
            btnDailyReport.Size = new Size(122, 27);
            btnDailyReport.TabIndex = 1;
            btnDailyReport.Text = "Gün Sonu Raporu";
            btnDailyReport.UseVisualStyleBackColor = true;
            btnDailyReport.Click += btnDailyReport_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(934, 14);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(54, 31);
            btnBack.TabIndex = 16;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToResizeColumns = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReports.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 217, 173);
            dataGridViewCellStyle2.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReports.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.GridColor = Color.FromArgb(224, 224, 224);
            dgvReports.Location = new Point(23, 354);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReports.RowHeadersVisible = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(947, 287);
            dgvReports.TabIndex = 17;
            dgvReports.CellBeginEdit += dgvReports_CellBeginEdit;
            dgvReports.DataError += dgvReports_DataError;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(146, 232, 189);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnExit);
            panel4.Controls.Add(btnBack);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(993, 72);
            panel4.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(442, 14);
            label6.Name = "label6";
            label6.Size = new Size(161, 37);
            label6.TabIndex = 20;
            label6.Text = "RAPORLAR";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(292, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(118, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(lblUserName);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(-1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 71);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(12, 24);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 1;
            label4.Text = "Stay Fit";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.Location = new Point(3, 44);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 19);
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
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1075, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(35, 30);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(56, 314);
            label5.Name = "label5";
            label5.Size = new Size(203, 37);
            label5.TabIndex = 19;
            label5.Text = "Rapor Çıktıları";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 316);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // AdminReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 653);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(dgvReports);
            Controls.Add(label1);
            Controls.Add(txtTotalCalorie);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTotalCalorie;
        private Panel panel3;
        private Button btnMostEaten;
        private Panel panel2;
        private Button btnMonthlyReport;
        private Label label3;
        private Button btnWeeklyReport;
        private ComboBox cmbCategoryList;
        private Label label2;
        private ComboBox cmbMealList;
        private Panel panel1;
        private DateTimePicker dtpCalendar;
        private Button btnDailyReport;
        private Button btnBack;
        private Button btnViewUsers;
        private DataGridView dgvReports;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label lblUserName;
        private PictureBox pictureBox2;
        private Button btnExit;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
    }
}