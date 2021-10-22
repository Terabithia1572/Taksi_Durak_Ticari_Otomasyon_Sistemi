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
    public partial class Arac : MetroFramework.Forms.MetroForm
    {
        public Arac()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");
        private void Arac_Load(object sender, EventArgs e)
        {
            Arac_Load();

            cbx_Model.DataSource = vt.Select("select model_id,modelAdi+'-'+CAST (modelYil as nvarchar(50))+'-'+cast(marka_id as nvarchar(50)) 'Model' from tbl_model");
            cbx_Model.DisplayMember = "Model";
            cbx_Model.ValueMember = "model_id";

            cbx_taksiDurak.DataSource = vt.Select("select taksiDurak_id,durakAdi+'-'+CAST (taksiDuraktelefon as nvarchar)+'-'+durakAdres as 'Taksi' from tbl_taksiDurak");
            cbx_taksiDurak.DisplayMember = "Taksi";
            cbx_taksiDurak.ValueMember = "taksiDurak_id";
         
        }

        private void Arac_Load()
        {
            dgv_Araclar.DataSource = vt.Select(@"select a.arac_id,a.plaka,m.model_id,t.taksiDurak_id,m.marka_id,m.modelAdi,m.modelYil,t.durakAdi,t.durakAdres,t.taksiDuraktelefon from tbl_Arac a join tbl_Model m on a.model_id=m.model_id join tbl_taksiDurak t on t.taksiDurak_id=a.taksiDurak_id");
            dgv_Araclar.Columns["arac_id"].Visible = false;
            dgv_Araclar.Columns["model_id"].Visible = false;
            dgv_Araclar.Columns["marka_id"].Visible = false;
            dgv_Araclar.Columns["taksiDurak_id"].Visible = false;
        }


        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            try {
            if (tx_Plaka.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                return;
            }
            if (cbx_Model.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Model Kısmını Seçiniz Boş Bırakmayınız...");
                return;
            }
            if (cbx_taksiDurak.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Taksi Durak Kısmını Seçiniz Boş Bırakmayınız...");
                return;
            }
            if (tx_Plaka.Text.Trim().Length < 8)
            {
                MessageBox.Show("Plaka en Az 8 Haneli Olmalıdır...");
                return;
            }

            object kayitsay = vt.Select("insert into tbl_Arac(plaka,model_id,taksiDurak_id)values('"+tx_Plaka.Text+"','"+cbx_Model.SelectedValue+"','"+cbx_taksiDurak.SelectedValue+"')");
            Arac_Load(null, null);
            MessageBox.Show(kayitsay+" Arac Başarıyla Eklendi..");
            }catch
            {
                MessageBox.Show("Unique Key olabilir lütfen Plaka için farklı bir değer girin..");
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

        private void brn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_Araclar.SelectedRows.Count == 0)// dgv_Personeller.SelectedRows[0],[0] yapmamızın nedeni ilk satır demek  
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçiniz..");
                return;
            }
            int kayitsay = vt.UpdateDelete("delete from tbl_Arac where arac_id=" + dgv_Araclar.SelectedRows[0].Cells["arac_id"].Value);//[0] seçilen satırı silecek Value ise seçilen değer demek yani arac_id deki değerden silecek
            if (kayitsay > 0)
            {
                Arac_Load();
                MessageBox.Show(kayitsay + " Kayıt Başarıyla Silindi...");
            }
            else
            {
                MessageBox.Show("Kayıt Silinemedi Lütfen Tekrar Deneyin..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_Araclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Satırı Seçiniz..");
                return;
            }

            if (tx_Plaka.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                return;
            }
            if (cbx_Model.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Model Kısmını Seçiniz Boş Bırakmayınız...");
                return;
            }
            if (cbx_taksiDurak.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Taksi Durak Kısmını Seçiniz Boş Bırakmayınız...");
                return;
            }
            if (tx_Plaka.Text.Trim().Length < 8)
            {
                MessageBox.Show("Plaka en Az 8 Haneli Olmalıdır...");
                return;
            }

            try
            {
                int kayitsay = vt.UpdateDelete(@"update tbl_Arac set plaka='"+tx_Plaka.Text+"',model_id='"+cbx_Model.SelectedValue+"',taksiDurak_id='"+cbx_taksiDurak.SelectedValue+"' where arac_id=" + dgv_Araclar.SelectedRows[0].Cells["arac_id"].Value);

                if (kayitsay > 0)
                {
                    Arac_Load();
                    MessageBox.Show(kayitsay + " Kayıt Başarıyla Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Unique Key olabilir lütfen Plaka için farklı bir değer girin..");

            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_Plaka.Text = "";
            cbx_Model.SelectedValue = -1;
            cbx_taksiDurak.SelectedValue = -1;

            if (dgv_Araclar.SelectedRows.Count > 0)
                dgv_Araclar.SelectedRows[0].Selected = false;
        }

        private void dgv_Araclar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Araclar.SelectedRows.Count == 0)
                return;
            tx_Plaka.Text= dgv_Araclar.SelectedRows[0].Cells["plaka"].Value.ToString();
            cbx_taksiDurak.SelectedValue = dgv_Araclar.SelectedRows[0].Cells["taksiDurak_id"].Value.ToString();
            cbx_Model.SelectedValue= dgv_Araclar.SelectedRows[0].Cells["model_id"].Value.ToString();

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
