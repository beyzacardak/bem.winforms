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
        public int zaman { get; set; }
        public double sinir { get; set; }

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
        


        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                zaman = int.Parse(streamReader.ReadLine());
                sinir = zaman / 10;
            }
            timer1.Enabled = true;
            timer1.Interval = 1000;
            
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.lblKalanZaman.Text = string.Format("{0:00}:{1:00}:{2:00}", (zaman / 3600), (zaman / 60), (zaman % 60));

            if (zaman<=sinir)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            zaman--;

            if (zaman==0)
            {
                timer1.Stop();
            }
        }
        
    }
}
