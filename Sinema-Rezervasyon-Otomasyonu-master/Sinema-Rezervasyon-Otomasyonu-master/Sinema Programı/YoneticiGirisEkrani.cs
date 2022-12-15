using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sinema_Programı
{
    public partial class YoneticiGirisEkrani : Form
    {
        public YoneticiGirisEkrani()
        {
            InitializeComponent();
        }
        //F53on24d91
        string myConnectionString = "Server=localhost;Database=sinema;uid=root;pwd=2469";

        public static string Yonetici = "Admin";
        public static string parola = "123456";
        private void btnyoneticigiris_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand("select * from kasiyerler where kasiyer_kullaniciadi = '" + txtkullaniciadi.Text + "'", connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (txtkullaniciadi.Text == reader["kasiyer_kullaniciadi"].ToString() && txtparola.Text == reader["kasiyer_sifre"].ToString())
                {
                    this.Hide();
                    YoneticiPaneli yoneticipaneli = new YoneticiPaneli();
                    yoneticipaneli.Closed += (s, args) => this.Close();
                    yoneticipaneli.Show();
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

            private void txtkullaniciadi_Enter(object sender, EventArgs e)
            {
                if (txtkullaniciadi.Text == "Kullanıcı Adınız")
                {
                    txtkullaniciadi.Text = "";
                    txtkullaniciadi.ForeColor = Color.Black;
                }
            }

            private void txtkullaniciadi_Leave(object sender, EventArgs e)
            {
                if (txtkullaniciadi.Text == "")
                {
                    txtkullaniciadi.Text = "Kullanıcı Adınız";
                    txtkullaniciadi.ForeColor = Color.Gray;
                }
            }

            private void YoneticiGirisEkrani_Load(object sender, EventArgs e)
            {

                txtkullaniciadi.Text = "Kullanıcı Adınız";
                txtkullaniciadi.ForeColor = Color.Gray;
                txtparola.Text = "Parolanız";
                txtparola.ForeColor = Color.Gray;
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

        public void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Resim Dosyaları | *.jpg;*.jpeg;*.png";
            openFileDialog1.ShowDialog();
            string dosya = openFileDialog1.FileName;
            pictureBox3.ImageLocation = dosya;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox3.ImageLocation.ToString() != "")
                {
                    string imagePath = pictureBox3.ImageLocation.ToString();
                    string imagepath = imagePath.ToString();
                    imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                    imagepath = imagepath.Remove(0, 1);
                    MySqlConnection connection = new MySqlConnection(myConnectionString);
                    MySqlCommand command = new MySqlCommand("select kasiyer_parmak from kasiyerler", connection);
                    MySqlDataReader reader;
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (imagepath == reader["kasiyer_parmak"].ToString())
                        {
                            this.Hide();
                            YoneticiPaneli yoneticipaneli = new YoneticiPaneli();
                            yoneticipaneli.Closed += (s, args) => this.Close();
                            yoneticipaneli.Show();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
    }
    }

