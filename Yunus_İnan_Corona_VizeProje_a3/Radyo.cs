using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yunus_İnan_Corona_VizeProje_a3
{
    public partial class Radyo : MetroFramework.Forms.MetroForm
    {
        public Radyo()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kralFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralwmp.radyotvonline.com:80";
        }

        private void btn_trtFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://sunucu.radyodinle.com:4999/;"; 

        }

        private void btn_Power_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://dinle.arabeskradyo.biz:7446/;";

        }

        private void btn_superFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyodamarfm.com:8404/;";
        }

        private void btn_slowTurk_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin1.yayindakiler.com:3190/;";
        }

        private void btn_bestFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.100.100:80/best/bestfm.stream/playlist.m3u8";
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIconTaksi_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();
        }
    }
}
