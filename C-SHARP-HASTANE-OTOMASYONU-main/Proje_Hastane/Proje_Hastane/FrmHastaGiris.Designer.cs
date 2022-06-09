namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            this.lnk_uye = new System.Windows.Forms.LinkLabel();
            this.lbl_HastaPanel = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnk_uye
            // 
            this.lnk_uye.AutoSize = true;
            this.lnk_uye.Location = new System.Drawing.Point(316, 163);
            this.lnk_uye.Name = "lnk_uye";
            this.lnk_uye.Size = new System.Drawing.Size(51, 17);
            this.lnk_uye.TabIndex = 0;
            this.lnk_uye.TabStop = true;
            this.lnk_uye.Text = "Üye Ol";
            this.lnk_uye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_uye_LinkClicked);
            // 
            // lbl_HastaPanel
            // 
            this.lbl_HastaPanel.AutoSize = true;
            this.lbl_HastaPanel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HastaPanel.Location = new System.Drawing.Point(53, 24);
            this.lbl_HastaPanel.Name = "lbl_HastaPanel";
            this.lbl_HastaPanel.Size = new System.Drawing.Size(312, 48);
            this.lbl_HastaPanel.TabIndex = 1;
            this.lbl_HastaPanel.Text = "Hasta Giriş Paneli";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(80, 122);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(88, 17);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "TC Kimilk No";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(80, 168);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Şifre";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(172, 163);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.Text = "1988";
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(172, 122);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(100, 22);
            this.msk_tc.TabIndex = 1;
            this.msk_tc.Text = "12961610795";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(172, 227);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(100, 29);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "Giris Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(473, 287);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_HastaPanel);
            this.Controls.Add(this.lnk_uye);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "HASTA GİRİŞ";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_uye;
        private System.Windows.Forms.Label lbl_HastaPanel;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Button btn_giris;
    }
}