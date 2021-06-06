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
    public partial class adminekle : Form
    {
        public adminekle()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into adminler(adminId,adminKullaniciAdi,adminSifre) values (@adminId,@Adi,@Sifre)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@adminId", textBox1.Text);
                komut.Parameters.AddWithValue("@Adi", textBox2.Text);
                komut.Parameters.AddWithValue("@Sifre", textBox3.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Admin Kayıt İşlemi Gerçekleşti.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        private void adminekle_Load(object sender, EventArgs e)
        {

        }
    }
}
