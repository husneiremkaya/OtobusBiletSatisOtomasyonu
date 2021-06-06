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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }
        int koltuksayisi=0;
        int koltuk;
        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.WhiteSmoke)
            {
                button4.BackColor = Color.Red;
                koltuksayisi++;
                koltuk = 4;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            else
            {
                button4.BackColor = Color.WhiteSmoke;
                koltuksayisi--;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            if (comboBox6.SelectedItem.ToString() == "Ögrenci")
            {
                baglanti.Open();
                string sql = "select dbo.indirim(@indirim)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@indirim", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();

            }
            else if (comboBox6.SelectedItem.ToString() == "Normal")
            {
                baglanti.Open();
                string sql = "select dbo.TUTAR(@tutar)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@tutar", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
            }
            else 
            {
                textBox6.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.WhiteSmoke)
            {
                button14.BackColor = Color.Red;
                koltuksayisi++;
                koltuk = 6;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            else
            {
                button14.BackColor = Color.WhiteSmoke;
                koltuksayisi--;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            if (comboBox6.SelectedItem.ToString() == "Ögrenci")
            {
                baglanti.Open();
                string sql = "select dbo.indirim(@indirim)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@indirim", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();

            }
            else if (comboBox6.SelectedItem.ToString() == "Normal")
            {
                baglanti.Open();
                string sql = "select dbo.TUTAR(@tutar)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@tutar", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(button13.BackColor== Color.WhiteSmoke)
            {
                button13.BackColor = Color.Red;
                koltuksayisi++;
                koltuk = 1;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            else
            {
                button13.BackColor = Color.WhiteSmoke;
                koltuksayisi--;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            if (comboBox6.SelectedItem.ToString() == "Ögrenci")
            {
                baglanti.Open();
                string sql = "select dbo.indirim(@indirim)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@indirim", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();

            }
            else if (comboBox6.SelectedItem.ToString() == "Normal")
            {
                baglanti.Open();
                string sql = "select dbo.TUTAR(@tutar)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@tutar", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.WhiteSmoke)
            {
                button12.BackColor = Color.Red;
                koltuksayisi++;
                koltuk = 3;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            else
            {
                button12.BackColor = Color.WhiteSmoke;
                koltuksayisi--;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            if (comboBox6.SelectedItem.ToString() == "Ögrenci")
            {
                baglanti.Open();
                string sql = "select dbo.indirim(@indirim)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@indirim", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();

            }
            else if (comboBox6.SelectedItem.ToString() == "Normal")
            {
                baglanti.Open();
                string sql = "select dbo.TUTAR(@tutar)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@tutar", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.WhiteSmoke)
            {
                button9.BackColor = Color.Red;
                koltuksayisi++;
                koltuk = 2;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            else
            {
                button9.BackColor = Color.WhiteSmoke;
                koltuksayisi--;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            if (comboBox6.SelectedItem.ToString() == "Ögrenci")
            {
                baglanti.Open();
                string sql = "select dbo.indirim(@indirim)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@indirim", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();

            }
            else if (comboBox6.SelectedItem.ToString() == "Normal")
            {
                baglanti.Open();
                string sql = "select dbo.TUTAR(@tutar)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@tutar", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
            }
            else
            {
                textBox6.Text = "";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.WhiteSmoke)
            {
                button10.BackColor = Color.Red;
                koltuksayisi++;
                koltuk = 5;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            else
            {
                button10.BackColor = Color.WhiteSmoke;
                koltuksayisi--;
                koltukk.Text = Convert.ToString(koltuksayisi);
            }
            if (comboBox6.SelectedItem.ToString() == "Ögrenci")
            {
                baglanti.Open();
                string sql = "select dbo.indirim(@indirim)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@indirim", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();

            }
            else if (comboBox6.SelectedItem.ToString() == "Normal")
            {
                baglanti.Open();
                string sql = "select dbo.TUTAR(@tutar)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@tutar", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Bilet_Load(object sender, EventArgs e)
        {
            koltukk.Text = Convert.ToString(koltuksayisi);
            baglanti.Open();
            string sql = "SELECT * FROM sehir";
            SqlCommand yeni = new SqlCommand(sql, baglanti);
            SqlDataReader dr;
            dr = yeni.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["sehirAdi"]);
            }
            baglanti.Close();
            baglanti.Open();
            string kayitlar = "SELECT * from yolcuu";
            SqlCommand eski = new SqlCommand(kayitlar, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(eski);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            string aa = "SELECT * from bilet";
            SqlCommand bb = new SqlCommand(aa, baglanti);
            SqlDataAdapter db = new SqlDataAdapter(bb);
            DataTable dd = new DataTable();
            db.Fill(dd);
            dataGridView2.DataSource = dd;
            baglanti.Close();



        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into yolcuu(yolcuId,yolcuAdi,yolcuSoyadi,cinsiyetId,tc,yolcutipi) values (@yolcuId,@yolcuAdi,@yolcuSoyadi,@cinsiyetId,@tc,@yolcutipi)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@yolcuId", textBox1.Text);
                komut.Parameters.AddWithValue("@yolcuAdi", textBox2.Text);
                komut.Parameters.AddWithValue("@yolcuSoyadi", textBox3.Text);
                if (comboBox1.SelectedItem.ToString() == "KADIN")
                {
                    komut.Parameters.AddWithValue("@cinsiyetId", 1);
                }
                else
                {
                    komut.Parameters.AddWithValue("@cinsiyetId", 2);
                }
                komut.Parameters.AddWithValue("@tc", textBox4.Text);
                komut.Parameters.AddWithValue("@yolcutipi", comboBox6.SelectedItem);
                komut.ExecuteNonQuery();
                baglanti.Close();
                

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string sql = "insert into bilet(biletId,yolcuId,seferId,koltukNo) values (@biletId,@yolcu,@seferId,@koltukNO)";
                SqlCommand yeni = new SqlCommand(sql, baglanti);
                yeni.Parameters.AddWithValue("@biletId", textBox5.Text);
                yeni.Parameters.AddWithValue("@yolcu", textBox1.Text);
                if(comboBox3.SelectedItem.ToString() == "BURDUR")
                {
                    yeni.Parameters.AddWithValue("@seferId", 1);
                }
                else
                {
                    yeni.Parameters.AddWithValue("@seferId", 2);
                }
                yeni.Parameters.AddWithValue("@koltukNO", koltuk);
                 yeni.ExecuteNonQuery();
                baglanti.Close();
                if(comboBox6.SelectedItem=="Normal")
                { 
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string sq = "insert into NormalYolcu(yolcuId,yas) values (@aa,@yas)";
                SqlCommand komu = new SqlCommand(sq, baglanti);
                komu.Parameters.AddWithValue("@aa", textBox1.Text);
                komu.Parameters.AddWithValue("@yas", textBox7.Text);
                komu.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string sq = "insert into ogrenciYolcu(yolcuId,ogrmail) values (@yolcuId,@mail)";
                    SqlCommand komu = new SqlCommand(sq, baglanti);
                    komu.Parameters.AddWithValue("@yolcuId", textBox1.Text);
                    komu.Parameters.AddWithValue("@mail", textBox7.Text);
                    komu.ExecuteNonQuery();
                    baglanti.Close();
                    /* */
                }
                
                MessageBox.Show("Satın Alma İşlemi Gerçekleşti.");

                baglanti.Open();
                string kayitlar = "SELECT * from yolcuu";
                SqlCommand eski = new SqlCommand(kayitlar, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(eski);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();

                baglanti.Open();
                string aa = "SELECT * from bilet";
                SqlCommand bb = new SqlCommand(aa, baglanti);
                SqlDataAdapter db = new SqlDataAdapter(bb);
                DataTable dd = new DataTable();
                db.Fill(dd);
                dataGridView2.DataSource = dd;
                baglanti.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                button13.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
                button12.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button10.BackColor = Color.WhiteSmoke;
                button14.BackColor = Color.WhiteSmoke;
                comboBox1.SelectedValue = 0;
                koltukk.Text = Convert.ToString( 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from bilet where biletId=@biletId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@biletId", textBox4.Text);
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
                MessageBox.Show("Bilet Bulunamadı.");
            baglanti.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox6.SelectedItem.ToString()=="Ögrenci")
            {
                baglanti.Open();
                string sql = "select dbo.indirim(@indirim)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@indirim",koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
                label10.Text = "Mail:";
                label10.Visible = true;
                textBox7.Visible = true;
                
            }
            else
            {
                baglanti.Open();
                string sql = "select dbo.TUTAR(@tutar)";
                SqlCommand secmeKomutu = new SqlCommand(sql, baglanti);
                secmeKomutu.Parameters.AddWithValue("@tutar", koltuksayisi);
                textBox6.Text = (secmeKomutu.ExecuteScalar()).ToString();
                baglanti.Close();
                label10.Text = "Yas:";
                label10.Visible = true;
                textBox7.Visible = true;
            }

           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
