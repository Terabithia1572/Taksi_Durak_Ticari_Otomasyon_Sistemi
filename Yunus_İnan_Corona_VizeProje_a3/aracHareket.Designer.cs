namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class aracHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aracHareket));
            this.nmr_Tarih = new System.Windows.Forms.NumericUpDown();
            this.btn_Temizle = new MetroFramework.Controls.MetroTile();
            this.btn_Guncelle = new MetroFramework.Controls.MetroTile();
            this.brn_Sil = new MetroFramework.Controls.MetroTile();
            this.btn_Ekle = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbx_Arac = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dgv_aracHareket = new MetroFramework.Controls.MetroGrid();
            this.tx_toplamHasilat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbx_Personel = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.tp_Arac = new MetroFramework.Components.MetroToolTip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Tarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aracHareket)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmr_Tarih
            // 
            this.nmr_Tarih.Location = new System.Drawing.Point(127, 160);
            this.nmr_Tarih.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmr_Tarih.Name = "nmr_Tarih";
            this.nmr_Tarih.Size = new System.Drawing.Size(120, 20);
            this.nmr_Tarih.TabIndex = 105;
            this.tp_Arac.SetToolTip(this.nmr_Tarih, "Tarih En az 4 Ganeli olmalı");
            this.nmr_Tarih.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.ActiveControl = null;
            this.btn_Temizle.Location = new System.Drawing.Point(653, 108);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(50, 50);
            this.btn_Temizle.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Temizle.TabIndex = 104;
            this.btn_Temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Temizle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.dry_clean__1_;
            this.btn_Temizle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Temizle.UseSelectable = true;
            this.btn_Temizle.UseTileImage = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            this.btn_Temizle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Temizle_KeyDown);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.ActiveControl = null;
            this.btn_Guncelle.Location = new System.Drawing.Point(597, 108);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(50, 50);
            this.btn_Guncelle.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Guncelle.TabIndex = 103;
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guncelle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.rotate__1_;
            this.btn_Guncelle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guncelle.UseSelectable = true;
            this.btn_Guncelle.UseTileImage = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            this.btn_Guncelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Guncelle_KeyDown);
            // 
            // brn_Sil
            // 
            this.brn_Sil.ActiveControl = null;
            this.brn_Sil.Location = new System.Drawing.Point(541, 108);
            this.brn_Sil.Name = "brn_Sil";
            this.brn_Sil.Size = new System.Drawing.Size(50, 50);
            this.brn_Sil.Style = MetroFramework.MetroColorStyle.Red;
            this.brn_Sil.TabIndex = 102;
            this.brn_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Sil.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.close_circular_button_of_a_cross__1_;
            this.brn_Sil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brn_Sil.UseSelectable = true;
            this.brn_Sil.UseTileImage = true;
            this.brn_Sil.Click += new System.EventHandler(this.brn_Sil_Click);
            this.brn_Sil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brn_Sil_KeyDown);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.ActiveControl = null;
            this.btn_Ekle.Location = new System.Drawing.Point(485, 108);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(50, 50);
            this.btn_Ekle.TabIndex = 101;
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ekle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.plus__1_;
            this.btn_Ekle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ekle.UseSelectable = true;
            this.btn_Ekle.UseTileImage = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            this.btn_Ekle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Ekle_KeyDown);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(652, 161);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 19);
            this.metroLabel10.TabIndex = 97;
            this.metroLabel10.Text = "Temizle";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(593, 161);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 98;
            this.metroLabel9.Text = "Güncelle";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(555, 161);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(22, 19);
            this.metroLabel8.TabIndex = 99;
            this.metroLabel8.Text = "Sil";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(492, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 100;
            this.metroLabel4.Text = "Ekle";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 96;
            this.metroLabel2.Text = "Tarih";
            // 
            // cbx_Arac
            // 
            this.cbx_Arac.FormattingEnabled = true;
            this.cbx_Arac.ItemHeight = 23;
            this.cbx_Arac.Location = new System.Drawing.Point(127, 200);
            this.cbx_Arac.Name = "cbx_Arac";
            this.cbx_Arac.Size = new System.Drawing.Size(309, 29);
            this.cbx_Arac.TabIndex = 95;
            this.tp_Arac.SetToolTip(this.cbx_Arac, "Araç Bilgilerini Gösterir");
            this.cbx_Arac.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(1, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 94;
            this.metroLabel7.Text = "Araç Bilgileri:";
            // 
            // dgv_aracHareket
            // 
            this.dgv_aracHareket.AllowUserToAddRows = false;
            this.dgv_aracHareket.AllowUserToDeleteRows = false;
            this.dgv_aracHareket.AllowUserToResizeRows = false;
            this.dgv_aracHareket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_aracHareket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_aracHareket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_aracHareket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aracHareket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_aracHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_aracHareket.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_aracHareket.EnableHeadersVisualStyles = false;
            this.dgv_aracHareket.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_aracHareket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_aracHareket.Location = new System.Drawing.Point(23, 324);
            this.dgv_aracHareket.MultiSelect = false;
            this.dgv_aracHareket.Name = "dgv_aracHareket";
            this.dgv_aracHareket.ReadOnly = true;
            this.dgv_aracHareket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aracHareket.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_aracHareket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_aracHareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_aracHareket.Size = new System.Drawing.Size(1019, 172);
            this.dgv_aracHareket.TabIndex = 93;
            this.dgv_aracHareket.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_aracHareket_CellDoubleClick);
            // 
            // tx_toplamHasilat
            // 
            // 
            // 
            // 
            this.tx_toplamHasilat.CustomButton.Image = null;
            this.tx_toplamHasilat.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_toplamHasilat.CustomButton.Name = "";
            this.tx_toplamHasilat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_toplamHasilat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_toplamHasilat.CustomButton.TabIndex = 1;
            this.tx_toplamHasilat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_toplamHasilat.CustomButton.UseSelectable = true;
            this.tx_toplamHasilat.CustomButton.Visible = false;
            this.tx_toplamHasilat.Lines = new string[0];
            this.tx_toplamHasilat.Location = new System.Drawing.Point(150, 114);
            this.tx_toplamHasilat.MaxLength = 25;
            this.tx_toplamHasilat.Name = "tx_toplamHasilat";
            this.tx_toplamHasilat.PasswordChar = '\0';
            this.tx_toplamHasilat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_toplamHasilat.SelectedText = "";
            this.tx_toplamHasilat.SelectionLength = 0;
            this.tx_toplamHasilat.SelectionStart = 0;
            this.tx_toplamHasilat.ShortcutsEnabled = false;
            this.tx_toplamHasilat.Size = new System.Drawing.Size(116, 23);
            this.tx_toplamHasilat.TabIndex = 92;
            this.tp_Arac.SetToolTip(this.tx_toplamHasilat, "Toplam Hasılatı Gösterir");
            this.tx_toplamHasilat.UseSelectable = true;
            this.tx_toplamHasilat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_toplamHasilat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_toplamHasilat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_toplamHasilat_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 91;
            this.metroLabel1.Text = "Toplam Hasılat:";
            // 
            // cbx_Personel
            // 
            this.cbx_Personel.FormattingEnabled = true;
            this.cbx_Personel.ItemHeight = 23;
            this.cbx_Personel.Location = new System.Drawing.Point(127, 275);
            this.cbx_Personel.Name = "cbx_Personel";
            this.cbx_Personel.Size = new System.Drawing.Size(663, 29);
            this.cbx_Personel.TabIndex = 107;
            this.tp_Arac.SetToolTip(this.cbx_Personel, "Personel Bilgilerini Gösterir");
            this.cbx_Personel.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(1, 275);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 19);
            this.metroLabel3.TabIndex = 106;
            this.metroLabel3.Text = "Personel Bilgileri:";
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
            // notifyIconTaksi
            // 
            this.notifyIconTaksi.ContextMenuStrip = this.metroContextMenu1;
            this.notifyIconTaksi.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTaksi.Icon")));
            this.notifyIconTaksi.Text = "Taksi Durak İşlemleri";
            this.notifyIconTaksi.Visible = true;
            this.notifyIconTaksi.DoubleClick += new System.EventHandler(this.notifyIconTaksi_DoubleClick);
            // 
            // tp_Arac
            // 
            this.tp_Arac.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_Arac.StyleManager = null;
            this.tp_Arac.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.carislem1;
            this.pictureBox1.Location = new System.Drawing.Point(302, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(653, 86);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(55, 19);
            this.metroLabel11.TabIndex = 113;
            this.metroLabel11.Text = "CTRL+T";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(597, 86);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 112;
            this.metroLabel6.Text = "CTRL+G";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(541, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 111;
            this.metroLabel5.Text = "CTRL+S";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(480, 86);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(55, 19);
            this.metroLabel12.TabIndex = 110;
            this.metroLabel12.Text = "CTRL+E";
            // 
            // aracHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 590);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbx_Personel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.nmr_Tarih);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.brn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbx_Arac);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dgv_aracHareket);
            this.Controls.Add(this.tx_toplamHasilat);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aracHareket";
            this.Text = "Araç Hareket";
            this.Load += new System.EventHandler(this.aracHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Tarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aracHareket)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmr_Tarih;
        private MetroFramework.Controls.MetroTile btn_Temizle;
        private MetroFramework.Controls.MetroTile btn_Guncelle;
        private MetroFramework.Controls.MetroTile brn_Sil;
        private MetroFramework.Controls.MetroTile btn_Ekle;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbx_Arac;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dgv_aracHareket;
        private MetroFramework.Controls.MetroTextBox tx_toplamHasilat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbx_Personel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Components.MetroToolTip tp_Arac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}