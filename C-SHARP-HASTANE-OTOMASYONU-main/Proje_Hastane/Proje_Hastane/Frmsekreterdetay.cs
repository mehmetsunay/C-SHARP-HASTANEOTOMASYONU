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
    public partial class Frmsekreterdetay : Form
    {
        public Frmsekreterdetay()
        {
            InitializeComponent();
        }

        private void gbox_kisisel_Enter(object sender, EventArgs e)
        {

        }

        public String tc;
        sqlbaglantisi sb = new sqlbaglantisi();

        private void Frmsekreterdetay_Load(object sender, EventArgs e)
        {
             lbl_TCno.Text=tc;

            //ad soyad çekimi
            
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", sb.baglanti());
            komut1.Parameters.AddWithValue("@p1",lbl_TCno.Text);
            SqlDataReader sd1 = komut1.ExecuteReader();

            while(sd1.Read())
            {
                lbl_AdSoyadNo.Text = sd1[0].ToString();

            }

            sb.baglanti().Close();


            //Data Gride Branşları çek

            DataTable dt1 = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From Tbl_Branslar", sb.baglanti());
            da.Fill(dt1);

            dtg_branslar.DataSource = dt1;


            //Doktorları Çek

            DataTable dt2 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' '+DoktorSoyad) as Doktorlar, DoktorBrans From Tbl_Doktor", sb.baglanti());

            da2.Fill(dt2);
            dtg_doktorlar.DataSource = dt2;

            //comboya brans cek

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar",sb.baglanti());

            SqlDataReader dr = komut2.ExecuteReader();

            while(dr.Read())
            {

                cmb_brans.Items.Add(dr[0]);

            }
            sb.baglanti().Close();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)", sb.baglanti());

            kaydet.Parameters.AddWithValue("r1", mtb_tarih.Text);
            kaydet.Parameters.AddWithValue("r2", mtb_saat.Text);
            kaydet.Parameters.AddWithValue("r3", cmb_brans.Text);
            kaydet.Parameters.AddWithValue("r4", cmb_doktor.Text);

            kaydet.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturuldu");
            
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();

            SqlCommand komut3 =new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1",sb.baglanti());

            komut3.Parameters.AddWithValue("@p1", cmb_brans.Text);

            SqlDataReader dr = komut3.ExecuteReader();

            while(dr.Read())
            {
                cmb_doktor.Items.Add( dr[0] + " "+ dr[1]);

            }
            sb.baglanti().Close();


        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru)values (@d1)", sb.baglanti());
            komut.Parameters.AddWithValue("@d1",rtb_sikayet.Text);
            komut.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Duyurunuz Oluşturuldu");
        }

        private void btn_doktor_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli dp = new FrmDoktorPaneli();
            dp.Show();
            
        }

        private void btn_brans_Click(object sender, EventArgs e)
        {
            FrmBrans br = new FrmBrans();
            br.Show();
        }

        private void btn_ranlis_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi rl = new FrmRandevuListesi();
            rl.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular dy = new FrmDuyurular();

            dy.Show();
        }

        private void cbox_durum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_AdSoyadNo_Click(object sender, EventArgs e)
        {

        }
    }
}
