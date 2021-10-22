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
    public partial class musteriTur : MetroFramework.Forms.MetroForm
    {
        public musteriTur()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");
        
        private void musteriTur_Load(object sender, EventArgs e)
        {
            dgv_musteriTur.DataSource = vt.Select("select musteriTur_id,musteriTur from tbl_musteriTur");
            dgv_musteriTur.Columns["musteriTur_id"].Visible = false;
           
        }
        

        private void dgv_musteriTur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_musteriTur.SelectedRows.Count == 0)
                return;

            tx_musteriTur.Text = dgv_musteriTur.SelectedRows[0].Cells["musteriTur"].Value.ToString();
        }


        private void tx_musteriTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tx_musteriTur.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                    return;
                }
                if (tx_musteriTur.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Müşteri Türü en az 3 karakter olmalıdır...");
                    return;
                }

                object kayitsay = vt.Insert(@"insert into tbl_musteriTur(musteriTur)values('" + tx_musteriTur.Text + "')");
                musteriTur_Load(null, null);
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
                if (dgv_musteriTur.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Silinecek Müşteri Türünü Seçiniz..");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"delete from tbl_musteriTur where musteriTur_id=" + dgv_musteriTur.SelectedRows[0].Cells["musteriTur_id"].Value);
                MessageBox.Show("Müşteri Türü Başarıyla Silindi...");
                musteriTur_Load(null, null);
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
                if (tx_musteriTur.Text.Trim().Length < 2)
                {
                    MessageBox.Show("Müşteri Türü En az 2 Karakter Olmalıdır..");
                    return;
                }
                if (dgv_musteriTur.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Güncellenecek Satır Seçiniz..!");
                    return;
                }
                if (tx_musteriTur.Text == "")
                {
                    MessageBox.Show("Müşteri Türü Boş Olamaz Lütfen Tekrar Deneyin..");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"update tbl_musteriTur set musteriTur='" + tx_musteriTur.Text + "' where musteriTur_id=" + dgv_musteriTur.SelectedRows[0].Cells["musteriTur_id"].Value);
                if (kayitsay > 0)
                {
                    musteriTur_Load(null, null);
                    MessageBox.Show("Müşteri Türü Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            tx_musteriTur.Text = "";

            if (dgv_musteriTur.SelectedRows.Count > 0)
                dgv_musteriTur.SelectedRows[0].Selected = false;
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

        private void musteriTur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode==Keys.E)
            {
                btn_Ekle_Click_1(null,null);
            }
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
