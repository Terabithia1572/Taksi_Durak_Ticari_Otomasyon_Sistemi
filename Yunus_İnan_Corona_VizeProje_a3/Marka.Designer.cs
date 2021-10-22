namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class Marka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marka));
            this.tx_Marka = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgv_Markalar = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Temizle = new MetroFramework.Controls.MetroTile();
            this.btn_Guncelle = new MetroFramework.Controls.MetroTile();
            this.brn_Sil = new MetroFramework.Controls.MetroTile();
            this.btn_Ekle = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tp_Marka = new MetroFramework.Components.MetroToolTip();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Markalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_Marka
            // 
            // 
            // 
            // 
            this.tx_Marka.CustomButton.Image = null;
            this.tx_Marka.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tx_Marka.CustomButton.Name = "";
            this.tx_Marka.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Marka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Marka.CustomButton.TabIndex = 1;
            this.tx_Marka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Marka.CustomButton.UseSelectable = true;
            this.tx_Marka.CustomButton.Visible = false;
            this.tx_Marka.Lines = new string[0];
            this.tx_Marka.Location = new System.Drawing.Point(108, 101);
            this.tx_Marka.MaxLength = 25;
            this.tx_Marka.Name = "tx_Marka";
            this.tx_Marka.PasswordChar = '\0';
            this.tx_Marka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Marka.SelectedText = "";
            this.tx_Marka.SelectionLength = 0;
            this.tx_Marka.SelectionStart = 0;
            this.tx_Marka.ShortcutsEnabled = false;
            this.tx_Marka.Size = new System.Drawing.Size(116, 23);
            this.tx_Marka.TabIndex = 8;
            this.tp_Marka.SetToolTip(this.tx_Marka, "Marka Adını Giriniz En az 2 Karakter");
            this.tx_Marka.UseSelectable = true;
            this.tx_Marka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Marka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_Marka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Marka_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Marka:";
            // 
            // dgv_Markalar
            // 
            this.dgv_Markalar.AllowUserToAddRows = false;
            this.dgv_Markalar.AllowUserToDeleteRows = false;
            this.dgv_Markalar.AllowUserToResizeRows = false;
            this.dgv_Markalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Markalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Markalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Markalar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Markalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_Markalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Markalar.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Markalar.EnableHeadersVisualStyles = false;
            this.dgv_Markalar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Markalar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Markalar.Location = new System.Drawing.Point(53, 230);
            this.dgv_Markalar.MultiSelect = false;
            this.dgv_Markalar.Name = "dgv_Markalar";
            this.dgv_Markalar.ReadOnly = true;
            this.dgv_Markalar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Markalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Markalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Markalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Markalar.Size = new System.Drawing.Size(221, 108);
            this.dgv_Markalar.TabIndex = 27;
            this.tp_Marka.SetToolTip(this.dgv_Markalar, "Marka Listesini Gösterir");
            this.dgv_Markalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Markalar_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.uber;
            this.pictureBox1.Location = new System.Drawing.Point(369, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.ActiveControl = null;
            this.btn_Temizle.Location = new System.Drawing.Point(505, 192);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(50, 50);
            this.btn_Temizle.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Temizle.TabIndex = 81;
            this.btn_Temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Temizle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.dry_clean__1_;
            this.btn_Temizle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Marka.SetToolTip(this.btn_Temizle, "Temizle");
            this.btn_Temizle.UseSelectable = true;
            this.btn_Temizle.UseTileImage = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click_1);
            this.btn_Temizle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Temizle_KeyDown);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.ActiveControl = null;
            this.btn_Guncelle.Location = new System.Drawing.Point(449, 192);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(50, 50);
            this.btn_Guncelle.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Guncelle.TabIndex = 80;
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guncelle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.rotate__1_;
            this.btn_Guncelle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Marka.SetToolTip(this.btn_Guncelle, "Güncelle");
            this.btn_Guncelle.UseSelectable = true;
            this.btn_Guncelle.UseTileImage = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click_1);
            this.btn_Guncelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Guncelle_KeyDown);
            // 
            // brn_Sil
            // 
            this.brn_Sil.ActiveControl = null;
            this.brn_Sil.Location = new System.Drawing.Point(393, 192);
            this.brn_Sil.Name = "brn_Sil";
            this.brn_Sil.Size = new System.Drawing.Size(50, 50);
            this.brn_Sil.Style = MetroFramework.MetroColorStyle.Red;
            this.brn_Sil.TabIndex = 79;
            this.brn_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Sil.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.close_circular_button_of_a_cross__1_;
            this.brn_Sil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Marka.SetToolTip(this.brn_Sil, "Sil");
            this.brn_Sil.UseSelectable = true;
            this.brn_Sil.UseTileImage = true;
            this.brn_Sil.Click += new System.EventHandler(this.brn_Sil_Click);
            this.brn_Sil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brn_Sil_KeyDown);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.ActiveControl = null;
            this.btn_Ekle.Location = new System.Drawing.Point(337, 192);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(50, 50);
            this.btn_Ekle.TabIndex = 78;
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ekle.TileImage = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.plus__1_;
            this.btn_Ekle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp_Marka.SetToolTip(this.btn_Ekle, "Ekle");
            this.btn_Ekle.UseSelectable = true;
            this.btn_Ekle.UseTileImage = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click_1);
            this.btn_Ekle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Ekle_KeyDown);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(504, 245);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 19);
            this.metroLabel10.TabIndex = 74;
            this.metroLabel10.Text = "Temizle";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(445, 245);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 75;
            this.metroLabel9.Text = "Güncelle";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(407, 245);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(22, 19);
            this.metroLabel8.TabIndex = 76;
            this.metroLabel8.Text = "Sil";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(344, 245);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 77;
            this.metroLabel4.Text = "Ekle";
            // 
            // tp_Marka
            // 
            this.tp_Marka.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_Marka.StyleManager = null;
            this.tp_Marka.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.metroLabel11.Location = new System.Drawing.Point(508, 170);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(55, 19);
            this.metroLabel11.TabIndex = 89;
            this.metroLabel11.Text = "CTRL+T";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(452, 170);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 88;
            this.metroLabel6.Text = "CTRL+G";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(396, 170);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 87;
            this.metroLabel5.Text = "CTRL+S";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(335, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 86;
            this.metroLabel3.Text = "CTRL+E";
            // 
            // Marka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 378);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.brn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_Markalar);
            this.Controls.Add(this.tx_Marka);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Marka";
            this.Text = "Marka İşlemleri";
            this.tp_Marka.SetToolTip(this, "Marka İşlemleri");
            this.Load += new System.EventHandler(this.Marka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Markalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tx_Marka;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgv_Markalar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_Temizle;
        private MetroFramework.Controls.MetroTile btn_Guncelle;
        private MetroFramework.Controls.MetroTile brn_Sil;
        private MetroFramework.Controls.MetroTile btn_Ekle;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Components.MetroToolTip tp_Marka;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}