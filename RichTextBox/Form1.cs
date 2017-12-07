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
            richTextBox1.SelectionFont=  new Font(richTextBox1.Font.FontFamily, 8);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 10);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12);
        }
        private void toolStripTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            float boyut = float.Parse(toolStripTextBox1.Text);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, boyut);
        }


        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kalınToolStripMenuItem.Checked)
              {
                kalınToolStripMenuItem.Checked = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
              }
            else
            {
                kalınToolStripMenuItem.Checked = true ;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            }
        }
        private void italikToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (italikToolStripMenuItem.Checked)
            {
                italikToolStripMenuItem.Checked = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
            else
            {
                italikToolStripMenuItem.Checked = true;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);

            }
        }
        private void altıÇizgiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (altıÇizgiliToolStripMenuItem.Checked)
            {
                altıÇizgiliToolStripMenuItem.Checked = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
            else
            {
                altıÇizgiliToolStripMenuItem.Checked = true;

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);

            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
              {
                richTextBox1.Cut();
              }
           else
              {
                MessageBox.Show("Seçili alan yok");
              }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
            else
            {
                MessageBox.Show("Seçili alan yok");
            }
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromArgb(trackBar1.Value,trackBar2.Value,trackBar3.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
    }


    
}
