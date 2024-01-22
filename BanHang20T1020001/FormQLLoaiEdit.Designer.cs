namespace BanHang20T1020001
{
    partial class FormQLLoaiEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLLoaiEdit));
            lbchucnang = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtml = new TextBox();
            txttl = new TextBox();
            datetimeNT = new DateTimePicker();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbchucnang
            // 
            lbchucnang.AutoSize = true;
            lbchucnang.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbchucnang.ForeColor = Color.Blue;
            lbchucnang.Location = new Point(47, 25);
            lbchucnang.Name = "lbchucnang";
            lbchucnang.RightToLeft = RightToLeft.Yes;
            lbchucnang.Size = new Size(192, 46);
            lbchucnang.TabIndex = 0;
            lbchucnang.Text = "Chức năng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(71, 138);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(395, 29);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(24, 88);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 3;
            label1.Text = "Ngày Thêm";
            // 
            // txtml
            // 
            txtml.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtml.Location = new Point(144, 29);
            txtml.Name = "txtml";
            txtml.Size = new Size(245, 31);
            txtml.TabIndex = 4;
            // 
            // txttl
            // 
            txttl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttl.Location = new Point(479, 30);
            txttl.Name = "txttl";
            txttl.Size = new Size(252, 31);
            txttl.TabIndex = 5;
            // 
            // datetimeNT
            // 
            datetimeNT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            datetimeNT.Location = new Point(142, 86);
            datetimeNT.Name = "datetimeNT";
            datetimeNT.Size = new Size(292, 31);
            datetimeNT.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(datetimeNT);
            panel1.Controls.Add(txtml);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txttl);
            panel1.Location = new Point(47, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 167);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(691, 296);
            button1.Name = "button1";
            button1.Size = new Size(116, 39);
            button1.TabIndex = 8;
            button1.Text = "Đồng Ý";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(504, -29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(380, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // FormQLLoaiEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 406);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lbchucnang);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQLLoaiEdit";
            Text = "FormQLLoaiEdit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbchucnang;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtml;
        private TextBox txttl;
        private DateTimePicker datetimeNT;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}