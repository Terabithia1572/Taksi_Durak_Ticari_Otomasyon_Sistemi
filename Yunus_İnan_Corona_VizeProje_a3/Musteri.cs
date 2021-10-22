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
    public partial class Musteri : MetroFramework.Forms.MetroForm
    {
        public Musteri()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");

        private void Musteri_Load(object sender, EventArgs e)
        {
            MusteriGridDoldur();

            cbx_musteriTur.DataSource = vt.Select("select musteriTur_id,musteriTur from tbl_musteriTur");
            cbx_musteriTur.DisplayMember = "musteriTur";
            cbx_musteriTur.ValueMember = "musteriTur_id";

            cbx_taksiDurak.DataSource = vt.Select("select taksiDurak_id,durakAdi+'-'+CAST (taksiDuraktelefon as nvarchar)+'-'+durakAdres as 'taksi' from tbl_taksiDurak");// Cast ile decimal veritipli olan telefonu nvarchara çevirdik + ile hepsini birleştirip as ile takma ad olarak tek sütunda taksi adını verdik
            cbx_taksiDurak.DisplayMember = "taksi"; //ekranda görünen değer
            cbx_taksiDurak.ValueMember = "taksiDurak_id"; //kullanılacak değer

            //cbx_perTur.DataSource = vt.Select("select perTur_id,perTur from tbl_personelTur"); // bu satırda ise combobox içerisinde system.Row hatası verir bunun sebebi sorguda 2 sütun olması bunun çözümü ise alttadır.Kullanıcının bir kullandığı değer ver birde ekran görünen değeri var diyoruz.
            //cbx_perTur.DisplayMember = "perTur";//displaymember ne demek ekran görünen değer demek yani görüntülenen kullanıcıya görünen değer demek.
            //cbx_perTur.ValueMember = "perTur_id";//Valumember yani arka planda kullanılacak değer demek bunada genelde id olanları ekliyoruz örnek perTur_id

        }

        private void MusteriGridDoldur()
        {
            dgv_Musteriler.DataSource = vt.Select("select m.musteri_id,m.ad,m.soyad,m.telefon,m.adres,mt.musteriTur_id,t.taksiDurak_id,mt.musteriTur,t.durakAdi,t.durakAdres,t.taksiDuraktelefon from tbl_Musteri m join tbl_musteriTur mt on m.musteriTur_id=mt.musteriTur_id join tbl_taksiDurak t on t.taksiDurak_id=m.taksiDurak_id");
            dgv_Musteriler.Columns["musteri_id"].Visible = false;
            dgv_Musteriler.Columns["musteriTur_id"].Visible = false;
            dgv_Musteriler.Columns["taksiDurak_id"].Visible = false;
        }


        private void dgv_Musteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Musteriler.SelectedRows.Count == 0)
                return;

            tx_Ad.Text = dgv_Musteriler.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_Adres.Text = dgv_Musteriler.SelectedRows[0].Cells["adres"].Value.ToString();
             tx_soyAd.Text = dgv_Musteriler.SelectedRows[0].Cells["soyad"].Value.ToString();
           tx_Telefon.Text = dgv_Musteriler.SelectedRows[0].Cells["telefon"].Value.ToString();
            cbx_musteriTur.SelectedValue = dgv_Musteriler.SelectedRows[0].Cells["musteriTur_id"].Value.ToString();
            cbx_taksiDurak.SelectedValue = dgv_Musteriler.SelectedRows[0].Cells["taksiDurak_id"].Value.ToString();
        }


        private void tx_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
           && !char.IsSeparator(e.KeyChar);
        }

        private void tx_soyAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
           && !char.IsSeparator(e.KeyChar);
        }

        private void tx_Adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            if (tx_Ad.Text == "" || tx_Adres.Text == "" || tx_soyAd.Text == "" || tx_Telefon.Text == "" || cbx_musteriTur.SelectedIndex == -1 || cbx_taksiDurak.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                return;
            }
            if (tx_Ad.Text.Trim().Length < 2) //.Trim() kullanmamızın sebebi önündeki boşlukları silmek için kullandık
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır...");
                return;
            }
            if (tx_soyAd.Text.Trim().Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır...");
                return;
            }
            if (tx_Adres.Text.Trim().Length < 3)
            {
                MessageBox.Show("Adres en az 3 karakter olmalıdır...");
                return;
            }
            if (tx_Telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon 11 karakter olmalıdır lütfen tekrar deneyin..");
                return;
            }
            try
            {
                object kayitsay = vt.Insert(@"insert into tbl_musteri(ad,soyad,telefon,adres,musteriTur_id,taksiDurak_id)values('" + tx_Ad.Text + "','" + tx_soyAd.Text + "','" + tx_Telefon.Text + "','" + tx_Adres.Text + "','" + cbx_musteriTur.SelectedValue + "','" + cbx_taksiDurak.SelectedValue + "')");
                MusteriGridDoldur();
                MessageBox.Show("Müşteri Eklendi..");
            }
            catch
            {
                MessageBox.Show("Unique Key olabilir Lütfen Telefon için farklı bir değer girin..");
            }
        }
        private void brn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_Musteriler.SelectedRows.Count == 0)// dgv_Musteriler.SelectedRows[0],[0] yapmamızın nedeni ilk satır demek  
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçiniz..");
                return;
            }

            int kayitsay = vt.UpdateDelete("delete from tbl_Musteri where musteri_id=" + dgv_Musteriler.SelectedRows[0].Cells["musteri_id"].Value);//[0] seçilen satırı silecek Value ise seçilen değer demek yani musteri_id deki değerden silecek
            if (kayitsay > 0)
            {
                MusteriGridDoldur();
                MessageBox.Show(kayitsay + " Kayıt Başarıyla Silindi...");
            }
            else
            {
                MessageBox.Show("Kayıt Silinemedi Lütfen Tekrar Deneyin..");
            }
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            if (dgv_Musteriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Satırı Seçiniz..");
                return;
            }
            if (tx_Ad.Text == "" || tx_Adres.Text == "" || tx_soyAd.Text == "" || tx_Telefon.Text == "" || cbx_musteriTur.SelectedIndex == -1 || cbx_taksiDurak.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Adı,Soyadı Veya Adresi Boş Alan Bırakmayınız...");
                return;
            }
            if (tx_Ad.Text.Trim().Length < 2) //.Trim() kullanmamızın sebebi önündeki boşlukları silmek için kullandık
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır...");
                return;
            }
            if (tx_soyAd.Text.Trim().Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır...");
                return;
            }
            if (tx_Adres.Text.Trim().Length < 3)
            {
                MessageBox.Show("Adres en az 3 karakter olmalıdır...");
                return;
            }
            if (tx_Telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon 11 karakter olmalıdır lütfen tekrar deneyin..");
                return;
            }
            try
            {
                int kayitsay = vt.UpdateDelete(@"update tbl_Musteri set ad='" + tx_Ad.Text + "',soyad='" + tx_soyAd.Text + "',telefon='" + tx_Telefon.Text + "',musteriTur_id='" + cbx_musteriTur.SelectedValue + "',taksiDurak_id='" + cbx_taksiDurak.SelectedValue + "' where musteri_id=" + dgv_Musteriler.SelectedRows[0].Cells["musteri_id"].Value);

                if (kayitsay > 0)
                {
                    MusteriGridDoldur();
                    MessageBox.Show(kayitsay + " Kayıt Başarıyla Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Unique Key olabilir Lütfen Telefon için farklı bir değer girin..");

            }
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            tx_Ad.Text = "";
            tx_Adres.Text = "";
            tx_soyAd.Text = "";
            tx_Telefon.Text = "";
            cbx_musteriTur.SelectedValue = -1;
            cbx_taksiDurak.SelectedValue = -1;
            if (dgv_Musteriler.SelectedRows.Count > 0)
                dgv_Musteriler.SelectedRows[0].Selected = false;
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

        private void btn_Ekle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                btn_Ekle_Click_1(null, null);
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
                btn_Guncelle_Click_1(null, null);
            }
        }

        private void btn_Temizle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.T)
            {
                btn_Temizle_Click_1(null, null);
            }
        }
    }
}
