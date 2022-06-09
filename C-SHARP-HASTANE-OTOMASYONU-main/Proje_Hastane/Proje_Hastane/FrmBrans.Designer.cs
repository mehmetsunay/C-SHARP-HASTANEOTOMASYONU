namespace Proje_Hastane
{
    partial class FrmBrans
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
            this.dtg_brans = new System.Windows.Forms.DataGridView();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_bransid = new System.Windows.Forms.Label();
            this.lbl_bransad = new System.Windows.Forms.Label();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_brans)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_brans
            // 
            this.dtg_brans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_brans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_brans.Location = new System.Drawing.Point(255, 61);
            this.dtg_brans.Name = "dtg_brans";
            this.dtg_brans.RowTemplate.Height = 24;
            this.dtg_brans.Size = new System.Drawing.Size(402, 268);
            this.dtg_brans.TabIndex = 64;
            this.dtg_brans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_brans_CellClick);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(105, 156);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 22);
            this.txt_ad.TabIndex = 63;
            // 
            // txt_bid
            // 
            this.txt_bid.Location = new System.Drawing.Point(105, 113);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.Size = new System.Drawing.Size(100, 22);
            this.txt_bid.TabIndex = 62;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(-65, 156);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(48, 17);
            this.lbl_Soyad.TabIndex = 61;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(-65, 113);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(29, 17);
            this.lbl_ad.TabIndex = 60;
            this.lbl_ad.Text = "Ad ";
            // 
            // lbl_bransid
            // 
            this.lbl_bransid.AutoSize = true;
            this.lbl_bransid.Location = new System.Drawing.Point(12, 113);
            this.lbl_bransid.Name = "lbl_bransid";
            this.lbl_bransid.Size = new System.Drawing.Size(66, 17);
            this.lbl_bransid.TabIndex = 65;
            this.lbl_bransid.Text = "Brans ID:";
            // 
            // lbl_bransad
            // 
            this.lbl_bransad.AutoSize = true;
            this.lbl_bransad.Location = new System.Drawing.Point(12, 161);
            this.lbl_bransad.Name = "lbl_bransad";
            this.lbl_bransad.Size = new System.Drawing.Size(70, 17);
            this.lbl_bransad.TabIndex = 66;
            this.lbl_bransad.Text = "Brans Ad:";
            // 
            // btn_guncel
            // 
            this.btn_guncel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_guncel.Location = new System.Drawing.Point(91, 272);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(86, 37);
            this.btn_guncel.TabIndex = 69;
            this.btn_guncel.Text = "Güncelle";
            this.btn_guncel.UseVisualStyleBackColor = false;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_sil.Location = new System.Drawing.Point(148, 216);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(86, 37);
            this.btn_sil.TabIndex = 68;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Ekle.Location = new System.Drawing.Point(15, 216);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(86, 37);
            this.btn_Ekle.TabIndex = 67;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(663, 395);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.lbl_bransad);
            this.Controls.Add(this.lbl_bransid);
            this.Controls.Add(this.dtg_brans);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_bid);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_ad);
            this.MinimizeBox = false;
            this.Name = "FrmBrans";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Brans Paneli";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_brans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_brans;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_bid;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_bransid;
        private System.Windows.Forms.Label lbl_bransad;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_Ekle;
    }
}