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
    public partial class FrmSekreter : Form
    {
        public FrmSekreter()
        {
            InitializeComponent();
        }
        sqlbaglantisi sb = new sqlbaglantisi();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", sb.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);

          SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())

            {
                Frmsekreterdetay sd = new Frmsekreterdetay();
                sd.tc = msk_tc.Text;
                sd.Show();
                this.Hide();
            


            }

            else
            {

                MessageBox.Show("Hatalı TC & Şifre","Tekrar Deneyin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sb.baglanti().Close();
            
        }
    }
}
