using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public partial class frmSinavEkrani : Form
    {
        public string AdSoyad { get; set; }
        public string SinavDosyaYolu { get; set; }

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) :this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }
        int saat=24, dakika=60, saniye=60;


        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
            }
            timer1.Enabled = true;
            timer1.Interval = 1000;
            
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye==0)
            {
                saniye = 60;
                dakika--;
            }
            if (dakika==0)
            {
                dakika = 60;
                saat--;
            }
            lblKalanZaman.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString();
            
        }
        public string adsoyad { get; set; }
        public string sinavadi { get; set; }
        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = adsoyad;
            //lblSinavAdi.Text = sinavadi;
        }
    }
}
