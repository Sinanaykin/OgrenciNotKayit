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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        void OgrenciListesi() //ogrenci listesi çağormak için metot olusturduk aşagıda çağırıcaz form_load da
        {
            SqlCommand komut = new SqlCommand("Select * from TblOgrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //2. YOL
            // SqlCommand komut = new SqlCommand("Select * from TblOgrenci", bgl.baglanti());
            //SqlDataReader dr = komut.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dataGridView1.DataSource = dt;

            //3. YOL
            //SqlCommand komut = new SqlCommand("Select * from TblOgrenci", bgl.baglanti());
            //SqlDataReader dr = komut.ExecuteReader();
            //dataGridView1.Columns.Add("AD","");
            //dataGridView1.Columns.Add("SOYAD", "");

            //while (dr.Read())
            //{
            //    dataGridView1.Rows.Add(dr["AD"],dr["SOYAD"]);
            //}


        }

        void NotListesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler",bgl.baglanti()); //notlistemek için prosedürümüzü kullanıyoruz ve datagrieview2 ye yazdırıyoruz bu metodu altta cağırarak
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            //2.YOL
            //SqlCommand komut = new SqlCommand("Execute Ogrenciler",bgl.baglanti()); 
            //  SqlDataReader dr = komut.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dataGridView2.DataSource = dt;

        }



        public string numara; //MskOgretmenNumara nın text inde geliyor

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            OgrenciListesi();//ogrenci listeleme metodunu çağırdık öğretmen giriş yapınca datagriedview1 de öğrenciler listelenir.
            NotListesi();//metodu çağırıyoruz ve notlar geliyor öğretmen giriş yapınca

            LblNumara.Text = numara; //lblnumaranın textine atanan numarayı yazdır

            SqlCommand komut = new SqlCommand("Select * from TblOgretmen where NUMARA=@p1", bgl.baglanti()); //numaraya göre isim bilgisi getirme
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];//tablomuzda 1. indexte ad 2. index de soyad vardır ondan böyle yaptık

            }
            bgl.baglanti().Close();
        }

        string Fotograf;
           private void BtnFotografSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //klasörü aç göster 
            Fotograf = openFileDialog1.FileName;//fotograf a sectiğin dosyayı ata
            pictureBox1.ImageLocation = Fotograf;//pictureboxın ımagelocation alanına Fotograf ı ata
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblOgrenci (AD,SOYAD,NUMARA,SIFRE,FOTOGRAF) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskNumara.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", Fotograf);

            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
           
        }

  

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//datagriedviewe tıklanınca verileri araçlara taşısın
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; //Bu kısım öğrenciyi getirir
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();



            SqlCommand komut = new SqlCommand("Select * from TblNotlar where OGRID=(Select ID from TblOgrenci where NUMARA=@p1)", bgl.baglanti()); //Bu kısım notları getirir
            komut.Parameters.AddWithValue("@p1", MskNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                TxtSınav1.Text = dr[1].ToString();
                TxtSınav2.Text = dr[2].ToString();
                TxtSınav3.Text = dr[3].ToString();
                TxtProje.Text = dr[4].ToString();
                TxtOrtalama.Text = dr[5].ToString();
                TxtDurum.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            //Öğrenci bilgilerini günceller
            SqlCommand komut = new SqlCommand("Update TblOgrenci set AD=@p1,SOYAD=@p2,SIFRE=@p3,FOTOGRAF=@p4 where NUMARA=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p4", Fotograf);
            komut.Parameters.AddWithValue("@p5", MskNumara.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Update TblNotlar set SINAV1=@p1,SINAV2=@p2,SINAV3=@p3,PROJE=@p4,ORTALAMA=@p5,DURUM=@p6 where OGRID=(Select ID from TblOgrenci where NUMARA=@p7)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtSınav1.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSınav2.Text);
            komut2.Parameters.AddWithValue("@p3", TxtSınav3.Text);
            komut2.Parameters.AddWithValue("@p4", TxtProje.Text);
            komut2.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtOrtalama.Text));
            komut2.Parameters.AddWithValue("@p6", TxtDurum.Text);
            komut2.Parameters.AddWithValue("@p7", MskNumara.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();

        }


         

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double sınav1, sınav2, sınav3, proje, ortalama;
            sınav1 = Convert.ToDouble(TxtSınav1.Text);
            sınav2 = Convert.ToDouble(TxtSınav2.Text);
            sınav3 = Convert.ToDouble(TxtSınav3.Text);
            proje = Convert.ToDouble(TxtProje.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            TxtOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                TxtDurum.Text = "True"; 
            }
            else
            {
                TxtDurum.Text = "False";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnDuyuruListesi_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            FrmDuyuruOluştur frm = new FrmDuyuruOluştur();
            frm.Show();
        }

        private void BtnDuyuruListesi_Click_1(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void BtnMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = LblNumara.Text; //numara bilgisi mesajlar formuna taşıyoruz önemli bunu yapmadan numarayı orda kullanamayız
            frm.Show();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
