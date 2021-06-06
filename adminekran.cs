using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class adminekran : Form
    {
        public adminekran()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void muavinlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soforler form2 = new soforler();
            form2.MdiParent = this;
            form2.Show();
            
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            admingiris f4 = new admingiris();
            f4.Show();
            this.Close();
        }

        private void biletSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilet form2 = new Bilet();
            form2.MdiParent = this;
            form2.Show();
            
        }

        private void yönetimselİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seferlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seferler form2 = new seferler();
            form2.MdiParent = this;
            form2.Show();
        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otobusler form2 = new otobusler();
            form2.MdiParent = this;
            form2.Show();
        }

        private void muavinlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            muavinler form2 = new muavinler();
            form2.MdiParent = this;
            form2.Show();
        }

        private void biletİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void biletSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilet form2 = new Bilet();
            form2.MdiParent = this;
            form2.Show();
        }

        private void biletListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilet form2 = new Bilet();
            form2.MdiParent = this;
            form2.Show();
        }

        private void adminekran_Load(object sender, EventArgs e)
        {

        }
    }
}
