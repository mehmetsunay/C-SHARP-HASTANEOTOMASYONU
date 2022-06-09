using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }

        sqlbaglantisi sb = new sqlbaglantisi();

        private void lnk_uye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit hk = new FrmHastaKayit();
           
            hk.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", sb.baglanti());

            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                FrmHastaDetay hd = new FrmHastaDetay();
                
                hd.tc = msk_tc.Text;

                hd.Show();

                this.Hide();

            }

            else
            {

                MessageBox.Show("Hatalı TC yada Şifre");
            }

            sb.baglanti().Close();

        }
    }
}
