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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            using(var streamReader = new StreamReader(openFileDialog1.FileName))
            {
                int position = 0;
                string satir = "";
                do {

                    satir = streamReader.ReadLine();

                    var label = new Label();
                    //label.Size = new Size(120, 20);
                    label.AutoSize = true;

                    label.Location = new Point(0, position);
                    position += 50;

                    label.Text = satir;

                    panel1.Controls.Add(label);
                } while (!string.IsNullOrWhiteSpace(satir));
            }
        }
    }
}
