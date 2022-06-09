namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            this.gbox_kisisel = new System.Windows.Forms.GroupBox();
            this.lbl_AdSoyadNo = new System.Windows.Forms.Label();
            this.lblAdSoy = new System.Windows.Forms.Label();
            this.lbl_TCno = new System.Windows.Forms.Label();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.gbox_Randevu = new System.Windows.Forms.GroupBox();
            this.txt_radid = new System.Windows.Forms.TextBox();
            this.lbl_rid = new System.Windows.Forms.Label();
            this.llabel_Bilgi = new System.Windows.Forms.LinkLabel();
            this.btn_randevu = new System.Windows.Forms.Button();
            this.rtb_sikayet = new System.Windows.Forms.RichTextBox();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.lbl_sikayet = new System.Windows.Forms.Label();
            this.lbl_doktor = new System.Windows.Forms.Label();
            this.lbl_brans = new System.Windows.Forms.Label();
            this.gbox_RanGec = new System.Windows.Forms.GroupBox();
            this.dtg_randevu = new System.Windows.Forms.DataGridView();
            this.gbox_ARan = new System.Windows.Forms.GroupBox();
            this.dta_aktfran = new System.Windows.Forms.DataGridView();
            this.gbox_kisisel.SuspendLayout();
            this.gbox_Randevu.SuspendLayout();
            this.gbox_RanGec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_randevu)).BeginInit();
            this.gbox_ARan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dta_aktfran)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_kisisel
            // 
            this.gbox_kisisel.Controls.Add(this.lbl_AdSoyadNo);
            this.gbox_kisisel.Controls.Add(this.lblAdSoy);
            this.gbox_kisisel.Controls.Add(this.lbl_TCno);
            this.gbox_kisisel.Controls.Add(this.lbl_TC);
            this.gbox_kisisel.Location = new System.Drawing.Point(23, 12);
            this.gbox_kisisel.Name = "gbox_kisisel";
            this.gbox_kisisel.Size = new System.Drawing.Size(279, 213);
            this.gbox_kisisel.TabIndex = 0;
            this.gbox_kisisel.TabStop = false;
            this.gbox_kisisel.Text = "Kişi Bilgileri";
            this.gbox_kisisel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_AdSoyadNo
            // 
            this.lbl_AdSoyadNo.AutoSize = true;
            this.lbl_AdSoyadNo.Location = new System.Drawing.Point(96, 96);
            this.lbl_AdSoyadNo.Name = "lbl_AdSoyadNo";
            this.lbl_AdSoyadNo.Size = new System.Drawing.Size(60, 17);
            this.lbl_AdSoyadNo.TabIndex = 5;
            this.lbl_AdSoyadNo.Text = "null null ";
            // 
            // lblAdSoy
            // 
            this.lblAdSoy.AutoSize = true;
            this.lblAdSoy.Location = new System.Drawing.Point(6, 96);
            this.lblAdSoy.Name = "lblAdSoy";
            this.lblAdSoy.Size = new System.Drawing.Size(73, 17);
            this.lblAdSoy.TabIndex = 4;
            this.lblAdSoy.Text = "Ad Soyad:";
            // 
            // lbl_TCno
            // 
            this.lbl_TCno.AutoSize = true;
            this.lbl_TCno.Location = new System.Drawing.Point(96, 38);
            this.lbl_TCno.Name = "lbl_TCno";
            this.lbl_TCno.Size = new System.Drawing.Size(96, 17);
            this.lbl_TCno.TabIndex = 3;
            this.lbl_TCno.Text = "00000000000";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(6, 38);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(30, 17);
            this.lbl_TC.TabIndex = 2;
            this.lbl_TC.Text = "TC:";
            // 
            // gbox_Randevu
            // 
            this.gbox_Randevu.Controls.Add(this.txt_radid);
            this.gbox_Randevu.Controls.Add(this.lbl_rid);
            this.gbox_Randevu.Controls.Add(this.llabel_Bilgi);
            this.gbox_Randevu.Controls.Add(this.btn_randevu);
            this.gbox_Randevu.Controls.Add(this.rtb_sikayet);
            this.gbox_Randevu.Controls.Add(this.cmb_doktor);
            this.gbox_Randevu.Controls.Add(this.cmb_brans);
            this.gbox_Randevu.Controls.Add(this.lbl_sikayet);
            this.gbox_Randevu.Controls.Add(this.lbl_doktor);
            this.gbox_Randevu.Controls.Add(this.lbl_brans);
            this.gbox_Randevu.Location = new System.Drawing.Point(23, 247);
            this.gbox_Randevu.Name = "gbox_Randevu";
            this.gbox_Randevu.Size = new System.Drawing.Size(279, 333);
            this.gbox_Randevu.TabIndex = 1;
            this.gbox_Randevu.TabStop = false;
            this.gbox_Randevu.Text = "Randevu Paneli";
            // 
            // txt_radid
            // 
            this.txt_radid.Enabled = false;
            this.txt_radid.Location = new System.Drawing.Point(99, 35);
            this.txt_radid.Name = "txt_radid";
            this.txt_radid.Size = new System.Drawing.Size(121, 22);
            this.txt_radid.TabIndex = 9;
            // 
            // lbl_rid
            // 
            this.lbl_rid.AutoSize = true;
            this.lbl_rid.Location = new System.Drawing.Point(12, 41);
            this.lbl_rid.Name = "lbl_rid";
            this.lbl_rid.Size = new System.Drawing.Size(86, 17);
            this.lbl_rid.TabIndex = 8;
            this.lbl_rid.Text = "Randevu ID:";
            // 
            // llabel_Bilgi
            // 
            this.llabel_Bilgi.AutoSize = true;
            this.llabel_Bilgi.Location = new System.Drawing.Point(12, 302);
            this.llabel_Bilgi.Name = "llabel_Bilgi";
            this.llabel_Bilgi.Size = new System.Drawing.Size(123, 17);
            this.llabel_Bilgi.TabIndex = 4;
            this.llabel_Bilgi.TabStop = true;
            this.llabel_Bilgi.Text = "Bilgilerimi Düzenle";
            this.llabel_Bilgi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llabel_Bilgi_LinkClicked);
            // 
            // btn_randevu
            // 
            this.btn_randevu.Location = new System.Drawing.Point(99, 265);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(121, 34);
            this.btn_randevu.TabIndex = 7;
            this.btn_randevu.Text = "Randevu Al";
            this.btn_randevu.UseVisualStyleBackColor = true;
            this.btn_randevu.Click += new System.EventHandler(this.btn_randevu_Click);
            // 
            // rtb_sikayet
            // 
            this.rtb_sikayet.Location = new System.Drawing.Point(99, 163);
            this.rtb_sikayet.Name = "rtb_sikayet";
            this.rtb_sikayet.Size = new System.Drawing.Size(121, 96);
            this.rtb_sikayet.TabIndex = 6;
            this.rtb_sikayet.Text = "";
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(99, 116);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(121, 24);
            this.cmb_doktor.TabIndex = 5;
            this.cmb_doktor.SelectedIndexChanged += new System.EventHandler(this.cmb_doktor_SelectedIndexChanged);
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(99, 75);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(121, 24);
            this.cmb_brans.TabIndex = 2;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // lbl_sikayet
            // 
            this.lbl_sikayet.AutoSize = true;
            this.lbl_sikayet.Location = new System.Drawing.Point(12, 166);
            this.lbl_sikayet.Name = "lbl_sikayet";
            this.lbl_sikayet.Size = new System.Drawing.Size(54, 17);
            this.lbl_sikayet.TabIndex = 4;
            this.lbl_sikayet.Text = "Şikayet";
            // 
            // lbl_doktor
            // 
            this.lbl_doktor.AutoSize = true;
            this.lbl_doktor.Location = new System.Drawing.Point(12, 119);
            this.lbl_doktor.Name = "lbl_doktor";
            this.lbl_doktor.Size = new System.Drawing.Size(50, 17);
            this.lbl_doktor.TabIndex = 3;
            this.lbl_doktor.Text = "Doktor";
            // 
            // lbl_brans
            // 
            this.lbl_brans.AutoSize = true;
            this.lbl_brans.Location = new System.Drawing.Point(12, 78);
            this.lbl_brans.Name = "lbl_brans";
            this.lbl_brans.Size = new System.Drawing.Size(45, 17);
            this.lbl_brans.TabIndex = 2;
            this.lbl_brans.Text = "Branş";
            // 
            // gbox_RanGec
            // 
            this.gbox_RanGec.Controls.Add(this.dtg_randevu);
            this.gbox_RanGec.Location = new System.Drawing.Point(386, 12);
            this.gbox_RanGec.Name = "gbox_RanGec";
            this.gbox_RanGec.Size = new System.Drawing.Size(899, 235);
            this.gbox_RanGec.TabIndex = 2;
            this.gbox_RanGec.TabStop = false;
            this.gbox_RanGec.Text = "Randevu Geçmişi";
            this.gbox_RanGec.Enter += new System.EventHandler(this.gbox_RanGec_Enter);
            // 
            // dtg_randevu
            // 
            this.dtg_randevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_randevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_randevu.Location = new System.Drawing.Point(3, 18);
            this.dtg_randevu.Name = "dtg_randevu";
            this.dtg_randevu.RowTemplate.Height = 24;
            this.dtg_randevu.Size = new System.Drawing.Size(893, 214);
            this.dtg_randevu.TabIndex = 0;
            this.dtg_randevu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_randevu_CellContentClick);
            // 
            // gbox_ARan
            // 
            this.gbox_ARan.Controls.Add(this.dta_aktfran);
            this.gbox_ARan.Location = new System.Drawing.Point(389, 317);
            this.gbox_ARan.Name = "gbox_ARan";
            this.gbox_ARan.Size = new System.Drawing.Size(896, 249);
            this.gbox_ARan.TabIndex = 3;
            this.gbox_ARan.TabStop = false;
            this.gbox_ARan.Text = "Aktif Randevular";
            // 
            // dta_aktfran
            // 
            this.dta_aktfran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dta_aktfran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dta_aktfran.Location = new System.Drawing.Point(3, 18);
            this.dta_aktfran.Name = "dta_aktfran";
            this.dta_aktfran.RowTemplate.Height = 24;
            this.dta_aktfran.Size = new System.Drawing.Size(890, 228);
            this.dta_aktfran.TabIndex = 0;
            this.dta_aktfran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dta_aktfran_CellClick);
            this.dta_aktfran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dta_aktfran_CellContentClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1317, 592);
            this.Controls.Add(this.gbox_ARan);
            this.Controls.Add(this.gbox_RanGec);
            this.Controls.Add(this.gbox_Randevu);
            this.Controls.Add(this.gbox_kisisel);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "HastaDetay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.gbox_kisisel.ResumeLayout(false);
            this.gbox_kisisel.PerformLayout();
            this.gbox_Randevu.ResumeLayout(false);
            this.gbox_Randevu.PerformLayout();
            this.gbox_RanGec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_randevu)).EndInit();
            this.gbox_ARan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dta_aktfran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_kisisel;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.GroupBox gbox_Randevu;
        private System.Windows.Forms.Label lbl_AdSoyadNo;
        private System.Windows.Forms.Label lblAdSoy;
        private System.Windows.Forms.Label lbl_TCno;
        private System.Windows.Forms.RichTextBox rtb_sikayet;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label lbl_sikayet;
        private System.Windows.Forms.Label lbl_doktor;
        private System.Windows.Forms.Label lbl_brans;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.GroupBox gbox_RanGec;
        private System.Windows.Forms.GroupBox gbox_ARan;
        private System.Windows.Forms.DataGridView dtg_randevu;
        private System.Windows.Forms.DataGridView dta_aktfran;
        private System.Windows.Forms.LinkLabel llabel_Bilgi;
        private System.Windows.Forms.TextBox txt_radid;
        private System.Windows.Forms.Label lbl_rid;
    }
}