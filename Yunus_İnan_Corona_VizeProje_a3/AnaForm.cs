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
    public partial class AnaForm : MetroFramework.Forms.MetroForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        public int KullaniciGiris_id = 1;

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.Exit();
        }

        private void tsbtn_Arac_Click(object sender, EventArgs e)
        {
            Arac ar = new Arac();
            ar.MdiParent = this;
            ar.Show();
        }

        private void tsbtn_aracHareket_Click(object sender, EventArgs e)
        {
            aracHareket ah = new aracHareket();
            ah.MdiParent = this;
            ah.Show();
        }

        private void tsbtn_taksiDurak_Click(object sender, EventArgs e)
        {
            taksiDurak td = new taksiDurak();
            td.MdiParent = this;
            td.Show();
        }

        private void tsbtn_Personel_Click(object sender, EventArgs e)
        {
            Personel pe = new Personel();
            pe.MdiParent = this;
            pe.Show();
        }

        private void tsbtn_personelTur_Click(object sender, EventArgs e)
        {
            personelTur pt = new personelTur();
            pt.MdiParent = this;
            pt.Show();
        }

        private void tsbtn_Musteri_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.MdiParent = this;
            m.Show();
        }

        private void tsbtn_musteriTur_Click(object sender, EventArgs e)
        {
            musteriTur mt = new musteriTur();
            mt.MdiParent = this;
            mt.Show();
        }

        private void tsbtn_Model_Click(object sender, EventArgs e)
        {
            Model mo = new Model();
            mo.MdiParent = this;
            mo.Show();
        }

        private void tsbtn_Marka_Click(object sender, EventArgs e)
        {
            Marka ma = new Marka();
            ma.MdiParent = this;
            ma.Show();
        }
        int sure = 1800;
        private void timerSure_Tick(object sender, EventArgs e)
        {
            sure--;
            tslbl_sure.Text = sure / 60 + ":" + sure % 60;
            tspgr_Durum.Value = sure;
            if (sure == 0)
            {
                timerSure.Stop();
                timerOturum.Start();
                DialogResult cevap = MessageBox.Show("Oturum Süresi Sona Erdi. Devam Etmek İstiyor Musunuz..?", " Süre Bitti..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    timerOturum.Stop();
                    sure = 1801;
                    timerSure.Start();

                }
                else
                    this.Close();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            
            timerSure.Start();
            tslbl_sure.Text = sure / 60 + ":" + sure % 60;
           
           
        }

        private void timerOturum_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIconanaTaksi_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();

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

        private void tsbtn_Sifirla_Click(object sender, EventArgs e)
        {
            sifreSifirla sf = new sifreSifirla();
            sf.MdiParent = this;
            sf.Show();
        }
    }
}
