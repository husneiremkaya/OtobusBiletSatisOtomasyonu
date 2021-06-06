using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Odev3
{
    public partial class soforler : Form
    {
        public soforler()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void soforler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
               string kayit = "SELECT * from sofor";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
                da.Fill(dt);
               dataGridView1.DataSource = dt;
               baglanti.Close();
            baglanti.Open();
            string sql = "SELECT * from emekli";
            SqlCommand komutt = new SqlCommand(sql, baglanti);
            SqlDataAdapter daa = new SqlDataAdapter(komutt);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            dataGridView2.DataSource = dtt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into sofor(soforId,soforAdi,soforSoyadi,tc) values (@soforId,@Adi,@Soyadi,@tc)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@soforId", textBox1.Text);
                komut.Parameters.AddWithValue("@Adi", textBox2.Text);
                komut.Parameters.AddWithValue("@Soyadi", textBox3.Text);
                komut.Parameters.AddWithValue("@tc", textBox4.Text);
               komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Şoför Kayıt İşlemi Gerçekleşti.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            baglanti.Open();
            string yeni = "SELECT * from sofor";
            SqlCommand komutlar = new SqlCommand(yeni, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutlar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from sofor where soforId=@soforId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@soforId", textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label10.Text= dr["soforId"].ToString();
                label11.Text = dr["soforAdi"].ToString();
                label12.Text= dr["soforSoyadi"].ToString();
                label13.Text = dr["tc"].ToString();
                string isim = dr["soforAdi"].ToString() + " " + dr["soforSoyadi"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " li şoför kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                
                if (DialogResult.Yes == durum) 
                {
                    string silmeSorgusu = "DELETE from sofor where soforId=@soforId";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@soforId", textBox5.Text);
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
                MessageBox.Show("Şoför Bulunamadı.");
            baglanti.Close();
            baglanti.Open();
            string aa = "SELECT * from sofor";
            SqlCommand bb = new SqlCommand(aa, baglanti);
            SqlDataAdapter cc = new SqlDataAdapter(bb);
            DataTable dd = new DataTable();
            cc.Fill(dd);
            dataGridView1.DataSource = dd;
            baglanti.Close();
            baglanti.Open();
            string ee = "SELECT * from emekli";
            SqlCommand ff = new SqlCommand(ee, baglanti);
            SqlDataAdapter daa = new SqlDataAdapter(ff);
            DataTable hh = new DataTable();
            daa.Fill(hh);
            dataGridView2.DataSource = hh;
            baglanti.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from sofor where soforId=@soforId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@soforId", textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label10.Text = dr["soforId"].ToString();
                label11.Text = dr["soforAdi"].ToString();
                label12.Text = dr["soforSoyadi"].ToString();
                label13.Text = dr["tc"].ToString();
                baglanti.Close();
            }
            else
                MessageBox.Show("Şoför Bulunamadı.");
            baglanti.Close();
        }
    }
}