using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sinema_Programı
{
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();

        }
        //F53on24d91
        string myConnectionString = "Server=localhost;Database=sinema;uid=root;pwd=2469";


        public static string[] user = new string[1];
         public static string[] pass = new string[1];
        public static int m = 1;


        public void filmListele()
        {
            cbFilm.Items.Clear();
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand("select film_ad from filmler",connection);
            connection.Open();
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbFilm.Items.Add(reader["film_ad"].ToString());
            }
            connection.Close();
        }


        private void btnprev_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();
            this.Hide();
            geri.Show();
        }
        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            filmListele();
        }


        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand("insert into filmler (film_ad, film_tur, film_yonetmeni, film_oyuncuları, film_imdb) values ('"+txtFilmAd.Text+"','"+txtFilmtur.Text+"','"+txtFilmYonetmen.Text+"','"+txtFilmOyuncu.Text+"','"+txtFilmImdb.Text+"')", connection);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Film başarılı bir şekilde eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Film eklenirken bir hata oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            filmListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand("insert into filmsalonseans (film_ad, salon_no, seans_saat, tarih) values ('"+cbFilm.Text+"','"+Convert.ToInt32(cbSalonNo.Text)+"','"+cbSeans.Text+"','"+dateTimePicker1.Text+"')", connection);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Seans başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seans eklenirken bir hata oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
