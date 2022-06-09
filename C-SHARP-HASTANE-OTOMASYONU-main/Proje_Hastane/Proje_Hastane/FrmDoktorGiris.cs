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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi sb = new sqlbaglantisi();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktor where DoktorTC=@p1 and DoktorSifre=@p2", sb.baglanti());

            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmDoktorDetay dd = new FrmDoktorDetay();
                dd.Tc = msk_tc.Text;
                dd.Show();

                this.Hide();

            }

            else
            {

                MessageBox.Show("Hatalı TC yada Şifre");
            }

            sb.baglanti().Close();
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
