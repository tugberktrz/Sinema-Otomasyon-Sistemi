using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sinema_Programı
{
    public partial class KullaniciGirisEkrani : Form
    {
        public KullaniciGirisEkrani()
        {
            InitializeComponent();
        }
        //F53on24d91
        string myConnectionString = "Server=localhost;Database=sinema;uid=root;pwd=2469";
        private void btnkullanicigiris_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand("select * from kullanicilar where kullanici_tel = '" + txtTelefon.Text + "'", connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (txtTelefon.Text == reader["kullanici_tel"].ToString() && txtparola.Text == reader["kullanici_sifre"].ToString())
                {
                    this.Hide();
                    SinemaRezervasyonProjesi sinema = new SinemaRezervasyonProjesi();
                    sinema.Closed += (s, args) => this.Close();
                    sinema.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da parola hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();
            this.Hide();
            geri.Show();
        }

        private void KullaniciGirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void txtkullaniciadi_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "")
            {
                txtTelefon.Text = "Kullanıcı Adınız";
                txtTelefon.ForeColor = Color.Gray;
            }
        }

        private void txtkullaniciadi_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "Kullanıcı Adınız")
            {
                txtTelefon.Text = "";
                txtTelefon.ForeColor = Color.Black;
            }
        }

        private void txtparola_Leave(object sender, EventArgs e)
        {
            if (txtparola.Text == "")
            {
                txtparola.Text = "Parolanız";
                txtparola.ForeColor = Color.Gray;
            }
        }

        private void txtparola_Enter(object sender, EventArgs e)
        {
            if (txtparola.Text == "Parolanız")
            {
                txtparola.Text = "";
                txtparola.ForeColor = Color.Black;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand("insert into kullanicilar (kullanici_ad, kullanici_soyad, kullanici_tel, kullanici_sifre) values ('"+txtUyelikAd.Text+"','"+txtUyelikSoyad.Text+"','"+txtUyelikTelefon.Text+"','"+txtUyelikSifre.Text+"')", connection);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Üyeliğiniz başarılı bir şekilde gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                SinemaRezervasyonProjesi sinema = new SinemaRezervasyonProjesi();
                sinema.Closed += (s, args) => this.Close();
                sinema.Show();
            }
            else
            {
                MessageBox.Show("Üyelik işleminiz başarısız oldu !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
