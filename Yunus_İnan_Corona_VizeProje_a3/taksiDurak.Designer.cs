namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class taksiDurak
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taksiDurak));
            this.tx_Adres = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dgv_Duraklar = new MetroFramework.Controls.MetroGrid();
            this.tx_Telefom = new MetroFramework.Controls.MetroTextBox();
            this.tx_durakAd = new MetroFramework.Controls.MetroTextBox();
            this.tx_Telefon = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Temizle = new MetroFramework.Controls.MetroTile();
            this.btn_Guncelle = new MetroFramework.Controls.MetroTile();
            this.brn_Sil = new MetroFramework.Controls.MetroTile();
            this.btn_Ekle = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tp_taksiDurak = new MetroFramework.Components.MetroToolTip();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Duraklar)).BeginInit();
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
            this.tx_Adres.Location = new System.Drawing.Point(120, 276);
            this.tx_Adres.MaxLength = 100;
            this.tx_Adres.Name = "tx_Adres";
            this.tx_Adres.PasswordChar = '\0';
            this.tx_Adres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Adres.SelectedText = "";
            this.tx_Adres.SelectionLength = 0;
            this.tx_Adres.SelectionStart = 0;
            this.tx_Adres.ShortcutsEnabled = false;
            this.tx_Adres.Size = new System.Drawing.Size(349, 23);
            this.tx_Adres.TabIndex = 13;
            this.tp_taksiDurak.SetToolTip(this.tx_Adres, "Adres Giriniz..");
            this.tx_Adres.UseSelectable = true;
            this.tx_Adres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Adres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_Adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Adres_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(42, 276);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Adres:";
            // 
            // dgv_Duraklar
            // 
            this.dgv_Duraklar.AllowUserToAddRows = false;
            this.dgv_Duraklar.AllowUserToDeleteRows = false;
            this.dgv_Duraklar.AllowUserToResizeRows = false;
            this.dgv_Duraklar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Duraklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Duraklar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Duraklar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Duraklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_Duraklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Duraklar.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Duraklar.EnableHeadersVisualStyles = false;
            this.dgv_Duraklar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Duraklar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Duraklar.Location = new System.Drawing.Point(45, 329);
            this.dgv_Duraklar.Name = "dgv_Duraklar";
            this.dgv_Duraklar.ReadOnly = true;
            this.dgv_Duraklar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Duraklar.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Duraklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Duraklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Duraklar.Size = new System.Drawing.Size(579, 150);
            this.dgv_Duraklar.TabIndex = 14;
            this.dgv_Duraklar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Duraklar_CellDoubleClick);
            // 
            // tx_Telefom
            // 
            // 
            // 
            // 
            this.tx_Telefom.CustomButton.Image = null;
            this.tx_Telefom.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_Telefom.CustomButton.Name = "";
            this.tx_Telefom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Telefom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Telefom.CustomButton.TabIndex = 1;
            this.tx_Telefom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Telefom.CustomButton.UseSelectable = true;
            this.tx_Telefom.CustomButton.Visible = false;
            this.tx_Telefom.Lines = new string[0];
            this.tx_Telefom.Location = new System.Drawing.Point(120, 231);
            this.tx_Telefom.MaxLength = 11;
            this.tx_Telefom.Name = "tx_Telefom";
            this.tx_Telefom.PasswordChar = '\0';
            this.tx_Telefom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Telefom.SelectedText = "";
            this.tx_Telefom.SelectionLength = 0;
            this.tx_Telefom.SelectionStart = 0;
            this.tx_Telefom.ShortcutsEnabled = false;
            this.tx_Telefom.Size = new System.Drawing.Size(116, 23);
            this.tx_Telefom.TabIndex = 18;
            this.tp_taksiDurak.SetToolTip(this.tx_Telefom, "Telefon 11 hane olmalıdır..");
            this.tx_Telefom.UseSelectable = true;
            this.tx_Telefom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Telefom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_Telefom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Telefom_KeyPress);
            // 
            // tx_durakAd
            // 
            // 
            // 
            // 
            this.tx_durakAd.CustomButton.Image = null;
            this.tx_durakAd.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_durakAd.CustomButton.Name = "";
            this.tx_durakAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_durakAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_durakAd.CustomButton.TabIndex = 1;
            this.tx_durakAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_durakAd.CustomButton.UseSelectable = true;
            this.tx_durakAd.CustomButton.Visible = false;
            this.tx_durakAd.Lines = new string[0];
            this.tx_durakAd.Location = new System.Drawing.Point(120, 186);
            this.tx_durakAd.MaxLength = 25;
            this.tx_durakAd.Name = "tx_durakAd";
            this.tx_durakAd.PasswordChar = '\0';
            this.tx_durakAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_durakAd.SelectedText = "";
            this.tx_durakAd.SelectionLength = 0;
            this.tx_durakAd.SelectionStart = 0;
            this.tx_durakAd.ShortcutsEnabled = false;
            this.tx_durakAd.Size = new System.Drawing.Size(116, 23);
            this.tx_durakAd.TabIndex = 17;
            this.tp_taksiDurak.SetToolTip(this.tx_durakAd, "Durak Adı Giriniz En az 2 Karakter");
            this.tx_durakAd.UseSelectable = true;
            this.tx_durakAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_durakAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_durakAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_durakAd_KeyPress);
            // 
            // tx_Telefon
            // 
            this.tx_Telefon.AutoSize = true;
            this.tx_Telefon.Location = new System.Drawing.Point(44, 231);
            this.tx_Telefon.Name = "tx_Telefon";
            this.tx_Telefon.Size = new System.Drawing.Size(53, 19);
            this.tx_Telefon.TabIndex = 16;
            this.tx_Telefon.Text = "Telefon:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Durak Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.taksi;
            this.pictureBox1.Location = new System.Drawing.Point(294, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.ActiveControl = null;
            this.btn_Temizle.Location = new System.Drawing.Point(689, 124);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(50, 50);
            this.btn_Temizle.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Temizle.TabIndex = 65;
            this.btn_Temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Temizle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.dry_clean__1_;
            this.btn_Temizle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_taksiDurak.SetToolTip(this.btn_Temizle, "Temizle");
            this.btn_Temizle.UseSelectable = true;
            this.btn_Temizle.UseTileImage = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click_1);
            this.btn_Temizle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Temizle_KeyDown);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.ActiveControl = null;
            this.btn_Guncelle.Location = new System.Drawing.Point(633, 124);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(50, 50);
            this.btn_Guncelle.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Guncelle.TabIndex = 64;
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guncelle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.rotate__1_;
            this.btn_Guncelle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_taksiDurak.SetToolTip(this.btn_Guncelle, "Güncelle");
            this.btn_Guncelle.UseSelectable = true;
            this.btn_Guncelle.UseTileImage = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click_1);
            this.btn_Guncelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Guncelle_KeyDown);
            // 
            // brn_Sil
            // 
            this.brn_Sil.ActiveControl = null;
            this.brn_Sil.Location = new System.Drawing.Point(577, 124);
            this.brn_Sil.Name = "brn_Sil";
            this.brn_Sil.Size = new System.Drawing.Size(50, 50);
            this.brn_Sil.Style = MetroFramework.MetroColorStyle.Red;
            this.brn_Sil.TabIndex = 63;
            this.brn_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Sil.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.close_circular_button_of_a_cross__1_;
            this.brn_Sil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_taksiDurak.SetToolTip(this.brn_Sil, "Sil");
            this.brn_Sil.UseSelectable = true;
            this.brn_Sil.UseTileImage = true;
            this.brn_Sil.Click += new System.EventHandler(this.brn_Sil_Click);
            this.brn_Sil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brn_Sil_KeyDown);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.ActiveControl = null;
            this.btn_Ekle.Location = new System.Drawing.Point(521, 124);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(50, 50);
            this.btn_Ekle.TabIndex = 62;
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ekle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.plus__1_;
            this.btn_Ekle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_taksiDurak.SetToolTip(this.btn_Ekle, "Ekle");
            this.btn_Ekle.UseSelectable = true;
            this.btn_Ekle.UseTileImage = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click_1);
            this.btn_Ekle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Ekle_KeyDown);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(688, 177);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 19);
            this.metroLabel10.TabIndex = 58;
            this.metroLabel10.Text = "Temizle";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(629, 177);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 59;
            this.metroLabel9.Text = "Güncelle";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(591, 177);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(22, 19);
            this.metroLabel8.TabIndex = 60;
            this.metroLabel8.Text = "Sil";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(528, 177);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 61;
            this.metroLabel4.Text = "Ekle";
            // 
            // tp_taksiDurak
            // 
            this.tp_taksiDurak.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_taksiDurak.StyleManager = null;
            this.tp_taksiDurak.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.hide;
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.eyes;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(689, 102);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(55, 19);
            this.metroLabel11.TabIndex = 89;
            this.metroLabel11.Text = "CTRL+T";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(633, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 88;
            this.metroLabel1.Text = "CTRL+G";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(577, 102);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 87;
            this.metroLabel5.Text = "CTRL+S";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(516, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 86;
            this.metroLabel3.Text = "CTRL+E";
            // 
            // taksiDurak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 502);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.brn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tx_Telefom);
            this.Controls.Add(this.tx_durakAd);
            this.Controls.Add(this.tx_Telefon);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dgv_Duraklar);
            this.Controls.Add(this.tx_Adres);
            this.Controls.Add(this.metroLabel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "taksiDurak";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Taksi Durak İşlemleri";
            this.Load += new System.EventHandler(this.taksiDurak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Duraklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tx_Adres;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid dgv_Duraklar;
        private MetroFramework.Controls.MetroTextBox tx_Telefom;
        private MetroFramework.Controls.MetroTextBox tx_durakAd;
        private MetroFramework.Controls.MetroLabel tx_Telefon;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_Temizle;
        private MetroFramework.Controls.MetroTile btn_Guncelle;
        private MetroFramework.Controls.MetroTile brn_Sil;
        private MetroFramework.Controls.MetroTile btn_Ekle;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Components.MetroToolTip tp_taksiDurak;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}