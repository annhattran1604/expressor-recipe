using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BanHang20T1020001
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
            GraphicsPath grp = new GraphicsPath();
            grp.AddEllipse(0, 0, button1.Width - 1, button1.Height - 1);
            button1.Region = new Region(grp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string databasePath = "E:\\.net frame\\Nhom1\\BanHang20T1020001\\bin\\Debug\\net6.0-windows\\userdb.db";
            string mkc = txt1.Text;
            string mkm = txt2.Text;
            //Lấy mk về
            string mk = Form1.GetPasword();
            if (mk.Equals(mkc))
            {
                if (mkm.Length >= 6)
                {
                    using (SqliteConnection con = new SqliteConnection($"Data Source={databasePath};"))
                    {
                        SqliteCommand cmd = new SqliteCommand(
                        string.Format("UPDATE user SET password = '{0}' WHERE username = '{1}'",
                        mkm, Form1.GetUserName()),
                        con);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới quá ngắn!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
