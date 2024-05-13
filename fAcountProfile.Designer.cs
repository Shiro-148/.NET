namespace QuanLiCafe
{
    partial class fAcountProfile
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
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 59);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(166, 18);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(260, 27);
            txbUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 59);
            panel1.TabIndex = 3;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(166, 15);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(260, 27);
            txbDisplayName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(135, 24);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 65);
            panel3.TabIndex = 4;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(166, 15);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(260, 27);
            txbPassWord.TabIndex = 2;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu: ";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 213);
            panel4.Name = "panel4";
            panel4.Size = new Size(442, 65);
            panel4.TabIndex = 5;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(166, 15);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(260, 27);
            txbNewPass.TabIndex = 2;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(3, 18);
            label4.Name = "label4";
            label4.Size = new Size(152, 24);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu mới: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 284);
            panel5.Name = "panel5";
            panel5.Size = new Size(442, 65);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(166, 15);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(260, 27);
            txbReEnterPass.TabIndex = 2;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(3, 18);
            label5.Name = "label5";
            label5.Size = new Size(99, 24);
            label5.TabIndex = 1;
            label5.Text = "Nhập lại: ";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLight;
            btnUpdate.Location = new Point(209, 355);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlLight;
            btnExit.Location = new Point(343, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // fAcountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(466, 413);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAcountProfile";
            Text = "Thông tin cá nhân";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPass;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnUpdate;
        private Button btnExit;
    }
}