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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        sqlbaglantisi sb = new sqlbaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktor", sb.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //branşları combo boxa çek
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", sb.baglanti());

            SqlDataReader dr = komut2.ExecuteReader();

            while (dr.Read())
            {

                cmb_brans.Items.Add(dr[0]);

            }
            sb.baglanti().Close();


        }


     
        private void btn_Ekle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@d1,@d2,@d3,@d4,@d5)", sb.baglanti());

            komut.Parameters.Add("@d1", txt_Ad.Text);
            komut.Parameters.Add("@d2", txt_Soyad.Text);
            komut.Parameters.Add("@d3", cmb_brans.Text);
            komut.Parameters.Add("@d4", msk_tc.Text);
            komut.Parameters.Add("@d5", txt_sifre.Text);

            komut.ExecuteNonQuery();

            sb.baglanti().Close();

            MessageBox.Show("Doktor Bilgisi Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_tc.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
           txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();


        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Doktor where DoktorTC=@p1", sb.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            komut.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Kayıt Silindi","Bilgilendirme",MessageBoxButtons.OK);

        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktor set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4 ", sb.baglanti());

            komut.Parameters.Add("@d1", txt_Ad.Text);
            komut.Parameters.Add("@d2", txt_Soyad.Text);
            komut.Parameters.Add("@d3", cmb_brans.Text);
            komut.Parameters.Add("@d4", msk_tc.Text);
            komut.Parameters.Add("@d5", txt_sifre.Text);

            komut.ExecuteNonQuery();

            sb.baglanti().Close();

            MessageBox.Show("Doktor Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
