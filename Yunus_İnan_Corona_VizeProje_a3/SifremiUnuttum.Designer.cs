namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.btn_Gondera = new MetroFramework.Controls.MetroButton();
            this.tx_ep = new MetroFramework.Controls.MetroTextBox();
            this.tx_ka = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tp_sifremiUnuttum = new MetroFramework.Components.MetroToolTip();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Gondera
            // 
            this.btn_Gondera.Location = new System.Drawing.Point(201, 196);
            this.btn_Gondera.Name = "btn_Gondera";
            this.btn_Gondera.Size = new System.Drawing.Size(75, 23);
            this.btn_Gondera.TabIndex = 9;
            this.btn_Gondera.Text = "Gönder";
            this.btn_Gondera.UseSelectable = true;
            this.btn_Gondera.Click += new System.EventHandler(this.btn_Gondera_Click);
            // 
            // tx_ep
            // 
            // 
            // 
            // 
            this.tx_ep.CustomButton.Image = null;
            this.tx_ep.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.tx_ep.CustomButton.Name = "";
            this.tx_ep.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_ep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_ep.CustomButton.TabIndex = 1;
            this.tx_ep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_ep.CustomButton.UseSelectable = true;
            this.tx_ep.CustomButton.Visible = false;
            this.tx_ep.Lines = new string[0];
            this.tx_ep.Location = new System.Drawing.Point(201, 133);
            this.tx_ep.MaxLength = 32767;
            this.tx_ep.Name = "tx_ep";
            this.tx_ep.PasswordChar = '\0';
            this.tx_ep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_ep.SelectedText = "";
            this.tx_ep.SelectionLength = 0;
            this.tx_ep.SelectionStart = 0;
            this.tx_ep.ShortcutsEnabled = true;
            this.tx_ep.Size = new System.Drawing.Size(103, 23);
            this.tx_ep.TabIndex = 8;
            this.tp_sifremiUnuttum.SetToolTip(this.tx_ep, "Sistemde Kayıtlı olan E-Posta Adresini Giriniz..");
            this.tx_ep.UseSelectable = true;
            this.tx_ep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_ep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tx_ka
            // 
            // 
            // 
            // 
            this.tx_ka.CustomButton.Image = null;
            this.tx_ka.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.tx_ka.CustomButton.Name = "";
            this.tx_ka.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_ka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_ka.CustomButton.TabIndex = 1;
            this.tx_ka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_ka.CustomButton.UseSelectable = true;
            this.tx_ka.CustomButton.Visible = false;
            this.tx_ka.Lines = new string[0];
            this.tx_ka.Location = new System.Drawing.Point(201, 95);
            this.tx_ka.MaxLength = 32767;
            this.tx_ka.Name = "tx_ka";
            this.tx_ka.PasswordChar = '\0';
            this.tx_ka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_ka.SelectedText = "";
            this.tx_ka.SelectionLength = 0;
            this.tx_ka.SelectionStart = 0;
            this.tx_ka.ShortcutsEnabled = true;
            this.tx_ka.Size = new System.Drawing.Size(103, 23);
            this.tx_ka.TabIndex = 7;
            this.tp_sifremiUnuttum.SetToolTip(this.tx_ka, "Sistemde Kayıtlı Olan Kullanıcı Adını Giriniz..");
            this.tx_ka.UseSelectable = true;
            this.tx_ka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_ka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(98, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "E-Posta:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(98, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            // 
            // tp_sifremiUnuttum
            // 
            this.tp_sifremiUnuttum.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_sifremiUnuttum.StyleManager = null;
            this.tp_sifremiUnuttum.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.pictureBox1.Image = global::Yunus_İnan_Corona_VizeProje_a3.Properties.Resources.sifremiUnuttum;
            this.pictureBox1.Location = new System.Drawing.Point(336, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Gondera);
            this.Controls.Add(this.tx_ep);
            this.Controls.Add(this.tx_ka);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremiUnuttum";
            this.Text = "Şifremi Unuttum";
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Gondera;
        private MetroFramework.Controls.MetroTextBox tx_ep;
        private MetroFramework.Controls.MetroTextBox tx_ka;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroToolTip tp_sifremiUnuttum;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}