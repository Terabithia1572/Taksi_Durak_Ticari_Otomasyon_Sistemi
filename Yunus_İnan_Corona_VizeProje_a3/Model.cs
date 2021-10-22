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
    public partial class Model : MetroFramework.Forms.MetroForm
    {
        public Model()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani("db_Corona", ".");
        private void Model_Load(object sender, EventArgs e)
        {
            ModelGridDoldur();

            cbx_Marka.DataSource = vt.Select("select marka_id,markaAdi from tbl_Marka");
            cbx_Marka.DisplayMember = "markaAdi";
            cbx_Marka.ValueMember = "marka_id";

          //  dtp_modelYil.Format = DateTimePickerFormat.Custom;
         //   dtp_modelYil.CustomFormat = "yyyy";


        }

        private void ModelGridDoldur()
        {
            dgv_Modeller.DataSource = vt.Select("select m.model_id,m.modelAdi,m.modelYil,mo.marka_id,mo.markaAdi from tbl_Model m join tbl_Marka mo on m.marka_id=mo.marka_id");
            dgv_Modeller.Columns["model_id"].Visible = false;
            dgv_Modeller.Columns["marka_id"].Visible = false;
        }


        private void dgv_Modeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Modeller.SelectedRows.Count == 0)
                return;

            tx_Model.Text =dgv_Modeller.SelectedRows[0].Cells["modelAdi"].Value.ToString();
            cbx_Marka.Text = dgv_Modeller.SelectedRows[0].Cells["markaAdi"].Value.ToString();
           nmr_modelYil.Text = dgv_Modeller.SelectedRows[0].Cells["modelYil"].Value.ToString();
        }


        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            if (tx_Model.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...");
                return;
            }
            if (cbx_Marka.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Marka Alanını Boş Bırakmayınız...");
                return;
            }
            if (nmr_modelYil.Text == "")
            {
                MessageBox.Show("Model Yıl Boş Bırakılamaz..");
                return;
            }

            object kayitsay = vt.Insert("insert into tbl_Model(modelAdi,modelYil,marka_id)values('" + tx_Model.Text + "','" + nmr_modelYil.Text + "','" + cbx_Marka.SelectedValue + "')");
            ModelGridDoldur();
            MessageBox.Show(kayitsay + " Kayıt Başarıyla Eklendi..");
        }

        private void brn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Modeller.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Silinecek Model Seçiniz..");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"delete from tbl_Model where model_id=" + dgv_Modeller.SelectedRows[0].Cells["model_id"].Value);
                MessageBox.Show(" Model Başarıyla Silindi...");
                Model_Load(null, null);
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
                if (dgv_Modeller.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Güncellenecek Satır Seçiniz..!");
                    return;
                }
                if (tx_Model.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Model Adı en az 3 Karakter Olmalıdır...");
                    return;
                }
                if (tx_Model.Text == "")
                {
                    MessageBox.Show("Lütfen Modeli Bırakmayınız...");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"update tbl_Model set modelAdi='" + tx_Model.Text + "',modelYil='" + nmr_modelYil.Text + "',marka_id='" + cbx_Marka.SelectedIndex + "' where model_id=" + dgv_Modeller.SelectedRows[0].Cells["model_id"].Value);


                if (kayitsay > 0)
                {
                    Model_Load(null, null);
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
            tx_Model.Text = "";
            cbx_Marka.SelectedIndex = -1;
            nmr_modelYil.Text = "";
            // dtp_modelYil.Value = DateTimePicker.MinimumDateTime;
            // dtp_modelYil.CustomFormat = " ";

            if (dgv_Modeller.SelectedRows.Count > 0)
                dgv_Modeller.SelectedRows[0].Selected = false;
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
