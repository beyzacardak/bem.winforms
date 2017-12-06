using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isUpdate;
        
        private int selectedRowIndex=-1;
        

        public object ImageList2 { get; private set; }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kisi = (isUpdate) ? (Kisi)lstKisi.SelectedItem : new Kisi();

            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.TcKimlikNo = txtKimlikNo.Text;
            kisi.Uzmanlik = txtUzmanlik.Text;

            if (!isUpdate)
            {
                lstKisi.Items.Add(kisi);

                //var ListItem = new ListViewItem(new[] { $"{ kisi.Ad }", $"{ kisi.Soyad}" });
                //listView1.Items.Add(ListItem);

                var ListItem = new ListViewItem(new[] { txtAd.Text, txtSoyad.Text, txtKimlikNo.Text, txtUzmanlik.Text });
                listView1.Items.Add(ListItem);
            }
            else
            {
                lstKisi.Items[lstKisi.SelectedIndex] = kisi;
               
            }

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKimlikNo.Text = "";
            txtUzmanlik.Text = "";

            isUpdate = false;
        }

        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem is null)
            {
                return;
            }

            Kisi gelenKisi = lstKisi.SelectedItem as Kisi;

            txtAd.Text = gelenKisi.Ad;
            txtSoyad.Text = gelenKisi.Soyad;
            txtKimlikNo.Text = gelenKisi.TcKimlikNo;
            txtUzmanlik.Text = gelenKisi.Uzmanlik;

            isUpdate = true;
        }

        

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var lv = sender as ListView;
            if (lv is null)
            {
                return;
            }

            var selected = lv.SelectedItems[0];
            

            txtAd.Text = selected.SubItems[0].Text;
            txtSoyad.Text = selected.SubItems[1].Text;
            txtKimlikNo.Text = selected.SubItems[2].Text;
            txtUzmanlik.Text = selected.SubItems[3].Text;
            
            pictureBox1.Image = ımageList2.Images[selected.ImageIndex];

            isUpdate = true;
            selectedRowIndex = lv.SelectedIndices[0];
        }

        private void yukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap img = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image=img;

        }

        
    }
}
