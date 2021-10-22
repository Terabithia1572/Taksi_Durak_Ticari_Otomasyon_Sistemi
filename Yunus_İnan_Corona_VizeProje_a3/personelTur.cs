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
    public partial class personelTur : MetroFramework.Forms.MetroForm
    {
        public personelTur()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");
        private void personelTur_Load(object sender, EventArgs e)
        {
            dgv_personelTur.DataSource = vt.Select("select perTur_id,perTur 'Personel Tür' from tbl_personelTur");
            dgv_personelTur.Columns["perTur_id"].Visible = false;
        }

        private void dgv_personelTur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_personelTur.SelectedRows.Count == 0)
                return;

            tx_personelTur.Text = dgv_personelTur.SelectedRows[0].Cells["perTur"].Value.ToString();
        }


        private void tx_personelTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tx_personelTur.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                    return;
                }
                if (tx_personelTur.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Personel Türü en az 3 karakter olmalıdır...");
                    return;
                }

                object kayitsay = vt.Insert(@"insert into tbl_personelTur(perTur)values('" + tx_personelTur.Text + "')");
                personelTur_Load(null, null);
                MessageBox.Show(kayitsay + " Kayıt Başarıyla Eklendi...");
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi Lütfen Tekrar Deneyin..");
            }
        }

        private void brn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_personelTur.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Silinecek Personel Türünü Seçiniz..");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"delete from tbl_personelTur where perTur_id=" + dgv_personelTur.SelectedRows[0].Cells["perTur_id"].Value);
                MessageBox.Show(kayitsay + " Personel Türü Başarıyla Silindi...");
                personelTur_Load(null, null);
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi Lütfen Tekrar Deneyin..");
            }
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tx_personelTur.Text.Trim().Length < 2)
                {
                    MessageBox.Show("Personel Türü En az 2 Karakter Olmalıdır..");
                    return;
                }
                if (dgv_personelTur.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Güncellenecek Satır Seçiniz..!");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"update tbl_personelTur set perTur='" + tx_personelTur.Text + "' where perTur_id=" + dgv_personelTur.SelectedRows[0].Cells["perTur_id"].Value);
                if (kayitsay > 0)
                {
                    personelTur_Load(null, null);
                    MessageBox.Show(kayitsay + " Personel Türü Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            tx_personelTur.Text = "";

            if (dgv_personelTur.SelectedRows.Count > 0)
                dgv_personelTur.SelectedRows[0].Selected = false;
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
