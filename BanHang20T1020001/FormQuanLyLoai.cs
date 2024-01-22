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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BanHang20T1020001
{
    public partial class FormQuanLyLoai : Form
    {
        public FormQuanLyLoai()
        {
            InitializeComponent();
            LoadCategory();
        }
        void LoadCategory()
        {
            //lấy dữ liệu từ danh mục từ DB
            var db = new BanHangDB();
            /*var ls = db.Categories.OrderBy(e=>e.Name).ToList();*/
            var ls = db.Types
                .ToList();

            typesBindingSource.DataSource = ls;
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //thêm loại
            FormQLLoaiEdit f = new FormQLLoaiEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCategory();
                this.Hide();
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //sửa
            var selCat = typesBindingSource.Current as Types;
            if (selCat != null)
            {
                var f = new FormQLLoaiEdit(selCat);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadCategory();
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Xoá
            var selCat = typesBindingSource.Current as Types;
            if (selCat != null)
            {
                var db = new BanHangDB();
                var obj = db.Types.Where(t => t.maloai == selCat.maloai).FirstOrDefault();
                var rs = MessageBox.Show("Bạn chắc chắn muốn xoá!", "Xoá loại đồ uống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    var rs1 = MessageBox.Show("Xoá loại sẽ ảnh hưởng đến các mặt hàng liên quan!", "Xoá loại đồ uống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs1 == DialogResult.Yes)
                    {
                        if (obj != null)
                        {
                            db.Types.Remove(obj);
                            db.SaveChanges();
                            LoadCategory();
                        }
                    }
                }
            }
        }

        private void quảnLýĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDoUong formQLDoUong = new FormQLDoUong();
            formQLDoUong.Show();
            this.Hide();
        }

        private void quảnLýNhàCCToolStripMenuItem_Click(object sender, EventArgs e)
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
            FormQLNhaCC f = new FormQLNhaCC();
            f.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormThongKe f = new FormThongKe();
            f.Show();
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
            var selCat = typesBindingSource.Current as Types;
            var db = new BanHangDB();
            var obj = db.Drinks.Where(t => t.MaLoai == selCat.maloai).ToList();
            txtsl.Text = obj.Count.ToString();
        }
    }
}
