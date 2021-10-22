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
    public partial class aracHareket : MetroFramework.Forms.MetroForm
    {
        public aracHareket()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona",".");
        private void aracHareket_Load(object sender, EventArgs e)
        {
            Hareket();

            cbx_Arac.DataSource = vt.Select("select a.arac_id,a.plaka+'-'+CAST(m.model_id as nvarchar(50))+'-'+m.modelAdi+'-'+CAST(m.modelYil as nvarchar(50)) as 'Arac' from tbl_Arac a join tbl_Model m on m.model_id=a.model_id");
            cbx_Arac.DisplayMember = "Arac";
            cbx_Arac.ValueMember = "arac_id";

            cbx_Personel.DataSource = vt.Select("select p.per_id,p.ad+'-'+p.adres+'-'+CAST(pt.perTur_id as nvarchar(50))+'-'+p.soyad+'-'+CAST(t.taksiDurak_id as nvarchar(50))+'-'+CAST(p.TC as nvarchar(50))+'-'+CAST(p.telefon as nvarchar)+'-'+t.durakAdi+'-'+t.durakAdres+'-'+CAST(t.taksiDuraktelefon as nvarchar) as 'Personel' from tbl_Personel p join tbl_personelTur pt on p.perTur_id=pt.perTur_id join tbl_taksiDurak t on t.taksiDurak_id=p.taksiDurak_id");
            cbx_Personel.DisplayMember = "Personel";
            cbx_Personel.ValueMember = "per_id";


        }

        private void Hareket()
        {
            dgv_aracHareket.DataSource = vt.Select(@"select ac.aracHareket_id,ac.tarih,ac.toplamHasilat,ar.arac_id,ar.model_id,ar.plaka,t.durakAdi,t.durakAdres,t.taksiDuraktelefon,t.taksiDurak_id,m.modelAdi,m.modelYil,ma.marka_id,ma.markaAdi,p.per_id,p.ad,p.soyad,p.soyad,p.TC,p.telefon from tbl_aracHareket ac join tbl_Arac ar on ar.arac_id=ac.arac_id join tbl_taksiDurak t on t.taksiDurak_id=ar.taksiDurak_id join tbl_Model m on m.model_id=ar.model_id join tbl_Marka ma on ma.marka_id=m.marka_id join tbl_Personel p on p.taksiDurak_id=t.taksiDurak_id"); //bu ifade ile gridin içini doldurduk
            dgv_aracHareket.Columns["marka_id"].Visible = false;
            dgv_aracHareket.Columns["per_id"].Visible = false;
            dgv_aracHareket.Columns["aracHareket_id"].Visible = false; // per_id sütununu gizlediğimiz kodumuz bu
            dgv_aracHareket.Columns["arac_id"].Visible = false;//perTur_id sütununu gizledik
            dgv_aracHareket.Columns["model_id"].Visible = false;
            dgv_aracHareket.Columns["taksiDurak_id"].Visible = false;
            dgv_aracHareket.Columns["soyad1"].Visible = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try {

                if(nmr_Tarih.Value.ToString().Length !=4)
                {
                    MessageBox.Show("Tarih 4 Haneli Olmalıdır...");
                    return;
                }
            if (tx_toplamHasilat.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                return;
            }
            if (cbx_Arac.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Araç Kısmını Seçiniz Boş Bırakmayınız...");
                return;
            }
            if (cbx_Personel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Personel Kısmını Seçiniz Boş Bırakmayınız...");
                return;
            }
            if(nmr_Tarih.Value==null)
            {
                MessageBox.Show("Lütfen Tarih Kısmını Seçiniz Boş Bırakmayınız...");
                return;
            }

            if(tx_toplamHasilat.Text.Trim().Length<0)
                {
                    MessageBox.Show("Toplam Hasılat Negatif Olamaz..");
                    return;
                }
                  
                object kayitsay = vt.Select(" insert into tbl_aracHareket(tarih, toplamHasilat, arac_id, per_id)values('"+nmr_Tarih.Value+"', '"+tx_toplamHasilat.Text+"','"+cbx_Arac.SelectedValue+"','"+cbx_Personel.SelectedValue+"')");
             
            aracHareket_Load(null, null);
            MessageBox.Show(kayitsay + " Arac Başarıyla Eklendi..");
            }catch
            {
                MessageBox.Show("Tarih Kısmını Lütfen Doğru ve Mantıklı Giriniz.. Veya Unique Key Olabilir Kontrol Ediniz..");
            }
        }

        private void brn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_aracHareket.SelectedRows.Count == 0)// dgv_Personeller.SelectedRows[0],[0] yapmamızın nedeni ilk satır demek  
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçiniz..");
                return;
            }
            int kayitsay = vt.UpdateDelete("delete from tbl_aracHareket where aracHareket_id=" + dgv_aracHareket.SelectedRows[0].Cells["aracHareket_id"].Value);//[0] seçilen satırı silecek Value ise seçilen değer demek yani per_id deki değerden silecek
            if (kayitsay > 0)
            {
                aracHareket_Load(null,null);
                MessageBox.Show(kayitsay + " Kayıt Başarıyla Silindi...");
            }
            else
            {
                MessageBox.Show("Kayıt Silinemedi Lütfen Tekrar Deneyin..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmr_Tarih.Value.ToString().Length != 4)
                {
                    MessageBox.Show("Tarih 4 Haneli Olmalıdır...");
                    return;
                }

                if (tx_toplamHasilat.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                    return;
                }
                if (cbx_Arac.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen Araç Kısmını Seçiniz Boş Bırakmayınız...");
                    return;
                }
                if (cbx_Personel.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen Personel Kısmını Seçiniz Boş Bırakmayınız...");
                    return;
                }
                if (nmr_Tarih.Value == null)
                {
                    MessageBox.Show("Lütfen Tarih Kısmını Seçiniz Boş Bırakmayınız...");
                    return;
                }

                if (tx_toplamHasilat.Text.Trim().Length < 0)
                {
                    MessageBox.Show("Toplam Hasılat Negatif Olamaz..");
                    return;
                }
                int kayitsay = vt.UpdateDelete(@"update tbl_aracHareket set tarih='" + nmr_Tarih.Value + "', toplamHasilat='" + tx_toplamHasilat.Text + "',arac_id='" + cbx_Arac.SelectedValue + "',per_id='" + cbx_Personel.SelectedValue + "' where aracHareket_id=" + dgv_aracHareket.SelectedRows[0].Cells["aracHareket_id"].Value);

                if (kayitsay > 0)
                {
                    aracHareket_Load(null, null);
                    MessageBox.Show(kayitsay + " Kayıt Başarıyla Güncellendi...");
                }
            } catch
            {
                MessageBox.Show("Unique Key olabilir lütfen TC ve Telefon için farklı bir değer girin..");

            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_toplamHasilat.Text = "";
            cbx_Arac.SelectedIndex = -1;
            cbx_Personel.SelectedIndex = -1;

            if (dgv_aracHareket.SelectedRows.Count > 0)
                dgv_aracHareket.SelectedRows[0].Selected = false;
        }

        private void dgv_aracHareket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_aracHareket.SelectedRows.Count == 0)
                return;

            tx_toplamHasilat.Text = dgv_aracHareket.SelectedRows[0].Cells["toplamHasilat"].Value.ToString();
            cbx_Arac.SelectedValue = dgv_aracHareket.SelectedRows[0].Cells["arac_id"].Value.ToString();
            cbx_Personel.SelectedValue = dgv_aracHareket.SelectedRows[0].Cells["per_id"].Value.ToString();
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

        private void tx_toplamHasilat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Ekle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                btn_Ekle_Click(null, null);
            }
        }

        private void brn_Sil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                brn_Sil_Click(null, null);
            }
        }

        private void btn_Guncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.G)
            {
                btn_Guncelle_Click(null, null);
            }
        }

        private void btn_Temizle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.T)
            {
                btn_Temizle_Click(null, null);
            }
        }
    }
}
