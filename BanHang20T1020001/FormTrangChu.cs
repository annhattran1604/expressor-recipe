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
    public partial class FormTrangChu : Form
    {
        public System.Threading.Timer timer;
        public FormTrangChu()
        {
            InitializeComponent();
            string user = Form1.GetUser();
            this.Text = "Xin chào " + user;
            txtuser.Text = user;
            timer = new System.Threading.Timer(Timer_Tick, null, 0, 1000);

        }
        private void Timer_Tick(object state)
        {
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("hh:mm:ss tt");
            UpdateTime(timeString);
        }

        private void UpdateTime(string time)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateTime), time);
            }
            else
            {
                txttime.Text = time;
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void quảnLýĐồUốngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormQLDoUong formQLDoUong = new FormQLDoUong();
            formQLDoUong.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMK f = new FormDoiMK();
            f.Show();
        }

        private void quảnLýLoạiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoai f = new FormQuanLyLoai();
            f.Show();
            this.Hide();
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

        private void txtqldu_Click(object sender, EventArgs e)
        {
            FormQLDoUong formQLDoUong = new FormQLDoUong();
            formQLDoUong.Show();
            this.Hide();
        }

        private void txtqlldu_Click(object sender, EventArgs e)
        {
            FormQuanLyLoai form = new FormQuanLyLoai();
            form.Show();
            this.Hide();
        }

        private void txtqlncc_Click(object sender, EventArgs e)
        {
            FormQLNhaCC form = new FormQLNhaCC();
            form.Show();
            this.Hide();
        }

        private void txttk_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe();
            form.Show();
            this.Hide();
        }
        private Boolean isCooplapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCooplapsed)
            {
                panelcontrol.Height += 10;
                if (panelcontrol.Size == panelcontrol.MaximumSize)
                {
                    timer1.Stop();
                    isCooplapsed = false;
                }
            }
            else
            {
                panelcontrol.Height -= 10;
                if (panelcontrol.Size == panelcontrol.MinimumSize)
                {
                    timer1.Stop();
                    isCooplapsed = true;
                }
            }
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            banHang.Show();
            this.Hide();
        }
    }
}
