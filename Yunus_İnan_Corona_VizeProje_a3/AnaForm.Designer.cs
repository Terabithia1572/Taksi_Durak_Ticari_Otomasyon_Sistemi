namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Arac = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_aracHareket = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_taksiDurak = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Personel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_personelTur = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Musteri = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_musteriTur = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Model = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Marka = new System.Windows.Forms.ToolStripButton();
            this.tp_anaForm = new MetroFramework.Components.MetroToolTip();
            this.statusStripDurum = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl_sure = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspgr_Durum = new System.Windows.Forms.ToolStripProgressBar();
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.timerOturum = new System.Windows.Forms.Timer(this.components);
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtn_Sifirla = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStripDurum.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Arac,
            this.tsbtn_aracHareket,
            this.tsbtn_taksiDurak,
            this.tsbtn_Personel,
            this.tsbtn_personelTur,
            this.tsbtn_Musteri,
            this.tsbtn_musteriTur,
            this.tsbtn_Model,
            this.tsbtn_Marka,
            this.tsbtn_Sifirla});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1077, 38);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Arac
            // 
            this.tsbtn_Arac.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Arac.Image")));
            this.tsbtn_Arac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Arac.Name = "tsbtn_Arac";
            this.tsbtn_Arac.Size = new System.Drawing.Size(82, 35);
            this.tsbtn_Arac.Text = "Araç İşlemleri";
            this.tsbtn_Arac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Arac.Click += new System.EventHandler(this.tsbtn_Arac_Click);
            // 
            // tsbtn_aracHareket
            // 
            this.tsbtn_aracHareket.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_aracHareket.Image")));
            this.tsbtn_aracHareket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_aracHareket.Name = "tsbtn_aracHareket";
            this.tsbtn_aracHareket.Size = new System.Drawing.Size(126, 35);
            this.tsbtn_aracHareket.Text = "Araç Hareket İşlemleri";
            this.tsbtn_aracHareket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_aracHareket.Click += new System.EventHandler(this.tsbtn_aracHareket_Click);
            // 
            // tsbtn_taksiDurak
            // 
            this.tsbtn_taksiDurak.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_taksiDurak.Image")));
            this.tsbtn_taksiDurak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_taksiDurak.Name = "tsbtn_taksiDurak";
            this.tsbtn_taksiDurak.Size = new System.Drawing.Size(119, 35);
            this.tsbtn_taksiDurak.Text = "Taksi Durak İşlemleri";
            this.tsbtn_taksiDurak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_taksiDurak.Click += new System.EventHandler(this.tsbtn_taksiDurak_Click);
            // 
            // tsbtn_Personel
            // 
            this.tsbtn_Personel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Personel.Image")));
            this.tsbtn_Personel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Personel.Name = "tsbtn_Personel";
            this.tsbtn_Personel.Size = new System.Drawing.Size(103, 35);
            this.tsbtn_Personel.Text = "Personel İşlemleri";
            this.tsbtn_Personel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Personel.Click += new System.EventHandler(this.tsbtn_Personel_Click);
            // 
            // tsbtn_personelTur
            // 
            this.tsbtn_personelTur.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_personelTur.Image")));
            this.tsbtn_personelTur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_personelTur.Name = "tsbtn_personelTur";
            this.tsbtn_personelTur.Size = new System.Drawing.Size(124, 35);
            this.tsbtn_personelTur.Text = "Personel Tür İşlemleri";
            this.tsbtn_personelTur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_personelTur.Click += new System.EventHandler(this.tsbtn_personelTur_Click);
            // 
            // tsbtn_Musteri
            // 
            this.tsbtn_Musteri.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Musteri.Image")));
            this.tsbtn_Musteri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Musteri.Name = "tsbtn_Musteri";
            this.tsbtn_Musteri.Size = new System.Drawing.Size(98, 35);
            this.tsbtn_Musteri.Text = "Müşteri İşlemleri";
            this.tsbtn_Musteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Musteri.Click += new System.EventHandler(this.tsbtn_Musteri_Click);
            // 
            // tsbtn_musteriTur
            // 
            this.tsbtn_musteriTur.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_musteriTur.Image")));
            this.tsbtn_musteriTur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_musteriTur.Name = "tsbtn_musteriTur";
            this.tsbtn_musteriTur.Size = new System.Drawing.Size(119, 35);
            this.tsbtn_musteriTur.Text = "Müşteri Tür İşlemleri";
            this.tsbtn_musteriTur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_musteriTur.Click += new System.EventHandler(this.tsbtn_musteriTur_Click);
            // 
            // tsbtn_Model
            // 
            this.tsbtn_Model.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Model.Image")));
            this.tsbtn_Model.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Model.Name = "tsbtn_Model";
            this.tsbtn_Model.Size = new System.Drawing.Size(92, 35);
            this.tsbtn_Model.Text = "Model İşlemleri";
            this.tsbtn_Model.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Model.Click += new System.EventHandler(this.tsbtn_Model_Click);
            // 
            // tsbtn_Marka
            // 
            this.tsbtn_Marka.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Marka.Image")));
            this.tsbtn_Marka.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Marka.Name = "tsbtn_Marka";
            this.tsbtn_Marka.Size = new System.Drawing.Size(91, 35);
            this.tsbtn_Marka.Text = "Marka İşlemleri";
            this.tsbtn_Marka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Marka.Click += new System.EventHandler(this.tsbtn_Marka_Click);
            // 
            // tp_anaForm
            // 
            this.tp_anaForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_anaForm.StyleManager = null;
            this.tp_anaForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // statusStripDurum
            // 
            this.statusStripDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslbl_sure,
            this.tspgr_Durum});
            this.statusStripDurum.Location = new System.Drawing.Point(20, 409);
            this.statusStripDurum.Name = "statusStripDurum";
            this.statusStripDurum.Size = new System.Drawing.Size(1077, 22);
            this.statusStripDurum.TabIndex = 10;
            this.statusStripDurum.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Kalan Süre:";
            // 
            // tslbl_sure
            // 
            this.tslbl_sure.Name = "tslbl_sure";
            this.tslbl_sure.Size = new System.Drawing.Size(56, 17);
            this.tslbl_sure.Text = "tslbl_sure";
            // 
            // tspgr_Durum
            // 
            this.tspgr_Durum.Maximum = 1800;
            this.tspgr_Durum.Name = "tspgr_Durum";
            this.tspgr_Durum.Size = new System.Drawing.Size(500, 16);
            this.tspgr_Durum.Value = 1800;
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // timerOturum
            // 
            this.timerOturum.Interval = 5000;
            this.timerOturum.Tick += new System.EventHandler(this.timerOturum_Tick);
            // 
            // notifyIconTaksi
            // 
            this.notifyIconTaksi.ContextMenuStrip = this.metroContextMenu1;
            this.notifyIconTaksi.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTaksi.Icon")));
            this.notifyIconTaksi.Text = "Taksi Durak İşlemleri";
            this.notifyIconTaksi.Visible = true;
            this.notifyIconTaksi.DoubleClick += new System.EventHandler(this.notifyIconanaTaksi_DoubleClick);
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
            // tsbtn_Sifirla
            // 
            this.tsbtn_Sifirla.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Sifirla.Image")));
            this.tsbtn_Sifirla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Sifirla.Name = "tsbtn_Sifirla";
            this.tsbtn_Sifirla.Size = new System.Drawing.Size(83, 35);
            this.tsbtn_Sifirla.Text = "Şifre Sıfırlama";
            this.tsbtn_Sifirla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Sifirla.Click += new System.EventHandler(this.tsbtn_Sifirla_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 451);
            this.Controls.Add(this.statusStripDurum);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Anaform";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStripDurum.ResumeLayout(false);
            this.statusStripDurum.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtn_Marka;
        public System.Windows.Forms.ToolStripButton tsbtn_musteriTur;
        public System.Windows.Forms.ToolStripButton tsbtn_Arac;
        public System.Windows.Forms.ToolStripButton tsbtn_aracHareket;
        public System.Windows.Forms.ToolStripButton tsbtn_taksiDurak;
        public System.Windows.Forms.ToolStripButton tsbtn_Personel;
        public System.Windows.Forms.ToolStripButton tsbtn_personelTur;
        public System.Windows.Forms.ToolStripButton tsbtn_Musteri;
        public System.Windows.Forms.ToolStripButton tsbtn_Model;
        private MetroFramework.Components.MetroToolTip tp_anaForm;
        private System.Windows.Forms.StatusStrip statusStripDurum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_sure;
        private System.Windows.Forms.ToolStripProgressBar tspgr_Durum;
        private System.Windows.Forms.Timer timerSure;
        private System.Windows.Forms.Timer timerOturum;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton tsbtn_Sifirla;
    }
}