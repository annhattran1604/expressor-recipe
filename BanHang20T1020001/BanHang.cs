using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Tables;
using BanHang20T1020001.Model;
using ThuVienWinform.Report.AsposeWordExtension;

namespace BanHang20T1020001
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
            LoadDrinks();
            LoadHoaDon();
        }
        void LoadDrinks()
        {
            var db = new BanHangDB();
            var ls = db.Drinks
                .ToList();

            var imageDictionary = new Dictionary<string, Image>(); // Dictionary lưu trữ đường dẫn và Image

            // Chuyển đổi đường dẫn hình ảnh thành đối tượng Image
            foreach (var drink in ls)
            {
                if (!string.IsNullOrEmpty(drink.HinhAnh) && File.Exists(drink.HinhAnh))
                {
                    Image img = Image.FromFile(drink.HinhAnh);
                    imageDictionary[drink.HinhAnh] = img;
                }
            }
            int yourImageColumnIndex = 4;
            dataGridView1.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == yourImageColumnIndex && e.RowIndex >= 0) // Thay yourImageColumnIndex bằng index của cột hình ảnh
                {
                    var row = dataGridView1.Rows[e.RowIndex];
                    var imagePath = row.Cells[yourImageColumnIndex].Value.ToString(); // Thay yourImageColumnIndex bằng index của cột hình ảnh

                    if (imageDictionary.ContainsKey(imagePath))
                    {
                        e.Value = imageDictionary[imagePath];
                    }
                }
            };
            dataGridView1.RowTemplate.Height = 80;

            drinksBindingSource.DataSource = ls;
        }
        void LoadHoaDon()
        {
            var db = new BanHangDB();
            var ls = db.hoaDons
                .ToList();
            hoaDonBindingSource.DataSource = ls;
            long tong = 0; // Khai báo biến `tong` trước khi sử dụng

            foreach (var name in ls)
            {
                tong += name.Gia * name.SoLuong; // Cộng giá trị mới vào `tong`
            }
            txtTongTien.Text = tong.ToString() + " đ";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (drinksBindingSource.Current != null)
            {
                var drink = drinksBindingSource.Current as Drinks;
                if (drink != null)
                {
                    txt1.Text = drink.TenDoUong;
                    txtgia.Text = drink.Gia.ToString();
                    txtma.Text = drink.MaDoUong;
                }
            }
            else
            {
                // Xử lý khi không có đối tượng nào được chọn
                txt1.Text = string.Empty;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //nút mua hàng
            var db = new BanHangDB();
            var obj = new HoaDon
            {
                MaDoUong = txtma.Text,
                TenDoUong = txt1.Text,
                Gia = long.Parse(txtgia.Text),
                SoLuong = Convert.ToInt64(nb1.Value),
            };
            var ls = db.hoaDons.Where(h => h.MaDoUong.Equals(obj.MaDoUong)).ToList();
            if (ls != null && !ls.Any())
            {
                var du = db.Drinks.Where(h => h.MaDoUong.Equals(txtma.Text)).FirstOrDefault();
                long sl = du.SoLuong;
                if (sl < Convert.ToInt64(nb1.Value))
                {
                    MessageBox.Show("Số Lượng Đồ Uống Không Đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.hoaDons.Add(obj);
                    db.SaveChanges();
                    LoadHoaDon();
                    nb1.Value = 1;
                }

            }
            else
            {
                var du = db.Drinks.Where(h => h.MaDoUong.Equals(txtma.Text)).FirstOrDefault();
                var obj2 = db.hoaDons.Where(h => h.MaDoUong.Equals(obj.MaDoUong)).FirstOrDefault();
                long sl = obj2.SoLuong;
                if (du.SoLuong < sl + Convert.ToInt64(nb1.Value))
                {
                    MessageBox.Show("Số Lượng Đồ Uống Không Đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    obj2.MaDoUong = txtma.Text;
                    obj2.TenDoUong = txt1.Text;
                    obj2.Gia = long.Parse(txtgia.Text);
                    obj2.SoLuong += Convert.ToInt64(nb1.Value);
                    db.SaveChanges();
                    LoadHoaDon();
                    nb1.Value = 1;
                }
            }
        }


        private void xoáHàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selCat = hoaDonBindingSource.Current as HoaDon;
            if (selCat != null)
            {
                var db = new BanHangDB();
                var obj = db.hoaDons.Where(t => t.MaDoUong == selCat.MaDoUong).FirstOrDefault();
                var rs = MessageBox.Show("Bạn chắc chắn muốn xoá!", "Xoá hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (obj != null)
                    {
                        db.hoaDons.Remove(obj);
                        db.SaveChanges();
                        LoadHoaDon();
                    }
                }
            }
        }

        private void sửaHàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new BanHangDB();
            var rs = MessageBox.Show("Bạn chắc chắn muốn xoá đơn hàng!", "Xoá đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                var allHoaDons = db.hoaDons.ToList();
                db.hoaDons.RemoveRange(allHoaDons);
                db.SaveChanges();
                LoadHoaDon();
            }
        }
        string madouong;
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            if (hoaDonBindingSource.Current != null)
            {
                var selCat = hoaDonBindingSource.Current as HoaDon;
                madouong = selCat.MaDoUong;
                if (selCat != null)
                {
                    txtsldu.Text = selCat.SoLuong.ToString();
                }
            }
            else
            {
                // Xử lý khi không có đối tượng nào được chọn
                txtsldu.Text = string.Empty;
            }

        }
        void LoadHoaDon2()
        {
            var db = new BanHangDB();
            var obj = db.hoaDons.Where(e => e.MaDoUong.Equals(madouong)).FirstOrDefault();
            if (obj != null)
            {
                obj.SoLuong = long.Parse(txtsldu.Text);
                db.SaveChanges();
            }
            LoadHoaDon();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var db = new BanHangDB();
            var obj = db.Drinks.Where(e => e.MaDoUong.Equals(madouong)).FirstOrDefault();
            if (obj.SoLuong > long.Parse(txtsldu.Text))
            {
                long sl = long.Parse(txtsldu.Text);
                txtsldu.Text = (sl + 1).ToString();
                LoadHoaDon2();
            }
            else
            {
                MessageBox.Show("Số Lượng Đồ Uống Không Đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            long sl = long.Parse(txtsldu.Text);
            if (sl > 1)
            {
                txtsldu.Text = (sl - 1).ToString();
                LoadHoaDon2();
            }
            else
            {
                var db = new BanHangDB();
                var obj = db.hoaDons.Where(t => t.MaDoUong == madouong).FirstOrDefault();
                var rs = MessageBox.Show("Bạn chắc chắn muốn xoá!", "Xoá hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (obj != null)
                    {
                        db.hoaDons.Remove(obj);
                        db.SaveChanges();
                        LoadHoaDon();
                    }
                }
            }
        }
        void TaoHoaDon()
        {
            //xuất dữ liệu
            var homNay = DateTime.Now;
            var db = new BanHangDB();
            var ls = db.hoaDons
                .ToList();
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("E:\\.net frame\\Nhom1\\BanHang20T1020001\\Model\\Order.doc");
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("{0}/{1}/{2}", homNay.Day, homNay.Month, homNay.Year) });
            long tong = 0;
            foreach (var name in ls)
            {
                tong += name.Gia * name.SoLuong;
            }

            // Merge for Tong_tien
            baoCao.MailMerge.Execute(new[] { "Tong_tien" }, new[] { string.Format("{0}", tong) });
            Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 0, true) as Table;
            
            int hangHienTai = 1;
            bangThongTinGiaDinh.InsertRows(hangHienTai, hangHienTai, ls.Count);

            for (int i = 0; i < ls.Count; i++)
            {
                bangThongTinGiaDinh.PutValue(hangHienTai, 0, (i + 1).ToString());//Cột STT
                bangThongTinGiaDinh.PutValue(hangHienTai, 1, ls[i].TenDoUong);
                bangThongTinGiaDinh.PutValue(hangHienTai, 2, ls[i].Gia.ToString());
                bangThongTinGiaDinh.PutValue(hangHienTai, 3, ls[i].SoLuong.ToString());
                hangHienTai++;

            }
           
            try
            {
                baoCao.Save("E:\\.net frame\\Nhom1\\BanHang20T1020001\\bin\\Debug\\net6.0-windows\\temp\\Hoadon.doc");
                MessageBox.Show("Thanh toán thành công!", "Thông báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var ls = hoaDonBindingSource.DataSource as List<HoaDon>;
            var db = new BanHangDB();
            foreach (HoaDon du in ls)
            {
                var obj = db.Drinks.Where(e => e.MaDoUong.Equals(du.MaDoUong)).FirstOrDefault();
                if (obj != null)
                {
                    obj.SoLuong -= du.SoLuong;
                    db.SaveChanges();
                }
                LoadHoaDon();
            }
            TaoHoaDon();
            var allHoaDons = db.hoaDons.ToList();
            db.hoaDons.RemoveRange(allHoaDons);
            db.SaveChanges();
            LoadHoaDon();
            LoadDrinks();
            
        }
    }

}
