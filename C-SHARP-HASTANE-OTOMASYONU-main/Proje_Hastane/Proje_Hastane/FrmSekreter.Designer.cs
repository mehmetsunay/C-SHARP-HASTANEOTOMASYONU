namespace Proje_Hastane
{
    partial class FrmSekreter
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_HastaPanel = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(182, 261);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(100, 29);
            this.btn_giris.TabIndex = 13;
            this.btn_giris.Text = "Giris Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(182, 156);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(100, 22);
            this.msk_tc.TabIndex = 12;
            this.msk_tc.Text = "12961610796";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(90, 202);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_sifre.TabIndex = 10;
            this.lbl_sifre.Text = "Şifre";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(90, 156);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(88, 17);
            this.lbl_tc.TabIndex = 9;
            this.lbl_tc.Text = "TC Kimilk No";
            // 
            // lbl_HastaPanel
            // 
            this.lbl_HastaPanel.AutoSize = true;
            this.lbl_HastaPanel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HastaPanel.Location = new System.Drawing.Point(63, 58);
            this.lbl_HastaPanel.Name = "lbl_HastaPanel";
            this.lbl_HastaPanel.Size = new System.Drawing.Size(351, 48);
            this.lbl_HastaPanel.TabIndex = 8;
            this.lbl_HastaPanel.Text = "Sekreter Giriş Paneli";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(182, 202);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 14;
            this.txt_sifre.Text = "1999";
            // 
            // FrmSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(484, 395);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_HastaPanel);
            this.Name = "FrmSekreter";
            this.Text = "Sekreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_HastaPanel;
        private System.Windows.Forms.TextBox txt_sifre;
    }
}