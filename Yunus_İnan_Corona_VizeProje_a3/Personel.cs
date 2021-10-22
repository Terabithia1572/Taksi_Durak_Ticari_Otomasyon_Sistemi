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
using VTIveDI;

namespace Yunus_İnan_Corona_VizeProje_a3
{
    public partial class Personel : MetroFramework.Forms.MetroForm
    {
        public Personel()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona",".");

        private void Personel_Load(object sender, EventArgs e)
        {
            PersonelGridDoldur();
            cbx_perTur.DataSource = vt.Select("select perTur_id,perTur from tbl_personelTur"); // bu satırda ise combobox içerisinde system.Row hatası verir bunun sebebi sorguda 2 sütun olması bunun çözümü ise alttadır.Kullanıcının bir kullandığı değer ver birde ekran görünen değeri var diyoruz.
            cbx_perTur.DisplayMember = "perTur";//displaymember ne demek ekran görünen değer demek yani görüntülenen kullanıcıya görünen değer demek.
            cbx_perTur.ValueMember = "perTur_id";//Valumember yani arka planda kullanılacak değer demek bunada genelde id olanları ekliyoruz örnek perTur_id


            cbx_taksiDurak.DataSource = vt.Select("select taksiDurak_id,durakAdi+'-'+CAST (taksiDuraktelefon as nvarchar)+'-'+durakAdres as 'taksi' from tbl_taksiDurak");// Cast ile decimal veritipli olan telefonu nvarchara çevirdik + ile hepsini birleştirip as ile takma ad olarak tek sütunda taksi adını verdik
            cbx_taksiDurak.DisplayMember = "taksi"; //ekranda görünen değer
            cbx_taksiDurak.ValueMember = "taksiDurak_id"; //kullanılacak değer

        //    cbx_kullaniciTur.DisplayMember = "kullaniciTur";
          //  cbx_kullaniciTur.ValueMember = "kullaniciTur_id";
            // cbx_kullaniciTur.DataSource = vt.Select("select * from tbl_kullaniciTur");



        }

        private void PersonelGridDoldur()
        {
            dgv_Personeller.DataSource = vt.Select(@"select p.per_id,p.ad,p.soyad,p.TC,p.telefon,p.adres,pt.perTur_id,pt.perTur,t.durakAdi,t.durakAdres,t.taksiDuraktelefon,t.taksiDurak_id from tbl_Personel p join tbl_personelTur pt on p.perTur_id=pt.perTur_id join tbl_taksiDurak t on t.taksiDurak_id=p.taksiDurak_id"); //bu ifade ile gridin içini doldurduk
            dgv_Personeller.Columns["per_id"].Visible = false; // per_id sütununu gizlediğimiz kodumuz bu
            dgv_Personeller.Columns["perTur_id"].Visible = false;//perTur_id sütununu gizledik
            dgv_Personeller.Columns["taksiDurak_id"].Visible = false; //taksiDurak_id sütununu gizledik
           // dgv_Personeller.Columns["kullaniciTur_id"].Visible = false;
        }


        private void dgv_Personeller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Personeller.SelectedRows.Count == 0)
                return;

            tx_Ad.Text = dgv_Personeller.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_Adres.Text = dgv_Personeller.SelectedRows[0].Cells["adres"].Value.ToString();
          //  tx_Gorev.Text = dgv_Personeller.SelectedRows[0].Cells["gorevi"].Value.ToString();
            tx_soyAd.Text = dgv_Personeller.SelectedRows[0].Cells["soyAd"].Value.ToString();
            tx_TC.Text = dgv_Personeller.SelectedRows[0].Cells["TC"].Value.ToString();
            tx_Telefon.Text = dgv_Personeller.SelectedRows[0].Cells["telefon"].Value.ToString();
            cbx_perTur.SelectedValue= dgv_Personeller.SelectedRows[0].Cells["perTur_id"].Value.ToString();
            cbx_taksiDurak.SelectedValue = dgv_Personeller.SelectedRows[0].Cells["taksiDurak_id"].Value.ToString();

        }


        private void tx_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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

        //private void tx_Gorev_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
        //      && !char.IsSeparator(e.KeyChar);
        //}

        private void tx_Adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);

        }

  

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            if (tx_Ad.Text == "" || tx_Adres.Text == "" || tx_soyAd.Text == "" || tx_TC.Text == "" || tx_Telefon.Text == "" || cbx_perTur.SelectedIndex == -1 || cbx_taksiDurak.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Adı,Soyadı,Görevi,Adresi,TC,Telefon,Personel Türü veya Durak Bilgilerini Boş Bırakmayınız...");
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
                MessageBox.Show("Adres en az 3 karakterden oluşmalıdır lütfen tekrar deneyin...");
                return;
            }

            if (tx_TC.Text.Trim().Length < 11)
            {
                MessageBox.Show("TC en az 11 haneden oluşmalıdır lütfen tekrar deneyin...");
                return;
            }
            if (tx_Telefon.Text.Trim().Length < 11)
            {
                MessageBox.Show("Telefon en az 11 haneden oluşmalıdır lütfen tekrar deneyin...");
                return;
            }

            try
            {
                object kayitsay = vt.Insert(@"insert into tbl_Personel(ad,soyad,TC,telefon,adres,perTur_id,taksiDurak_id)values('" + tx_Ad.Text + "','" + tx_soyAd.Text + "','" + tx_TC.Text + "','" + tx_Telefon.Text + "','" + tx_Adres.Text + "','" + cbx_perTur.SelectedValue + "','" + cbx_taksiDurak.SelectedValue + "')");
                PersonelGridDoldur();
                MessageBox.Show("Personel Eklendi..");
            }
            catch
            {
                MessageBox.Show("Unique Key olabilir lütfen TC ve Telefon için farklı bir değer girin..");
            }
        }

        private void brn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_Personeller.SelectedRows.Count == 0)// dgv_Personeller.SelectedRows[0],[0] yapmamızın nedeni ilk satır demek  
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçiniz..");
                return;
            }
            int kayitsay = vt.UpdateDelete("delete from tbl_Personel where per_id=" + dgv_Personeller.SelectedRows[0].Cells["per_id"].Value);//[0] seçilen satırı silecek Value ise seçilen değer demek yani per_id deki değerden silecek
            if (kayitsay > 0)
            {
                PersonelGridDoldur();
                MessageBox.Show(kayitsay + " Kayıt Başarıyla Silindi...");
            }
            else
            {
                MessageBox.Show("Kayıt Silinemedi Lütfen Tekrar Deneyin..");
            }
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            if (dgv_Personeller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Satırı Seçiniz..");
                return;
            }
            if (tx_Ad.Text == "" || tx_Adres.Text == "" || tx_soyAd.Text == "" || tx_TC.Text == "" || tx_Telefon.Text == "" || cbx_perTur.SelectedIndex == -1 || cbx_taksiDurak.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Adı,Soyadı,Adresi,TC,Telefon,Personel Türü veya Durak Bilgilerini Boş Bırakmayınız...");
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
                MessageBox.Show("Adres en az 3 karakterden oluşmalıdır lütfen tekrar deneyin...");
                return;
            }

            if (tx_TC.Text.Trim().Length < 11)
            {
                MessageBox.Show("TC en az 11 haneden oluşmalıdır lütfen tekrar deneyin...");
                return;
            }
            if (tx_Telefon.Text.Trim().Length < 11)
            {
                MessageBox.Show("Telefon en az 11 haneden oluşmalıdır lütfen tekrar deneyin...");
                return;
            }
            try
            {
                int kayitsay = vt.UpdateDelete(@"update tbl_Personel set ad='" + tx_Ad.Text + "',soyad='" + tx_soyAd.Text + "',TC='" + tx_TC.Text + "',telefon='" + tx_Telefon.Text + "',adres='" + tx_Adres.Text + "',perTur_id='" + cbx_perTur.SelectedValue + "',taksiDurak_id=" + cbx_taksiDurak.SelectedValue + " where per_id=" + dgv_Personeller.SelectedRows[0].Cells["per_id"].Value);

                if (kayitsay > 0)
                {
                    PersonelGridDoldur();
                    MessageBox.Show(kayitsay + " Kayıt Başarıyla Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Unique Key olabilir lütfen TC ve Telefon için farklı bir değer girin..");

            }
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            tx_Ad.Text = "";
            tx_Adres.Text = "";
            //  tx_Gorev.Text = "";
            tx_soyAd.Text = "";
            tx_TC.Text = "";
            tx_Telefon.Text = "";
            cbx_perTur.SelectedValue = -1;
            cbx_taksiDurak.SelectedValue = -1;
            if (dgv_Personeller.SelectedRows.Count > 0)
                dgv_Personeller.SelectedRows[0].Selected = false;
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
