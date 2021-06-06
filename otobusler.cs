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
    public partial class otobusler : Form
    {
        public otobusler()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void otobusler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from otobus";
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
                string kayit = "insert into otobus(otobusId,plakaNo,otobusMarka) values (@otobusId,@plakaNo,@otobusMarka)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@otobusId", textBox1.Text);
                komut.Parameters.AddWithValue("@plakaNo", textBox2.Text);
                komut.Parameters.AddWithValue("@otobusMarka", textBox3.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Otobüs Kayıt İşlemi Gerçekleşti.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                baglanti.Open();
                string aa = "SELECT * from otobus";
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
            string secmeSorgusu = "SELECT * from otobus where otobusId=@otobusId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@otobusId", textBox4.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr["OtobusId"].ToString();
                label6.Text = dr["plakaNo"].ToString();
                label7.Text = dr["otobusMarka"].ToString();
                baglanti.Close();
            }
            else
                MessageBox.Show("Otobüs Bulunamadı.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from otobus where otobusId=@otobusId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@otobusId", textBox4.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr["otobusId"].ToString();
                label6.Text = dr["plakaNo"].ToString();
                label7.Text = dr["otobusMarka"].ToString();
               string plaka = dr["plakaNo"].ToString();
                
                dr.Close();
                DialogResult durum = MessageBox.Show(plaka + " li Otobüsün kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from otobus where otobusId=@otobusId";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@otobusId", textBox4.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
                    textBox4.Clear();
                    label5.Text = "***";
                    label6.Text = "***";
                    label7.Text = "***";
                   
                }
            }
            else
                MessageBox.Show("Otobüs Bulunamadı.");
            baglanti.Close();
            baglanti.Open();
            string ee = "SELECT * from otobus";
            SqlCommand ll = new SqlCommand(ee, baglanti);
            SqlDataAdapter oo = new SqlDataAdapter(ll);
            DataTable dt = new DataTable();
            oo.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
    }
}
