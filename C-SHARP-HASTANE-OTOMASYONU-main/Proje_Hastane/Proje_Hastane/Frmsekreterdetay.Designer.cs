namespace Proje_Hastane
{
    partial class Frmsekreterdetay
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
            this.btn_randevu = new System.Windows.Forms.Button();
            this.rtb_sikayet = new System.Windows.Forms.RichTextBox();
            this.gbox_ran = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cbox_durum = new System.Windows.Forms.CheckBox();
            this.mtb_tc = new System.Windows.Forms.MaskedTextBox();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.mtb_saat = new System.Windows.Forms.MaskedTextBox();
            this.mtb_tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_tcnosek = new System.Windows.Forms.Label();
            this.lbl_doktor = new System.Windows.Forms.Label();
            this.lbl_brans = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.gbox_Doktorlar = new System.Windows.Forms.GroupBox();
            this.dtg_doktorlar = new System.Windows.Forms.DataGridView();
            this.gpb_Branslar = new System.Windows.Forms.GroupBox();
            this.dtg_branslar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_duyurular = new System.Windows.Forms.Button();
            this.btn_ranlis = new System.Windows.Forms.Button();
            this.btn_brans = new System.Windows.Forms.Button();
            this.btn_doktor = new System.Windows.Forms.Button();
            this.gbox_kisisel.SuspendLayout();
            this.gbox_Randevu.SuspendLayout();
            this.gbox_ran.SuspendLayout();
            this.gbox_Doktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doktorlar)).BeginInit();
            this.gpb_Branslar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_branslar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_kisisel
            // 
            this.gbox_kisisel.Controls.Add(this.lbl_AdSoyadNo);
            this.gbox_kisisel.Controls.Add(this.lblAdSoy);
            this.gbox_kisisel.Controls.Add(this.lbl_TCno);
            this.gbox_kisisel.Controls.Add(this.lbl_TC);
            this.gbox_kisisel.Location = new System.Drawing.Point(34, 12);
            this.gbox_kisisel.Name = "gbox_kisisel";
            this.gbox_kisisel.Size = new System.Drawing.Size(279, 168);
            this.gbox_kisisel.TabIndex = 1;
            this.gbox_kisisel.TabStop = false;
            this.gbox_kisisel.Text = "Kişi Bilgileri";
            this.gbox_kisisel.Enter += new System.EventHandler(this.gbox_kisisel_Enter);
            // 
            // lbl_AdSoyadNo
            // 
            this.lbl_AdSoyadNo.AutoSize = true;
            this.lbl_AdSoyadNo.Location = new System.Drawing.Point(96, 96);
            this.lbl_AdSoyadNo.Name = "lbl_AdSoyadNo";
            this.lbl_AdSoyadNo.Size = new System.Drawing.Size(60, 17);
            this.lbl_AdSoyadNo.TabIndex = 5;
            this.lbl_AdSoyadNo.Text = "null null ";
            this.lbl_AdSoyadNo.Click += new System.EventHandler(this.lbl_AdSoyadNo_Click);
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
            this.lbl_TC.Size = new System.Drawing.Size(52, 17);
            this.lbl_TC.TabIndex = 2;
            this.lbl_TC.Text = "TC No:";
            // 
            // gbox_Randevu
            // 
            this.gbox_Randevu.Controls.Add(this.btn_randevu);
            this.gbox_Randevu.Controls.Add(this.rtb_sikayet);
            this.gbox_Randevu.Location = new System.Drawing.Point(34, 215);
            this.gbox_Randevu.Name = "gbox_Randevu";
            this.gbox_Randevu.Size = new System.Drawing.Size(279, 285);
            this.gbox_Randevu.TabIndex = 2;
            this.gbox_Randevu.TabStop = false;
            this.gbox_Randevu.Text = "Duyuru Oluştur";
            // 
            // btn_randevu
            // 
            this.btn_randevu.Location = new System.Drawing.Point(84, 226);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(121, 34);
            this.btn_randevu.TabIndex = 7;
            this.btn_randevu.Text = "Oluştur";
            this.btn_randevu.UseVisualStyleBackColor = true;
            this.btn_randevu.Click += new System.EventHandler(this.btn_randevu_Click);
            // 
            // rtb_sikayet
            // 
            this.rtb_sikayet.Location = new System.Drawing.Point(35, 38);
            this.rtb_sikayet.Name = "rtb_sikayet";
            this.rtb_sikayet.Size = new System.Drawing.Size(215, 165);
            this.rtb_sikayet.TabIndex = 6;
            this.rtb_sikayet.Text = "";
            // 
            // gbox_ran
            // 
            this.gbox_ran.Controls.Add(this.btn_kaydet);
            this.gbox_ran.Controls.Add(this.cbox_durum);
            this.gbox_ran.Controls.Add(this.mtb_tc);
            this.gbox_ran.Controls.Add(this.cmb_doktor);
            this.gbox_ran.Controls.Add(this.cmb_brans);
            this.gbox_ran.Controls.Add(this.mtb_saat);
            this.gbox_ran.Controls.Add(this.mtb_tarih);
            this.gbox_ran.Controls.Add(this.txt_id);
            this.gbox_ran.Controls.Add(this.lbl_tcnosek);
            this.gbox_ran.Controls.Add(this.lbl_doktor);
            this.gbox_ran.Controls.Add(this.lbl_brans);
            this.gbox_ran.Controls.Add(this.lbl_saat);
            this.gbox_ran.Controls.Add(this.lbl_tarih);
            this.gbox_ran.Controls.Add(this.lbl_id);
            this.gbox_ran.Location = new System.Drawing.Point(370, 12);
            this.gbox_ran.Name = "gbox_ran";
            this.gbox_ran.Size = new System.Drawing.Size(342, 488);
            this.gbox_ran.TabIndex = 3;
            this.gbox_ran.TabStop = false;
            this.gbox_ran.Text = "Randevu Paneli";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(117, 393);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(121, 34);
            this.btn_kaydet.TabIndex = 15;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cbox_durum
            // 
            this.cbox_durum.AutoSize = true;
            this.cbox_durum.Location = new System.Drawing.Point(117, 339);
            this.cbox_durum.Name = "cbox_durum";
            this.cbox_durum.Size = new System.Drawing.Size(72, 21);
            this.cbox_durum.TabIndex = 14;
            this.cbox_durum.Text = "Durum";
            this.cbox_durum.UseVisualStyleBackColor = true;
            this.cbox_durum.CheckedChanged += new System.EventHandler(this.cbox_durum_CheckedChanged);
            // 
            // mtb_tc
            // 
            this.mtb_tc.Location = new System.Drawing.Point(117, 282);
            this.mtb_tc.Mask = "00000000000";
            this.mtb_tc.Name = "mtb_tc";
            this.mtb_tc.Size = new System.Drawing.Size(124, 22);
            this.mtb_tc.TabIndex = 13;
            this.mtb_tc.ValidatingType = typeof(int);
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(117, 221);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(124, 24);
            this.cmb_doktor.TabIndex = 12;
            this.cmb_doktor.SelectedIndexChanged += new System.EventHandler(this.cmb_doktor_SelectedIndexChanged);
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(117, 179);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(124, 24);
            this.cmb_brans.TabIndex = 11;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // mtb_saat
            // 
            this.mtb_saat.Location = new System.Drawing.Point(117, 127);
            this.mtb_saat.Mask = "00:00";
            this.mtb_saat.Name = "mtb_saat";
            this.mtb_saat.Size = new System.Drawing.Size(124, 22);
            this.mtb_saat.TabIndex = 10;
            this.mtb_saat.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_tarih
            // 
            this.mtb_tarih.Location = new System.Drawing.Point(117, 78);
            this.mtb_tarih.Mask = "00/00/0000";
            this.mtb_tarih.Name = "mtb_tarih";
            this.mtb_tarih.Size = new System.Drawing.Size(124, 22);
            this.mtb_tarih.TabIndex = 9;
            this.mtb_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(117, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(124, 22);
            this.txt_id.TabIndex = 8;
            // 
            // lbl_tcnosek
            // 
            this.lbl_tcnosek.AutoSize = true;
            this.lbl_tcnosek.Location = new System.Drawing.Point(17, 282);
            this.lbl_tcnosek.Name = "lbl_tcnosek";
            this.lbl_tcnosek.Size = new System.Drawing.Size(30, 17);
            this.lbl_tcnosek.TabIndex = 7;
            this.lbl_tcnosek.Text = "TC:";
            // 
            // lbl_doktor
            // 
            this.lbl_doktor.AutoSize = true;
            this.lbl_doktor.Location = new System.Drawing.Point(12, 228);
            this.lbl_doktor.Name = "lbl_doktor";
            this.lbl_doktor.Size = new System.Drawing.Size(50, 17);
            this.lbl_doktor.TabIndex = 5;
            this.lbl_doktor.Text = "Doktor";
            // 
            // lbl_brans
            // 
            this.lbl_brans.AutoSize = true;
            this.lbl_brans.Location = new System.Drawing.Point(12, 179);
            this.lbl_brans.Name = "lbl_brans";
            this.lbl_brans.Size = new System.Drawing.Size(45, 17);
            this.lbl_brans.TabIndex = 4;
            this.lbl_brans.Text = "Branş";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(12, 130);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(37, 17);
            this.lbl_saat.TabIndex = 2;
            this.lbl_saat.Text = "Saat";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(12, 83);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(41, 17);
            this.lbl_tarih.TabIndex = 1;
            this.lbl_tarih.Text = "Tarih";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 38);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 17);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // gbox_Doktorlar
            // 
            this.gbox_Doktorlar.Controls.Add(this.dtg_doktorlar);
            this.gbox_Doktorlar.Location = new System.Drawing.Point(739, 312);
            this.gbox_Doktorlar.Name = "gbox_Doktorlar";
            this.gbox_Doktorlar.Size = new System.Drawing.Size(507, 260);
            this.gbox_Doktorlar.TabIndex = 4;
            this.gbox_Doktorlar.TabStop = false;
            this.gbox_Doktorlar.Text = "Doktorlar";
            // 
            // dtg_doktorlar
            // 
            this.dtg_doktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_doktorlar.Location = new System.Drawing.Point(3, 18);
            this.dtg_doktorlar.Name = "dtg_doktorlar";
            this.dtg_doktorlar.RowTemplate.Height = 24;
            this.dtg_doktorlar.Size = new System.Drawing.Size(501, 239);
            this.dtg_doktorlar.TabIndex = 0;
            // 
            // gpb_Branslar
            // 
            this.gpb_Branslar.Controls.Add(this.dtg_branslar);
            this.gpb_Branslar.Location = new System.Drawing.Point(739, 27);
            this.gpb_Branslar.Name = "gpb_Branslar";
            this.gpb_Branslar.Size = new System.Drawing.Size(507, 267);
            this.gpb_Branslar.TabIndex = 3;
            this.gpb_Branslar.TabStop = false;
            this.gpb_Branslar.Text = "Branşlar";
            // 
            // dtg_branslar
            // 
            this.dtg_branslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_branslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_branslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_branslar.Location = new System.Drawing.Point(3, 18);
            this.dtg_branslar.Name = "dtg_branslar";
            this.dtg_branslar.RowTemplate.Height = 24;
            this.dtg_branslar.Size = new System.Drawing.Size(501, 246);
            this.dtg_branslar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_duyurular);
            this.groupBox1.Controls.Add(this.btn_ranlis);
            this.groupBox1.Controls.Add(this.btn_brans);
            this.groupBox1.Controls.Add(this.btn_doktor);
            this.groupBox1.Location = new System.Drawing.Point(22, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hızlı Erişim";
            // 
            // btn_duyurular
            // 
            this.btn_duyurular.Location = new System.Drawing.Point(520, 38);
            this.btn_duyurular.Name = "btn_duyurular";
            this.btn_duyurular.Size = new System.Drawing.Size(115, 41);
            this.btn_duyurular.TabIndex = 4;
            this.btn_duyurular.Text = "Duyurular";
            this.btn_duyurular.UseVisualStyleBackColor = true;
            this.btn_duyurular.Click += new System.EventHandler(this.btn_duyurular_Click);
            // 
            // btn_ranlis
            // 
            this.btn_ranlis.Location = new System.Drawing.Point(363, 38);
            this.btn_ranlis.Name = "btn_ranlis";
            this.btn_ranlis.Size = new System.Drawing.Size(124, 41);
            this.btn_ranlis.TabIndex = 3;
            this.btn_ranlis.Text = "Randevu Listele";
            this.btn_ranlis.UseVisualStyleBackColor = true;
            this.btn_ranlis.Click += new System.EventHandler(this.btn_ranlis_Click);
            // 
            // btn_brans
            // 
            this.btn_brans.Location = new System.Drawing.Point(194, 38);
            this.btn_brans.Name = "btn_brans";
            this.btn_brans.Size = new System.Drawing.Size(119, 41);
            this.btn_brans.TabIndex = 2;
            this.btn_brans.Text = "Branş Paneli";
            this.btn_brans.UseVisualStyleBackColor = true;
            this.btn_brans.Click += new System.EventHandler(this.btn_brans_Click);
            // 
            // btn_doktor
            // 
            this.btn_doktor.Location = new System.Drawing.Point(33, 38);
            this.btn_doktor.Name = "btn_doktor";
            this.btn_doktor.Size = new System.Drawing.Size(115, 41);
            this.btn_doktor.TabIndex = 1;
            this.btn_doktor.Text = "Doktor Paneli";
            this.btn_doktor.UseVisualStyleBackColor = true;
            this.btn_doktor.Click += new System.EventHandler(this.btn_doktor_Click);
            // 
            // Frmsekreterdetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1320, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_Branslar);
            this.Controls.Add(this.gbox_Doktorlar);
            this.Controls.Add(this.gbox_ran);
            this.Controls.Add(this.gbox_Randevu);
            this.Controls.Add(this.gbox_kisisel);
            this.MaximizeBox = false;
            this.Name = "Frmsekreterdetay";
            this.Text = "sekreterdetay";
            this.Load += new System.EventHandler(this.Frmsekreterdetay_Load);
            this.gbox_kisisel.ResumeLayout(false);
            this.gbox_kisisel.PerformLayout();
            this.gbox_Randevu.ResumeLayout(false);
            this.gbox_ran.ResumeLayout(false);
            this.gbox_ran.PerformLayout();
            this.gbox_Doktorlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doktorlar)).EndInit();
            this.gpb_Branslar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_branslar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_kisisel;
        private System.Windows.Forms.Label lbl_AdSoyadNo;
        private System.Windows.Forms.Label lblAdSoy;
        private System.Windows.Forms.Label lbl_TCno;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.GroupBox gbox_Randevu;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.RichTextBox rtb_sikayet;
        private System.Windows.Forms.GroupBox gbox_ran;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_doktor;
        private System.Windows.Forms.Label lbl_brans;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.MaskedTextBox mtb_saat;
        private System.Windows.Forms.MaskedTextBox mtb_tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_tcnosek;
        private System.Windows.Forms.CheckBox cbox_durum;
        private System.Windows.Forms.MaskedTextBox mtb_tc;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.GroupBox gbox_Doktorlar;
        private System.Windows.Forms.DataGridView dtg_doktorlar;
        private System.Windows.Forms.GroupBox gpb_Branslar;
        private System.Windows.Forms.DataGridView dtg_branslar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ranlis;
        private System.Windows.Forms.Button btn_brans;
        private System.Windows.Forms.Button btn_doktor;
        private System.Windows.Forms.Button btn_duyurular;
    }
}