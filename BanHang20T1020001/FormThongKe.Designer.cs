namespace BanHang20T1020001.Model
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐồUốngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýLoạiĐồUốngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cmbloai = new ComboBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            cmbncc = new ComboBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            maDoUongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDoUongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hinhAnhDataGridViewTextBoxColumn = new DataGridViewImageColumn();
            drinksBindingSource = new BindingSource(components);
            lblTK = new Label();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drinksBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýĐồUốngToolStripMenuItem, quảnLýLoạiĐồUốngToolStripMenuItem, quảnLýNhàCungCấpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1224, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(101, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            trangChủToolStripMenuItem.Size = new Size(244, 30);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            trangChủToolStripMenuItem.Click += trangChủToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            đăngXuấtToolStripMenuItem.Size = new Size(244, 30);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýĐồUốngToolStripMenuItem
            // 
            quảnLýĐồUốngToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            quảnLýĐồUốngToolStripMenuItem.Name = "quảnLýĐồUốngToolStripMenuItem";
            quảnLýĐồUốngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D1;
            quảnLýĐồUốngToolStripMenuItem.Size = new Size(161, 29);
            quảnLýĐồUốngToolStripMenuItem.Text = "Quản lý đồ uống";
            quảnLýĐồUốngToolStripMenuItem.Click += quảnLýĐồUốngToolStripMenuItem_Click;
            // 
            // quảnLýLoạiĐồUốngToolStripMenuItem
            // 
            quảnLýLoạiĐồUốngToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            quảnLýLoạiĐồUốngToolStripMenuItem.Name = "quảnLýLoạiĐồUốngToolStripMenuItem";
            quảnLýLoạiĐồUốngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
            quảnLýLoạiĐồUốngToolStripMenuItem.Size = new Size(194, 29);
            quảnLýLoạiĐồUốngToolStripMenuItem.Text = "Quản lý loại đồ uống";
            quảnLýLoạiĐồUốngToolStripMenuItem.Click += quảnLýLoạiĐồUốngToolStripMenuItem_Click;
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            quảnLýNhàCungCấpToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            quảnLýNhàCungCấpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            quảnLýNhàCungCấpToolStripMenuItem.Size = new Size(198, 29);
            quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            quảnLýNhàCungCấpToolStripMenuItem.Click += quảnLýNhàCungCấpToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 23, 44);
            label1.Location = new Point(38, 123);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 3;
            label1.Text = "Loại đồ uống";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 476);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cmbloai
            // 
            cmbloai.BackColor = Color.FromArgb(255, 198, 199);
            cmbloai.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbloai.FormattingEnabled = true;
            cmbloai.Location = new Point(3, 157);
            cmbloai.Name = "cmbloai";
            cmbloai.Size = new Size(239, 33);
            cmbloai.TabIndex = 1;
            cmbloai.SelectedIndexChanged += cmbloai_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 198, 199);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbloai);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(cmbncc);
            panel2.Location = new Point(977, 30);
            panel2.MaximumSize = new Size(245, 601);
            panel2.MinimumSize = new Size(0, 601);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 601);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(14, 23, 44);
            label2.Location = new Point(38, 300);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 2;
            label2.Text = "Nhà cung cấp";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // cmbncc
            // 
            cmbncc.BackColor = Color.FromArgb(255, 198, 199);
            cmbncc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbncc.FormattingEnabled = true;
            cmbncc.Location = new Point(3, 334);
            cmbncc.Name = "cmbncc";
            cmbncc.Size = new Size(239, 33);
            cmbncc.TabIndex = 0;
            cmbncc.SelectedIndexChanged += cmbncc_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(139, 211, 221);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(lblTK);
            panel3.Location = new Point(0, 31);
            panel3.MaximumSize = new Size(1212, 493);
            panel3.MinimumSize = new Size(977, 493);
            panel3.Name = "panel3";
            panel3.Size = new Size(977, 493);
            panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(925, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(139, 211, 221);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maDoUongDataGridViewTextBoxColumn, tenDoUongDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, hinhAnhDataGridViewTextBoxColumn });
            dataGridView1.DataSource = drinksBindingSource;
            dataGridView1.GridColor = Color.FromArgb(255, 192, 192);
            dataGridView1.ImeMode = ImeMode.Disable;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.MaximumSize = new Size(1200, 436);
            dataGridView1.MinimumSize = new Size(962, 436);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(962, 436);
            dataGridView1.TabIndex = 1;
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
            giaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            giaDataGridViewTextBoxColumn.HeaderText = "Giá cả";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
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
            hinhAnhDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            hinhAnhDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // drinksBindingSource
            // 
            drinksBindingSource.DataSource = typeof(Drinks);
            // 
            // lblTK
            // 
            lblTK.AutoSize = true;
            lblTK.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTK.ForeColor = Color.FromArgb(0, 25, 98);
            lblTK.Location = new Point(397, 5);
            lblTK.Name = "lblTK";
            lblTK.Size = new Size(188, 45);
            lblTK.TabIndex = 0;
            lblTK.Text = "Thống Kê";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 198, 199);
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(734, 530);
            button1.Name = "button1";
            button1.Size = new Size(221, 50);
            button1.TabIndex = 4;
            button1.Text = "Hàng cần nhập thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.White;
            toolTip1.ForeColor = Color.Red;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(734, 586);
            button2.Name = "button2";
            button2.Size = new Size(221, 42);
            button2.TabIndex = 5;
            button2.Text = "Xuất dữ liệu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 6;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 6;
            timer2.Tick += timer2_Tick;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(139, 211, 221);
            ClientSize = new Size(1224, 631);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê đồ uống";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)drinksBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private Panel panel2;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐồUốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýLoạiĐồUốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private Panel panel3;
        private Label lblTK;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cmbloai;
        private PictureBox pictureBox2;
        private ComboBox cmbncc;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private BindingSource drinksBindingSource;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn maDoUongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDoUongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewImageColumn hinhAnhDataGridViewTextBoxColumn;
        private Button button2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}