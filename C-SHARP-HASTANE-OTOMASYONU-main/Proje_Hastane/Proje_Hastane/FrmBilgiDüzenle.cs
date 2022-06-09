using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Proje_Hastane
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string Tcno;

        sqlbaglantisi sb = new sqlbaglantisi();

        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msk_tc.Text = Tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",sb.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {

                txt_Ad.Text = dr[1].ToString();

                txt_Soyad.Text = dr[2].ToString();

                msk_Tel.Text = dr[4].ToString();

                txt_sifre.Text = dr[5].ToString();

                cmb_cnsyt.Text = dr[6].ToString();

            }

            sb.baglanti().Close();


        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4", sb.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3", msk_Tel.Text);
            komut2.Parameters.AddWithValue("@p4", txt_sifre.Text);
            komut2.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
