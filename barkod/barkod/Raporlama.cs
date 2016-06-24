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
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Barkod_OkuyucuDataSet3.Rapor' table. You can move, or remove it, as needed.
            this.RaporTableAdapter.Fill(this.Barkod_OkuyucuDataSet3.Rapor);

            this.reportViewer1.RefreshReport();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 satıs = new Form1();
            satıs.Show();
            this.Hide();
        }

        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satıs satıs = new Satıs();
            satıs.Show();
            this.Hide();
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hknda = new Hakkında();
            hknda.ShowDialog();
        }
    }
}
