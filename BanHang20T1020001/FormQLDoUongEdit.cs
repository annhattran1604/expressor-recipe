using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHang20T1020001.Model;

namespace BanHang20T1020001
{
    public partial class FormQLDoUongEdit : Form
    {
        Drinks drinks;
        private ErrorProvider errorProvider;
        public FormQLDoUongEdit(Drinks drinks = null)
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            this.drinks = drinks;
            txtsl.Text = "0";
            if (drinks != null)
            {
                var db = new BanHangDB();
                var obj = db.Types.Where(t => t.maloai == drinks.MaLoai).FirstOrDefault();
                var obj2 = db.Providers.Where(t => t.MaNCC == drinks.MaNCC).FirstOrDefault();
                txtmadu.Text = drinks.MaDoUong;
                txttendu.Text = drinks.TenDoUong;
                txtgia.Text = drinks.Gia.ToString();
                txtsl.Text = drinks.SoLuong.ToString();
                dateTimePicker1.Value = drinks.NgaySX;
                dateTimePicker2.Value = drinks.NgayHH;
                string ml = obj.tenloai;
                string mncc = obj2.TenNCC;

                txtloaidu.Text = ml;
                txtncc.Text = mncc;
                txtloaidu.ReadOnly = true;
                txtncc.ReadOnly = true;

                this.Text = "Cập nhật sản phẩm";
                label1.Text = "Cập Nhật";
                pic1.ImageLocation = drinks.HinhAnh;
                txtmadu.ReadOnly = true;
                txtloaidu.Enabled = true;
                txtncc.Enabled = true;
            }
            else
            {
                this.Text = "Thêm sản phẩm mới";
                label1.Text = "Thêm Mới";
                txtloaidu.ReadOnly = true;
                txtncc.ReadOnly = true;
            }
            LoadCategory();
        }
        void LoadCategory()
        {
            var db = new BanHangDB();
            var ls1 = db.Types.ToList();
            var ls2 = db.Providers.ToList();
            cmbml.DataSource = ls1;
            cmbml.DisplayMember = "tenloai";
            cmbncc.DataSource = ls2;
            cmbncc.DisplayMember = "TenNCC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selCat1 = cmbml.SelectedItem as Types;
            var selCat2 = cmbncc.SelectedItem as Provider;
            string ma = txtmadu.Text;
            string tl = txttendu.Text;
            string sl = txtsl.Text;
            string gia = txtgia.Text;
            if (string.IsNullOrWhiteSpace(ma))
            {
                errorProvider.SetError(txtmadu, "Mã không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tl))
            {
                errorProvider.SetError(txttendu, "Tên không được để trống.");
                return;
            }
            else
            {
                errorProvider.SetError(txtmadu, "");
                errorProvider.SetError(txttendu, "");
                int parsedSL, parsedGia;
                if (!int.TryParse(sl, out parsedSL))
                {
                    errorProvider.SetError(txtsl, "Số lượng phải là số.");
                    return;
                }
                if (!int.TryParse(gia, out parsedSL))
                {
                    errorProvider.SetError(txtgia, "Giá phải là số.");
                    return;
                }
                if (pic1.ImageLocation == null)
                {

                    MessageBox.Show("Thiếu hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    errorProvider.SetError(txtsl, "");
                    errorProvider.SetError(txtgia, "");
                    if (drinks == null)
                    {

                        //Thêm mới
                        var db1 = new BanHangDB();
                        var obj1 = db1.Drinks.Where(t => t.MaDoUong == txtmadu.Text).FirstOrDefault();
                        var obj2 = db1.Drinks.Where(t => t.TenDoUong == txttendu.Text).FirstOrDefault();
                        if (obj1 == null && obj2 == null)
                        {
                            var obj = new Drinks
                            {
                                MaDoUong = txtmadu.Text,
                                TenDoUong = txttendu.Text,
                                Gia = long.Parse(txtgia.Text),
                                SoLuong = long.Parse(txtsl.Text),
                                NgaySX = dateTimePicker1.Value,
                                NgayHH = dateTimePicker2.Value,
                                MaLoai = selCat1.maloai,
                                MaNCC = selCat2.MaNCC,
                                HinhAnh = pic1.ImageLocation
                            };
                            var db = new BanHangDB();
                            db.Drinks.Add(obj);
                            db.SaveChanges();
                            //tự đôngj tắt form
                            DialogResult = DialogResult.OK;
                            FormQLDoUong f = new FormQLDoUong();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Đồ uống này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Cập nhật
                        var db = new BanHangDB();
                        var obj = db.Drinks.Where(t => t.MaDoUong == drinks.MaDoUong).FirstOrDefault();
                        if (obj != null)
                        {
                            obj.MaDoUong = txtmadu.Text;
                            obj.TenDoUong = txttendu.Text;
                            obj.Gia = long.Parse(txtgia.Text);
                            obj.SoLuong = long.Parse(txtsl.Text);
                            obj.NgaySX = dateTimePicker1.Value;
                            obj.NgayHH = dateTimePicker2.Value;
                            obj.MaLoai = selCat1.maloai;
                            obj.MaNCC = selCat2.MaNCC;
                            obj.HinhAnh = pic1.ImageLocation;
                            db.SaveChanges();
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
            }

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Title = "Chọn ảnh",
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var selectdFile = openFile.FileName;
                pic1.ImageLocation = selectdFile;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            long a = int.Parse(txtsl.Text);
            if (a >= 10)
            {
                txtsl.Text = (a - 10).ToString();
            }
            else
            {
                MessageBox.Show("Số lương nhỏ hơn 10", "");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            long a = int.Parse(txtsl.Text);
            txtsl.Text = (a + 10).ToString();
        }
    }
}
