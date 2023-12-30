namespace BanHang20T1020001
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            btndn = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtname = new TextBox();
            txtusername = new TextBox();
            txtpass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btndn
            // 
            btndn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndn.ForeColor = Color.FromArgb(0, 25, 98);
            btndn.Location = new Point(395, 308);
            btndn.Name = "btndn";
            btndn.Size = new Size(124, 43);
            btndn.TabIndex = 4;
            btndn.Text = "Đăng nhập";
            btndn.UseVisualStyleBackColor = true;
            btndn.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 25, 98);
            button2.Location = new Point(573, 308);
            button2.Name = "button2";
            button2.Size = new Size(112, 43);
            button2.TabIndex = 3;
            button2.Text = "Đăng ký";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 25, 98);
            label1.Location = new Point(436, 26);
            label1.Name = "label1";
            label1.Size = new Size(214, 31);
            label1.TabIndex = 3;
            label1.Text = "Đăng Ký Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 25, 98);
            label2.Location = new Point(373, 74);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 4;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 25, 98);
            label3.Location = new Point(373, 218);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 5;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 25, 98);
            label4.Location = new Point(373, 150);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 6;
            label4.Text = "Họ tên";
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(395, 176);
            txtname.Name = "txtname";
            txtname.PlaceholderText = "họ và tên";
            txtname.Size = new Size(290, 30);
            txtname.TabIndex = 1;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(395, 111);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "username";
            txtusername.Size = new Size(290, 30);
            txtusername.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.Location = new Point(395, 244);
            txtpass.Name = "txtpass";
            txtpass.PlaceholderText = "password";
            txtpass.Size = new Size(290, 30);
            txtpass.TabIndex = 2;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 238, 231);
            ClientSize = new Size(719, 383);
            ControlBox = false;
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(btndn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            Load += FormDangKy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndn;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtname;
        private TextBox txtusername;
        private TextBox txtpass;
    }
}