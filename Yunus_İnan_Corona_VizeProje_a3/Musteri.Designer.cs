namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class Musteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.tx_Adres = new MetroFramework.Controls.MetroTextBox();
            this.tx_Telefon = new MetroFramework.Controls.MetroTextBox();
            this.tx_soyAd = new MetroFramework.Controls.MetroTextBox();
            this.tx_Ad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgv_Musteriler = new MetroFramework.Controls.MetroGrid();
            this.cbx_taksiDurak = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbx_musteriTur = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Temizle = new MetroFramework.Controls.MetroTile();
            this.btn_Guncelle = new MetroFramework.Controls.MetroTile();
            this.brn_Sil = new MetroFramework.Controls.MetroTile();
            this.btn_Ekle = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tp_Musteri = new MetroFramework.Components.MetroToolTip();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_Adres
            // 
            // 
            // 
            // 
            this.tx_Adres.CustomButton.Image = null;
            this.tx_Adres.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.tx_Adres.CustomButton.Name = "";
            this.tx_Adres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Adres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Adres.CustomButton.TabIndex = 1;
            this.tx_Adres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Adres.CustomButton.UseSelectable = true;
            this.tx_Adres.CustomButton.Visible = false;
            this.tx_Adres.Lines = new string[0];
            this.tx_Adres.Location = new System.Drawing.Point(126, 199);
            this.tx_Adres.MaxLength = 100;
            this.tx_Adres.Name = "tx_Adres";
            this.tx_Adres.PasswordChar = '\0';
            this.tx_Adres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Adres.SelectedText = "";
            this.tx_Adres.SelectionLength = 0;
            this.tx_Adres.SelectionStart = 0;
            this.tx_Adres.ShortcutsEnabled = false;
            this.tx_Adres.Size = new System.Drawing.Size(349, 23);
            this.tx_Adres.TabIndex = 19;
            this.tp_Musteri.SetToolTip(this.tx_Adres, "Adres Giriniz..");
            this.tx_Adres.UseSelectable = true;
            this.tx_Adres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Adres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_Adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Adres_KeyPress);
            // 
            // tx_Telefon
            // 
            // 
            // 
            // 
            this.tx_Telefon.CustomButton.Image = null;
            this.tx_Telefon.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_Telefon.CustomButton.Name = "";
            this.tx_Telefon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Telefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Telefon.CustomButton.TabIndex = 1;
            this.tx_Telefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Telefon.CustomButton.UseSelectable = true;
            this.tx_Telefon.CustomButton.Visible = false;
            this.tx_Telefon.Lines = new string[0];
            this.tx_Telefon.Location = new System.Drawing.Point(126, 158);
            this.tx_Telefon.MaxLength = 11;
            this.tx_Telefon.Name = "tx_Telefon";
            this.tx_Telefon.PasswordChar = '\0';
            this.tx_Telefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Telefon.SelectedText = "";
            this.tx_Telefon.SelectionLength = 0;
            this.tx_Telefon.SelectionStart = 0;
            this.tx_Telefon.ShortcutsEnabled = false;
            this.tx_Telefon.Size = new System.Drawing.Size(116, 23);
            this.tx_Telefon.TabIndex = 18;
            this.tp_Musteri.SetToolTip(this.tx_Telefon, "Telefon 11 Hane Olmalıdır");
            this.tx_Telefon.UseSelectable = true;
            this.tx_Telefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Telefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Telefon_KeyPress);
            // 
            // tx_soyAd
            // 
            // 
            // 
            // 
            this.tx_soyAd.CustomButton.Image = null;
            this.tx_soyAd.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_soyAd.CustomButton.Name = "";
            this.tx_soyAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_soyAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_soyAd.CustomButton.TabIndex = 1;
            this.tx_soyAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_soyAd.CustomButton.UseSelectable = true;
            this.tx_soyAd.CustomButton.Visible = false;
            this.tx_soyAd.Lines = new string[0];
            this.tx_soyAd.Location = new System.Drawing.Point(126, 116);
            this.tx_soyAd.MaxLength = 25;
            this.tx_soyAd.Name = "tx_soyAd";
            this.tx_soyAd.PasswordChar = '\0';
            this.tx_soyAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_soyAd.SelectedText = "";
            this.tx_soyAd.SelectionLength = 0;
            this.tx_soyAd.SelectionStart = 0;
            this.tx_soyAd.ShortcutsEnabled = false;
            this.tx_soyAd.Size = new System.Drawing.Size(116, 23);
            this.tx_soyAd.TabIndex = 17;
            this.tp_Musteri.SetToolTip(this.tx_soyAd, "Soyad En az 2 Karakter Olmalıdır...");
            this.tx_soyAd.UseSelectable = true;
            this.tx_soyAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_soyAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_soyAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyAd_KeyPress);
            // 
            // tx_Ad
            // 
            // 
            // 
            // 
            this.tx_Ad.CustomButton.Image = null;
            this.tx_Ad.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_Ad.CustomButton.Name = "";
            this.tx_Ad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Ad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Ad.CustomButton.TabIndex = 1;
            this.tx_Ad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Ad.CustomButton.UseSelectable = true;
            this.tx_Ad.CustomButton.Visible = false;
            this.tx_Ad.Lines = new string[0];
            this.tx_Ad.Location = new System.Drawing.Point(126, 83);
            this.tx_Ad.MaxLength = 25;
            this.tx_Ad.Name = "tx_Ad";
            this.tx_Ad.PasswordChar = '\0';
            this.tx_Ad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Ad.SelectedText = "";
            this.tx_Ad.SelectionLength = 0;
            this.tx_Ad.SelectionStart = 0;
            this.tx_Ad.ShortcutsEnabled = false;
            this.tx_Ad.Size = new System.Drawing.Size(116, 23);
            this.tx_Ad.TabIndex = 16;
            this.tp_Musteri.SetToolTip(this.tx_Ad, "Ad En az 2 Karakter Olmalıdır...");
            this.tx_Ad.UseSelectable = true;
            this.tx_Ad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Ad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Ad_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(68, 199);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Adres:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(68, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Telefon:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(68, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Soyad:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Ad:";
            // 
            // dgv_Musteriler
            // 
            this.dgv_Musteriler.AllowUserToAddRows = false;
            this.dgv_Musteriler.AllowUserToDeleteRows = false;
            this.dgv_Musteriler.AllowUserToResizeRows = false;
            this.dgv_Musteriler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Musteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Musteriler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Musteriler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Musteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Musteriler.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Musteriler.EnableHeadersVisualStyles = false;
            this.dgv_Musteriler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Musteriler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Musteriler.Location = new System.Drawing.Point(23, 323);
            this.dgv_Musteriler.MultiSelect = false;
            this.dgv_Musteriler.Name = "dgv_Musteriler";
            this.dgv_Musteriler.ReadOnly = true;
            this.dgv_Musteriler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Musteriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Musteriler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Musteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Musteriler.Size = new System.Drawing.Size(851, 150);
            this.dgv_Musteriler.TabIndex = 20;
            this.dgv_Musteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Musteriler_CellDoubleClick);
            // 
            // cbx_taksiDurak
            // 
            this.cbx_taksiDurak.FormattingEnabled = true;
            this.cbx_taksiDurak.ItemHeight = 23;
            this.cbx_taksiDurak.Location = new System.Drawing.Point(459, 272);
            this.cbx_taksiDurak.Name = "cbx_taksiDurak";
            this.cbx_taksiDurak.Size = new System.Drawing.Size(284, 29);
            this.cbx_taksiDurak.TabIndex = 28;
            this.tp_Musteri.SetToolTip(this.cbx_taksiDurak, "Taksi Durak Seçiniz..");
            this.cbx_taksiDurak.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(346, 272);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Taksi Durak:";
            // 
            // cbx_musteriTur
            // 
            this.cbx_musteriTur.FormattingEnabled = true;
            this.cbx_musteriTur.ItemHeight = 23;
            this.cbx_musteriTur.Location = new System.Drawing.Point(177, 272);
            this.cbx_musteriTur.Name = "cbx_musteriTur";
            this.cbx_musteriTur.Size = new System.Drawing.Size(121, 29);
            this.cbx_musteriTur.TabIndex = 26;
            this.tp_Musteri.SetToolTip(this.cbx_musteriTur, "Müşteri Türü Seçiniz..");
            this.cbx_musteriTur.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(64, 272);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Müşteri Türü:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.Musteri;
            this.pictureBox1.Location = new System.Drawing.Point(288, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.ActiveControl = null;
            this.btn_Temizle.Location = new System.Drawing.Point(667, 105);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(50, 50);
            this.btn_Temizle.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Temizle.TabIndex = 97;
            this.btn_Temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Temizle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.dry_clean__1_;
            this.btn_Temizle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Musteri.SetToolTip(this.btn_Temizle, "Temizle");
            this.btn_Temizle.UseSelectable = true;
            this.btn_Temizle.UseTileImage = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click_1);
            this.btn_Temizle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Temizle_KeyDown);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.ActiveControl = null;
            this.btn_Guncelle.Location = new System.Drawing.Point(611, 105);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(50, 50);
            this.btn_Guncelle.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Guncelle.TabIndex = 96;
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guncelle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.rotate__1_;
            this.btn_Guncelle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Musteri.SetToolTip(this.btn_Guncelle, "Güncelle");
            this.btn_Guncelle.UseSelectable = true;
            this.btn_Guncelle.UseTileImage = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click_1);
            this.btn_Guncelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Guncelle_KeyDown);
            // 
            // brn_Sil
            // 
            this.brn_Sil.ActiveControl = null;
            this.brn_Sil.Location = new System.Drawing.Point(555, 105);
            this.brn_Sil.Name = "brn_Sil";
            this.brn_Sil.Size = new System.Drawing.Size(50, 50);
            this.brn_Sil.Style = MetroFramework.MetroColorStyle.Red;
            this.brn_Sil.TabIndex = 95;
            this.brn_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Sil.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.close_circular_button_of_a_cross__1_;
            this.brn_Sil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Musteri.SetToolTip(this.brn_Sil, "Sil");
            this.brn_Sil.UseSelectable = true;
            this.brn_Sil.UseTileImage = true;
            this.brn_Sil.Click += new System.EventHandler(this.brn_Sil_Click);
            this.brn_Sil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brn_Sil_KeyDown);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.ActiveControl = null;
            this.btn_Ekle.Location = new System.Drawing.Point(499, 105);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(50, 50);
            this.btn_Ekle.TabIndex = 94;
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ekle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.plus__1_;
            this.btn_Ekle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Musteri.SetToolTip(this.btn_Ekle, "Ekle");
            this.btn_Ekle.UseSelectable = true;
            this.btn_Ekle.UseTileImage = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click_1);
            this.btn_Ekle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Ekle_KeyDown);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(666, 158);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 19);
            this.metroLabel10.TabIndex = 90;
            this.metroLabel10.Text = "Temizle";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(607, 158);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 91;
            this.metroLabel9.Text = "Güncelle";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(569, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 92;
            this.metroLabel3.Text = "Sil";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(506, 158);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 19);
            this.metroLabel5.TabIndex = 93;
            this.metroLabel5.Text = "Ekle";
            // 
            // tp_Musteri
            // 
            this.tp_Musteri.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_Musteri.StyleManager = null;
            this.tp_Musteri.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // notifyIconTaksi
            // 
            this.notifyIconTaksi.ContextMenuStrip = this.metroContextMenu1;
            this.notifyIconTaksi.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTaksi.Icon")));
            this.notifyIconTaksi.Text = "Taksi Durak İşlemleri";
            this.notifyIconTaksi.Visible = true;
            this.notifyIconTaksi.DoubleClick += new System.EventHandler(this.notifyIconTaksi_DoubleClick);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(151, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.show;
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.hide;
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.eyes;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(667, 83);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(55, 19);
            this.metroLabel11.TabIndex = 101;
            this.metroLabel11.Text = "CTRL+T";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(611, 83);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(57, 19);
            this.metroLabel12.TabIndex = 100;
            this.metroLabel12.Text = "CTRL+G";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(555, 83);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(55, 19);
            this.metroLabel13.TabIndex = 99;
            this.metroLabel13.Text = "CTRL+S";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(494, 83);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(55, 19);
            this.metroLabel14.TabIndex = 98;
            this.metroLabel14.Text = "CTRL+E";
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 527);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.brn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbx_taksiDurak);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cbx_musteriTur);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dgv_Musteriler);
            this.Controls.Add(this.tx_Adres);
            this.Controls.Add(this.tx_Telefon);
            this.Controls.Add(this.tx_soyAd);
            this.Controls.Add(this.tx_Ad);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tx_Adres;
        private MetroFramework.Controls.MetroTextBox tx_Telefon;
        private MetroFramework.Controls.MetroTextBox tx_soyAd;
        private MetroFramework.Controls.MetroTextBox tx_Ad;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgv_Musteriler;
        private MetroFramework.Controls.MetroComboBox cbx_taksiDurak;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cbx_musteriTur;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_Temizle;
        private MetroFramework.Controls.MetroTile btn_Guncelle;
        private MetroFramework.Controls.MetroTile btn_Ekle;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Components.MetroToolTip tp_Musteri;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private MetroFramework.Controls.MetroTile brn_Sil;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
    }
}