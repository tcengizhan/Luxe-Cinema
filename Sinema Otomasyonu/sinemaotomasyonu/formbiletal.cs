using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace sinemaotomasyonu
{
    public partial class formbiletal : Form
    {
        public formbiletal()
        {


            InitializeComponent();


            //sqlConnection baglanti = new sqlConnection("Data Source=BUGRA\\SQLEXPRESS;Inital Catalog = Seanslar;Integrated Security=True");


            //SqlCommand komut = new SqlCommand("Select FilmID from Seanslar", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmAcilis Form1 = new FrmAcilis();
            Form1.Show();
        }

        private void pnlKoltuklar_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {

        }



        private void KoltuklariCiz(int satir, int sutun)
        {
            int butonGenislik = 50;
            int butonYukseklik = 50;
            int aralik = 5;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Button koltuk = new Button();
                    koltuk.Width = butonGenislik;
                    koltuk.Height = butonYukseklik;

                    koltuk.Left = j * (butonGenislik + aralik);
                    koltuk.Top = i * (butonYukseklik + aralik);

                    char siraHarf = (char)('A' + i);
                    koltuk.Text = $"{siraHarf}{j + 1}";
                    koltuk.BackColor = Color.Green;
                    koltuk.Tag = false; // seçilmedi

                    koltuk.Click += Koltuk_Click;

                    panel1.Controls.Add(koltuk);
                }
            }
        }



        List<string> secilenkoltuk = new List<string>();


        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                bool seciliMi = (bool)btn.Tag;

                if (!seciliMi)
                {
                    btn.BackColor = Color.Red;
                    btn.Tag = true;
                    secilenkoltuk.Add(btn.Text);
                }
                else
                {
                    btn.BackColor = Color.Green;
                    btn.Tag = false;
                    secilenkoltuk.Remove(btn.Text);
                }
            }



        }

        private void Seat_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Önce tüm koltukları sıfırla
            foreach (Control c in panel1.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.Green;
                    btn.Enabled = true;
                    btn.Tag = false;
                }
            }

            // Seçilen seansa göre dolu koltukları kırmızı yap
            Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(
                "Data Source=DESKTOP-6T6V5J6\\SQLEXPRESS04;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True");

            string sql = "SELECT Koltuk FROM Biletler WHERE Film = @film AND Seans = @seans";
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@film", comboBox1.Text);
            komut.Parameters.AddWithValue("@seans", comboBox2.Text);

            baglanti.Open();
            Microsoft.Data.SqlClient.SqlDataReader reader = komut.ExecuteReader();

            List<string> doluKoltuklar = new List<string>();
            while (reader.Read())
            {
                string[] koltuklar = reader["Koltuk"].ToString().Split(',');
                foreach (string k in koltuklar)
                    doluKoltuklar.Add(k.Trim());
            }
            reader.Close();
            baglanti.Close();

            foreach (Control c in panel1.Controls)
            {
                if (c is Button btn && doluKoltuklar.Contains(btn.Text))
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                    btn.Tag = true;
                }
            }

            secilenkoltuk.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            // Kontroller
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ad Soyad boş bırakılamaz.");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Film seçiniz.");
                return;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Seans seçiniz.");
                return;
            }
            if (secilenkoltuk.Count == 0)
            {
                MessageBox.Show("Koltuk seçiniz.");
                return;
            }

            // 6 haneli rastgele kod üret
            Random rnd = new Random();
            string biletKod = rnd.Next(100000, 999999).ToString();

            // Büfe fiyatı hesapla
            int bufeFiyat = 0;
            string bufeSiparis = "";
            if (checkBox1.Checked) { bufeFiyat += 75; bufeSiparis += "Patlamış mısır "; }
            if (checkBox2.Checked) { bufeFiyat += 45; bufeSiparis += "Kola "; }
            if (checkBox3.Checked) { bufeFiyat += 25; bufeSiparis += "Su "; }

            int biletFiyat = 100; // bilet fiyatı — istersen değiştir
            int toplam = biletFiyat + bufeFiyat;

            // Veritabanına kaydet
            Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(
                "Data Source=DESKTOP-6T6V5J6\\SQLEXPRESS04;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True");

            string sql = "INSERT INTO Biletler (BiletKod, AdSoyad, TelNo, Film, Seans, Koltuk, BufeSiparis, ToplamFiyat) " +
                         "VALUES (@kod, @ad, @tel, @film, @seans, @koltuk, @bufe, @fiyat)";

            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@kod", biletKod);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@film", comboBox1.Text);
            komut.Parameters.AddWithValue("@seans", comboBox2.Text);
            komut.Parameters.AddWithValue("@koltuk", string.Join(",", secilenkoltuk));
            komut.Parameters.AddWithValue("@bufe", bufeSiparis.Trim());
            komut.Parameters.AddWithValue("@fiyat", toplam);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ödeme tamamlandı!\nBilet Kodunuz: " + biletKod + "\nToplam: " + toplam + " TL\nKoltuğunuz: " + string.Join(", ", secilenkoltuk));

            // Seçilen koltuğu kalıcı kırmızı bırak (artık satılmış)
            foreach (Control c in panel1.Controls)
            {
                if (c is Button btn && secilenkoltuk.Contains(btn.Text))
                {
                    btn.Enabled = false; // tıklanamaz hale getir
                    btn.BackColor = Color.Red;
                }
            }

            secilenkoltuk.Clear();
        }

        private void formbiletal_Load(object sender, EventArgs e)
        {
            KoltuklariCiz(5, 10);

            // Veritabanından dolu koltukları çek ve kırmızı yap
            Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(
                "Data Source=DESKTOP-6T6V5J6\\SQLEXPRESS04;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True");

            string sql = "SELECT Koltuk FROM Biletler WHERE Film = @film AND Seans = @seans";
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@film", comboBox1.Text);
            komut.Parameters.AddWithValue("@seans", comboBox2.Text);

            baglanti.Open();
            Microsoft.Data.SqlClient.SqlDataReader reader = komut.ExecuteReader();

            List<string> doluKoltuklar = new List<string>();
            while (reader.Read())
            {
                string[] koltuklar = reader["Koltuk"].ToString().Split(',');
                foreach (string k in koltuklar)
                    doluKoltuklar.Add(k.Trim());
            }
            reader.Close();
            baglanti.Close();

            // Dolu koltukları kırmızı yap
            foreach (Control c in panel1.Controls)
            {
                if (c is Button btn && doluKoltuklar.Contains(btn.Text))
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                    btn.Tag = true;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }




}

