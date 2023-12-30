namespace BanHang20T1020001
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnDangNhap = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 238, 231);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 25, 98);
            label1.Location = new Point(465, 48);
            label1.Name = "label1";
            label1.Size = new Size(302, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(250, 238, 231);
            label2.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 25, 98);
            label2.Location = new Point(450, 103);
            label2.Name = "label2";
            label2.Size = new Size(65, 39);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(250, 238, 231);
            label3.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 25, 98);
            label3.Location = new Point(450, 199);
            label3.Name = "label3";
            label3.Size = new Size(114, 39);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(459, 145);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(339, 34);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(459, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(339, 34);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-26, -86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 604);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.White;
            btnDangNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.FromArgb(0, 25, 98);
            btnDangNhap.Location = new Point(658, 293);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(140, 41);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 25, 98);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(459, 293);
            button2.Name = "button2";
            button2.Size = new Size(147, 41);
            button2.TabIndex = 3;
            button2.Text = "Đăng ký";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(790, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 238, 231);
            ClientSize = new Size(834, 429);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(btnDangNhap);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(0, 25, 98);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button btnDangNhap;
        private Button button2;
        private PictureBox pictureBox2;
    }
}