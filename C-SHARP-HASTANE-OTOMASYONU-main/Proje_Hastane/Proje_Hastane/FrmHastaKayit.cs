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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi sb = new sqlbaglantisi();

        private void btn_kyt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",sb.baglanti());

            komut.Parameters.AddWithValue("@p1",txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", msk_tc.Text);
            komut.Parameters.AddWithValue("@p4", msk_Tel.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut.Parameters.AddWithValue("@p6", cmb_cnsyt.Text);

            komut.ExecuteNonQuery();
            sb.baglanti().Close();

            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz" + txt_sifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
