using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHang20T1020001.Model;

namespace BanHang20T1020001
{
    public partial class FormQLNhaCC : Form
    {
        public FormQLNhaCC()
        {
            InitializeComponent();
            LoadCategory();
        }
        void LoadCategory()
        {
            //lấy dữ liệu từ danh mục từ DB
            var db = new BanHangDB();
            /*var ls = db.Categories.OrderBy(e=>e.Name).ToList();*/
            var ls = db.Providers
                .ToList();
            providerBindingSource.DataSource = ls;
        }
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void quảnLýĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDoUong f = new FormQLDoUong();
            f.Show();
            this.Hide();
        }

        private void quảnLýLoạiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoai f = new FormQuanLyLoai();
            f.Show();
            this.Hide();
        }

        private void toolxoa_Click(object sender, EventArgs e)
        {
            var selCat = providerBindingSource.Current as Provider;
            if (selCat != null)
            {
                var db = new BanHangDB();
                var obj = db.Providers.Where(t => t.MaNCC == selCat.MaNCC).FirstOrDefault();
                var rs = MessageBox.Show("Bạn chắc chắn muốn xoá!", "Xoá nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    var rs1 = MessageBox.Show("Xoá sẽ ảnh hưởng đến các mặt hàng liên quan!", "Xoá nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs1 == DialogResult.Yes)
                    {
                        if (obj != null)
                        {
                            db.Providers.Remove(obj);
                            db.SaveChanges();
                            LoadCategory();
                        }
                    }
                }
            }
        }

        private void toolsua_Click(object sender, EventArgs e)
        {
            var selCat = providerBindingSource.Current as Provider;
            if (selCat != null)
            {
                var f = new FormQLNCCEdit(selCat);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadCategory();
                }
            }
        }

        private void toolthem_Click(object sender, EventArgs e)
        {
            FormQLNCCEdit f = new FormQLNCCEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCategory();
                this.Hide();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
            this.Hide();
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            string tim = txttim.Text.ToLower();
            var db = new BanHangDB();
            var ls = db.Providers.Where(e => e.DiaChi.ToLower().Contains(tim)).ToList();
            providerBindingSource.DataSource = ls;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Đổi màu cho hàng chẵn
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(139, 211, 221);
            }
            else // Đổi màu cho hàng lẻ
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormQLDoUong formQLDoUong = new FormQLDoUong();
            formQLDoUong.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormQuanLyLoai form = new FormQuanLyLoai();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            formTrangChu.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var selCat = providerBindingSource.Current as Provider;
            var db = new BanHangDB();
            var obj = db.Drinks.Where(t => t.MaNCC == selCat.MaNCC).ToList();
            textBox1.Text = obj.Count.ToString();
        }
    }
}
