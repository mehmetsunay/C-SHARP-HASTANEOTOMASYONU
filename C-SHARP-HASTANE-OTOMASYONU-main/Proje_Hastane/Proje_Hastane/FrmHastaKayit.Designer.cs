namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_Hkayit = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.msk_Tel = new System.Windows.Forms.MaskedTextBox();
            this.cmb_cnsyt = new System.Windows.Forms.ComboBox();
            this.btn_kyt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(165, 195);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(127, 22);
            this.msk_tc.TabIndex = 4;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(163, 280);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(127, 22);
            this.txt_sifre.TabIndex = 5;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(71, 285);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_sifre.TabIndex = 8;
            this.lbl_sifre.Text = "Şifre";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(71, 200);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(88, 17);
            this.lbl_tc.TabIndex = 7;
            this.lbl_tc.Text = "TC Kimilk No";
            // 
            // lbl_Hkayit
            // 
            this.lbl_Hkayit.AutoSize = true;
            this.lbl_Hkayit.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hkayit.Location = new System.Drawing.Point(66, 50);
            this.lbl_Hkayit.Name = "lbl_Hkayit";
            this.lbl_Hkayit.Size = new System.Drawing.Size(319, 48);
            this.lbl_Hkayit.TabIndex = 6;
            this.lbl_Hkayit.Text = "Hasta Kayıt Paneli";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(71, 116);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(29, 17);
            this.lbl_ad.TabIndex = 11;
            this.lbl_ad.Text = "Ad ";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(71, 159);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(48, 17);
            this.lbl_Soyad.TabIndex = 12;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Location = new System.Drawing.Point(72, 244);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(56, 17);
            this.lbl_Tel.TabIndex = 13;
            this.lbl_Tel.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cinsiyet";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(163, 116);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(127, 22);
            this.txt_Ad.TabIndex = 1;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(163, 159);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(127, 22);
            this.txt_Soyad.TabIndex = 2;
            // 
            // msk_Tel
            // 
            this.msk_Tel.Location = new System.Drawing.Point(165, 244);
            this.msk_Tel.Mask = "(999) 000-0000";
            this.msk_Tel.Name = "msk_Tel";
            this.msk_Tel.Size = new System.Drawing.Size(127, 22);
            this.msk_Tel.TabIndex = 3;
            // 
            // cmb_cnsyt
            // 
            this.cmb_cnsyt.FormattingEnabled = true;
            this.cmb_cnsyt.Items.AddRange(new object[] {
            "Erkek ",
            "Bayan"});
            this.cmb_cnsyt.Location = new System.Drawing.Point(163, 330);
            this.cmb_cnsyt.Name = "cmb_cnsyt";
            this.cmb_cnsyt.Size = new System.Drawing.Size(127, 24);
            this.cmb_cnsyt.TabIndex = 6;
            // 
            // btn_kyt
            // 
            this.btn_kyt.Location = new System.Drawing.Point(163, 394);
            this.btn_kyt.Name = "btn_kyt";
            this.btn_kyt.Size = new System.Drawing.Size(127, 37);
            this.btn_kyt.TabIndex = 19;
            this.btn_kyt.Text = "Kayıt Yap";
            this.btn_kyt.UseVisualStyleBackColor = true;
            this.btn_kyt.Click += new System.EventHandler(this.btn_kyt_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btn_kyt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(473, 505);
            this.Controls.Add(this.btn_kyt);
            this.Controls.Add(this.cmb_cnsyt);
            this.Controls.Add(this.msk_Tel);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_Hkayit);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "HASTA KAYIT";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_Hkayit;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.MaskedTextBox msk_Tel;
        private System.Windows.Forms.ComboBox cmb_cnsyt;
        private System.Windows.Forms.Button btn_kyt;
    }
}