using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yunus_İnan_Corona_VizeProje_a3
{
    public partial class mailGonder : MetroFramework.Forms.MetroForm
    {
        public mailGonder()
        {
            InitializeComponent();
        }

        private void btn_mesajGonder_Click(object sender, EventArgs e)
        {
          //  KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            if (tx_adSoyad.Text == "" || tx_Konu.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız...");
                return;
            }
            if(tx_adSoyad.Text.Trim().Length<2)
            {
                MessageBox.Show("Ad Soyad En az 2 karakterden Oluşmalıdır..");
                return;
            }
            MailMessage mesaj = new MailMessage(); // Mail sınıfından bir değişken türetiyoruz
            mesaj.From = new MailAddress("legendys65@gmail.com");
            mesaj.To.Add("legendys65@gmail.com");
            mesaj.Subject = tx_Konu.Text;
            mesaj.Body = richTextBox1.Text;

            SmtpClient rc = new SmtpClient();

            // Gönderenin eposta giriş bilgileri
            rc.Credentials = new System.Net.NetworkCredential("legendys65293@gmail.com", "Yunus6565");
            rc.Port = 587;
            rc.Host = "smtp.gmail.com";
            rc.EnableSsl = true;

            object userState = mesaj;
            bool kontrol = true;

            try
            {
                rc.SendAsync(mesaj, (object)mesaj);
                MessageBox.Show("Mesajınız Başarıyla Gönderilmiştir..");
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatası Oluştu..");
            }
        }

        private void tx_adSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
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
