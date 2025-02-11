namespace StockDb
{
    partial class frmUrunEkle
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnYeniEkle = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboMarka = new ComboBox();
            comboKategori = new ComboBox();
            txtSatisFiyati = new TextBox();
            txtAlisFiyati = new TextBox();
            txtMiktari = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            groupBox2 = new GroupBox();
            lblMiktari = new Label();
            btnVarOlanEkle = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            SatisFIyatitxt = new TextBox();
            AlisFiyatitxt = new TextBox();
            Miktaritxt = new TextBox();
            UrunAditxt = new TextBox();
            Markatxt = new TextBox();
            Kategoritxt = new TextBox();
            BarkodNotxt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboMarka);
            groupBox1.Controls.Add(comboKategori);
            groupBox1.Controls.Add(txtSatisFiyati);
            groupBox1.Controls.Add(txtAlisFiyati);
            groupBox1.Controls.Add(txtMiktari);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Location = new Point(70, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 419);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Urun";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 310);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 13;
            label7.Text = "Satis FIyati";
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.Location = new Point(173, 370);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(79, 34);
            btnYeniEkle.TabIndex = 2;
            btnYeniEkle.Text = "Ekle";
            btnYeniEkle.UseVisualStyleBackColor = true;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 265);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 12;
            label6.Text = "Alis Fiyati";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 220);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 11;
            label5.Text = "Miktari";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 175);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 10;
            label4.Text = "Urun Adi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 130);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 9;
            label3.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 85);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 8;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 7;
            label1.Text = "BarkodNo";
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(121, 133);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(148, 33);
            comboMarka.TabIndex = 6;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(121, 84);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(148, 33);
            comboKategori.TabIndex = 5;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(121, 323);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(150, 31);
            txtSatisFiyati.TabIndex = 4;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Location = new Point(121, 276);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(150, 31);
            txtAlisFiyati.TabIndex = 3;
            // 
            // txtMiktari
            // 
            txtMiktari.Location = new Point(121, 229);
            txtMiktari.Name = "txtMiktari";
            txtMiktari.Size = new Size(150, 31);
            txtMiktari.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(121, 182);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(150, 31);
            txtUrunAdi.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(121, 37);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(150, 31);
            txtBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMiktari);
            groupBox2.Controls.Add(btnVarOlanEkle);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(SatisFIyatitxt);
            groupBox2.Controls.Add(AlisFiyatitxt);
            groupBox2.Controls.Add(Miktaritxt);
            groupBox2.Controls.Add(UrunAditxt);
            groupBox2.Controls.Add(Markatxt);
            groupBox2.Controls.Add(Kategoritxt);
            groupBox2.Controls.Add(BarkodNotxt);
            groupBox2.Location = new Point(419, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 419);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Urun";
            // 
            // lblMiktari
            // 
            lblMiktari.AutoSize = true;
            lblMiktari.Location = new Point(24, 374);
            lblMiktari.Name = "lblMiktari";
            lblMiktari.Size = new Size(0, 25);
            lblMiktari.TabIndex = 15;
            // 
            // btnVarOlanEkle
            // 
            btnVarOlanEkle.Location = new Point(155, 365);
            btnVarOlanEkle.Name = "btnVarOlanEkle";
            btnVarOlanEkle.Size = new Size(90, 34);
            btnVarOlanEkle.TabIndex = 3;
            btnVarOlanEkle.Text = "Ekle";
            btnVarOlanEkle.UseVisualStyleBackColor = true;
            btnVarOlanEkle.Click += btnVarOlanEkle_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 308);
            label14.Name = "label14";
            label14.Size = new Size(95, 25);
            label14.TabIndex = 14;
            label14.Text = "Satis Fiyati";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 263);
            label13.Name = "label13";
            label13.Size = new Size(86, 25);
            label13.TabIndex = 13;
            label13.Text = "Alis Fiyati";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(45, 218);
            label12.Name = "label12";
            label12.Size = new Size(66, 25);
            label12.TabIndex = 12;
            label12.Text = "Miktari";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 173);
            label11.Name = "label11";
            label11.Size = new Size(87, 25);
            label11.TabIndex = 11;
            label11.Text = "Urun Adi ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 128);
            label10.Name = "label10";
            label10.Size = new Size(61, 25);
            label10.TabIndex = 10;
            label10.Text = "Marka";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 83);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 9;
            label9.Text = "Kategori";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 37);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 8;
            label8.Text = "BarkodNo";
            // 
            // SatisFIyatitxt
            // 
            SatisFIyatitxt.Location = new Point(117, 307);
            SatisFIyatitxt.Name = "SatisFIyatitxt";
            SatisFIyatitxt.Size = new Size(150, 31);
            SatisFIyatitxt.TabIndex = 7;
            // 
            // AlisFiyatitxt
            // 
            AlisFiyatitxt.Location = new Point(117, 261);
            AlisFiyatitxt.Name = "AlisFiyatitxt";
            AlisFiyatitxt.Size = new Size(150, 31);
            AlisFiyatitxt.TabIndex = 6;
            // 
            // Miktaritxt
            // 
            Miktaritxt.Location = new Point(117, 215);
            Miktaritxt.Name = "Miktaritxt";
            Miktaritxt.Size = new Size(150, 31);
            Miktaritxt.TabIndex = 5;
            // 
            // UrunAditxt
            // 
            UrunAditxt.Location = new Point(117, 169);
            UrunAditxt.Name = "UrunAditxt";
            UrunAditxt.Size = new Size(150, 31);
            UrunAditxt.TabIndex = 4;
            // 
            // Markatxt
            // 
            Markatxt.Location = new Point(117, 123);
            Markatxt.Name = "Markatxt";
            Markatxt.Size = new Size(150, 31);
            Markatxt.TabIndex = 3;
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(117, 77);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.Size = new Size(150, 31);
            Kategoritxt.TabIndex = 2;
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(117, 31);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(150, 31);
            BarkodNotxt.TabIndex = 1;
            BarkodNotxt.TextChanged += BarkodNotxt_TextChanged;
            // 
            // frmUrunEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(785, 592);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmUrunEkle";
            Text = "Urun Ekle Sayfasi";
            Load += frmUrunEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboMarka;
        private ComboBox comboKategori;
        private TextBox txtSatisFiyati;
        private TextBox txtAlisFiyati;
        private TextBox txtMiktari;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox SatisFIyatitxt;
        private TextBox AlisFiyatitxt;
        private TextBox Miktaritxt;
        private TextBox UrunAditxt;
        private TextBox Markatxt;
        private TextBox Kategoritxt;
        private TextBox BarkodNotxt;
        private Button btnYeniEkle;
        private Button btnVarOlanEkle;
        private Label lblMiktari;
    }
}