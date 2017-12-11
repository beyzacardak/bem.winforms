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

                
                
                string satir = "";
                int soruSayisi = 0;
                int top = -350;
                int left = 0;

                while (!string.IsNullOrWhiteSpace((satir = streamReader.ReadLine())))
                {
                    soruSayisi++;
                    var items = satir.Split('|');

                    top += (soruSayisi % 2 == 1) ? 350 : 0;
                    left = (soruSayisi % 2 == 1) ? 0 : 286;

                    var groupBox = new GroupBox
                    {
                        Location = new Point(left, top),
                        Size = new Size(275, 300),
                        Text = $"{soruSayisi}. Soru"
                    };

                    var lbl = new Label
                    {
                        Text = items[0],
                        MaximumSize = new Size(260, 0),
                        AutoSize = true,
                        Location = new Point(15, 15)
                    };
                    int radiotop = lbl.Location.Y + lbl.PreferredHeight+15;
                    for (int i = 0; i < items.Length; i++)
                    {
                        var rdb = new RadioButton
                        {
                            Text = items[i],
                           
                            
                            Location = new Point(20, radiotop)
                        };
                    groupBox.Controls.Add(rdb);
                        radiotop += 30;
                }
                  
                    groupBox.Controls.Add(lbl);
                    
                    pnlSorular.Controls.Add(groupBox);

                };
            }
            timer1.Start();
            timer1.Interval = 1000;
        }
    }
}
