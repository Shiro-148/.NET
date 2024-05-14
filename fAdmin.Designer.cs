namespace QuanLiCafe
{
    partial class fAdmin
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
            pageSetupDialog1 = new PageSetupDialog();
            tabPage5 = new TabPage();
            panel24 = new Panel();
            btnResetPass = new Button();
            panel25 = new Panel();
            nmAccountType = new NumericUpDown();
            label10 = new Label();
            panel26 = new Panel();
            txbDisplayName = new TextBox();
            label11 = new Label();
            panel27 = new Panel();
            txbUserName = new TextBox();
            label12 = new Label();
            panel22 = new Panel();
            btnShowAccount = new Button();
            btnEditAcount = new Button();
            btnDeleteAcount = new Button();
            btnAddAccount = new Button();
            dtgvAccount = new DataGridView();
            tabPage2 = new TabPage();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btbnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            btnBillView = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            dtgvBill = new DataGridView();
            tp = new TabControl();
            tabPage5.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).BeginInit();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            tabPage2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tp.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(panel24);
            tabPage5.Controls.Add(panel22);
            tabPage5.Controls.Add(dtgvAccount);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(885, 544);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Tài khoản";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnResetPass);
            panel24.Controls.Add(panel25);
            panel24.Controls.Add(panel26);
            panel24.Controls.Add(panel27);
            panel24.Location = new Point(562, 78);
            panel24.Name = "panel24";
            panel24.Size = new Size(318, 376);
            panel24.TabIndex = 7;
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = Color.RosyBrown;
            btnResetPass.Location = new Point(192, 198);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(102, 54);
            btnResetPass.TabIndex = 4;
            btnResetPass.Text = "Đặt lại mật khẩu";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // panel25
            // 
            panel25.Controls.Add(nmAccountType);
            panel25.Controls.Add(label10);
            panel25.Location = new Point(3, 133);
            panel25.Name = "panel25";
            panel25.Size = new Size(310, 59);
            panel25.TabIndex = 6;
            // 
            // nmAccountType
            // 
            nmAccountType.Location = new Point(160, 20);
            nmAccountType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nmAccountType.Name = "nmAccountType";
            nmAccountType.Size = new Size(150, 27);
            nmAccountType.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.Location = new Point(3, 18);
            label10.Name = "label10";
            label10.Size = new Size(150, 24);
            label10.TabIndex = 1;
            label10.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbDisplayName);
            panel26.Controls.Add(label11);
            panel26.Location = new Point(3, 68);
            panel26.Name = "panel26";
            panel26.Size = new Size(310, 59);
            panel26.TabIndex = 5;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(152, 18);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(155, 27);
            txbDisplayName.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label11.Location = new Point(3, 18);
            label11.Name = "label11";
            label11.Size = new Size(135, 24);
            label11.TabIndex = 1;
            label11.Text = "Tên hiển thị: ";
            // 
            // panel27
            // 
            panel27.Controls.Add(txbUserName);
            panel27.Controls.Add(label12);
            panel27.Location = new Point(3, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(310, 59);
            panel27.TabIndex = 4;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = SystemColors.ButtonHighlight;
            txbUserName.Location = new Point(152, 18);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(155, 27);
            txbUserName.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label12.Location = new Point(7, 14);
            label12.Name = "label12";
            label12.Size = new Size(146, 24);
            label12.TabIndex = 1;
            label12.Text = "Tên tài khoản:";
            // 
            // panel22
            // 
            panel22.Controls.Add(btnShowAccount);
            panel22.Controls.Add(btnEditAcount);
            panel22.Controls.Add(btnDeleteAcount);
            panel22.Controls.Add(btnAddAccount);
            panel22.Location = new Point(3, 6);
            panel22.Name = "panel22";
            panel22.Size = new Size(368, 63);
            panel22.TabIndex = 4;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(257, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(77, 54);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnEditAcount
            // 
            btnEditAcount.Location = new Point(174, 3);
            btnEditAcount.Name = "btnEditAcount";
            btnEditAcount.Size = new Size(77, 54);
            btnEditAcount.TabIndex = 2;
            btnEditAcount.Text = "Sửa";
            btnEditAcount.UseVisualStyleBackColor = true;
            btnEditAcount.Click += btnEditAcount_Click;
            // 
            // btnDeleteAcount
            // 
            btnDeleteAcount.Location = new Point(91, 3);
            btnDeleteAcount.Name = "btnDeleteAcount";
            btnDeleteAcount.Size = new Size(77, 54);
            btnDeleteAcount.TabIndex = 1;
            btnDeleteAcount.Text = "Xóa";
            btnDeleteAcount.UseVisualStyleBackColor = true;
            btnDeleteAcount.Click += btnDeleteAcount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(8, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(77, 54);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 78);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(553, 463);
            dtgvAccount.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(885, 544);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thức ăn";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(572, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(313, 63);
            panel6.TabIndex = 2;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(14, 17);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(216, 27);
            txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(236, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(77, 54);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(572, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(313, 466);
            panel5.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 198);
            panel10.Name = "panel10";
            panel10.Size = new Size(310, 59);
            panel10.TabIndex = 6;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(109, 19);
            nmFoodPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(198, 27);
            nmFoodPrice.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(3, 18);
            label4.Name = "label4";
            label4.Size = new Size(55, 24);
            label4.TabIndex = 1;
            label4.Text = "Giá: ";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 133);
            panel9.Name = "panel9";
            panel9.Size = new Size(310, 59);
            panel9.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(109, 15);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(198, 28);
            cbFoodCategory.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 1;
            label3.Text = "Danh mục: ";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(3, 68);
            panel8.Name = "panel8";
            panel8.Size = new Size(310, 59);
            panel8.TabIndex = 5;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(109, 18);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(198, 27);
            txbFoodName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên món: ";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(310, 59);
            panel7.TabIndex = 4;
            // 
            // txbFoodID
            // 
            txbFoodID.BackColor = SystemColors.AppWorkspace;
            txbFoodID.Location = new Point(109, 18);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(198, 27);
            txbFoodID.TabIndex = 2;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(42, 24);
            label2.TabIndex = 1;
            label2.Text = "ID: ";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btbnAddFood);
            panel4.Location = new Point(0, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 63);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(257, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(77, 54);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(174, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(77, 54);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(91, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(77, 54);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btbnAddFood
            // 
            btbnAddFood.Location = new Point(8, 3);
            btbnAddFood.Name = "btbnAddFood";
            btbnAddFood.Size = new Size(77, 54);
            btbnAddFood.TabIndex = 0;
            btbnAddFood.Text = "Thêm";
            btbnAddFood.UseVisualStyleBackColor = true;
            btbnAddFood.Click += btbnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(569, 469);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(0, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(566, 463);
            dtgvFood.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(885, 544);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Doanh thu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBillView);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 35);
            panel2.TabIndex = 1;
            // 
            // btnBillView
            // 
            btnBillView.BackColor = Color.Yellow;
            btnBillView.Location = new Point(383, 1);
            btnBillView.Name = "btnBillView";
            btnBillView.Size = new Size(115, 29);
            btnBillView.TabIndex = 2;
            btnBillView.Text = "Thống kê";
            btnBillView.UseVisualStyleBackColor = false;
            btnBillView.Click += btnBillView_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(556, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(316, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(0, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(310, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 497);
            panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(1, 2);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(875, 492);
            dtgvBill.TabIndex = 0;
            // 
            // tp
            // 
            tp.Controls.Add(tabPage1);
            tp.Controls.Add(tabPage2);
            tp.Controls.Add(tabPage5);
            tp.Location = new Point(0, 0);
            tp.Name = "tp";
            tp.SelectedIndex = 0;
            tp.Size = new Size(893, 577);
            tp.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(891, 589);
            Controls.Add(tp);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabPage5.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).EndInit();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            tabPage2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PageSetupDialog pageSetupDialog1;
        private TabPage tabPage5;
        private Panel panel24;
        private Button btnResetPass;
        private Panel panel25;
        private NumericUpDown nmAccountType;
        private Label label10;
        private Panel panel26;
        private TextBox txbDisplayName;
        private Label label11;
        private Panel panel27;
        private TextBox txbUserName;
        private Label label12;
        private Panel panel22;
        private Button btnShowAccount;
        private Button btnEditAcount;
        private Button btnDeleteAcount;
        private Button btnAddAccount;
        private DataGridView dtgvAccount;
        private TabPage tabPage2;
        private Panel panel6;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel5;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label3;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label1;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label2;
        private Panel panel4;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btbnAddFood;
        private Panel panel3;
        private DataGridView dtgvFood;
        private TabPage tabPage1;
        private Panel panel2;
        private Button btnBillView;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private TabControl tp;
    }
}