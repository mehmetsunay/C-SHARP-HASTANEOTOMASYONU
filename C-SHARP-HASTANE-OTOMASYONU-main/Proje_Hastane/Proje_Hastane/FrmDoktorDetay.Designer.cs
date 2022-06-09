namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            this.grp_dbilgi = new System.Windows.Forms.GroupBox();
            this.lbl_isimgoster = new System.Windows.Forms.Label();
            this.lbl_tcnum = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.gbox_randevu = new System.Windows.Forms.GroupBox();
            this.dtg_rliste = new System.Windows.Forms.DataGridView();
            this.gbox_Rdety = new System.Windows.Forms.GroupBox();
            this.rtb_rdetay = new System.Windows.Forms.RichTextBox();
            this.gbox_heris = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btn_internet = new System.Windows.Forms.Button();
            this.btn_duyuru = new System.Windows.Forms.Button();
            this.btn_bilgi = new System.Windows.Forms.Button();
            this.grp_dbilgi.SuspendLayout();
            this.gbox_randevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_rliste)).BeginInit();
            this.gbox_Rdety.SuspendLayout();
            this.gbox_heris.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_dbilgi
            // 
            this.grp_dbilgi.Controls.Add(this.lbl_isimgoster);
            this.grp_dbilgi.Controls.Add(this.lbl_tcnum);
            this.grp_dbilgi.Controls.Add(this.lbl_isim);
            this.grp_dbilgi.Controls.Add(this.lbl_tc);
            this.grp_dbilgi.Location = new System.Drawing.Point(12, 29);
            this.grp_dbilgi.Name = "grp_dbilgi";
            this.grp_dbilgi.Size = new System.Drawing.Size(260, 114);
            this.grp_dbilgi.TabIndex = 0;
            this.grp_dbilgi.TabStop = false;
            this.grp_dbilgi.Text = "DoktorBilgi";
            this.grp_dbilgi.Enter += new System.EventHandler(this.grp_dbilgi_Enter);
            // 
            // lbl_isimgoster
            // 
            this.lbl_isimgoster.AutoSize = true;
            this.lbl_isimgoster.Location = new System.Drawing.Point(94, 66);
            this.lbl_isimgoster.Name = "lbl_isimgoster";
            this.lbl_isimgoster.Size = new System.Drawing.Size(46, 17);
            this.lbl_isimgoster.TabIndex = 3;
            this.lbl_isimgoster.Text = "label1";
            // 
            // lbl_tcnum
            // 
            this.lbl_tcnum.AutoSize = true;
            this.lbl_tcnum.Location = new System.Drawing.Point(91, 32);
            this.lbl_tcnum.Name = "lbl_tcnum";
            this.lbl_tcnum.Size = new System.Drawing.Size(96, 17);
            this.lbl_tcnum.TabIndex = 2;
            this.lbl_tcnum.Text = "00000000000";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(17, 66);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(73, 17);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "Ad Soyad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(17, 32);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(55, 17);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "TC NO:";
            // 
            // gbox_randevu
            // 
            this.gbox_randevu.Controls.Add(this.dtg_rliste);
            this.gbox_randevu.Location = new System.Drawing.Point(337, 29);
            this.gbox_randevu.Name = "gbox_randevu";
            this.gbox_randevu.Size = new System.Drawing.Size(435, 504);
            this.gbox_randevu.TabIndex = 1;
            this.gbox_randevu.TabStop = false;
            this.gbox_randevu.Text = "RandevuListesi";
            // 
            // dtg_rliste
            // 
            this.dtg_rliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_rliste.Location = new System.Drawing.Point(6, 21);
            this.dtg_rliste.Name = "dtg_rliste";
            this.dtg_rliste.RowTemplate.Height = 24;
            this.dtg_rliste.Size = new System.Drawing.Size(429, 477);
            this.dtg_rliste.TabIndex = 0;
            // 
            // gbox_Rdety
            // 
            this.gbox_Rdety.Controls.Add(this.rtb_rdetay);
            this.gbox_Rdety.Location = new System.Drawing.Point(12, 168);
            this.gbox_Rdety.Name = "gbox_Rdety";
            this.gbox_Rdety.Size = new System.Drawing.Size(260, 214);
            this.gbox_Rdety.TabIndex = 1;
            this.gbox_Rdety.TabStop = false;
            this.gbox_Rdety.Text = "RandevuDetay";
            // 
            // rtb_rdetay
            // 
            this.rtb_rdetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_rdetay.Location = new System.Drawing.Point(3, 18);
            this.rtb_rdetay.Name = "rtb_rdetay";
            this.rtb_rdetay.Size = new System.Drawing.Size(254, 193);
            this.rtb_rdetay.TabIndex = 0;
            this.rtb_rdetay.Text = "";
            // 
            // gbox_heris
            // 
            this.gbox_heris.Controls.Add(this.btncikis);
            this.gbox_heris.Controls.Add(this.btn_internet);
            this.gbox_heris.Controls.Add(this.btn_duyuru);
            this.gbox_heris.Controls.Add(this.btn_bilgi);
            this.gbox_heris.Location = new System.Drawing.Point(12, 418);
            this.gbox_heris.Name = "gbox_heris";
            this.gbox_heris.Size = new System.Drawing.Size(260, 115);
            this.gbox_heris.TabIndex = 2;
            this.gbox_heris.TabStop = false;
            this.gbox_heris.Text = "HızlıErişim";
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(123, 65);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(89, 33);
            this.btncikis.TabIndex = 4;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            // 
            // btn_internet
            // 
            this.btn_internet.Location = new System.Drawing.Point(6, 65);
            this.btn_internet.Name = "btn_internet";
            this.btn_internet.Size = new System.Drawing.Size(90, 33);
            this.btn_internet.TabIndex = 3;
            this.btn_internet.Text = "İnternet";
            this.btn_internet.UseVisualStyleBackColor = true;
            this.btn_internet.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_duyuru
            // 
            this.btn_duyuru.Location = new System.Drawing.Point(123, 21);
            this.btn_duyuru.Name = "btn_duyuru";
            this.btn_duyuru.Size = new System.Drawing.Size(89, 38);
            this.btn_duyuru.TabIndex = 2;
            this.btn_duyuru.Text = "Duyurular";
            this.btn_duyuru.UseVisualStyleBackColor = true;
            // 
            // btn_bilgi
            // 
            this.btn_bilgi.Location = new System.Drawing.Point(6, 21);
            this.btn_bilgi.Name = "btn_bilgi";
            this.btn_bilgi.Size = new System.Drawing.Size(100, 38);
            this.btn_bilgi.TabIndex = 1;
            this.btn_bilgi.Text = "BilgiDüzenle";
            this.btn_bilgi.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(797, 545);
            this.Controls.Add(this.gbox_heris);
            this.Controls.Add(this.gbox_Rdety);
            this.Controls.Add(this.gbox_randevu);
            this.Controls.Add(this.grp_dbilgi);
            this.Name = "FrmDoktorDetay";
            this.Text = "DoktorDetay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.grp_dbilgi.ResumeLayout(false);
            this.grp_dbilgi.PerformLayout();
            this.gbox_randevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_rliste)).EndInit();
            this.gbox_Rdety.ResumeLayout(false);
            this.gbox_heris.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_dbilgi;
        private System.Windows.Forms.GroupBox gbox_randevu;
        private System.Windows.Forms.GroupBox gbox_Rdety;
        private System.Windows.Forms.GroupBox gbox_heris;
        private System.Windows.Forms.RichTextBox rtb_rdetay;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btn_internet;
        private System.Windows.Forms.Button btn_duyuru;
        private System.Windows.Forms.Button btn_bilgi;
        private System.Windows.Forms.Label lbl_tcnum;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_isimgoster;
        private System.Windows.Forms.DataGridView dtg_rliste;
    }
}