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
    public partial class FormQLNCCEdit : Form
    {
        private ErrorProvider errorProvider;
        Provider provider;
        public FormQLNCCEdit(Provider provider = null)
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            this.provider = provider;
            if (provider != null)
            {
                txtma.Text = provider.MaNCC;
                txtten.Text = provider.TenNCC;
                txtsdt.Text = provider.SoDT;
                txtdc.Text = provider.DiaChi;
                this.Text = "Cập nhật nhà cung cấp";
                label1.Text = "Cập Nhật";
                txtma.ReadOnly = true;
            }
            else
            {
                this.Text = "Thêm loại nhà cung cấp";
                label1.Text = "Thêm Mới";
            }
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtma.Text))
            {
                errorProvider.SetError(txtma, "Mã không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                errorProvider.SetError(txtten, "Tên không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtsdt.Text))
            {
                errorProvider.SetError(txtsdt, "Số điện thoại không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdc.Text))
            {
                errorProvider.SetError(txtdc, "Địa chỉ không được để trống.");
                return;
            }
            else
            {
                errorProvider.SetError(txtma, "");
                errorProvider.SetError(txtten, "");
                errorProvider.SetError(txtsdt, "");
                errorProvider.SetError(txtdc, "");

                if (provider == null)
                {
                    var db1 = new BanHangDB();
                    var obj1 = db1.Providers.Where(t => t.MaNCC == txtma.Text).FirstOrDefault();
                    var obj2 = db1.Providers.Where(t => t.TenNCC == txtten.Text).FirstOrDefault();
                    if (obj1 == null && obj2 == null)
                    {
                        //Thêm mới
                        var obj = new Provider
                        {
                            MaNCC = txtma.Text,
                            TenNCC = txtten.Text,
                            SoDT = txtsdt.Text,
                            DiaChi = txtdc.Text,

                        };
                        var db = new BanHangDB();
                        db.Providers.Add(obj);
                        db.SaveChanges();
                        //tự đôngj tắt form
                        DialogResult = DialogResult.OK;
                        FormQLNhaCC f = new FormQLNhaCC();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //Cập nhật
                    var db = new BanHangDB();
                    var obj = db.Providers.Where(t => t.MaNCC == provider.MaNCC).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.MaNCC = txtma.Text;
                        obj.TenNCC = txtten.Text;
                        obj.SoDT = txtsdt.Text;
                        obj.DiaChi = txtdc.Text;
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
