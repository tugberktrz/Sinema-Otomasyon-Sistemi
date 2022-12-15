using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinema_Programı
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnkullanici_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciGirisEkrani kullanici = new KullaniciGirisEkrani();
            kullanici.Closed += (s, args) => this.Close();
            kullanici.Show();
        }

        private void btnyonetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiGirisEkrani yonetici = new YoneticiGirisEkrani();
            yonetici.Closed += (s, args) => this.Close();
            yonetici.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
