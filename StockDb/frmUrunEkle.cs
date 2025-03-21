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
using WinFormsTextBox = System.Windows.Forms.TextBox;


namespace StockDb
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KARTAL\\SQL;Initial Catalog=\"Giyim Takibi\";Integrated Security=True;Encrypt=False");
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;

            // Barkod numarasının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                durum = false;
                return;
            }

            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno = @barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);

            SqlDataReader read = komut.ExecuteReader();

            // Eğer veritabanında aynı barkod numarasına sahip bir ürün varsa
            if (read.HasRows)
            {
                durum = false; // Barkod numarası zaten var
            }

            baglanti.Close();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // La partie des marka ait et leurs kategories ds le from UrunEkle
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            // Barkod kontrolünü yap
            barkodkontrol();

            if (durum == true)
            {
                // Barkod numarası geçerliyse, ürünü ekle
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO urun (barkodno, kategori, marka, urunadi, miktari, alisfiyati, satisfiyati, tarih) VALUES (@barkodno, @kategori, @marka, @urunadi, @miktari, @alisfiyati, @satisfiyati, @tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", Convert.ToInt32(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", Convert.ToDouble(txtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", Convert.ToDouble(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            else
            {
                // Eğer barkod numarası zaten varsa, uyarı mesajı göster
                MessageBox.Show("Böyle bir barkod numarası zaten mevcut.", "Uyarı");
            }

            // ComboBox ve TextBox'ları temizle
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is WinFormsTextBox textBox)
                {
                    textBox.Text = "";
                }


                if (item is WinFormsTextBox comboBox)
                {
                    comboBox.Text = "";
                }
            }
        }


        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            // Barkod numarası boşsa tüm alanları temizle ve işlemi durdur
            if (string.IsNullOrWhiteSpace(BarkodNotxt.Text))
            {
                lblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }
                }
                return;
            }

            try
            {
                baglanti.Open();

                // SQL Injection riskini önlemek için parametreli sorgu kullanıyoruz
                SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno LIKE @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text + "%");

                SqlDataReader read = komut.ExecuteReader();

                if (read.Read()) // Eğer veri varsa
                {
                    Kategoritxt.Text = read["kategori"].ToString();
                    Markatxt.Text = read["marka"].ToString();
                    UrunAditxt.Text = read["urunadi"].ToString();
                    lblMiktari.Text = read["miktari"].ToString();
                    AlisFiyatitxt.Text = read["alisfiyati"].ToString();
                    SatisFIyatitxt.Text = read["satisfiyati"].ToString();
                }
                else // Eğer barkod bulunamazsa, tüm alanları temizle
                {
                    Kategoritxt.Text = "";
                    Markatxt.Text = "";
                    UrunAditxt.Text = "";
                    lblMiktari.Text = "";
                    AlisFiyatitxt.Text = "";
                    SatisFIyatitxt.Text = "";
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnVarOlanEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari = miktari + " + Convert.ToInt32(Miktaritxt.Text) + " where barkodno='" + BarkodNotxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı.");
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
