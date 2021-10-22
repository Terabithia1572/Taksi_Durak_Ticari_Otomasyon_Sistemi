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
    public partial class Marka : MetroFramework.Forms.MetroForm
    {
        public Marka()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");
        private void Marka_Load(object sender, EventArgs e)
        {
            dgv_Markalar.DataSource = vt.Select("select marka_id,markaAdi from tbl_marka");
            dgv_Markalar.Columns["marka_id"].Visible = false;
  
        }

        private void dgv_Markalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Markalar.SelectedRows.Count == 0)
                return;

            tx_Marka.Text = dgv_Markalar.SelectedRows[0].Cells["markaAdi"].Value.ToString();
        }


        private void btn_Ekle_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Ekle.BackgroundImage = Properties.Resources.ekle;
            btn_Ekle.Text = "";

        }

        private void btn_Ekle_MouseLeave(object sender, EventArgs e)
        {
            btn_Ekle.BackgroundImage = null;
            btn_Ekle.Text = "Ekle";
            
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tx_Marka.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                    return;
                }
                if (tx_Marka.Text.Trim().Length < 3)
                {
                    MessageBox.Show(" Marka en az 3 karakter olmalıdır...");
                    return;
                }
                object kayitsay = vt.Insert("insert into tbl_Marka(markaAdi)values('" + tx_Marka.Text + "')");
                Marka_Load(null, null);
                MessageBox.Show(kayitsay + " Kayıt Başarıyla Eklendi..");
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
                if (dgv_Markalar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Silinecek Marka Seçiniz..");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"delete from tbl_Marka where marka_id=" + dgv_Markalar.SelectedRows[0].Cells["marka_id"].Value);
                MessageBox.Show(" Marka Başarıyla Silindi...");
                Marka_Load(null, null);
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
                if (dgv_Markalar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Güncellenecek Satır Seçiniz..!");
                    return;
                }
                if (tx_Marka.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Marka Adı en az 3 Karakter Olmalıdır...");
                    return;
                }
                if (tx_Marka.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"update tbl_Marka set markaAdi='" + tx_Marka.Text + "' where marka_id=" + dgv_Markalar.SelectedRows[0].Cells["marka_id"].Value);


                if (kayitsay > 0)
                {
                    Marka_Load(null, null);
                    MessageBox.Show(kayitsay + " Kayıt Başarıyla Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            if (dgv_Markalar.SelectedRows.Count > 0)
                dgv_Markalar.SelectedRows[0].Selected = false;
            tx_Marka.Text = "";
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

        private void tx_Marka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
           && !char.IsSeparator(e.KeyChar);
        }
    }
}
