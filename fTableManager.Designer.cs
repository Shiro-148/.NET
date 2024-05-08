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
            listView = new ListView();
            panel3 = new Panel();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            numericDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            numericFoodCount = new NumericUpDown();
            btnAddfood = new Button();
            comboBox1 = new ComboBox();
            comboBox = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1105, 28);
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
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listView);
            panel2.Location = new Point(658, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 359);
            panel2.TabIndex = 1;
            // 
            // listView
            // 
            listView.Location = new Point(0, 0);
            listView.Name = "listView";
            listView.Size = new Size(435, 359);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(numericDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(658, 474);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 81);
            panel3.TabIndex = 1;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 46);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(106, 28);
            cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = SystemColors.ControlLight;
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(106, 36);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            // 
            // numericDiscount
            // 
            numericDiscount.Location = new Point(161, 46);
            numericDiscount.Name = "numericDiscount";
            numericDiscount.Size = new Size(106, 27);
            numericDiscount.TabIndex = 4;
            numericDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = SystemColors.ControlLight;
            btnDiscount.Location = new Point(161, 4);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(106, 36);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += button1_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ControlLight;
            btnCheckOut.Location = new Point(326, 0);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(106, 78);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(numericFoodCount);
            panel4.Controls.Add(btnAddfood);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(comboBox);
            panel4.Location = new Point(658, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(435, 72);
            panel4.TabIndex = 1;
            // 
            // numericFoodCount
            // 
            numericFoodCount.Location = new Point(369, 24);
            numericFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericFoodCount.Name = "numericFoodCount";
            numericFoodCount.Size = new Size(63, 27);
            numericFoodCount.TabIndex = 3;
            numericFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 1;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(3, 3);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(248, 28);
            comboBox.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(640, 524);
            flpTable.TabIndex = 2;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 567);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            Text = "Quản Lý Quán Cafe";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericFoodCount).EndInit();
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
        private ListView listView;
        private Panel panel4;
        private ComboBox comboBox;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAddfood;
        private NumericUpDown numericFoodCount;
        private FlowLayoutPanel flpTable;
        private Button btnCheckOut;
        private Button btnDiscount;
        private NumericUpDown numericDiscount;
        private Button btnSwitchTable;
        private ComboBox cbSwitchTable;
    }
}