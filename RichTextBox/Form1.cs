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

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur a maximus quam. Ut vehicula a mauris id aliquam. Morbi faucibus consequat interdum. Morbi cursus leo eu augue iaculis, et blandit eros finibus. Donec efficitur condimentum velit. Nam in augue at lacus mattis fringilla. Integer quis orci diam. Aenean eget tristique urna, eget varius libero. Ut id mollis magna.

Etiam sed accumsan risus, vitae gravida ex. Donec ex risus, mollis quis pulvinar nec, vehicula quis nisi. Integer eleifend urna sed tortor venenatis feugiat vitae in mi. Nam sagittis est at tincidunt dignissim. Curabitur nec ligula luctus, sollicitudin ligula at, aliquet nulla. Praesent vitae iaculis libero. Proin dignissim interdum commodo. Nam nec aliquam magna.";
        }

        private void btnFontSec_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void btnSolaYasla_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnOrtala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnSagaYasla_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void menuItemYeni_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void menuItemAç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            var reader = new StreamReader(openFileDialog1.FileName, Encoding.Default);

            var text = reader.ReadToEnd();

            richTextBox1.Text = text;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            using (var streamWriter = new StreamWriter(saveFileDialog1.FileName, true))
            {
                streamWriter.Write(richTextBox1.Text);
            }
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;

        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;

        }

        private void diğerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont=  new Font("Microsoft San Serif", 8);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Microsoft San Serif", 10);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Microsoft San Serif", 12);
        }
        
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            var a = float.Parse(toolStripTextBox1.Text);
            Font f = new Font("Arial", a,FontStyle.Regular);
            //richTextBox1.SelectionFont = new Font(toolStripTextBox1.Text);
        }

        private void inceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionFont = new Font("Arial", 11, FontStyle.Italic);
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            richTextBox1.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
        }

        private void altıÇizgiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionFont = new Font("Arial", 11, FontStyle.Underline);
        }
    }
}
