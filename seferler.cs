
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
    public partial class seferler : Form
    {
        public seferler()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void seferler_Load(object sender, EventArgs e)
        {

          
            baglanti.Open();
            string kayit = "SELECT * from sefer";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
              string sql = "SELECT * FROM sehir";
            SqlCommand yeni = new SqlCommand(sql, baglanti);
            SqlDataReader dr;
            dr = yeni.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["sehirAdi"]);
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into sefer(seferNo,nereden,nereye,tarih,otobusNo,soforNo,muavinNo,ikramNo,bosKoltukSayisi) values (@seferId,@nereden,@nereye,@tarih,@otobusNo,@soforNo,@muavinNo,@ikramNo,@koltuk)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@seferId", textBox1.Text);
                komut.Parameters.AddWithValue("@nereden", comboBox1.SelectedItem);
                if(comboBox2.SelectedItem.ToString() == "BURDUR")
                {
                    komut.Parameters.AddWithValue("@nereye", 2);
                }
                else
                { 
                komut.Parameters.AddWithValue("@nereye", 1);
                }
                komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@otobusNo", textBox3.Text);
                komut.Parameters.AddWithValue("@soforNo", textBox2.Text);
                komut.Parameters.AddWithValue("@muavinNo", textBox4.Text);
                komut.Parameters.AddWithValue("@ikramNo", textBox5.Text);
                komut.Parameters.AddWithValue("@koltuk", textBox6.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sefer Kayıt İşlemi Gerçekleşti.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                baglanti.Open();
                string bb = "SELECT * from sefer";
                SqlCommand aa = new SqlCommand(bb, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(aa);
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
    }
}
