using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace barkod
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button_Satıs_Click(object sender, EventArgs e)
        {
            Satıs satıs = new Satıs();
            satıs.Show();
            this.Hide();
        }

        private void button_fatura_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.ShowDialog();
            
        }

        private void button_urunler_Click(object sender, EventArgs e)
        {
            Form1 urunler = new Form1();
            urunler.Show();
            this.Hide();
        }

        private void button_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_rapor_Click(object sender, EventArgs e)
        {
            Raporlama rpr = new Raporlama();
            rpr.Show();
            this.Hide();
        }

     

        
    }
}
