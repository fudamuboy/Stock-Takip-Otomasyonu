using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StockDb
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KARTAL\\SQLEXPRESS;Initial Catalog=Stock_Takibi;Integrated Security=True;Encrypt=False");
       
        bool durum;
        
        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle(); // Kategori olup olmadığını kontrol et
            if (durum == true) // Eğer kategori yoksa ekle
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO kategoribilgileri (kategori) VALUES (@kategori)", baglanti);
                komut.Parameters.AddWithValue("@kategori", textBox1.Text.Trim());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kategori eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori zaten var", "Uyarı");
            }
            textBox1.Text = "";
        }

        private void kategoriengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT kategori FROM kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                if (textBox1.Text.Trim().ToLower() == read["kategori"].ToString().Trim().ToLower() || string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    durum = false;
                    break; // Kategori bulunduğunda döngüyü hemen durdur.
                }
            }
            read.Close(); // Veri okuyucuyu kapat.
            baglanti.Close(); // Bağlantıyı kapat.
        }


    }
}
