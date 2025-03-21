using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace StockDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=KARTAL\\SQL;Initial Catalog=\"Giyim Takibi\";Integrated Security=True;Encrypt=False");

        DataSet ds = new DataSet();
        // burda devam etczazz
        private void sepetelsitele()
        {
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM sepet", baglanti);
            adtr.Fill(ds, "sepet");
            dataGridView1.DataSource = ds.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();  // liaisoon entre les musteri ekleme 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();   // liaison entre listeleme
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUrunEkle ekle = new frmUrunEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sepetelsitele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmUrunListele listele = new frmUrunListele();
            listele.ShowDialog();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text))
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
                return;
            }

            baglanti.Open(); // Baðlantýyý aç
            SqlCommand komut = new SqlCommand("SELECT * FROM musteri WHERE tc LIKE @tc", baglanti);

            komut.Parameters.AddWithValue("@tc", txtTC.Text + "%"); // Like kullanýmý düzeltildi
            SqlDataReader read = komut.ExecuteReader();

            if (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            else
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }

            baglanti.Close(); // Baðlantýyý kapat
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                Temizle();
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno LIKE '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUrunAdi.Text = read["urunadi"].ToString();
                txtSatisFiyati.Text = read["satisfiyati"].ToString(); // Burada sorun olabilir!
            }
            baglanti.Close();
        }


        private void Temizle()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }

            }
        }
        bool durum;

        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM sepet WHERE barkodno = @barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);

            SqlDataReader read = komut.ExecuteReader();
            if (read.Read()) // Eðer veri varsa, ürün zaten sepette var demektir.
            {
                durum = false;
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();

            // Eðer gerekli alanlar boþsa iþlem yapýlmaz.
            if (string.IsNullOrWhiteSpace(txtBarkodNo.Text) ||
                string.IsNullOrWhiteSpace(txtUrunAdi.Text) ||
                string.IsNullOrWhiteSpace(txtMiktari.Text) ||
                string.IsNullOrWhiteSpace(txtSatisFiyati.Text) ||
                string.IsNullOrWhiteSpace(txtToplamFiyat.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baglanti.Open();

            if (durum == true) // Ürün sepette yoksa yeni kayýt ekle
            {
                SqlCommand komut = new SqlCommand("INSERT INTO sepet (tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) " +
                                                  "VALUES (@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih)", baglanti);

                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", Convert.ToInt32(txtMiktari.Text));
                komut.Parameters.AddWithValue("@satisfiyati", Convert.ToDouble(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", Convert.ToDouble(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);

                komut.ExecuteNonQuery();
            }
            else // Ürün zaten sepette varsa miktarý ve fiyatý güncelle
            {
                SqlCommand komut2 = new SqlCommand("UPDATE sepet SET miktari = miktari + @miktari WHERE barkodno = @barkodno", baglanti);
                komut2.Parameters.AddWithValue("@miktari", Convert.ToInt32(txtMiktari.Text));
                komut2.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("UPDATE sepet SET toplamfiyati = miktari * satisfiyati WHERE barkodno = @barkodno", baglanti);
                komut3.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut3.ExecuteNonQuery();
            }

            baglanti.Close();

            txtMiktari.Text = "1";
            ds.Tables["sepet"].Clear();
            sepetelsitele();
            Temizle();
        }



        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplamFiyat();
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplamFiyat();
        }

        private void HesaplaToplamFiyat()
        {
            if (string.IsNullOrWhiteSpace(txtMiktari.Text) || string.IsNullOrWhiteSpace(txtSatisFiyati.Text))
            {
                txtToplamFiyat.Text = "";
                return;
            }

            if (int.TryParse(txtMiktari.Text, out int miktar) &&
                double.TryParse(txtSatisFiyati.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double satisFiyati))
            {
                txtToplamFiyat.Text = (miktar * satisFiyati).ToString("F2"); // Ondalýklý gösterim için
            }
            else
            {
                txtToplamFiyat.Text = "Hata!";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["barkodno"].Clear();
            sepetelsitele();
            MessageBox.Show("Urun sepetten cikarildi");
        }

        private void btnSatisFiyat_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["barkodno"].Clear();
            sepetelsitele();
            MessageBox.Show("Urun sepetten cikarildi");
        }
    }
}
