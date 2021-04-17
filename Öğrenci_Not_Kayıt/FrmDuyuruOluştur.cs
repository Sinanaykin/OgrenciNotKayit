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
    public partial class FrmDuyuruOluştur : Form
    {
        public FrmDuyuruOluştur()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * from TblDuyurular", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmDuyuruOluştur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e) //Duyuru eklme
        {
            SqlCommand komut = new SqlCommand("insert into TblDuyurular (Icerik) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
        }

        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//tıkladığımız duyuruyu richbox a getirir
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            RchDuyuru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            this.Text = id; //secilen id yi sol üstte göstermek için
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TblDuyurular where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id); //string id oluşturmuştuk üstte onu kullandık genele tanımlamıştık
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            bgl.baglanti().Close();
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblDuyurular set Icerik=@p1 where ID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            komut.Parameters.AddWithValue("@p2", id);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            Listele();
        }
    }
}
