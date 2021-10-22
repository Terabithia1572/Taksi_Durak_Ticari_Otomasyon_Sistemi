namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class Radyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radyo));
            this.btn_kralFm = new MetroFramework.Controls.MetroButton();
            this.btn_trtFM = new MetroFramework.Controls.MetroButton();
            this.btn_Power = new MetroFramework.Controls.MetroButton();
            this.btn_superFM = new MetroFramework.Controls.MetroButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_kapat = new MetroFramework.Controls.MetroButton();
            this.btn_slowTurk = new MetroFramework.Controls.MetroButton();
            this.btn_bestFM = new MetroFramework.Controls.MetroButton();
            this.tp_Radyo = new MetroFramework.Components.MetroToolTip();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kralFm
            // 
            this.btn_kralFm.Location = new System.Drawing.Point(55, 86);
            this.btn_kralFm.Name = "btn_kralFm";
            this.btn_kralFm.Size = new System.Drawing.Size(112, 31);
            this.btn_kralFm.TabIndex = 0;
            this.btn_kralFm.Text = "Kral Fm";
            this.tp_Radyo.SetToolTip(this.btn_kralFm, "Kral FM Radyosunu Oynatır");
            this.btn_kralFm.UseSelectable = true;
            this.btn_kralFm.Click += new System.EventHandler(this.btn_kralFm_Click);
            // 
            // btn_trtFM
            // 
            this.btn_trtFM.Location = new System.Drawing.Point(55, 140);
            this.btn_trtFM.Name = "btn_trtFM";
            this.btn_trtFM.Size = new System.Drawing.Size(112, 31);
            this.btn_trtFM.TabIndex = 1;
            this.btn_trtFM.Text = "TRT Fm";
            this.tp_Radyo.SetToolTip(this.btn_trtFM, "TRT FM  Radyosunu Oynatır");
            this.btn_trtFM.UseSelectable = true;
            this.btn_trtFM.Click += new System.EventHandler(this.btn_trtFM_Click);
            // 
            // btn_Power
            // 
            this.btn_Power.Location = new System.Drawing.Point(55, 199);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(112, 31);
            this.btn_Power.TabIndex = 2;
            this.btn_Power.Text = "PowerTürk FM";
            this.tp_Radyo.SetToolTip(this.btn_Power, "PowerTürk  Radyosunu Oynatır");
            this.btn_Power.UseSelectable = true;
            this.btn_Power.Click += new System.EventHandler(this.btn_Power_Click);
            // 
            // btn_superFM
            // 
            this.btn_superFM.Location = new System.Drawing.Point(55, 258);
            this.btn_superFM.Name = "btn_superFM";
            this.btn_superFM.Size = new System.Drawing.Size(112, 31);
            this.btn_superFM.TabIndex = 3;
            this.btn_superFM.Text = "Süper FM";
            this.tp_Radyo.SetToolTip(this.btn_superFM, "Süper FM  Radyosunu Oynatır");
            this.btn_superFM.UseSelectable = true;
            this.btn_superFM.Click += new System.EventHandler(this.btn_superFM_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(55, 304);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(486, 44);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.tp_Radyo.SetToolTip(this.axWindowsMediaPlayer1, "Oynatıcı");
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(429, 86);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(112, 31);
            this.btn_kapat.TabIndex = 5;
            this.btn_kapat.Text = "Kapat";
            this.tp_Radyo.SetToolTip(this.btn_kapat, "Kapat");
            this.btn_kapat.UseSelectable = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_slowTurk
            // 
            this.btn_slowTurk.Location = new System.Drawing.Point(234, 86);
            this.btn_slowTurk.Name = "btn_slowTurk";
            this.btn_slowTurk.Size = new System.Drawing.Size(112, 31);
            this.btn_slowTurk.TabIndex = 6;
            this.btn_slowTurk.Text = "Slow Türk";
            this.tp_Radyo.SetToolTip(this.btn_slowTurk, "Slow Türk Radyosunu Oynatır");
            this.btn_slowTurk.UseSelectable = true;
            this.btn_slowTurk.Click += new System.EventHandler(this.btn_slowTurk_Click);
            // 
            // btn_bestFM
            // 
            this.btn_bestFM.Location = new System.Drawing.Point(234, 140);
            this.btn_bestFM.Name = "btn_bestFM";
            this.btn_bestFM.Size = new System.Drawing.Size(112, 31);
            this.btn_bestFM.TabIndex = 7;
            this.btn_bestFM.Text = "Best FM";
            this.tp_Radyo.SetToolTip(this.btn_bestFM, "Best FM  Radyosunu Oynatır");
            this.btn_bestFM.UseSelectable = true;
            this.btn_bestFM.Click += new System.EventHandler(this.btn_bestFM_Click);
            // 
            // tp_Radyo
            // 
            this.tp_Radyo.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_Radyo.StyleManager = null;
            this.tp_Radyo.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.metroContextMenu1.Size = new System.Drawing.Size(153, 92);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 90);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Radyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_bestFM);
            this.Controls.Add(this.btn_slowTurk);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btn_superFM);
            this.Controls.Add(this.btn_Power);
            this.Controls.Add(this.btn_trtFM);
            this.Controls.Add(this.btn_kralFm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Radyo";
            this.Text = "Radyo";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_kralFm;
        private MetroFramework.Controls.MetroButton btn_trtFM;
        private MetroFramework.Controls.MetroButton btn_Power;
        private MetroFramework.Controls.MetroButton btn_superFM;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MetroFramework.Controls.MetroButton btn_kapat;
        private MetroFramework.Controls.MetroButton btn_slowTurk;
        private MetroFramework.Controls.MetroButton btn_bestFM;
        private MetroFramework.Components.MetroToolTip tp_Radyo;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}