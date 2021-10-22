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
    public partial class taksiDurak : MetroFramework.Forms.MetroForm
    {
        public taksiDurak()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");

        private void taksiDurak_Load(object sender, EventArgs e)
        {
            dgv_Duraklar.DataSource = vt.Select("select taksiDurak_id,durakAdi,taksiDuraktelefon,durakAdres from tbl_taksiDurak");
            dgv_Duraklar.Columns["taksiDurak_id"].Visible = false;
        }


        private void dgv_Duraklar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Duraklar.SelectedRows.Count == 0)
                return;

            tx_Adres.Text = dgv_Duraklar.SelectedRows[0].Cells["durakAdres"].Value.ToString();
            tx_durakAd.Text= dgv_Duraklar.SelectedRows[0].Cells["durakAdi"].Value.ToString();
            tx_Telefom.Text= dgv_Duraklar.SelectedRows[0].Cells["taksiDuraktelefon"].Value.ToString();

        }

        private void tx_Telefom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_Adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            try
            {
                //.Trim() kullanmamızın nedeni karakterden önce karakterden bırakmasını engellemek için boşluk bırakmıyor
                if (tx_Adres.Text == "" || tx_durakAd.Text == "" || tx_Telefom.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                    return;
                }
                if (tx_Adres.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Adres en az 3 haneden oluşmalıdır lütfen tekrar deneyin...");
                    return;
                }
                if (tx_durakAd.Text.Trim().Length < 2)
                {
                    MessageBox.Show("Durak Adı en az 2 karakterden oluşmalıdır lütfen tekrar deneyin..");
                    return;
                }
                if (tx_Telefom.Text.Trim().Length != 11)
                {
                    MessageBox.Show("Telefon 11 karakterden oluşmalıdır lütfen tekrar deneyin..");
                    return;
                }

                object kayitsay = vt.Insert(@"insert into tbl_taksiDurak(durakAdi,taksiDuraktelefon,durakAdres)values('" + tx_durakAd.Text + "','" + tx_Telefom.Text + "','" + tx_Adres.Text + "')");
                taksiDurak_Load(null, null);
                MessageBox.Show(kayitsay + " Durak Başarıyla Eklendi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void brn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Duraklar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Silinecek Taksi Durak Seçiniz..!");
                    return;
                }
                int kayitsay = vt.UpdateDelete(@"delete from tbl_taksiDurak where taksiDurak_id=" + dgv_Duraklar.SelectedRows[0].Cells["taksiDurak_id"].Value);
                taksiDurak_Load(null, null);
                MessageBox.Show(kayitsay + " Taksi Durak Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            tx_Adres.Text = "";
            tx_durakAd.Text = "";
            tx_Telefom.Text = "";
            if (dgv_Duraklar.SelectedRows.Count > 0)
                dgv_Duraklar.SelectedRows[0].Selected = false;
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            {
                if (dgv_Duraklar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Güncellenecek Satırı Seçiniz..");
                    return;
                }
                if (tx_Adres.Text == "" || tx_durakAd.Text == "" || tx_Telefom.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                    return;
                }
                if (tx_Adres.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Adres en az 3 haneden oluşmalıdır lütfen tekrar deneyin...");
                    return;
                }
                if (tx_durakAd.Text.Trim().Length < 2)
                {
                    MessageBox.Show("Durak Adı en az 2 karakterden oluşmalıdır lütfen tekrar deneyin..");
                    return;
                }
                if (tx_Telefom.Text.Trim().Length != 11)
                {
                    MessageBox.Show("Telefon 11 karakterden oluşmalıdır lütfen tekrar deneyin..");
                    return;
                }
                try
                {
                    int kayitsay = vt.UpdateDelete(@"update tbl_taksiDurak set durakAdi='" + tx_durakAd.Text + "',taksiDuraktelefon='" + tx_Telefom.Text + "',durakAdres='" + tx_Adres.Text + "' where taksiDurak_id=" + dgv_Duraklar.SelectedRows[0].Cells["taksiDurak_id"].Value);

                    if (kayitsay > 0)
                    {
                        taksiDurak_Load(null, null);
                        MessageBox.Show(kayitsay + " Kayıt Başarıyla Güncellendi...");
                    }
                }
                catch
                {
                    MessageBox.Show("Unique key olabilir lütfen Telefon numarasını farklı giriniz..");

                }
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

        private void tx_durakAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
           && !char.IsSeparator(e.KeyChar);
        }
    }
}
