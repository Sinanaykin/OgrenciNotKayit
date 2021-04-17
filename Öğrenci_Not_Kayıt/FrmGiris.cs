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

namespace Öğrenci_Not_Kayıt
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        SqlBaglantisi bgl = new SqlBaglantisi();


        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            //open olayını class içinde yaptıık ondan burda gerek yok.
            SqlCommand komut = new SqlCommand("Select * from TblOgretmen where NUMARA=@p1 and SIFRE=@p2", bgl.baglanti()); //bgl nesnesi  ile SqlBaglantisi classına gideriz ordan da baglanti metoduna
            komut.Parameters.AddWithValue("@p1", MskOgretmenNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgretmenSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmOgretmen frm = new FrmOgretmen();
                frm.numara = MskOgretmenNumara.Text; //numara ya  MASKEDTEXT DEKİ OGRETMENİN TEXTİNİ ATA
                frm.Show();
                MessageBox.Show("Sisteme Hoş Geldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }

        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblOgrenci where NUMARA=@p1 and SIFRE=@p2", bgl.baglanti()); //bgl nesnesi  ile SqlBaglantisi classına gideriz ordan da baglanti metoduna
            komut.Parameters.AddWithValue("@p1", MskOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenci frm = new FrmOgrenci();
                frm.Show();
                MessageBox.Show("Sisteme Hoş Geldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }
    }
}
