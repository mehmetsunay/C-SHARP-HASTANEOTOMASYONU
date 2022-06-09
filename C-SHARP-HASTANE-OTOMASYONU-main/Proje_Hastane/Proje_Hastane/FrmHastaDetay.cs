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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi sb = new sqlbaglantisi();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbox_RanGec_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbl_TCno.Text = tc;

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", sb.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TCno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())

            {
                lbl_AdSoyadNo.Text = dr[0] + " " + dr[1];

              
            }

             sb.baglanti().Close();

            //randevu geçmişi
           
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, sb.baglanti());
            da.Fill(dt);
            dtg_randevu.DataSource = dt;

            //Branş Çekme

            SqlCommand komut2 = new SqlCommand("select BransAD From Tbl_Branslar",sb.baglanti());

            SqlDataReader dr2 = komut2.ExecuteReader();

            while(dr2.Read())
            {

                cmb_brans.Items.Add(dr2[0]);


            }

            sb.baglanti().Close();
         




        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",sb.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TCno.Text);
            komut.Parameters.AddWithValue("@p2", rtb_sikayet.Text);
            komut.Parameters.AddWithValue("@p3", txt_radid.Text);
            komut.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();


            SqlCommand komut3 = new SqlCommand("select DoktorAd +SPACE(1),DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1", sb.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())

            {
                cmb_doktor.Items.Add(dr3[0] + "" + dr3[1]);

               


            }

            sb.baglanti().Close();
        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + cmb_doktor.Text + "' and RandevuDurum=0", sb.baglanti());

            da.Fill(dt);
            dta_aktfran.DataSource = dt;

        }

        private void llabel_Bilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();

            fr.Tcno = lbl_TCno.Text;

            fr.Show();

        }

        private void dta_aktfran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dta_aktfran.SelectedCells[0].RowIndex;
            txt_radid.Text = dta_aktfran.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dta_aktfran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_randevu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
