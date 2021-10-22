using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DLLIslemleri;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Yunus_İnan_Corona_VizeProje_a3
{
    public partial class SifremiUnuttum : MetroFramework.Forms.MetroForm
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=db_Corona;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataTable dt = new DataTable();
        Veritabani vt = new Veritabani();
        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("legendys65@gmail.com");//buraya kendi gmail hesabınız
            //
            ePosta.To.Add(tx_ka.Text);//bura şifre unutanın maili textboxdan çekdiniz.
            ;

            ePosta.Subject = konu; //butonda veri tabanı çekdikden sonra aldımız değer konu değeri
            //
            ePosta.Body = icerik;  // buda şifremiz
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("yunusn561@gmail.com", "Yunus6565");
            //kendi gmail hesabiniz var şifresi
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }

        private void btn_Gondera_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = vt.Select("Select * from tbl_kulanici where eposta='" + tx_ep.Text.ToString() +
                     "' and kullaniciAdi='" + tx_ka.Text.ToString() + "'");
                //burada veritabanina kodlayarak yazdımız şifrelerin kodlarını karşılaştırdık

                if (dt.Rows.Count > 0)
                {
                    //burada verdiği tc ve mail doğruysa gireceği için şifreyi veritabanından çekip gönder fonksiyonunu kullanarak göndereceğiz

                    string sifre = dt.Rows[0]["sifre"].ToString();
                    //veritabanından çekdik            
                    MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail adresinize yollanıyor");
                    Gonder("Unutmuş Olduğunuz Şifreniz Ektedir", sifre);
                    //gönder paremetresi ile içeriğe 2 string değer yolladık biri mesajımız öbürü şifresi
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Bilgileriniz Uyuşmadı");
                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Eposta Adresinizi Kontrol Ediniz..");
            }
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
