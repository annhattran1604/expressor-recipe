using Microsoft.Data.Sqlite;

namespace BanHang20T1020001
{
    public partial class Form1 : Form
    {
        static string user;
        static string password;
        static string username;
        public Form1()
        {
            InitializeComponent();
            txtUser.PlaceholderText = "Username";
            txtPassword.PlaceholderText = "Password";
        }
        public static string GetUser()
        {
            return user;
        }
        public static string GetPasword()
        {
            return password;
        }
        public static string GetUserName()
        {
            return username;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string databasePath = "E:\\.net frame\\Nhom1\\BanHang20T1020001\\bin\\Debug\\net6.0-windows\\userdb.db";
            using (SqliteConnection con = new SqliteConnection($"Data Source={databasePath};"))
            {
                SqliteCommand cmd = new SqliteCommand(
                    string.Format("Select * from user where username = '{0}' and password ='{1}'",
                    txtUser.Text, txtPassword.Text),
                    con);
                con.Open();
                SqliteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    //lấy ra tên
                    if (reader.Read())
                    {
                        user = reader.GetString(reader.GetOrdinal("name"));
                        password = reader.GetString(reader.GetOrdinal("password"));
                        username = reader.GetString(reader.GetOrdinal("username"));
                        FormTrangChu f = new FormTrangChu();
                        f.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDangKy dk = new FormDangKy();
            dk.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}