namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class kullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciGiris));
            this.btn_Giris = new MetroFramework.Controls.MetroTile();
            this.chbx_beniHatirla = new System.Windows.Forms.CheckBox();
            this.chbx_windowsIleBaslama = new MetroFramework.Controls.MetroCheckBox();
            this.lbl_Sifre = new MetroFramework.Controls.MetroLabel();
            this.lbl_Telefon = new MetroFramework.Controls.MetroLabel();
            this.chbx_sifreGoster = new MetroFramework.Controls.MetroCheckBox();
            this.btn_sifremiUnuttum = new MetroFramework.Controls.MetroButton();
            this.tx_sifre = new MetroFramework.Controls.MetroTextBox();
            this.tx_tcNo = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mailGonder = new MetroFramework.Controls.MetroButton();
            this.btn_yarisOyunu = new MetroFramework.Controls.MetroButton();
            this.btn_Yilan = new MetroFramework.Controls.MetroButton();
            this.btn_Radyo = new MetroFramework.Controls.MetroButton();
            this.tp_kullanici = new MetroFramework.Components.MetroToolTip();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_Tarih = new MetroFramework.Controls.MetroLabel();
            this.lbl_Saat = new MetroFramework.Controls.MetroLabel();
            this.timersaatTarih = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.ActiveControl = null;
            this.btn_Giris.Location = new System.Drawing.Point(154, 342);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(280, 53);
            this.btn_Giris.TabIndex = 42;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Giris.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Giris.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tp_kullanici.SetToolTip(this.btn_Giris, "Giriş Yapmak İçin Tıklayın");
            this.btn_Giris.UseSelectable = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // chbx_beniHatirla
            // 
            this.chbx_beniHatirla.AutoSize = true;
            this.chbx_beniHatirla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_beniHatirla.Location = new System.Drawing.Point(451, 293);
            this.chbx_beniHatirla.Name = "chbx_beniHatirla";
            this.chbx_beniHatirla.Size = new System.Drawing.Size(83, 17);
            this.chbx_beniHatirla.TabIndex = 39;
            this.chbx_beniHatirla.Text = "Beni Hatırla:";
            this.tp_kullanici.SetToolTip(this.chbx_beniHatirla, "Beni Hatırla");
            this.chbx_beniHatirla.UseVisualStyleBackColor = true;
            // 
            // chbx_windowsIleBaslama
            // 
            this.chbx_windowsIleBaslama.AutoSize = true;
            this.chbx_windowsIleBaslama.Location = new System.Drawing.Point(429, 53);
            this.chbx_windowsIleBaslama.Name = "chbx_windowsIleBaslama";
            this.chbx_windowsIleBaslama.Size = new System.Drawing.Size(132, 15);
            this.chbx_windowsIleBaslama.TabIndex = 37;
            this.chbx_windowsIleBaslama.Text = "Windows ile başlasın";
            this.tp_kullanici.SetToolTip(this.chbx_windowsIleBaslama, "Bilgisayar Başlarken Bu Uygulamada Açılır");
            this.chbx_windowsIleBaslama.UseSelectable = true;
            this.chbx_windowsIleBaslama.CheckedChanged += new System.EventHandler(this.chbx_windowsIleBaslama_CheckedChanged);
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(154, 246);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(38, 19);
            this.lbl_Sifre.TabIndex = 35;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(154, 194);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(82, 19);
            this.lbl_Telefon.TabIndex = 34;
            this.lbl_Telefon.Text = "Kullanıcı Adı:";
            // 
            // chbx_sifreGoster
            // 
            this.chbx_sifreGoster.AutoSize = true;
            this.chbx_sifreGoster.Location = new System.Drawing.Point(154, 304);
            this.chbx_sifreGoster.Name = "chbx_sifreGoster";
            this.chbx_sifreGoster.Size = new System.Drawing.Size(92, 15);
            this.chbx_sifreGoster.TabIndex = 43;
            this.chbx_sifreGoster.Text = "Şifreyi Göster";
            this.tp_kullanici.SetToolTip(this.chbx_sifreGoster, "Şifreyi Gösterir");
            this.chbx_sifreGoster.UseSelectable = true;
            this.chbx_sifreGoster.CheckedChanged += new System.EventHandler(this.chbx_sifre_CheckedChanged);
            // 
            // btn_sifremiUnuttum
            // 
            this.btn_sifremiUnuttum.Location = new System.Drawing.Point(321, 303);
            this.btn_sifremiUnuttum.Name = "btn_sifremiUnuttum";
            this.btn_sifremiUnuttum.Size = new System.Drawing.Size(113, 32);
            this.btn_sifremiUnuttum.TabIndex = 44;
            this.btn_sifremiUnuttum.Text = "Şifremi Unuttum ?";
            this.tp_kullanici.SetToolTip(this.btn_sifremiUnuttum, "Şifremi Unuttum Açmak İçin Tıklayın");
            this.btn_sifremiUnuttum.UseSelectable = true;
            this.btn_sifremiUnuttum.Click += new System.EventHandler(this.btn_sifremiUnuttum_Click);
            // 
            // tx_sifre
            // 
            // 
            // 
            // 
            this.tx_sifre.CustomButton.Image = null;
            this.tx_sifre.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.tx_sifre.CustomButton.Name = "";
            this.tx_sifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_sifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_sifre.CustomButton.TabIndex = 1;
            this.tx_sifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_sifre.CustomButton.UseSelectable = true;
            this.tx_sifre.CustomButton.Visible = false;
            this.tx_sifre.DisplayIcon = true;
            this.tx_sifre.Icon = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.lock1;
            this.tx_sifre.Lines = new string[0];
            this.tx_sifre.Location = new System.Drawing.Point(154, 271);
            this.tx_sifre.MaxLength = 32767;
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '\0';
            this.tx_sifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_sifre.SelectedText = "";
            this.tx_sifre.SelectionLength = 0;
            this.tx_sifre.SelectionStart = 0;
            this.tx_sifre.ShortcutsEnabled = true;
            this.tx_sifre.Size = new System.Drawing.Size(280, 26);
            this.tx_sifre.TabIndex = 41;
            this.tp_kullanici.SetToolTip(this.tx_sifre, "Şifre En Az 6 Karakter");
            this.tx_sifre.UseSelectable = true;
            this.tx_sifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_sifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tx_tcNo
            // 
            // 
            // 
            // 
            this.tx_tcNo.CustomButton.Image = null;
            this.tx_tcNo.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.tx_tcNo.CustomButton.Name = "";
            this.tx_tcNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_tcNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_tcNo.CustomButton.TabIndex = 1;
            this.tx_tcNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_tcNo.CustomButton.UseSelectable = true;
            this.tx_tcNo.CustomButton.Visible = false;
            this.tx_tcNo.DisplayIcon = true;
            this.tx_tcNo.Icon = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.man_user01;
            this.tx_tcNo.Lines = new string[0];
            this.tx_tcNo.Location = new System.Drawing.Point(154, 221);
            this.tx_tcNo.MaxLength = 32767;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.PasswordChar = '\0';
            this.tx_tcNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_tcNo.SelectedText = "";
            this.tx_tcNo.SelectionLength = 0;
            this.tx_tcNo.SelectionStart = 0;
            this.tx_tcNo.ShortcutsEnabled = true;
            this.tx_tcNo.Size = new System.Drawing.Size(280, 26);
            this.tx_tcNo.TabIndex = 40;
            this.tp_kullanici.SetToolTip(this.tx_tcNo, "Kullanıcı Adı Yazarak Giriş Yapılmalı");
            this.tx_tcNo.UseSelectable = true;
            this.tx_tcNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_tcNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(183, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btn_mailGonder
            // 
            this.btn_mailGonder.Location = new System.Drawing.Point(451, 246);
            this.btn_mailGonder.Name = "btn_mailGonder";
            this.btn_mailGonder.Size = new System.Drawing.Size(113, 32);
            this.btn_mailGonder.TabIndex = 45;
            this.btn_mailGonder.Text = "Mail Gönder";
            this.tp_kullanici.SetToolTip(this.btn_mailGonder, "Mail Gönderir");
            this.btn_mailGonder.UseSelectable = true;
            this.btn_mailGonder.Click += new System.EventHandler(this.btn_mailGonder_Click);
            // 
            // btn_yarisOyunu
            // 
            this.btn_yarisOyunu.Location = new System.Drawing.Point(451, 328);
            this.btn_yarisOyunu.Name = "btn_yarisOyunu";
            this.btn_yarisOyunu.Size = new System.Drawing.Size(113, 32);
            this.btn_yarisOyunu.TabIndex = 46;
            this.btn_yarisOyunu.Text = "Araba Yarış Oyunu";
            this.tp_kullanici.SetToolTip(this.btn_yarisOyunu, "Araba Yarış Oyununu Açar");
            this.btn_yarisOyunu.UseSelectable = true;
            this.btn_yarisOyunu.Click += new System.EventHandler(this.btn_yarisOyunu_Click);
            // 
            // btn_Yilan
            // 
            this.btn_Yilan.Location = new System.Drawing.Point(451, 366);
            this.btn_Yilan.Name = "btn_Yilan";
            this.btn_Yilan.Size = new System.Drawing.Size(113, 32);
            this.btn_Yilan.TabIndex = 47;
            this.btn_Yilan.Text = "Yılan Oyunu";
            this.tp_kullanici.SetToolTip(this.btn_Yilan, "Yılan Oyununu Açar");
            this.btn_Yilan.UseSelectable = true;
            this.btn_Yilan.Click += new System.EventHandler(this.btn_Yilan_Click);
            // 
            // btn_Radyo
            // 
            this.btn_Radyo.Location = new System.Drawing.Point(451, 194);
            this.btn_Radyo.Name = "btn_Radyo";
            this.btn_Radyo.Size = new System.Drawing.Size(113, 32);
            this.btn_Radyo.TabIndex = 48;
            this.btn_Radyo.Text = "Radyo Dinle";
            this.tp_kullanici.SetToolTip(this.btn_Radyo, "Radyo\'yu Açar");
            this.btn_Radyo.UseSelectable = true;
            this.btn_Radyo.Click += new System.EventHandler(this.btn_Radyo_Click);
            // 
            // tp_kullanici
            // 
            this.tp_kullanici.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_kullanici.StyleManager = null;
            this.tp_kullanici.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(153, 92);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.show;
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.hide;
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.eyes;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
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
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(474, 104);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(0, 0);
            this.lbl_Tarih.TabIndex = 49;
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.AutoSize = true;
            this.lbl_Saat.Location = new System.Drawing.Point(474, 137);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(0, 0);
            this.lbl_Saat.TabIndex = 50;
            // 
            // timersaatTarih
            // 
            this.timersaatTarih.Interval = 1000;
            this.timersaatTarih.Tick += new System.EventHandler(this.timersaatTarih_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(429, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 52;
            this.metroLabel1.Text = "Saat:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(429, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Tarih:";
            // 
            // kullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbl_Saat);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.btn_Radyo);
            this.Controls.Add(this.btn_Yilan);
            this.Controls.Add(this.btn_yarisOyunu);
            this.Controls.Add(this.btn_mailGonder);
            this.Controls.Add(this.btn_sifremiUnuttum);
            this.Controls.Add(this.chbx_sifreGoster);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_tcNo);
            this.Controls.Add(this.chbx_beniHatirla);
            this.Controls.Add(this.chbx_windowsIleBaslama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Telefon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullaniciGiris";
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kullaniciGiris_FormClosing);
            this.Load += new System.EventHandler(this.kullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_Giris;
        private MetroFramework.Controls.MetroTextBox tx_sifre;
        public MetroFramework.Controls.MetroTextBox tx_tcNo;
        private System.Windows.Forms.CheckBox chbx_beniHatirla;
        private MetroFramework.Controls.MetroCheckBox chbx_windowsIleBaslama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lbl_Sifre;
        private MetroFramework.Controls.MetroLabel lbl_Telefon;
        private MetroFramework.Controls.MetroCheckBox chbx_sifreGoster;
        private MetroFramework.Controls.MetroButton btn_sifremiUnuttum;
        private MetroFramework.Controls.MetroButton btn_mailGonder;
        private MetroFramework.Controls.MetroButton btn_yarisOyunu;
        private MetroFramework.Controls.MetroButton btn_Yilan;
        private MetroFramework.Controls.MetroButton btn_Radyo;
        private MetroFramework.Components.MetroToolTip tp_kullanici;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroLabel lbl_Tarih;
        private MetroFramework.Controls.MetroLabel lbl_Saat;
        private System.Windows.Forms.Timer timersaatTarih;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}