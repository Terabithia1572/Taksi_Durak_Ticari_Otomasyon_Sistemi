using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLIslemleri;
using Microsoft.Win32;

namespace Yunus_İnan_Corona_VizeProje_a3
{
    public partial class kullaniciGiris : MetroFramework.Forms.MetroForm
    {
        public kullaniciGiris()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");
    //    private object datatable;
       

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (tx_tcNo.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız...");
                return;
            }

              string sifreMD5 = CreateMD5(tx_sifre.Text);

            DataTable dtSonuc = vt.Select(@"select kullaniciTur_id,kullaniciGiris_id,ad,soyad from tbl_kullaniciGiris 
                    where tc='" + tx_tcNo.Text + "' and sifre='" + sifreMD5 + "'");
            if (dtSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Tc No veya Şifre Hatalı...");
                return;
            }
            if (chbx_beniHatirla.Checked == true)
            {
                Ayarlar.Default.beniHatirla = true;
                Ayarlar.Default.tcNo = tx_tcNo.Text;
                Ayarlar.Default.sifre = tx_sifre.Text;
                Ayarlar.Default.Save();
            }
            else
            {
                Ayarlar.Default.Reset();
            }

            this.Hide();
            AnaForm afrm = new AnaForm();


            if (dtSonuc.Rows[0]["kullaniciTur_id"].ToString() != "1")
            {
                    afrm.tsbtn_Arac.Visible = false;
                    afrm.tsbtn_aracHareket.Visible = false;
                    afrm.tsbtn_Marka.Visible = false;
                   afrm.tsbtn_Model.Visible = false;
                afrm.tsbtn_Personel.Visible = false;
                afrm.tsbtn_personelTur.Visible = false;
                afrm.tsbtn_Sifirla.Visible = false;
                afrm.tsbtn_taksiDurak.Visible = false;
            }
            afrm.KullaniciGiris_id = Convert.ToInt32(dtSonuc.Rows[0]["kullaniciGiris_id"]);
            afrm.Text = "Taksi Durak [" + dtSonuc.Rows[0]["ad"].ToString() + " " + dtSonuc.Rows[0]["soyad"].ToString() + "]";
            
            afrm.Show();
        }

        private void kullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public Baslangic baslangic_frm;

        private void kullaniciGiris_Load(object sender, EventArgs e)
        {
            timersaatTarih.Start();
            if (Ayarlar.Default.beniHatirla == true)
            {
                chbx_beniHatirla.Checked = true;
                tx_tcNo.Text = Ayarlar.Default.tcNo;
                tx_sifre.Text = Ayarlar.Default.sifre;
            }
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("KullaniciGirisi").ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    chbx_windowsIleBaslama.Checked = true;
                }
            }
            catch
            { }

            tx_sifre.PasswordChar = '●';

        }

        private void chbx_windowsIleBaslama_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_windowsIleBaslama.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("KullaniciGirisi", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("KullaniciGirisi");
            }
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }

        }

        private void chbx_sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_sifreGoster.Checked == true)
                tx_sifre.PasswordChar = '\0';
            else
                tx_sifre.PasswordChar = '●';
        }

        private void btn_sifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum su = new SifremiUnuttum();
            su.Show();
        }

        private void btn_mailGonder_Click(object sender, EventArgs e)
        {
            mailGonder mg = new mailGonder();
            mg.Show();
        }

        private void btn_yarisOyunu_Click(object sender, EventArgs e)
        {
            arabaYarisi aY = new arabaYarisi();
            aY.Show();
        }

        private void btn_Yilan_Click(object sender, EventArgs e)
        {
            yilanOyunu yo = new yilanOyunu();
            yo.Show();
        }

        private void btn_Radyo_Click(object sender, EventArgs e)
        {
            Radyo rd = new Radyo();
            rd.Show();
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

        private void timersaatTarih_Tick(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToLongDateString();
            lbl_Saat.Text= DateTime.Now.ToLongTimeString();
        }
    }
}
