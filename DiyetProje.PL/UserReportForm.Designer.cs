namespace DiyetProje.PL
{
    partial class UserReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReportForm));
            btnDailyReport = new Button();
            panel1 = new Panel();
            dtpCalendar = new DateTimePicker();
            label1 = new Label();
            txtTotalCalorie = new TextBox();
            btnWeeklyReport = new Button();
            panel2 = new Panel();
            btnMonthlyReport = new Button();
            label3 = new Label();
            cmbCategoryList = new ComboBox();
            label2 = new Label();
            cmbMealList = new ComboBox();
            panel3 = new Panel();
            btnMostEaten = new Button();
            btnBack = new Button();
            dgvReports = new DataGridView();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label4 = new Label();
            lblUserName = new Label();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnDailyReport
            // 
            btnDailyReport.Location = new Point(45, 186);
            btnDailyReport.Name = "btnDailyReport";
            btnDailyReport.Size = new Size(139, 34);
            btnDailyReport.TabIndex = 1;
            btnDailyReport.Text = "Gün Sonu Raporu";
            btnDailyReport.UseVisualStyleBackColor = true;
            btnDailyReport.Click += btnDailyReport_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpCalendar);
            panel1.Controls.Add(btnDailyReport);
            panel1.Location = new Point(133, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 246);
            panel1.TabIndex = 6;
            // 
            // dtpCalendar
            // 
            dtpCalendar.Location = new Point(13, 119);
            dtpCalendar.Name = "dtpCalendar";
            dtpCalendar.Size = new Size(201, 26);
            dtpCalendar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label1.Location = new Point(466, 378);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 4;
            label1.Text = "Toplam Kalori:";
            // 
            // txtTotalCalorie
            // 
            txtTotalCalorie.Enabled = false;
            txtTotalCalorie.Location = new Point(466, 400);
            txtTotalCalorie.Name = "txtTotalCalorie";
            txtTotalCalorie.Size = new Size(201, 26);
            txtTotalCalorie.TabIndex = 3;
            txtTotalCalorie.TextAlign = HorizontalAlignment.Center;
            // 
            // btnWeeklyReport
            // 
            btnWeeklyReport.Location = new Point(30, 162);
            btnWeeklyReport.Name = "btnWeeklyReport";
            btnWeeklyReport.Size = new Size(83, 60);
            btnWeeklyReport.TabIndex = 1;
            btnWeeklyReport.Text = "Haftalık Rapor";
            btnWeeklyReport.UseVisualStyleBackColor = true;
            btnWeeklyReport.Click += btnWeeklyReport_Click;
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
            panel2.Location = new Point(449, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 246);
            panel2.TabIndex = 7;
            // 
            // btnMonthlyReport
            // 
            btnMonthlyReport.Location = new Point(120, 162);
            btnMonthlyReport.Name = "btnMonthlyReport";
            btnMonthlyReport.Size = new Size(88, 60);
            btnMonthlyReport.TabIndex = 1;
            btnMonthlyReport.Text = "Aylık Rapor";
            btnMonthlyReport.UseVisualStyleBackColor = true;
            btnMonthlyReport.Click += btnMonthlyReport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 95);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 5;
            label3.Text = "Kategori Seç:";
            // 
            // cmbCategoryList
            // 
            cmbCategoryList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryList.FormattingEnabled = true;
            cmbCategoryList.Location = new Point(27, 122);
            cmbCategoryList.Name = "cmbCategoryList";
            cmbCategoryList.Size = new Size(172, 27);
            cmbCategoryList.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 30);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 3;
            label2.Text = "Öğün Seç:";
            // 
            // cmbMealList
            // 
            cmbMealList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMealList.FormattingEnabled = true;
            cmbMealList.Location = new Point(30, 58);
            cmbMealList.Name = "cmbMealList";
            cmbMealList.Size = new Size(172, 27);
            cmbMealList.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnMostEaten);
            panel3.Location = new Point(765, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 246);
            panel3.TabIndex = 8;
            // 
            // btnMostEaten
            // 
            btnMostEaten.Location = new Point(44, 89);
            btnMostEaten.Name = "btnMostEaten";
            btnMostEaten.Size = new Size(145, 60);
            btnMostEaten.TabIndex = 2;
            btnMostEaten.Text = "En Çok Yenen Yemekler";
            btnMostEaten.UseVisualStyleBackColor = true;
            btnMostEaten.Click += btnMostEaten_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1055, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 32);
            btnBack.TabIndex = 9;
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
            dgvReports.BorderStyle = BorderStyle.None;
            dgvReports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Gray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvReports.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 217, 173);
            dataGridViewCellStyle8.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvReports.DefaultCellStyle = dataGridViewCellStyle8;
            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.GridColor = Color.FromArgb(224, 224, 224);
            dgvReports.Location = new Point(31, 445);
            dgvReports.Margin = new Padding(3, 4, 3, 4);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReports.RowHeadersVisible = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(1092, 369);
            dgvReports.TabIndex = 10;
            dgvReports.CellBeginEdit += dgvReports_CellBeginEdit_1;
            dgvReports.DataError += dgvReports_DataError_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.Location = new Point(33, 24);
            label7.Name = "label7";
            label7.Size = new Size(162, 25);
            label7.TabIndex = 4;
            label7.Text = "Gün Sonu Raporu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 391);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(86, 389);
            label5.Name = "label5";
            label5.Size = new Size(203, 37);
            label5.TabIndex = 21;
            label5.Text = "Rapor Çıktıları";
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
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1135, 91);
            panel4.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(505, 18);
            label6.Name = "label6";
            label6.Size = new Size(161, 37);
            label6.TabIndex = 20;
            label6.Text = "RAPORLAR";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(334, 6);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(135, 76);
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
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 89);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(14, 30);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 1;
            label4.Text = "Stay Fit";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.Location = new Point(3, 56);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 19);
            lblUserName.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(132, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1229, 5);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 38);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // UserReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 827);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(dgvReports);
            Controls.Add(label1);
            Controls.Add(txtTotalCalorie);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserReportForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDailyReport;
        private Panel panel1;
        private DateTimePicker dtpCalendar;
        private Button btnWeeklyReport;
        private Panel panel2;
        private Button btnMonthlyReport;
        private Panel panel3;
        private TextBox txtTotalCalorie;
        private Label label1;
        private Button btnBack;
        private Label label3;
        private ComboBox cmbCategoryList;
        private Label label2;
        private ComboBox cmbMealList;
        private Button btnMostEaten;
        private DataGridView dgvReports;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Label label4;
        private Label lblUserName;
        private PictureBox pictureBox2;
        private Button btnExit;
    }
}