using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;//Thêm thư viện này (file Dll\Aspose.Word.dll)
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;


namespace BanHang20T1020001.Model
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            LoadCategory();
        }
        void LoadCategory()
        {
            //lấy dữ liệu từ danh mục từ DB
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
            var ls1 = db.Types.ToList();
            var ls2 = db.Providers.ToList();
            cmbloai.DataSource = ls1;
            cmbloai.DisplayMember = "tenloai";
            cmbncc.DataSource = ls2;
            cmbncc.DisplayMember = "TenNCC";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var db = new BanHangDB();
            var ls = db.Drinks.Where(e => e.SoLuong < 50)
                .OrderByDescending(e => e.SoLuong)
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

        private void cmbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selCat1 = cmbloai.SelectedItem as Types;
            var db = new BanHangDB();
            var ls = db.Drinks.Where(e => e.MaLoai.Equals(selCat1.maloai))
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

        private void cmbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selCat1 = cmbncc.SelectedItem as Provider;
            var db = new BanHangDB();
            var ls = db.Drinks.Where(e => e.MaNCC.Equals(selCat1.MaNCC))
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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Hàng số lượng dưới 50!");
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            formTrangChu.Show();
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
            FormQLDoUong formQLDoUong = new FormQLDoUong();
            formQLDoUong.Show();
            this.Hide();
        }

        private void quảnLýLoạiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoai formQuanLyLoai = new FormQuanLyLoai();
            formQuanLyLoai.Show();
            this.Hide();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLNhaCC formQLNhaCC = new FormQLNhaCC();
            formQLNhaCC.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //xuất dữ liệu
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("E:\\.net frame\\Nhom1\\BanHang20T1020001\\Model\\Mau_Bao_Cao.doc");
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("Huế, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            var db = new BanHangDB();
            var ls = db.Drinks.Where(e => e.SoLuong < 50)
                .OrderByDescending(e => e.SoLuong)
                .ToList();
            int hangHienTai = 1;
            bangThongTinGiaDinh.InsertRows(hangHienTai, hangHienTai, ls.Count);

            for (int i = 0; i < ls.Count; i++)
            {
                bangThongTinGiaDinh.PutValue(hangHienTai, 0, (i + 1).ToString());//Cột STT
                bangThongTinGiaDinh.PutValue(hangHienTai, 1, ls[i].MaDoUong);
                bangThongTinGiaDinh.PutValue(hangHienTai, 2, ls[i].TenDoUong);
                bangThongTinGiaDinh.PutValue(hangHienTai, 3, ls[i].Gia.ToString());
                bangThongTinGiaDinh.PutValue(hangHienTai, 4, ls[i].SoLuong.ToString());
                var lsncc = db.Providers.Where(e => e.MaNCC.Equals(ls[i].MaNCC)).ToList();
                bangThongTinGiaDinh.PutValue(hangHienTai, 5, lsncc[0].TenNCC);
                bangThongTinGiaDinh.PutValue(hangHienTai, 6, lsncc[0].SoDT);
                hangHienTai++;

            }
            try
            {
                baoCao.Save("E:\\.net frame\\Nhom1\\BanHang20T1020001\\bin\\Debug\\net6.0-windows\\temp\\BaoCao.doc");
                MessageBox.Show("Lưu tệp thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        private Boolean isCooplapsed;
        private Boolean isCooplapsed1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCooplapsed)
            {
                panel2.Width += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    isCooplapsed = false;
                }

            }
            else
            {
                panel2.Width -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCooplapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isCooplapsed1)
            {
                panel3.Width += 20;
                dataGridView1.Width += 20;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer2.Stop();
                    isCooplapsed1 = true;
                }

            }
            else
            {
                panel3.Width -= 20;
                dataGridView1.Width -= 20;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer2.Stop();
                    isCooplapsed1 = false;
                }
            }
        }
    }
}
