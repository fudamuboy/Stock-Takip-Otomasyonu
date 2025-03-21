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
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KARTAL\\SQL;Initial Catalog=\"Giyim Takibi\";Integrated Security=True;Encrypt=False");
        DataSet ds = new DataSet();
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
        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategorigetir();
        }

        private void UrunListele()
        {
            baglanti.Open();
            ds.Clear();  // Önceki verileri temizle
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM urun", baglanti);
            adtr.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            baglanti.Close();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            UrunAditxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktaritxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlisFiyatitxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatisFIyatitxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE urun SET urunadi=@urunadi, miktari=@miktari, alisfiyati=@alisfiyati, satisfiyati=@satisfiyati WHERE barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@urunadi", UrunAditxt.Text);
            komut.Parameters.AddWithValue("@miktari", Convert.ToInt32(Miktaritxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", Convert.ToDouble(AlisFiyatitxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", Convert.ToDouble(SatisFIyatitxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["urun"].Clear();
            UrunListele();
            
            MessageBox.Show("Guncelleme Yaplidi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }



        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            // bitmedi burda devam etcezz
            if (BarkodNotxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE urun SET kategori=@kategori, marka=@marka WHERE barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Guncelleme Yaplidi");
                ds.Tables["urun"].Clear();
                UrunListele();
            }
            else
            {
                MessageBox.Show("Barkod yazili degil");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayit Silindi");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM urun WHERE barkodno LIKE '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
