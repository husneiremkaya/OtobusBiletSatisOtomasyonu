using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;

namespace Odev3
{
    public partial class muavinler : Form
    {
        public muavinler()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void muavinler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from muavin";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into muavin(muavinId,muavinAdi,muavinSoyadi,muavinTC) values (@soforId,@Adi,@Soyadi,@tc)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@soforId", textBox1.Text);
                komut.Parameters.AddWithValue("@Adi", textBox2.Text);
                komut.Parameters.AddWithValue("@Soyadi", textBox3.Text);
                komut.Parameters.AddWithValue("@tc", textBox4.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Muavin Kayıt İşlemi Gerçekleşti.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                baglanti.Open();
                string aa = "SELECT * from muavin";
                SqlCommand bb = new SqlCommand(aa, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(bb);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from muavin where muavinId=@muavinId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@muavinId", textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label10.Text = dr["muavinId"].ToString();
                label11.Text = dr["muavinAdi"].ToString();
                label12.Text = dr["muavinSoyadi"].ToString();
                label13.Text = dr["muavinTC"].ToString();
                baglanti.Close();
            }
            else
                MessageBox.Show("Muavin Bulunamadı.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from muavin where muavinId=@muavinId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@muavinId", textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label10.Text = dr["muavinId"].ToString();
                label11.Text = dr["muavinAdi"].ToString();
                label12.Text = dr["muavinSoyadi"].ToString();
                label13.Text = dr["muavinTC"].ToString();
                string isim = dr["muavinAdi"].ToString() + " " + dr["muavinSoyadi"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " li muavin kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from muavin where muavinId=@muavinId";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@muavinId", textBox5.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
                    textBox5.Clear();
                    label10.Text = "***";
                    label11.Text = "***";
                    label12.Text = "***";
                    label13.Text = "***";
                }
            }
            else
                MessageBox.Show("Muavin Bulunamadı.");
            baglanti.Close();
            baglanti.Open();
            string cc = "SELECT * from muavin";
            SqlCommand dd = new SqlCommand(cc, baglanti);
            SqlDataAdapter ee = new SqlDataAdapter(dd);
            DataTable dt = new DataTable();
            ee.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
