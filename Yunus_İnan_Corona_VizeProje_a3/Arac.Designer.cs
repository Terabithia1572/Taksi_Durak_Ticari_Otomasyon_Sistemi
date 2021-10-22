namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class Arac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arac));
            this.tx_Plaka = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbx_Model = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbx_taksiDurak = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgv_Araclar = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Temizle = new MetroFramework.Controls.MetroTile();
            this.btn_Guncelle = new MetroFramework.Controls.MetroTile();
            this.brn_Sil = new MetroFramework.Controls.MetroTile();
            this.btn_Ekle = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tp_Arac = new MetroFramework.Components.MetroToolTip();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Araclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_Plaka
            // 
            // 
            // 
            // 
            this.tx_Plaka.CustomButton.Image = null;
            this.tx_Plaka.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_Plaka.CustomButton.Name = "";
            this.tx_Plaka.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Plaka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Plaka.CustomButton.TabIndex = 1;
            this.tx_Plaka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Plaka.CustomButton.UseSelectable = true;
            this.tx_Plaka.CustomButton.Visible = false;
            this.tx_Plaka.Lines = new string[0];
            this.tx_Plaka.Location = new System.Drawing.Point(127, 123);
            this.tx_Plaka.MaxLength = 25;
            this.tx_Plaka.Name = "tx_Plaka";
            this.tx_Plaka.PasswordChar = '\0';
            this.tx_Plaka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Plaka.SelectedText = "";
            this.tx_Plaka.SelectionLength = 0;
            this.tx_Plaka.SelectionStart = 0;
            this.tx_Plaka.ShortcutsEnabled = false;
            this.tx_Plaka.Size = new System.Drawing.Size(116, 23);
            this.tx_Plaka.TabIndex = 24;
            this.tp_Arac.SetToolTip(this.tx_Plaka, "Plaka Giriniz En Fazla 8 KArakter");
            this.tx_Plaka.UseSelectable = true;
            this.tx_Plaka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Plaka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(69, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Plaka:";
            // 
            // cbx_Model
            // 
            this.cbx_Model.FormattingEnabled = true;
            this.cbx_Model.ItemHeight = 23;
            this.cbx_Model.Location = new System.Drawing.Point(127, 169);
            this.cbx_Model.Name = "cbx_Model";
            this.cbx_Model.Size = new System.Drawing.Size(121, 29);
            this.cbx_Model.TabIndex = 26;
            this.tp_Arac.SetToolTip(this.cbx_Model, "Model Seçiniz..");
            this.cbx_Model.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(62, 169);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Model:";
            // 
            // cbx_taksiDurak
            // 
            this.cbx_taksiDurak.FormattingEnabled = true;
            this.cbx_taksiDurak.ItemHeight = 23;
            this.cbx_taksiDurak.Location = new System.Drawing.Point(144, 217);
            this.cbx_taksiDurak.Name = "cbx_taksiDurak";
            this.cbx_taksiDurak.Size = new System.Drawing.Size(308, 29);
            this.cbx_taksiDurak.TabIndex = 28;
            this.tp_Arac.SetToolTip(this.cbx_taksiDurak, "Taksi Durak Seçiniz..");
            this.cbx_taksiDurak.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 217);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Taksi Durak:";
            // 
            // dgv_Araclar
            // 
            this.dgv_Araclar.AllowUserToAddRows = false;
            this.dgv_Araclar.AllowUserToDeleteRows = false;
            this.dgv_Araclar.AllowUserToResizeRows = false;
            this.dgv_Araclar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Araclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Araclar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Araclar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Araclar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Araclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Araclar.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Araclar.EnableHeadersVisualStyles = false;
            this.dgv_Araclar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Araclar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Araclar.Location = new System.Drawing.Point(23, 343);
            this.dgv_Araclar.Name = "dgv_Araclar";
            this.dgv_Araclar.ReadOnly = true;
            this.dgv_Araclar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Araclar.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Araclar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Araclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Araclar.Size = new System.Drawing.Size(709, 150);
            this.dgv_Araclar.TabIndex = 29;
            this.tp_Arac.SetToolTip(this.dgv_Araclar, "Araç Listesini Gösterir..");
            this.dgv_Araclar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Araclar_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.carIslem;
            this.pictureBox1.Location = new System.Drawing.Point(404, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.ActiveControl = null;
            this.btn_Temizle.Location = new System.Drawing.Point(683, 236);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(50, 50);
            this.btn_Temizle.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Temizle.TabIndex = 81;
            this.btn_Temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Temizle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.dry_clean__1_;
            this.btn_Temizle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Arac.SetToolTip(this.btn_Temizle, "Temizle");
            this.btn_Temizle.UseSelectable = true;
            this.btn_Temizle.UseTileImage = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            this.btn_Temizle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Temizle_KeyDown);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.ActiveControl = null;
            this.btn_Guncelle.Location = new System.Drawing.Point(627, 236);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(50, 50);
            this.btn_Guncelle.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Guncelle.TabIndex = 80;
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guncelle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.rotate__1_;
            this.btn_Guncelle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Arac.SetToolTip(this.btn_Guncelle, "Güncelle");
            this.btn_Guncelle.UseSelectable = true;
            this.btn_Guncelle.UseTileImage = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            this.btn_Guncelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Guncelle_KeyDown);
            // 
            // brn_Sil
            // 
            this.brn_Sil.ActiveControl = null;
            this.brn_Sil.Location = new System.Drawing.Point(571, 236);
            this.brn_Sil.Name = "brn_Sil";
            this.brn_Sil.Size = new System.Drawing.Size(50, 50);
            this.brn_Sil.Style = MetroFramework.MetroColorStyle.Red;
            this.brn_Sil.TabIndex = 79;
            this.brn_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Sil.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.close_circular_button_of_a_cross__1_;
            this.brn_Sil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Arac.SetToolTip(this.brn_Sil, "Sil");
            this.brn_Sil.UseSelectable = true;
            this.brn_Sil.UseTileImage = true;
            this.brn_Sil.Click += new System.EventHandler(this.brn_Sil_Click);
            this.brn_Sil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brn_Sil_KeyDown);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.ActiveControl = null;
            this.btn_Ekle.Location = new System.Drawing.Point(515, 236);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(50, 50);
            this.btn_Ekle.TabIndex = 78;
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ekle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.plus__1_;
            this.btn_Ekle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Arac.SetToolTip(this.btn_Ekle, "Ekle");
            this.btn_Ekle.UseSelectable = true;
            this.btn_Ekle.UseTileImage = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click_1);
            this.btn_Ekle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Ekle_KeyDown);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(682, 289);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 19);
            this.metroLabel10.TabIndex = 74;
            this.metroLabel10.Text = "Temizle";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(623, 289);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 75;
            this.metroLabel9.Text = "Güncelle";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(585, 289);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(22, 19);
            this.metroLabel8.TabIndex = 76;
            this.metroLabel8.Text = "Sil";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(522, 289);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 77;
            this.metroLabel4.Text = "Ekle";
            // 
            // tp_Arac
            // 
            this.tp_Arac.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_Arac.StyleManager = null;
            this.tp_Arac.Theme = MetroFramework.MetroThemeStyle.Light;
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(510, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 82;
            this.metroLabel3.Text = "CTRL+E";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(571, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 83;
            this.metroLabel5.Text = "CTRL+S";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(627, 214);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 84;
            this.metroLabel6.Text = "CTRL+G";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(683, 214);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(55, 19);
            this.metroLabel11.TabIndex = 85;
            this.metroLabel11.Text = "CTRL+T";
            // 
            // Arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 503);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel6);
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
            this.Controls.Add(this.dgv_Araclar);
            this.Controls.Add(this.cbx_taksiDurak);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbx_Model);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tx_Plaka);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arac";
            this.Text = "Araç İşlemleri";
            this.Load += new System.EventHandler(this.Arac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Araclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tx_Plaka;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbx_Model;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbx_taksiDurak;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgv_Araclar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_Temizle;
        private MetroFramework.Controls.MetroTile btn_Guncelle;
        private MetroFramework.Controls.MetroTile brn_Sil;
        private MetroFramework.Controls.MetroTile btn_Ekle;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Components.MetroToolTip tp_Arac;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}