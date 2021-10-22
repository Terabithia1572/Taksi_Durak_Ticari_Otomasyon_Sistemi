namespace Yunus_İnan_Corona_VizeProje_a3
{
    partial class mailGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailGonder));
            this.btn_mesajGonder = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tx_Konu = new MetroFramework.Controls.MetroTextBox();
            this.tx_adSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tp_Mail = new MetroFramework.Components.MetroToolTip();
            this.notifyIconTaksi = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mesajGonder
            // 
            this.btn_mesajGonder.ActiveControl = null;
            this.btn_mesajGonder.Location = new System.Drawing.Point(228, 364);
            this.btn_mesajGonder.Name = "btn_mesajGonder";
            this.btn_mesajGonder.Size = new System.Drawing.Size(219, 53);
            this.btn_mesajGonder.TabIndex = 42;
            this.btn_mesajGonder.Text = "Gönder";
            this.btn_mesajGonder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mesajGonder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_mesajGonder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tp_Mail.SetToolTip(this.btn_mesajGonder, "Göndermek İçin Tıklayın..");
            this.btn_mesajGonder.UseSelectable = true;
            this.btn_mesajGonder.Click += new System.EventHandler(this.btn_mesajGonder_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(121, 182);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Mesajınız:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(121, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 143);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "";
            this.tp_Mail.SetToolTip(this.richTextBox1, "Mesajınızı Buraya Yazınız..");
            // 
            // tx_Konu
            // 
            // 
            // 
            // 
            this.tx_Konu.CustomButton.Image = null;
            this.tx_Konu.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.tx_Konu.CustomButton.Name = "";
            this.tx_Konu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Konu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Konu.CustomButton.TabIndex = 1;
            this.tx_Konu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Konu.CustomButton.UseSelectable = true;
            this.tx_Konu.CustomButton.Visible = false;
            this.tx_Konu.Lines = new string[0];
            this.tx_Konu.Location = new System.Drawing.Point(204, 134);
            this.tx_Konu.MaxLength = 32767;
            this.tx_Konu.Name = "tx_Konu";
            this.tx_Konu.PasswordChar = '\0';
            this.tx_Konu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Konu.SelectedText = "";
            this.tx_Konu.SelectionLength = 0;
            this.tx_Konu.SelectionStart = 0;
            this.tx_Konu.ShortcutsEnabled = false;
            this.tx_Konu.Size = new System.Drawing.Size(310, 23);
            this.tx_Konu.TabIndex = 39;
            this.tp_Mail.SetToolTip(this.tx_Konu, "Konu Giriniz");
            this.tx_Konu.UseSelectable = true;
            this.tx_Konu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Konu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tx_adSoyad
            // 
            // 
            // 
            // 
            this.tx_adSoyad.CustomButton.Image = null;
            this.tx_adSoyad.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.tx_adSoyad.CustomButton.Name = "";
            this.tx_adSoyad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_adSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_adSoyad.CustomButton.TabIndex = 1;
            this.tx_adSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_adSoyad.CustomButton.UseSelectable = true;
            this.tx_adSoyad.CustomButton.Visible = false;
            this.tx_adSoyad.Lines = new string[0];
            this.tx_adSoyad.Location = new System.Drawing.Point(204, 83);
            this.tx_adSoyad.MaxLength = 32767;
            this.tx_adSoyad.Name = "tx_adSoyad";
            this.tx_adSoyad.PasswordChar = '\0';
            this.tx_adSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_adSoyad.SelectedText = "";
            this.tx_adSoyad.SelectionLength = 0;
            this.tx_adSoyad.SelectionStart = 0;
            this.tx_adSoyad.ShortcutsEnabled = false;
            this.tx_adSoyad.Size = new System.Drawing.Size(310, 23);
            this.tx_adSoyad.TabIndex = 38;
            this.tp_Mail.SetToolTip(this.tx_adSoyad, "Adınız Soyadınız En az 2 karakterden Oluşmalıdır");
            this.tx_adSoyad.UseSelectable = true;
            this.tx_adSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_adSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tx_adSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_adSoyad_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(79, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Konu:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(79, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Adınız Soyadınız:";
            // 
            // tp_Mail
            // 
            this.tp_Mail.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_Mail.StyleManager = null;
            this.tp_Mail.Theme = MetroFramework.MetroThemeStyle.Light;
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
            // mailGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 432);
            this.Controls.Add(this.btn_mesajGonder);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tx_Konu);
            this.Controls.Add(this.tx_adSoyad);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mailGonder";
            this.Text = "Mail Gönder";
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_mesajGonder;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroTextBox tx_Konu;
        private MetroFramework.Controls.MetroTextBox tx_adSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroToolTip tp_Mail;
        private System.Windows.Forms.NotifyIcon notifyIconTaksi;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}