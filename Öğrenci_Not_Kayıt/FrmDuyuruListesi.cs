﻿using System;
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
    public partial class FrmDuyuruListesi : Form
    {
        public FrmDuyuruListesi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmDuyuruListesi_Load(object sender, EventArgs e)//DuyuruListesi sayfası yüklenince formda dinamik bir listbox aracı oluşssun istersek bunu toolbox danda ekleyebilirdik
        {
            ListBox lst = new ListBox();
            Point lstkonum = new Point(10, 10);
            lst.Name = "ListBox1";
            lst.Height = 250;
            lst.Width = 450;
            lst.Font = new Font("Georgia", 14, FontStyle.Regular);
            lst.Location = lstkonum;
            this.Controls.Add(lst);

            //Duyuruları listeleme kodları
            SqlCommand komut = new SqlCommand("Select * from TblDuyurular", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lst.Items.Add(dr[0] + ":" + dr[1]);
            }
            bgl.baglanti().Close();
        }
    }
}
