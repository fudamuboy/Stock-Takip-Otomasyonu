namespace StockDb
{
    partial class frmUrunListele
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
            dataGridView1 = new DataGridView();
            lblMiktari = new Label();
            btnGuncelle = new Button();
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
            btnSil = new Button();
            txtBarkodNoAra = new TextBox();
            label1 = new Label();
            comboKategori = new ComboBox();
            comboMarka = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnMarkaGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(325, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(703, 275);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // lblMiktari
            // 
            lblMiktari.AutoSize = true;
            lblMiktari.Location = new Point(60, 479);
            lblMiktari.Name = "lblMiktari";
            lblMiktari.Size = new Size(0, 25);
            lblMiktari.TabIndex = 31;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(191, 470);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(90, 34);
            btnGuncelle.TabIndex = 18;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(52, 413);
            label14.Name = "label14";
            label14.Size = new Size(95, 25);
            label14.TabIndex = 30;
            label14.Text = "Satis Fiyati";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(61, 368);
            label13.Name = "label13";
            label13.Size = new Size(86, 25);
            label13.TabIndex = 29;
            label13.Text = "Alis Fiyati";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(81, 323);
            label12.Name = "label12";
            label12.Size = new Size(66, 25);
            label12.TabIndex = 28;
            label12.Text = "Miktari";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(60, 278);
            label11.Name = "label11";
            label11.Size = new Size(87, 25);
            label11.TabIndex = 27;
            label11.Text = "Urun Adi ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 233);
            label10.Name = "label10";
            label10.Size = new Size(61, 25);
            label10.TabIndex = 26;
            label10.Text = "Marka";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(69, 188);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 25;
            label9.Text = "Kategori";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 142);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 24;
            label8.Text = "BarkodNo";
            // 
            // SatisFIyatitxt
            // 
            SatisFIyatitxt.Location = new Point(153, 412);
            SatisFIyatitxt.Name = "SatisFIyatitxt";
            SatisFIyatitxt.Size = new Size(150, 31);
            SatisFIyatitxt.TabIndex = 23;
            // 
            // AlisFiyatitxt
            // 
            AlisFiyatitxt.Location = new Point(153, 366);
            AlisFiyatitxt.Name = "AlisFiyatitxt";
            AlisFiyatitxt.Size = new Size(150, 31);
            AlisFiyatitxt.TabIndex = 22;
            // 
            // Miktaritxt
            // 
            Miktaritxt.Location = new Point(153, 320);
            Miktaritxt.Name = "Miktaritxt";
            Miktaritxt.Size = new Size(150, 31);
            Miktaritxt.TabIndex = 21;
            // 
            // UrunAditxt
            // 
            UrunAditxt.Location = new Point(153, 274);
            UrunAditxt.Name = "UrunAditxt";
            UrunAditxt.Size = new Size(150, 31);
            UrunAditxt.TabIndex = 20;
            // 
            // Markatxt
            // 
            Markatxt.Location = new Point(153, 228);
            Markatxt.Name = "Markatxt";
            Markatxt.ReadOnly = true;
            Markatxt.Size = new Size(150, 31);
            Markatxt.TabIndex = 19;
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(153, 182);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.Size = new Size(150, 31);
            Kategoritxt.TabIndex = 17;
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(153, 136);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(150, 31);
            BarkodNotxt.TabIndex = 16;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1042, 142);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(95, 34);
            btnSil.TabIndex = 32;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtBarkodNoAra
            // 
            txtBarkodNoAra.Location = new Point(678, 79);
            txtBarkodNoAra.Name = "txtBarkodNoAra";
            txtBarkodNoAra.Size = new Size(169, 31);
            txtBarkodNoAra.TabIndex = 33;
            txtBarkodNoAra.TextChanged += txtBarkodNoAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 85);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 34;
            label1.Text = "BarkodNo ya Gore Ara";
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(614, 514);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(151, 33);
            comboKategori.TabIndex = 35;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(613, 560);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(151, 33);
            comboMarka.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 563);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 38;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 518);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 37;
            label3.Text = "Kategori";
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.Location = new Point(783, 518);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(137, 70);
            btnMarkaGuncelle.TabIndex = 39;
            btnMarkaGuncelle.Text = "Marka Guncelle";
            btnMarkaGuncelle.UseVisualStyleBackColor = true;
            btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
            // 
            // frmUrunListele
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1166, 638);
            Controls.Add(btnMarkaGuncelle);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboMarka);
            Controls.Add(comboKategori);
            Controls.Add(label1);
            Controls.Add(txtBarkodNoAra);
            Controls.Add(btnSil);
            Controls.Add(lblMiktari);
            Controls.Add(btnGuncelle);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(SatisFIyatitxt);
            Controls.Add(AlisFiyatitxt);
            Controls.Add(Miktaritxt);
            Controls.Add(UrunAditxt);
            Controls.Add(Markatxt);
            Controls.Add(Kategoritxt);
            Controls.Add(BarkodNotxt);
            Controls.Add(dataGridView1);
            Name = "frmUrunListele";
            Text = "Urun Listeleme Sayfasi";
            Load += frmUrunListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblMiktari;
        private Button btnGuncelle;
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
        private Button btnSil;
        private TextBox txtBarkodNoAra;
        private Label label1;
        private ComboBox comboKategori;
        private ComboBox comboMarka;
        private Label label2;
        private Label label3;
        private Button btnMarkaGuncelle;
    }
}