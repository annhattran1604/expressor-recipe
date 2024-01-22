namespace BanHang20T1020001
{
    partial class FormQLDoUong
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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLDoUong));
			label1 = new Label();
			menuStrip1 = new MenuStrip();
			hệThốngToolStripMenuItem = new ToolStripMenuItem();
			trangChủToolStripMenuItem = new ToolStripMenuItem();
			đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
			quảnLýLoạiĐồUốngToolStripMenuItem = new ToolStripMenuItem();
			quảnLýNhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
			thốngKêToolStripMenuItem = new ToolStripMenuItem();
			dataGridView1 = new DataGridView();
			maDoUongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			tenDoUongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			ngaySXDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			ngayHHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			drinksBindingSource = new BindingSource(components);
			panel1 = new Panel();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			btn = new ToolStripButton();
			btnupdate = new ToolStripButton();
			btnxoa = new ToolStripButton();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			label4 = new Label();
			pictureBox5 = new PictureBox();
			label3 = new Label();
			pictureBox4 = new PictureBox();
			label2 = new Label();
			pictureBox3 = new PictureBox();
			pictureBox2 = new PictureBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)drinksBindingSource).BeginInit();
			panel1.SuspendLayout();
			toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(0, 25, 98);
			label1.Location = new Point(639, 49);
			label1.Name = "label1";
			label1.Size = new Size(263, 37);
			label1.TabIndex = 0;
			label1.Text = "Quản Lý Đồ Uống";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýLoạiĐồUốngToolStripMenuItem, quảnLýNhàCungCấpToolStripMenuItem, thốngKêToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1566, 33);
			menuStrip1.TabIndex = 1;
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
			// quảnLýLoạiĐồUốngToolStripMenuItem
			// 
			quảnLýLoạiĐồUốngToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			quảnLýLoạiĐồUốngToolStripMenuItem.Name = "quảnLýLoạiĐồUốngToolStripMenuItem";
			quảnLýLoạiĐồUốngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D1;
			quảnLýLoạiĐồUốngToolStripMenuItem.Size = new Size(194, 29);
			quảnLýLoạiĐồUốngToolStripMenuItem.Text = "Quản lý loại đồ uống";
			quảnLýLoạiĐồUốngToolStripMenuItem.Click += quảnLýLoạiĐồUốngToolStripMenuItem_Click;
			// 
			// quảnLýNhàCungCấpToolStripMenuItem
			// 
			quảnLýNhàCungCấpToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
			quảnLýNhàCungCấpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
			quảnLýNhàCungCấpToolStripMenuItem.Size = new Size(198, 29);
			quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
			quảnLýNhàCungCấpToolStripMenuItem.Click += quảnLýNhàCungCấpToolStripMenuItem_Click;
			// 
			// thốngKêToolStripMenuItem
			// 
			thốngKêToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
			thốngKêToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
			thốngKêToolStripMenuItem.Size = new Size(100, 29);
			thốngKêToolStripMenuItem.Text = "Thống kê";
			thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 35;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maDoUongDataGridViewTextBoxColumn, tenDoUongDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, ngaySXDataGridViewTextBoxColumn, ngayHHDataGridViewTextBoxColumn });
			dataGridView1.DataSource = drinksBindingSource;
			dataGridView1.Location = new Point(-52, 28);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1058, 396);
			dataGridView1.TabIndex = 2;
			dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
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
			giaDataGridViewTextBoxColumn.HeaderText = "Giá cả";
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
			// ngaySXDataGridViewTextBoxColumn
			// 
			ngaySXDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ngaySXDataGridViewTextBoxColumn.DataPropertyName = "NgaySX";
			dataGridViewCellStyle2.Format = "dd/MM/yyyy";
			ngaySXDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			ngaySXDataGridViewTextBoxColumn.HeaderText = "Ngày sản xuất";
			ngaySXDataGridViewTextBoxColumn.MinimumWidth = 6;
			ngaySXDataGridViewTextBoxColumn.Name = "ngaySXDataGridViewTextBoxColumn";
			// 
			// ngayHHDataGridViewTextBoxColumn
			// 
			ngayHHDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ngayHHDataGridViewTextBoxColumn.DataPropertyName = "NgayHH";
			dataGridViewCellStyle3.Format = "dd/MM/yyyy";
			ngayHHDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			ngayHHDataGridViewTextBoxColumn.HeaderText = "Ngày hết hạn";
			ngayHHDataGridViewTextBoxColumn.MinimumWidth = 6;
			ngayHHDataGridViewTextBoxColumn.Name = "ngayHHDataGridViewTextBoxColumn";
			// 
			// drinksBindingSource
			// 
			drinksBindingSource.DataSource = typeof(Model.Drinks);
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(255, 255, 192);
			panel1.Controls.Add(toolStrip1);
			panel1.Controls.Add(dataGridView1);
			panel1.Location = new Point(267, 93);
			panel1.Name = "panel1";
			panel1.Size = new Size(1006, 424);
			panel1.TabIndex = 3;
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, btn, btnupdate, btnxoa });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1006, 30);
			toolStrip1.TabIndex = 3;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			toolStripButton1.ForeColor = Color.Blue;
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(167, 27);
			toolStripButton1.Text = "Danh sách đồ uống";
			// 
			// btn
			// 
			btn.Alignment = ToolStripItemAlignment.Right;
			btn.Image = (Image)resources.GetObject("btn.Image");
			btn.ImageTransparentColor = Color.Magenta;
			btn.Name = "btn";
			btn.Size = new Size(130, 27);
			btn.Text = "Thêm đồ uống";
			btn.Click += btn_Click;
			// 
			// btnupdate
			// 
			btnupdate.Alignment = ToolStripItemAlignment.Right;
			btnupdate.Image = (Image)resources.GetObject("btnupdate.Image");
			btnupdate.ImageTransparentColor = Color.Magenta;
			btnupdate.Name = "btnupdate";
			btnupdate.Size = new Size(118, 27);
			btnupdate.Text = "Sửa đồ uống";
			btnupdate.Click += btnupdate_Click;
			// 
			// btnxoa
			// 
			btnxoa.Alignment = ToolStripItemAlignment.Right;
			btnxoa.Image = (Image)resources.GetObject("btnxoa.Image");
			btnxoa.ImageTransparentColor = Color.Magenta;
			btnxoa.Name = "btnxoa";
			btnxoa.Size = new Size(119, 27);
			btnxoa.Text = "Xoá đồ uống";
			btnxoa.Click += btnxoa_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.White;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(1279, 129);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(259, 388);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(255, 255, 192);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(pictureBox5);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(pictureBox4);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(pictureBox3);
			panel2.Controls.Add(pictureBox2);
			panel2.Location = new Point(0, 31);
			panel2.Name = "panel2";
			panel2.Size = new Size(261, 516);
			panel2.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(50, 324);
			label4.Name = "label4";
			label4.RightToLeft = RightToLeft.No;
			label4.Size = new Size(116, 31);
			label4.TabIndex = 8;
			label4.Text = "Thống Kê";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			label4.Click += label4_Click;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(2, 315);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(46, 48);
			pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 7;
			pictureBox5.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(48, 229);
			label3.Name = "label3";
			label3.RightToLeft = RightToLeft.No;
			label3.Size = new Size(212, 62);
			label3.TabIndex = 6;
			label3.Text = "Quản Lý Nhà Cung\r\nCấp";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			label3.Click += label3_Click;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(2, 238);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(46, 48);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 5;
			pictureBox4.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(50, 147);
			label2.Name = "label2";
			label2.RightToLeft = RightToLeft.No;
			label2.Size = new Size(188, 62);
			label2.TabIndex = 4;
			label2.Text = "Quản Lý Loại Đồ\r\nUống";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			label2.Click += label2_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(2, 156);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(46, 48);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 3;
			pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(-1, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(262, 141);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// FormQLDoUong
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(139, 211, 221);
			ClientSize = new Size(1566, 546);
			ControlBox = false;
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Controls.Add(label1);
			Controls.Add(menuStrip1);
			Controls.Add(panel2);
			FormBorderStyle = FormBorderStyle.None;
			MainMenuStrip = menuStrip1;
			Name = "FormQLDoUong";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quản lý đồ uống";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)drinksBindingSource).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýLoạiĐồUốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private DataGridView dataGridView1;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton btn;
        private ToolStripButton btnupdate;
        private ToolStripButton btnxoa;
        private BindingSource drinksBindingSource;
        private DataGridViewTextBoxColumn maDoUongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDoUongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cachDongGoiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayHHDataGridViewTextBoxColumn;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label3;
        private PictureBox pictureBox4;
    }
}