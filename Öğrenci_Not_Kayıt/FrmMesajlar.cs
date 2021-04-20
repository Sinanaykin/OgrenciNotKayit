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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        public string numara;

        void GelenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * from TblMesajlar where ALICI=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void GidenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * from TblMesajlar where GONDEREN=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

       
        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            MskGonderen.Text = numara;
            GelenMesajlar();
            GidenMesajlar();
        }

        private void BtnGönder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblMesajlar (GONDEREN,ALICI,BASLIK,İCERİK) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskGonderen.Text);//Gönderen ve Alıcı numara olarak ayarldık (öğrenci ve öğretmen)
            komut.Parameters.AddWithValue("@p2", MskAlıcı.Text);
            komut.Parameters.AddWithValue("@p3", TxtKonu.Text);
            komut.Parameters.AddWithValue("@p4", RchMesaj.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesajınız İletildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            GelenMesajlar();
            GidenMesajlar();
        }
    }
}
