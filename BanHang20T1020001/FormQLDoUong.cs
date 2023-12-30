using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHang20T1020001.Model;

namespace BanHang20T1020001
{
    public partial class FormQLDoUong : Form
    {
        public FormQLDoUong()
        {
            InitializeComponent();
            LoadCategory();
        }
        void LoadCategory()
        {
            //lấy dữ liệu từ danh mục từ DB
            var db = new BanHangDB();
            /*var ls = db.Categories.OrderBy(e=>e.Name).ToList();*/
            var ls = db.Drinks
                .ToList();
            drinksBindingSource.DataSource = ls;
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            formTrangChu.Show();
            this.Hide();
        }

        private void quảnLýLoạiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoai formQuanLyLoai = new FormQuanLyLoai();
            formQuanLyLoai.Show();
            this.Hide();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var selCat = drinksBindingSource.Current as Drinks;
            if (selCat != null)
            {
                var db = new BanHangDB();
                var obj = db.Drinks.Where(t => t.MaDoUong == selCat.MaDoUong).FirstOrDefault();
                var rs = MessageBox.Show("Bạn chắc chắn muốn xoá!", "Xoá hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (obj != null)
                    {
                        db.Drinks.Remove(obj);
                        db.SaveChanges();
                        LoadCategory();
                    }
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            FormQLDoUongEdit f = new FormQLDoUongEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCategory();
                this.Hide();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var selCat = drinksBindingSource.Current as Drinks;
            if (selCat != null)
            {
                var f = new FormQLDoUongEdit(selCat);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadCategory();
                }
            }
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLNhaCC formQLNhaCC = new FormQLNhaCC();
            formQLNhaCC.Show();
            this.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tim = txttim.Text.ToLower();
            string normalizedTim = RemoveDiacritics(tim.ToLower());
            var db = new BanHangDB();
            var ls = db.Drinks.Where(e => e.TenDoUong.ToLower().Contains(tim)).ToList();
            if (ls != null)
            {
                drinksBindingSource.DataSource = ls;
            }
        }
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
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



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var selCat = drinksBindingSource.Current as Drinks;
            pictureBox1.ImageLocation = selCat.HinhAnh;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormQuanLyLoai formQuanLyLoai = new FormQuanLyLoai();
            formQuanLyLoai.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormQLNhaCC formQLNhaCC = new FormQLNhaCC();
            formQLNhaCC.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            formTrangChu.Show();
            this.Hide();
        }
    }
}
