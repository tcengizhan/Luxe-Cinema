using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sinemaotomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 6)
            {
                MessageBox.Show("Lütfen 6 haneli bilet kodunu giriniz.");
                return;
            }

            Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(
                "Data Source=DESKTOP-6T6V5J6\\SQLEXPRESS04;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True");

            // Önce var mı kontrol et
            string sqlKontrol = "SELECT COUNT(*) FROM Biletler WHERE BiletKod = @kod";
            Microsoft.Data.SqlClient.SqlCommand komutKontrol = new Microsoft.Data.SqlClient.SqlCommand(sqlKontrol, baglanti);
            komutKontrol.Parameters.AddWithValue("@kod", textBox1.Text);

            baglanti.Open();
            int sayi = (int)komutKontrol.ExecuteScalar();

            if (sayi == 0)
            {
                baglanti.Close();
                MessageBox.Show("Bu koda ait bilet bulunamadı.");
                return;
            }

            // Sil
            string sqlSil = "DELETE FROM Biletler WHERE BiletKod = @kod";
            Microsoft.Data.SqlClient.SqlCommand komutSil = new Microsoft.Data.SqlClient.SqlCommand(sqlSil, baglanti);
            komutSil.Parameters.AddWithValue("@kod", textBox1.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Bilet iadesi gerçekleştirildi.");
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAcilis Form1 = new FrmAcilis();
            Form1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
