using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Odev3
{
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from adminler where adminKullaniciAdi=@admin AND adminSifre=@sifre ";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@admin", textBox1.Text);
            secmeKomutu.Parameters.AddWithValue("@sifre", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                adminekran f1 = new adminekran();
                f1.Show();
                this.Hide();
                baglanti.Close();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            adminekle f2 = new adminekle();
            f2.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            adminsil f3 = new adminsil();
            f3.Show();
           

        }

        private void admingiris_Load(object sender, EventArgs e)
        {

        }
    }
}
