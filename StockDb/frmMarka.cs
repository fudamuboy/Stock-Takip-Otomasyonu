using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDb
{
    public partial class frmMarka : Form
    {
        // la partie des marka avec les donnees 

        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KARTAL\\SQL;Initial Catalog=\"Giyim Takibi\";Integrated Security=True;Encrypt=False");

        bool durum;
        private void markaengelle()
        {
            durum = true; // Varsayılan olarak durum doğru kabul ediliyor.

            // Kategori veya marka boşsa durumu false yap
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                durum = false;
                return;
            }

            baglanti.Open();

            // Sadece kategori ve marka bilgisiyle sorgu yapıyoruz.
            SqlCommand komut = new SqlCommand("SELECT * FROM markabilgileri WHERE kategori = @kategori AND marka = @marka", baglanti);
            komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
            komut.Parameters.AddWithValue("@marka", textBox1.Text);

            SqlDataReader read = komut.ExecuteReader();

            // Eğer böyle bir kategori ve marka varsa, durum false olmalı.
            if (read.HasRows)
            {
                durum = false; // Kategori ve marka zaten mevcut
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markaengelle(); // Mevcut fonksiyon değiştirilmedi.

            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Kategori ve Marka boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO markabilgileri (kategori, marka) VALUES (@kategori, @marka)", baglanti);
                komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@marka", textBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Marka başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Bu kategori ve marka zaten var!", "Uyarı");
            }

            // Form alanlarını temizle
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
        }


        
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}
