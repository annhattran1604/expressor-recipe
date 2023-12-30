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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BanHang20T1020001
{
    public partial class FormQLLoaiEdit : Form
    {

        private ErrorProvider errorProvider;
        Types types;

        public FormQLLoaiEdit(Types types = null)
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            this.types = types;
            if (types != null)
            {
                txtml.Text = types.maloai;
                txttl.Text = types.tenloai;
                datetimeNT.Value = types.ngaynhap;
                this.Text = "Cập nhật loại đồ uống";
                lbchucnang.Text = "Cập Nhật";
                txtml.ReadOnly = true;
            }
            else
            {
                this.Text = "Thêm loại đồ uống";
                lbchucnang.Text = "Thêm Mới";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nút đồng ý
            if (string.IsNullOrWhiteSpace(txttl.Text))
            {
                errorProvider.SetError(txttl, "Tên loại không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtml.Text))
            {
                errorProvider.SetError(txtml, "Mã loại không được để trống.");
                return;
            }
            else
            {
                errorProvider.SetError(txtml, "");
                errorProvider.SetError(txttl, "");
                if (types == null)
                {
                    //Thêm mới
                    var db1 = new BanHangDB();
                    var obj1 = db1.Types.Where(t => t.maloai == txtml.Text).FirstOrDefault();
                    var obj2 = db1.Types.Where(t => t.tenloai == txttl.Text).FirstOrDefault();
                    if (obj1 == null && obj2 == null)
                    {
                        var obj = new Types
                        {
                            maloai = txtml.Text,
                            tenloai = txttl.Text,
                            ngaynhap = datetimeNT.Value,
                        };
                        var db = new BanHangDB();
                        db.Types.Add(obj);
                        db.SaveChanges();
                        //tự đôngj tắt form
                        DialogResult = DialogResult.OK;
                        FormQuanLyLoai f = new FormQuanLyLoai();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Loại này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //Cập nhật
                    var db = new BanHangDB();
                    var obj = db.Types.Where(t => t.maloai == types.maloai).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.maloai = txtml.Text;
                        obj.tenloai = txttl.Text;
                        obj.ngaynhap = datetimeNT.Value;
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
