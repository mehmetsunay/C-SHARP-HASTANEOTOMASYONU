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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi sb = new sqlbaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", sb.baglanti());
            da.Fill(dt);
            dtg_brans.DataSource = dt;

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar(BransAd) values(@b1)",sb.baglanti());
     
            komut.Parameters.AddWithValue("@b1", txt_ad.Text);
            komut.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void dtg_brans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtg_brans.SelectedCells[0].RowIndex;
            txt_bid.Text = dtg_brans.Rows[secilen].Cells[0].Value.ToString();
            txt_ad.Text = dtg_brans.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Branslar where Bransid=@b1",sb.baglanti());

            komut.Parameters.AddWithValue("@b1",txt_bid.Text);
            komut.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

        
            
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Branslar set BransAd=@b1 where Bransid=@b2",sb.baglanti());

            komut.Parameters.AddWithValue("@b1",txt_ad.Text);
            komut.Parameters.AddWithValue("@b2", txt_bid.Text);
            komut.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Güncellendi");
        }
    }
}
