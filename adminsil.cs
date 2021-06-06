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
    public partial class adminsil : Form
    {
        public adminsil()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-5QH0G6O\\SQLEXPRESS;Initial Catalog = Odev3; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from adminler where adminId=@adminId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@adminId", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label4.Text = dr["adminId"].ToString();
                label5.Text = dr["adminKullaniciAdi"].ToString();
               string isim = dr["adminKullaniciAdi"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " li admin kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from adminler where adminId=@adminId";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@adminId", textBox1.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
                    textBox1.Clear();
                    label4.Text = "***";
                    label5.Text = "***";
                    
                }
            }
            else
                MessageBox.Show("Admin Bulunamadı.");
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from adminler where adminId=@adminId";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@adminId", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                label4.Text = dr["adminId"].ToString();
                label5.Text = dr["adminKullaniciAdi"].ToString();
                baglanti.Close();
            }
            else
                MessageBox.Show("Admin Bulunamadı.");
            baglanti.Close();
        }
    }
}
