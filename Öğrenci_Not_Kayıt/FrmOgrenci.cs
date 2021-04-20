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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

       public  string numara;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara; //numara değişkenini herkese acık şekilde tanımladık ve  öğrenci forumnda ki LblNumara nın text ine  yazdırdık
           
            //numaraya göre isim getirme
            SqlCommand komut = new SqlCommand("Select * from TblOgrenci where NUMARA=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2]; //öğrenci tablosunda numrası secilen öğrencinin 1. ve 2. kolonlarını alır
                pictureBox1.ImageLocation = dr[5].ToString();//öğrenci tablosunda numrası secilen öğrencinin 5. kolonunu alır
            }
            

            //numaraya göre sınav notlarını getirdik.

            SqlCommand komut2 = new SqlCommand("Select * from TblNotlar where OGRID=(Select ID from TblOgrenci where NUMARA=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", LblNumara.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                LblSınav1.Text = dr2[1].ToString();
                LblSınav2.Text = dr2[2].ToString();
                LblSınav3.Text = dr2[3].ToString();
                LblProje.Text = dr2[4].ToString();
                LblOrtalama.Text = dr2[5].ToString();
                
            }
            bgl.baglanti().Close();

            if(Convert.ToDouble(LblOrtalama.Text)>=50)
            {
                LblDurum.Text = "Geçti";
            }
            else
            {
                LblDurum.Text = "Kaldı";
            }


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void BtnMesajlar_Click(object sender, EventArgs e) //çğrenci formundaki mesajlar butonuna tıklayınca mesajlar formuna göndersin.
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e) //duyurulara tıklayunca duyurular formundaki duyuruları listeler
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void BtnHesapMakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");//calc.exe hesap makinesini çalıştırmak için gereken komut
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gerçekten kapatmak istiyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
