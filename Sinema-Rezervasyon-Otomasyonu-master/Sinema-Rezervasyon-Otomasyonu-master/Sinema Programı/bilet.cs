using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Programı
{
    public partial class bilet : Form
    {
        public bilet()
        {
            InitializeComponent();
        }

        public string film { get; set; }

        public string koltukk { get; set; }

        public string seans { get; set; }

        public string isim { get; set; }

        public string soyisim { get; set; }

        public string fiyat { get; set; }

        private void bilet_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000000, 999999999);
            string number = randomNumber.ToString();
            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = brCode.Draw(number, 100);
            label6.Text = number;
            lbFilm.Text = film;
            lbKoltuk.Text = koltukk.ToString();
            lbSeans.Text = seans;
            lbTarih.Text = DateTime.Today.ToShortDateString().ToString();
            lbAd.Text = isim.ToString() + "  " + soyisim.ToString();
            lbFiyat.Text = fiyat;
        }
    }
}
