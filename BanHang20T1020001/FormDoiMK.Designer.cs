namespace BanHang20T1020001
{
    partial class FormDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMK));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 25, 98);
            label1.Location = new Point(478, 26);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 1;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 25, 98);
            label2.Location = new Point(406, 78);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 25, 98);
            label3.Location = new Point(406, 171);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu mới";
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(415, 120);
            txt1.Name = "txt1";
            txt1.PlaceholderText = "mật khẩu cũ";
            txt1.Size = new Size(287, 31);
            txt1.TabIndex = 5;
            // 
            // txt2
            // 
            txt2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.Location = new Point(415, 210);
            txt2.Name = "txt2";
            txt2.PlaceholderText = "mật khẩu mới";
            txt2.Size = new Size(287, 31);
            txt2.TabIndex = 6;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 25, 98);
            button1.Location = new Point(493, 257);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(147, 49);
            button1.TabIndex = 7;
            button1.Text = "Đồng ý";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(680, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FormDoiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 238, 231);
            ClientSize = new Size(725, 379);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoiMK";
            Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt2;
        private Button button1;
        private PictureBox pictureBox2;
    }
}