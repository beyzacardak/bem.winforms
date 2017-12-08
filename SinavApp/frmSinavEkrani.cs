using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public partial class frmSinavEkrani : Form
    {
        public frmSinavEkrani()
        {
            InitializeComponent();
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
