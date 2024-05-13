namespace QuanLiCafe
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoanToolStripMenuItem = new ToolStripMenuItem();
            thôngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            cbCategory1 = new ComboBox();
            nmFoodCount = new NumericUpDown();
            btnAddfood = new Button();
            cbFood = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            flpTable = new FlowLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1118, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoanToolStripMenuItem
            // 
            thôngTinTàiKhoanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoanToolStripMenuItem.Name = "thôngTinTàiKhoanToolStripMenuItem";
            thôngTinTàiKhoanToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoanToolStripMenuItem.Click += thôngTinTàiKhoanToolStripMenuItem_Click;
            // 
            // thôngToolStripMenuItem
            // 
            thôngToolStripMenuItem.Name = "thôngToolStripMenuItem";
            thôngToolStripMenuItem.Size = new Size(224, 26);
            thôngToolStripMenuItem.Text = "Thông tin cá nhân ";
            thôngToolStripMenuItem.Click += thôngToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(658, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 359);
            panel2.TabIndex = 1;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, -3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(429, 359);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 140;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(658, 474);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 81);
            panel3.TabIndex = 1;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbTotalPrice.ForeColor = Color.OrangeRed;
            txbTotalPrice.Location = new Point(201, 25);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(122, 28);
            txbTotalPrice.TabIndex = 7;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 46);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(98, 28);
            cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = SystemColors.ControlLight;
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(98, 36);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(107, 45);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(88, 27);
            nmDiscount.TabIndex = 4;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = SystemColors.ControlLight;
            btnDiscount.Location = new Point(107, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(88, 36);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ControlLight;
            btnCheckOut.Location = new Point(329, 0);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(106, 78);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbCategory1);
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddfood);
            panel4.Controls.Add(cbFood);
            panel4.Location = new Point(658, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(435, 72);
            panel4.TabIndex = 1;
            // 
            // cbCategory1
            // 
            cbCategory1.FormattingEnabled = true;
            cbCategory1.Location = new Point(0, 3);
            cbCategory1.Name = "cbCategory1";
            cbCategory1.Size = new Size(251, 28);
            cbCategory1.TabIndex = 4;
            cbCategory1.SelectedIndexChanged += cbCategory_SelectedlndexChanged;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(369, 24);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(63, 27);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddfood
            // 
            btnAddfood.BackColor = SystemColors.ControlLight;
            btnAddfood.Location = new Point(257, 0);
            btnAddfood.Name = "btnAddfood";
            btnAddfood.Size = new Size(106, 72);
            btnAddfood.TabIndex = 2;
            btnAddfood.Text = "Thêm món";
            btnAddfood.UseVisualStyleBackColor = false;
            btnAddfood.Click += btnAddfood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 37);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(248, 28);
            cbFood.TabIndex = 1;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(0, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(655, 546);
            flpTable.TabIndex = 2;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 567);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            Text = "Quản Lý Quán Cafe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoanToolStripMenuItem;
        private ToolStripMenuItem thôngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvBill;
        private Panel panel4;
        private ComboBox cbFood;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAddfood;
        private NumericUpDown nmFoodCount;
        private FlowLayoutPanel flpTable;
        private Button btnCheckOut;
        private Button btnDiscount;
        private NumericUpDown nmDiscount;
        private Button btnSwitchTable;
        private ComboBox cbSwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private ComboBox cbCategory;
        private ComboBox cbCategory1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}