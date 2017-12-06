namespace FromApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyAd = new System.Windows.Forms.Label();
            this.lblKimlikNo = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.lblUzmanlik = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.pnlCinsiyet = new System.Windows.Forms.Panel();
            this.rbDiger = new System.Windows.Forms.RadioButton();
            this.rdbCinsiyetErkek = new System.Windows.Forms.RadioButton();
            this.rdbCinsiyetKadin = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(13, 31);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyAd
            // 
            this.lblSoyAd.AutoSize = true;
            this.lblSoyAd.Location = new System.Drawing.Point(13, 62);
            this.lblSoyAd.Name = "lblSoyAd";
            this.lblSoyAd.Size = new System.Drawing.Size(37, 13);
            this.lblSoyAd.TabIndex = 1;
            this.lblSoyAd.Text = "Soyad";
            // 
            // lblKimlikNo
            // 
            this.lblKimlikNo.AutoSize = true;
            this.lblKimlikNo.Location = new System.Drawing.Point(12, 93);
            this.lblKimlikNo.Name = "lblKimlikNo";
            this.lblKimlikNo.Size = new System.Drawing.Size(74, 13);
            this.lblKimlikNo.TabIndex = 2;
            this.lblKimlikNo.Text = "T.C. Kimlik No";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(104, 20);
            this.txtAd.TabIndex = 3;
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 55);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(104, 20);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(112, 86);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(104, 20);
            this.txtKimlikNo.TabIndex = 5;
            this.txtKimlikNo.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 175);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(204, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(112, 122);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(104, 20);
            this.txtUzmanlik.TabIndex = 8;
            this.txtUzmanlik.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // lblUzmanlik
            // 
            this.lblUzmanlik.AutoSize = true;
            this.lblUzmanlik.Location = new System.Drawing.Point(13, 129);
            this.lblUzmanlik.Name = "lblUzmanlik";
            this.lblUzmanlik.Size = new System.Drawing.Size(50, 13);
            this.lblUzmanlik.TabIndex = 9;
            this.lblUzmanlik.Text = "Uzmanlık";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Location = new System.Drawing.Point(112, 152);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(47, 17);
            this.chkAktif.TabIndex = 10;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // pnlCinsiyet
            // 
            this.pnlCinsiyet.Controls.Add(this.rbDiger);
            this.pnlCinsiyet.Controls.Add(this.rdbCinsiyetErkek);
            this.pnlCinsiyet.Controls.Add(this.rdbCinsiyetKadin);
            this.pnlCinsiyet.Location = new System.Drawing.Point(222, 175);
            this.pnlCinsiyet.Name = "pnlCinsiyet";
            this.pnlCinsiyet.Size = new System.Drawing.Size(186, 25);
            this.pnlCinsiyet.TabIndex = 14;
            // 
            // rbDiger
            // 
            this.rbDiger.AutoSize = true;
            this.rbDiger.Location = new System.Drawing.Point(130, 3);
            this.rbDiger.Name = "rbDiger";
            this.rbDiger.Size = new System.Drawing.Size(50, 17);
            this.rbDiger.TabIndex = 16;
            this.rbDiger.TabStop = true;
            this.rbDiger.Tag = "2";
            this.rbDiger.Text = "Diğer";
            this.rbDiger.UseVisualStyleBackColor = true;
            // 
            // rdbCinsiyetErkek
            // 
            this.rdbCinsiyetErkek.AutoSize = true;
            this.rdbCinsiyetErkek.Location = new System.Drawing.Point(58, 3);
            this.rdbCinsiyetErkek.Name = "rdbCinsiyetErkek";
            this.rdbCinsiyetErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbCinsiyetErkek.TabIndex = 15;
            this.rdbCinsiyetErkek.TabStop = true;
            this.rdbCinsiyetErkek.Tag = "1";
            this.rdbCinsiyetErkek.Text = "Erkek";
            this.rdbCinsiyetErkek.UseVisualStyleBackColor = true;
            // 
            // rdbCinsiyetKadin
            // 
            this.rdbCinsiyetKadin.AutoSize = true;
            this.rdbCinsiyetKadin.Location = new System.Drawing.Point(3, 3);
            this.rdbCinsiyetKadin.Name = "rdbCinsiyetKadin";
            this.rdbCinsiyetKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbCinsiyetKadin.TabIndex = 14;
            this.rdbCinsiyetKadin.TabStop = true;
            this.rdbCinsiyetKadin.Tag = "0";
            this.rdbCinsiyetKadin.Text = "Kadın";
            this.rdbCinsiyetKadin.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 233);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 86);
            this.listView1.SmallImageList = this.imageList2;
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "T.C. Kimlik No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Uzmanlık";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plastic_model_3XN_icon.ico");
            this.imageList1.Images.SetKeyName(1, "akrep.png");
            this.imageList1.Images.SetKeyName(2, "aslan.png");
            this.imageList1.Images.SetKeyName(3, "balik.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.jpg | *.png";
            this.openFileDialog1.InitialDirectory = "c:\\";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(225, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 118);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Resim Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar1.Location = new System.Drawing.Point(12, 335);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.güncelleToolStripMenuItem.Text = "güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 370);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pnlCinsiyet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.lblUzmanlik);
            this.Controls.Add(this.txtUzmanlik);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblKimlikNo);
            this.Controls.Add(this.lblSoyAd);
            this.Controls.Add(this.lblAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCinsiyet.ResumeLayout(false);
            this.pnlCinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyAd;
        private System.Windows.Forms.Label lblKimlikNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.Label lblUzmanlik;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Panel pnlCinsiyet;
        private System.Windows.Forms.RadioButton rdbCinsiyetErkek;
        private System.Windows.Forms.RadioButton rdbCinsiyetKadin;
        private System.Windows.Forms.RadioButton rbDiger;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}

