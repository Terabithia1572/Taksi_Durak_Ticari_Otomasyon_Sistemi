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

namespace Yunus_İnan_Corona_VizeProje_a3
{
    public partial class sifreSifirla : MetroFramework.Forms.MetroForm
    {
        public sifreSifirla()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");


        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            if (dgv_sifreSifirla.SelectedRows.Count == 0)
            {
                MessageBox.Show("Şifresi sıfırlanacak kullanıcıyı seçiniz.");
                return;
            }

            int kayitSay = vt.UpdateDelete("update tbl_kullaniciGiris set sifre='" +
                VTIveDI.DigerIslemler.MD5Sifrele(dgv_sifreSifirla.SelectedRows[0].Cells["tc"].Value.ToString()) +
                "' where kullaniciGiris_id=" + dgv_sifreSifirla.SelectedRows[0].Cells[0].Value);
            if (kayitSay > 0)
            {
                MessageBox.Show("Kullanıcı Adı TC kimlik Numarasına Göre Sıfırlanmıştır..");
                sifreSifirla_Load(null, null);
            }
        }

        private void sifreSifirla_Load(object sender, EventArgs e)
        {
            dgv_sifreSifirla.DataSource = vt.Select("select kullaniciGiris_id,ad,soyAd,tc,sifre,kullaniciTur_id from tbl_kullaniciGiris");
            dgv_sifreSifirla.Columns["kullaniciGiris_id"].Visible = false;
            dgv_sifreSifirla.Columns["kullaniciTur_id"].Visible = false;
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

        private void btn_sifirla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btn_sifirla_Click(null, null);
            }
        }
    }
}
