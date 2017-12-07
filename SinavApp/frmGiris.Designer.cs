namespace SinavApp
{
    partial class frmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnSinavSec = new System.Windows.Forms.Button();
            this.lblSinavDosyaYolu = new System.Windows.Forms.Label();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 28);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(125, 116);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // btnSinavSec
            // 
            this.btnSinavSec.Location = new System.Drawing.Point(55, 152);
            this.btnSinavSec.Name = "btnSinavSec";
            this.btnSinavSec.Size = new System.Drawing.Size(75, 23);
            this.btnSinavSec.TabIndex = 4;
            this.btnSinavSec.Text = "Sınav Seç";
            this.btnSinavSec.UseVisualStyleBackColor = true;
            // 
            // lblSinavDosyaYolu
            // 
            this.lblSinavDosyaYolu.AutoSize = true;
            this.lblSinavDosyaYolu.Location = new System.Drawing.Point(166, 161);
            this.lblSinavDosyaYolu.Name = "lblSinavDosyaYolu";
            this.lblSinavDosyaYolu.Size = new System.Drawing.Size(35, 13);
            this.lblSinavDosyaYolu.TabIndex = 5;
            this.lblSinavDosyaYolu.Text = "label2";
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(55, 201);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(170, 23);
            this.btnDevamEt.TabIndex = 6;
            this.btnDevamEt.Text = "DEVAM >>";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 465);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.lblSinavDosyaYolu);
            this.Controls.Add(this.btnSinavSec);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "frmGiris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnSinavSec;
        private System.Windows.Forms.Label lblSinavDosyaYolu;
        private System.Windows.Forms.Button btnDevamEt;
    }
}

