namespace StockDb
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtToplamFiyat = new TextBox();
            txtSatisFiyati = new TextBox();
            txtMiktari = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnSatisFiyat = new Button();
            btnSatisYap = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(320, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(789, 391);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTC);
            groupBox1.Location = new Point(28, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 160);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 106);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(31, 25);
            label1.TabIndex = 3;
            label1.Text = "TC";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(136, 103);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(132, 31);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(136, 62);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(132, 31);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(136, 21);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(132, 31);
            txtTC.TabIndex = 0;
            txtTC.TextChanged += txtTC_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatisFiyati);
            groupBox2.Controls.Add(txtMiktari);
            groupBox2.Controls.Add(txtUrunAdi);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Location = new Point(28, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 289);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 212);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 10;
            label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 168);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 9;
            label7.Text = "Satis Fiyati";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 124);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 8;
            label6.Text = "Miktari";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 80);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 7;
            label5.Text = "Urun Adi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 36);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 6;
            label4.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(136, 226);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(132, 31);
            txtToplamFiyat.TabIndex = 5;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(136, 177);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(132, 31);
            txtSatisFiyati.TabIndex = 4;
            txtSatisFiyati.TextChanged += txtSatisFiyati_TextChanged;
            // 
            // txtMiktari
            // 
            txtMiktari.Location = new Point(136, 128);
            txtMiktari.Name = "txtMiktari";
            txtMiktari.Size = new Size(132, 31);
            txtMiktari.TabIndex = 3;
            txtMiktari.Text = "1";
            txtMiktari.TextAlign = HorizontalAlignment.Center;
            txtMiktari.TextChanged += txtMiktari_TextChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(136, 79);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(132, 31);
            txtUrunAdi.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(136, 30);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(132, 31);
            txtBarkodNo.TabIndex = 1;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(664, 585);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 4;
            label9.Text = "Genel Tpm";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(798, 585);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 5;
            label10.Text = "label10";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 150);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(1127, 43);
            button2.Name = "button2";
            button2.Size = new Size(100, 61);
            button2.TabIndex = 14;
            button2.Text = "Marka";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1006, 42);
            button1.Name = "button1";
            button1.Size = new Size(98, 61);
            button1.TabIndex = 13;
            button1.Text = "Kategori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(814, 42);
            button9.Name = "button9";
            button9.Size = new Size(174, 61);
            button9.TabIndex = 12;
            button9.Text = "Satislarin Listeleme";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(619, 42);
            button8.Name = "button8";
            button8.Size = new Size(174, 61);
            button8.TabIndex = 11;
            button8.Text = "Urun Listeleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(417, 42);
            button7.Name = "button7";
            button7.Size = new Size(174, 61);
            button7.TabIndex = 10;
            button7.Text = "Urun Ekleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(222, 42);
            button6.Name = "button6";
            button6.Size = new Size(174, 61);
            button6.TabIndex = 9;
            button6.Text = "Musteri Listeleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(25, 42);
            button5.Name = "button5";
            button5.Size = new Size(174, 61);
            button5.TabIndex = 8;
            button5.Text = "Musteri Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(314, 576);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1115, 167);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSatisFiyat
            // 
            btnSatisFiyat.Location = new Point(1115, 215);
            btnSatisFiyat.Name = "btnSatisFiyat";
            btnSatisFiyat.Size = new Size(112, 34);
            btnSatisFiyat.TabIndex = 9;
            btnSatisFiyat.Text = "Satis Fiyati";
            btnSatisFiyat.UseVisualStyleBackColor = true;
            btnSatisFiyat.Click += btnSatisFiyat_Click;
            // 
            // btnSatisYap
            // 
            btnSatisYap.Location = new Point(955, 576);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(112, 34);
            btnSatisYap.TabIndex = 10;
            btnSatisYap.Text = "Satis Yap";
            btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1254, 676);
            Controls.Add(btnSatisYap);
            Controls.Add(btnSatisFiyat);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtToplamFiyat;
        private TextBox txtSatisFiyati;
        private TextBox txtMiktari;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button btnEkle;
        private Button btnSil;
        private Button btnSatisFiyat;
        private Button btnSatisYap;
        private Button button2;
        private Button button1;
    }
}
