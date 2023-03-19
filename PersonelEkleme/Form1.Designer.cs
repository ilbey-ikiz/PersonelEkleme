namespace OdevvErdıncHoca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            mtbTelefon = new MaskedTextBox();
            pbResim = new PictureBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            btnResimSec = new Button();
            dtpDogumTarihi = new DateTimePicker();
            dtpIseGirisTarihi = new DateTimePicker();
            txtAdres = new TextBox();
            txtMail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvPersonelBilgileri = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtbTelefon);
            groupBox1.Controls.Add(pbResim);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(btnResimSec);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(dtpIseGirisTarihi);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 3);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1001, 441);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(182, 278);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(225, 34);
            mtbTelefon.TabIndex = 4;
            // 
            // pbResim
            // 
            pbResim.Location = new Point(538, 225);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(215, 198);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 4;
            pbResim.TabStop = false;
            pbResim.ImageLocation = "";
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Location = new Point(801, 381);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(178, 42);
            btnSil.TabIndex = 11;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Location = new Point(801, 333);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(178, 42);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.Location = new Point(801, 281);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(178, 42);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnResimSec
            // 
            btnResimSec.BackColor = SystemColors.ActiveCaption;
            btnResimSec.Location = new Point(801, 225);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(178, 42);
            btnResimSec.TabIndex = 8;
            btnResimSec.Text = "RESİM SEÇ";
            btnResimSec.UseVisualStyleBackColor = false;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDogumTarihi.Location = new Point(182, 219);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(225, 30);
            dtpDogumTarihi.TabIndex = 3;
            // 
            // dtpIseGirisTarihi
            // 
            dtpIseGirisTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dtpIseGirisTarihi.Location = new Point(730, 150);
            dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            dtpIseGirisTarihi.Size = new Size(235, 30);
            dtpIseGirisTarihi.TabIndex = 7;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(628, 46);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(337, 74);
            txtAdres.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(182, 327);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(225, 34);
            txtMail.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(182, 167);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(225, 34);
            txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(182, 117);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(225, 34);
            txtAd.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(182, 64);
            txtID.Name = "txtID";
            txtID.Size = new Size(225, 34);
            txtID.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(538, 155);
            label8.Name = "label8";
            label8.Size = new Size(172, 28);
            label8.TabIndex = 0;
            label8.Text = "İŞE GİRİŞ TARİHİ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(538, 70);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 0;
            label7.Text = "ADRES:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 333);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 0;
            label6.Text = "E-MAİL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 281);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 0;
            label5.Text = "TELEFON NO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 225);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 0;
            label4.Text = "DOĞUM TARİHİ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 173);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 0;
            label3.Text = "SOYAD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 123);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 0;
            label2.Text = "AD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 70);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 0;
            label1.Text = "PERSONEL ID:";
            // 
            // lvPersonelBilgileri
            // 
            lvPersonelBilgileri.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvPersonelBilgileri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lvPersonelBilgileri.FullRowSelect = true;
            lvPersonelBilgileri.GridLines = true;
            lvPersonelBilgileri.Location = new Point(55, 451);
            lvPersonelBilgileri.Name = "lvPersonelBilgileri";
            lvPersonelBilgileri.Size = new Size(954, 375);
            lvPersonelBilgileri.TabIndex = 1;
            lvPersonelBilgileri.UseCompatibleStateImageBehavior = false;
            lvPersonelBilgileri.View = View.Details;
            lvPersonelBilgileri.SelectedIndexChanged += lvPersonelBilgileri_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel ID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "İse Giriş Tarihi";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mail Adresi";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Resim Yolu";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 850);
            Controls.Add(lvPersonelBilgileri);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox groupBox1;
        public PictureBox pbResim;
        public Button btnSil;
        public Button btnGuncelle;
        public Button btnKaydet;
        public Button btnResimSec;
        public DateTimePicker dtpDogumTarihi;
        public DateTimePicker dtpIseGirisTarihi;
        public TextBox txtAdres;
        public TextBox txtMail;
        public TextBox txtSoyad;
        public TextBox txtAd;
        public TextBox txtID;
        public Label label8;
        public Label label7;
        public Label label6;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
        public MaskedTextBox mtbTelefon;
        public ListView lvPersonelBilgileri;
        public ColumnHeader columnHeader1;
        public ColumnHeader columnHeader2;
        public ColumnHeader columnHeader3;
        public ColumnHeader columnHeader4;
        public ColumnHeader columnHeader5;
        public ColumnHeader columnHeader6;
    }
}