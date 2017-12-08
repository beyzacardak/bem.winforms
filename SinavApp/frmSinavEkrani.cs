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
        
        

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (zaman == 0)
            {
                timer1.Stop();
            }
            this.lblKalanZaman.Text = string.Format("{0:00}:{1:00}:{2:00}", (zaman / 3600), (zaman / 60), (zaman % 60));

            if (zaman<=sinir)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            zaman--;

            
        }

        private void frmSinavEkrani_Load_1(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                zaman = int.Parse(streamReader.ReadLine());
                sinir = zaman / 10;

                int position = 0;
                int position2 = 0;
                string satir = "";
                do
                {

                    satir = streamReader.ReadLine();

                    if (!string.IsNullOrWhiteSpace(satir))
                    {

                    
                    var label = new Label();
                    var groupbox = new GroupBox();
                    //label.Size = new Size(120, 20);
                    label.AutoSize = true;
                    groupbox.AutoSize = true;

                    label.Location = new Point(0,position);
                    groupbox.Location = new Point(0, position2);
                    position += 50;
                    
                    label.Text = satir.Substring(0,satir.IndexOf(@"|"));




                    panel1.Controls.Add(label);
                    panel1.Controls.Add(groupbox);
                    }

                } while (!string.IsNullOrWhiteSpace(satir));
            }
            timer1.Start();
            timer1.Interval = 1000;
        }
    }
}
