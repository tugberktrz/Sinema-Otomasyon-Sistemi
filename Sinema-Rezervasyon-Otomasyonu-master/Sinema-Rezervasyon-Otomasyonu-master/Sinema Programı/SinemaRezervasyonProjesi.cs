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
    public partial class SinemaRezervasyonProjesi : Form
    {
        public SinemaRezervasyonProjesi()
        {
            InitializeComponent();
        }

        string ad, soyad;
        int koltukno, sayac =0, boskoltuk = 38, dolukoltuk = 0;

        string myConnectionString = "Server=localhost;Database=sinema;uid=root;pwd=2469";
        int[] dolukoltukdizi = new int[0];

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            bilet bil = new bilet();
            bil.film = cbFilm.Text;
            bil.koltukk = txtkoltukno.Text;
            bil.seans = cbSeans.Text;
            bil.isim = textisim.Text;
            bil.soyisim = txtsoyisim.Text;
            if (rbOgrenci.Checked)
            {
                bil.fiyat = "15₺";
            }
            else if (rbTam.Checked)
            {
                bil.fiyat = "30₺";
            }
            else
            {
                MessageBox.Show("Bilet seçmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (textisim.Text == "" || txtsoyisim.Text == "" || txtkoltukno.Text == "") MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!(rderkek.Checked || rdkadin.Checked)) MessageBox.Show("Lütfen cinsiyet seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                try
                {

                    ad = textisim.Text;
                    soyad = txtsoyisim.Text;
                    koltukno = Convert.ToInt32(txtkoltukno.Text);

                    if (koltukno < 1 || koltukno > 35)
                    {
                        MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtkoltukno.Text = "";
                    }
                    else
                    {
                       
                        if (Array.IndexOf(dolukoltukdizi, koltukno) == -1)
                        {
                          
                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;

                            if (koltukara != null)
                            {
                                koltukara.Text += "\r" + ad + " " + soyad; 
                                koltukara.BackColor = Color.GreenYellow;
                                dolukoltuk++; 
                                boskoltuk--; 

                                Array.Resize(ref dolukoltukdizi, dolukoltukdizi.Length+1);
                                dolukoltukdizi[sayac] = koltukno;
                                sayac++;

                                lbldolu.Text = dolukoltuk.ToString(); 
                                lblbos.Text = boskoltuk.ToString();   

                                textisim.Text = "";    
                                txtsoyisim.Text = "";
                                txtkoltukno.Text = "";


                                Image erkek = Image.FromFile("İconlar/E.png");
                                Image kadin = Image.FromFile("İconlar/K.png");
                                if (rdkadin.Checked)
                                {
                                    koltukara.Image = kadin;
                                }
                                else
                                {
                                    koltukara.Image = erkek;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girmiş olduğunuz koltuk numarasına ait koltuk dolu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkoltukno.Text = "";
                        }
                    }
                }
               
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtkoltukno.Text = "";
                }
            }
            
            bil.Show();

        }

        private void btniptalet_Click(object sender, EventArgs e)
        {
            try
            {
                    koltukno = Convert.ToInt32(txtiptalkoltukno.Text);
                  
                    if (koltukno < 1 || koltukno > 35)
                    {
                    MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtiptalkoltukno.Text = "";
                    }

                    else
                    {
                        if (Array.IndexOf(dolukoltukdizi, koltukno) != -1)
                        {

                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;
                            if (koltukara != null) 
                            {
                                koltukara.Text = koltukno + ".koltuk"; 
                                koltukara.BackColor = Color.FloralWhite;   
                                dolukoltuk--;                         
                                boskoltuk++;                           

                                int sirano = Array.IndexOf(dolukoltukdizi, koltukno); 
                                Array.Clear(dolukoltukdizi, sirano, 1);

                                lbldolu.Text = dolukoltuk.ToString();
                                lblbos.Text = boskoltuk.ToString();
                                txtiptalkoltukno.Text = "";

                                Image bos_koltuk = Image.FromFile("İconlar/VarsayılanKoltuk.png");
                                koltukara.Image = bos_koltuk; 
                            }
                        }
                        else
                        {
                            MessageBox.Show("İptal edilmek istenen koltuk zaten boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtiptalkoltukno.Text = "";
                        }
                   }

               }

                catch (Exception)
                {
                MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtiptalkoltukno.Text = "";
                }
        }

        private void koltuk17_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmListele();
            lbldolu.Text = dolukoltuk.ToString();
            lblbos.Text = boskoltuk.ToString();
        }

        public void filmListele()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            cbFilm.Items.Clear();
            MySqlCommand command = new MySqlCommand("select film_ad from filmler", connection);
            connection.Open();
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbFilm.Items.Add(reader["film_ad"].ToString());
            }
            connection.Close();
        }

    }
}
