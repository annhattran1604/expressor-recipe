using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BanHang20T1020001
{
    public partial class FormDangKy : Form
    {
        private ErrorProvider errorProvider;
        public FormDangKy()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //đăng nhập
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string databasePath = "E:\\.net frame\\Nhom1\\BanHang20T1020001\\bin\\Debug\\net6.0-windows\\userdb.db";
            string username = txtusername.Text;
            string name = txtname.Text;
            string pass = txtpass.Text;

            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
                errorProvider.SetError(txtname, "User không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                errorProvider.SetError(txtname, "Họ tên không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                errorProvider.SetError(txtpass, "Mật khẩu không được để trống.");
                return;
            }
            else
            {
                errorProvider.SetError(txtusername, "");
                errorProvider.SetError(txtname, "");
                errorProvider.SetError(txtpass, "");
                if (pass.Length >= 6)
                {
                    using (SqliteConnection con = new SqliteConnection($"Data Source={databasePath};"))
                    {

                        SqliteCommand cmd1 = new SqliteCommand(
                        string.Format("Select * from user where username = '{0}'",
                        username),
                        con);
                        con.Open();
                        SqliteDataReader reader = cmd1.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqliteCommand cmd = new SqliteCommand(
                            string.Format("INSERT INTO user (username, password, name) VALUES" +
                                "('{0}', '{1}', '{2}')", username, pass, name
                            ),
                            con);
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Đăng ký thành công!", "Thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Quá Ngắn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ControlPaint.DrawBorder(txtpass.CreateGraphics(),
                                txtpass.ClientRectangle,
                                Color.Red,  // Màu viền
                                ButtonBorderStyle.Solid);
                }
            }
        }
    }
}
