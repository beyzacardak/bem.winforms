﻿using System;
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
        public TimeSpan SinavSüresi { get; private set; }
        public double SinavSüresiYüzdeOn { get; private set; }
        //bool btnaktifmi=false;

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) : this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }

        public void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                SinavSüresi = TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()));
                SinavSüresiYüzdeOn = SinavSüresi.TotalSeconds * 0.1;

                string line = "";

                int soruSayisi = 0;
                int top = -350;
                int left = 0;

                while (!string.IsNullOrWhiteSpace((line = streamReader.ReadLine())))
                {
                    soruSayisi++;
                    var items = line.Split('|');

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

                    int radioTop = lbl.Location.Y+ lbl.PreferredHeight +15;

                    for (int i = 1; i < items.Length-1; i++)
                    {
                        var radio = new RadioButton
                        {
                            Text = items[i],
                            Location = new Point(20, radioTop),
                            //Enabled = false,
                            AutoSize = true,
                            MaximumSize = new Size(200,0)
                        };
                        

                        groupBox.Controls.Add(radio);

                        radioTop += 30;
                    }

                    groupBox.Controls.Add(lbl);

                    pnlSorular.Controls.Add(groupBox);

                    
                };


                
                //timer1.Interval = 1;
            }
          
        }
       
        private void basla_Click(object sender, EventArgs e)
        {
            //btnaktifmi = true;
            timer1.Start();
            
            //basla.Enabled = false;
 
        }

       



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SinavSüresi.TotalSeconds == 0)
            {
                timer1.Stop();
                basla.Enabled = false; 
            }
            this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");

            if (SinavSüresi.TotalSeconds <= SinavSüresiYüzdeOn)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            SinavSüresi = TimeSpan.FromSeconds(SinavSüresi.TotalSeconds - 1);
        }

      
        private void bitir_Click(object sender, EventArgs e)
        {
            cevaplarKayit();
            timer1.Stop();


        }
      

        private void cevaplarKayit()
         {
             int cevaplananSayisi = 0;

             using (var streamWriter = new StreamWriter(@"C:\Users\BEM\Source\Repos\bem.winforms\SinavApp\Cevaplar\" + lblSinavAdi.Text + "-" + lblAdSoyad.Text + "-001.txt", true))
             {
                 streamWriter.WriteLine($"{lblSinavAdi.Text}");
                 List<Control> Radiolar = new List<Control>();
                
                 foreach (var radio in Radiolar)
                 {
                     foreach (var control in radio.Controls)
                     {
                         if (control is RadioButton)
                       {
                            cevaplananSayisi++;
                             RadioButton radios = control as RadioButton;
                             if (radios.Checked)
                             {
                                 streamWriter.WriteLine($"{radio.Name} {cevaplananSayisi}");
                                cevaplananSayisi = 0;
                                 break;
                             }
                         }
                     }
                 }
            }
         }
 

    }
}
