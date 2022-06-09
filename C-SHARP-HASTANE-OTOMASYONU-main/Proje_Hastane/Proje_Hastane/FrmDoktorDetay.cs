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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi sb = new sqlbaglantisi();
        public String Tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbl_tcnum.Text = Tc;


           
            // girişe ad soyad cektim

            SqlCommand komut3 = new SqlCommand("Select DoktorAd + SPACE(1), DoktorSoyad from Tbl_Doktor where DoktorTC=@p1", sb.baglanti());
            komut3.Parameters.AddWithValue("@p1",lbl_tcnum.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())

            {
                lbl_isimgoster.Text = dr3[0] + "" + dr3[1];

                
             }

            sb.baglanti().Close();
          /*
            string kayit = "SELECT RandevuDoktor=@p1 from Tbl_Randevular where RandevuDurum=1 ";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit,sb.baglanti());
            komut.Parameters.AddWithValue("@p1",lbl_isimgoster.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtg_rliste.DataSource = dt;
           sb.baglanti().Close();
           */



               //randevu listesini cekiyorum
               DataTable dt = new DataTable();
               SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+lbl_isimgoster.Text+"'and RandevuDurum=1",sb.baglanti());

              // SqlCommand komut = new SqlCommand("Select * From Tbl_Randevular where RandevuDoktor='" + lbl_isimgoster.Text.Replace("'","") + "'", sb.baglanti());
              // SqlDataAdapter da = new SqlDataAdapter(komut);
               da.Fill(dt);
               dtg_rliste.DataSource = dt;

               sb.baglanti().Close();


        }

        private void lbl_tcnum_Click(object sender, EventArgs e)
        {

        }

        private void lbl_isimgoster_Click(object sender, EventArgs e)
        {

        }

        private void grp_dbilgi_Enter(object sender, EventArgs e)
        {

        }
    }
}
