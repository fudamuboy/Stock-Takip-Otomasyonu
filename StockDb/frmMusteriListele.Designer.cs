namespace StockDb
{
    partial class frmMusteriListele
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
            btnGuncelle = new Button();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSil = new Button();
            txtTcAra = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(255, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(813, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(156, 444);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(93, 34);
            btnGuncelle.TabIndex = 21;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 383);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(131, 31);
            txtEmail.TabIndex = 20;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(111, 331);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(131, 31);
            txtAdres.TabIndex = 19;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(111, 279);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(131, 31);
            txtTelefon.TabIndex = 18;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(111, 227);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(131, 31);
            txtAdSoyad.TabIndex = 17;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(111, 175);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(131, 31);
            txtTc.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 388);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 15;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 337);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 14;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 286);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 13;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 224);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 12;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 181);
            label1.Name = "label1";
            label1.Size = new Size(31, 25);
            label1.TabIndex = 11;
            label1.Text = "TC";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1087, 147);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(71, 34);
            btnSil.TabIndex = 22;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(684, 92);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(184, 31);
            txtTcAra.TabIndex = 23;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(606, 98);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 24;
            label6.Text = "Tc Ara";
            // 
            // frmMusteriListele
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1170, 630);
            Controls.Add(label6);
            Controls.Add(txtTcAra);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmMusteriListele";
            Text = "Musteri Listele";
            Load += frmMusteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuncelle;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSil;
        private TextBox txtTcAra;
        private Label label6;
    }
}