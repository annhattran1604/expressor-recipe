namespace BanHang20T1020001
{
    partial class BanHang
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            maDoUongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDoUongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hinhAnhDataGridViewTextBoxColumn = new DataGridViewImageColumn();
            drinksBindingSource = new BindingSource(components);
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtsldu = new TextBox();
            txtTongTien = new TextBox();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            xoáHàngHoáToolStripMenuItem = new ToolStripMenuItem();
            sửaHàngHoáToolStripMenuItem = new ToolStripMenuItem();
            dataGridView2 = new DataGridView();
            tenDoUongDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            hoaDonBindingSource = new BindingSource(components);
            drinksBindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            nb1 = new NumericUpDown();
            txt1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtma = new TextBox();
            txtgia = new TextBox();
            button1 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drinksBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drinksBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(31, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 260);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maDoUongDataGridViewTextBoxColumn, tenDoUongDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, hinhAnhDataGridViewTextBoxColumn });
            dataGridView1.DataSource = drinksBindingSource;
            dataGridView1.Location = new Point(-51, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(955, 260);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // maDoUongDataGridViewTextBoxColumn
            // 
            maDoUongDataGridViewTextBoxColumn.DataPropertyName = "MaDoUong";
            maDoUongDataGridViewTextBoxColumn.HeaderText = "Mã đồ uống";
            maDoUongDataGridViewTextBoxColumn.MinimumWidth = 6;
            maDoUongDataGridViewTextBoxColumn.Name = "maDoUongDataGridViewTextBoxColumn";
            maDoUongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDoUongDataGridViewTextBoxColumn
            // 
            tenDoUongDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenDoUongDataGridViewTextBoxColumn.DataPropertyName = "TenDoUong";
            tenDoUongDataGridViewTextBoxColumn.HeaderText = "Tên đồ uống";
            tenDoUongDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenDoUongDataGridViewTextBoxColumn.Name = "tenDoUongDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // hinhAnhDataGridViewTextBoxColumn
            // 
            hinhAnhDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
            hinhAnhDataGridViewTextBoxColumn.HeaderText = "Hình ảnh";
            hinhAnhDataGridViewTextBoxColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            hinhAnhDataGridViewTextBoxColumn.MinimumWidth = 6;
            hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
            hinhAnhDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            hinhAnhDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // drinksBindingSource
            // 
            drinksBindingSource.DataSource = typeof(Model.Drinks);
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtsldu);
            panel2.Controls.Add(txtTongTien);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(31, 445);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 231);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(800, 47);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(625, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtsldu
            // 
            txtsldu.BorderStyle = BorderStyle.FixedSingle;
            txtsldu.Enabled = false;
            txtsldu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtsldu.Location = new Point(669, 47);
            txtsldu.Name = "txtsldu";
            txtsldu.Size = new Size(125, 34);
            txtsldu.TabIndex = 4;
            txtsldu.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.Location = new Point(701, 119);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(186, 43);
            txtTongTien.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(578, 127);
            label5.Name = "label5";
            label5.Size = new Size(117, 31);
            label5.TabIndex = 1;
            label5.Text = "Tổng tiền";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { xoáHàngHoáToolStripMenuItem, sửaHàngHoáToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(904, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // xoáHàngHoáToolStripMenuItem
            // 
            xoáHàngHoáToolStripMenuItem.BackColor = Color.Blue;
            xoáHàngHoáToolStripMenuItem.ForeColor = Color.White;
            xoáHàngHoáToolStripMenuItem.Name = "xoáHàngHoáToolStripMenuItem";
            xoáHàngHoáToolStripMenuItem.Size = new Size(102, 29);
            xoáHàngHoáToolStripMenuItem.Text = "Xoá hàng";
            xoáHàngHoáToolStripMenuItem.Click += xoáHàngHoáToolStripMenuItem_Click;
            // 
            // sửaHàngHoáToolStripMenuItem
            // 
            sửaHàngHoáToolStripMenuItem.BackColor = Color.Blue;
            sửaHàngHoáToolStripMenuItem.ForeColor = Color.White;
            sửaHàngHoáToolStripMenuItem.Name = "sửaHàngHoáToolStripMenuItem";
            sửaHàngHoáToolStripMenuItem.Size = new Size(139, 29);
            sửaHàngHoáToolStripMenuItem.Text = "Xoá đơn hàng";
            sửaHàngHoáToolStripMenuItem.Click += sửaHàngHoáToolStripMenuItem_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { tenDoUongDataGridViewTextBoxColumn1, soLuongDataGridViewTextBoxColumn1, giaDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = hoaDonBindingSource;
            dataGridView2.Location = new Point(-51, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(601, 200);
            dataGridView2.TabIndex = 0;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // tenDoUongDataGridViewTextBoxColumn1
            // 
            tenDoUongDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenDoUongDataGridViewTextBoxColumn1.DataPropertyName = "TenDoUong";
            tenDoUongDataGridViewTextBoxColumn1.HeaderText = "Tên đồ uống";
            tenDoUongDataGridViewTextBoxColumn1.MinimumWidth = 6;
            tenDoUongDataGridViewTextBoxColumn1.Name = "tenDoUongDataGridViewTextBoxColumn1";
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn1.HeaderText = "Số lượng";
            soLuongDataGridViewTextBoxColumn1.MinimumWidth = 6;
            soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            soLuongDataGridViewTextBoxColumn1.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn1
            // 
            giaDataGridViewTextBoxColumn1.DataPropertyName = "Gia";
            giaDataGridViewTextBoxColumn1.HeaderText = "Giá";
            giaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn1.Name = "giaDataGridViewTextBoxColumn1";
            giaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            hoaDonBindingSource.DataSource = typeof(Model.HoaDon);
            // 
            // drinksBindingSource1
            // 
            drinksBindingSource1.DataSource = typeof(Model.Drinks);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 102);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 2;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(459, 55);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 3;
            label2.Text = "Số lượng";
            // 
            // nb1
            // 
            nb1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            nb1.Location = new Point(550, 53);
            nb1.Name = "nb1";
            nb1.Size = new Size(150, 31);
            nb1.TabIndex = 4;
            nb1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txt1
            // 
            txt1.Enabled = false;
            txt1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(173, 99);
            txt1.Name = "txt1";
            txt1.Size = new Size(237, 31);
            txt1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(908, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(732, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 57);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 8;
            label3.Text = "Mã sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(459, 102);
            label4.Name = "label4";
            label4.Size = new Size(41, 28);
            label4.TabIndex = 9;
            label4.Text = "Giá";
            // 
            // txtma
            // 
            txtma.Enabled = false;
            txtma.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtma.Location = new Point(172, 56);
            txtma.Name = "txtma";
            txtma.Size = new Size(125, 31);
            txtma.TabIndex = 10;
            // 
            // txtgia
            // 
            txtgia.Enabled = false;
            txtgia.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtgia.Location = new Point(550, 103);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(150, 31);
            txtgia.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(770, 623);
            button1.Name = "button1";
            button1.Size = new Size(144, 40);
            button1.TabIndex = 12;
            button1.Text = "Thanh Toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(31, 9);
            label6.Name = "label6";
            label6.Size = new Size(305, 38);
            label6.TabIndex = 13;
            label6.Text = "Cửa Hàng Đồ Uống";
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(965, 688);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtgia);
            Controls.Add(txtma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txt1);
            Controls.Add(nb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "BanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BanHang";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)drinksBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)drinksBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn maDoUongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDoUongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewImageColumn hinhAnhDataGridViewTextBoxColumn;
        private BindingSource drinksBindingSource;
        private Label label1;
        private Label label2;
        private NumericUpDown nb1;
        private TextBox txt1;
        private PictureBox pictureBox1;
        private BindingSource drinksBindingSource1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView2;
        private BindingSource hoaDonBindingSource;
        private Label label3;
        private Label label4;
        private TextBox txtma;
        private TextBox txtgia;
        private DataGridViewTextBoxColumn tenDoUongDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn1;
        private TextBox txtTongTien;
        private Label label5;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem xoáHàngHoáToolStripMenuItem;
        private ToolStripMenuItem sửaHàngHoáToolStripMenuItem;
        private Label label6;
        private TextBox txtsldu;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}