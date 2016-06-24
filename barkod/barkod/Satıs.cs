using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace barkod
{
    public partial class Satıs : Form
    {
        public Satıs()
        {
            InitializeComponent();
        }

        SqlConnection kon = new SqlConnection("Server=localhost;Database=Barkod_Okuyucu;User id=ksk;Password=12345678");
        SqlTransaction trns;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                Form1 satıs = new Form1();
                satıs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Satış Tamamlanmadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                Fatura fatura = new Fatura();
                fatura.ShowDialog();
            }
            else
            {
                MessageBox.Show("Satış Tamamlanmadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
        

        private void btn_ara_Click(object sender, EventArgs e)
        {

            try
            {
                
                string SQL = "Select * from Urunler where Barkod_no like '%" + maskedTextBox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(SQL, kon);
                cmd.Transaction = trns;
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    textBox4.Text = reader.GetString(0).ToString();
                    textBox3.Text = reader.GetString(1).ToString();
                    textBox5.Text = reader.GetString(2).ToString();
                    textBox6.Text = reader.GetString(3).ToString();
                    textBox7.Text = reader.GetString(4).ToString();
                    textBox8.Text = reader.GetSqlInt32(5).ToString();
                }
                reader.Close();
                int stok_sayısı = (Convert.ToInt32(textBox8.Text) - Convert.ToInt32(textBox1.Text));
                textBox8.Text = Convert.ToString(stok_sayısı);
                if (Convert.ToInt32(textBox8.Text) <= 10 && Convert.ToInt32(textBox8.Text) >= 0)
                {
                    MessageBox.Show(textBox8.Text + " Adet Kalmıştır.", "STOK UYARISI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Convert.ToInt32(textBox8.Text) < 0)
                {
                    DialogResult secim = DialogResult.OK;
                    secim = MessageBox.Show("Stokta Yeteri Kadar Ürün Bulunmadığı için Satış Yapamazsınız ", "STOK UYARISI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (secim == DialogResult.OK)
                    {
                        maskedTextBox1.Text = "";
                        
                        textBox1.Text = "1";
                        textBox2.Text = "0";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                    }

                }
                else
                {
                    SqlCommand satısekle = new SqlCommand("satıs_ekle", kon);
                    satısekle.Transaction = trns;
                    satısekle.CommandType = CommandType.StoredProcedure;

                    SqlParameter barkod = new SqlParameter("@barkodno", SqlDbType.VarChar, 50);
                    barkod.Value = maskedTextBox1.Text;
                    satısekle.Parameters.Add(barkod);

                    SqlParameter faturano = new SqlParameter("@faturano", SqlDbType.VarChar, 50);
                    faturano.Value = label4.Text;
                    satısekle.Parameters.Add(faturano);

                    SqlParameter adet = new SqlParameter("@adet", SqlDbType.Int);
                    adet.Value = textBox1.Text;
                    satısekle.Parameters.Add(adet);

                    satısekle.ExecuteNonQuery();


                    string sql = string.Format("UPDATE Urunler SET kalan_stok='" + textBox8.Text + "' WHERE Barkod_no='" + maskedTextBox1.Text + "'");
                    SqlCommand stok = new SqlCommand(sql, kon);
                    stok.Transaction = trns;
                    stok.ExecuteNonQuery();

                    listBox1.Items.Add(maskedTextBox1.Text + " " + " x " + textBox1.Text + " = " + Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox1.Text) + " TL");
                    double fiyatı = (Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox1.Text)) + Convert.ToDouble(textBox2.Text);
                    maskedTextBox1.Text = "";
                    textBox1.Text = "1";
                    textBox2.Text = Convert.ToString(fiyatı);
                    textBox8.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


             
             

        }

        

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void Satıs_Load(object sender, EventArgs e)
        {
            
            string SQL = "Select max(fatura_no) from Fatura";
            SqlCommand cmd = new SqlCommand(SQL, kon);
            kon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    label4.Text = reader.GetSqlInt32(0).ToString();
                }

            }
            finally
            {
               
                reader.Close();
                kon.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                

                string sql = string.Format("UPDATE Fatura SET toplam_fiyat='" + Convert.ToDouble(textBox2.Text) + "' WHERE fatura_no='" + label4.Text + "'");
                SqlCommand cmd = new SqlCommand(sql, kon);
                cmd.Transaction = trns;
                cmd.ExecuteNonQuery();
                trns.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kon.Close();
            }
            button1.Enabled = false;
            btn_ara.Enabled = false;
            button2.Enabled = true;
            textBox10.Text = textBox2.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text != "Null")
            {
                label4.Text = Convert.ToString(Convert.ToInt32(label4.Text) + 1);
            }
            else
            {
                label4.Text = "1";
            }
            try
            {
                kon.Open();

                trns = kon.BeginTransaction();
                

                SqlCommand faturaac = new SqlCommand("fatura_ac", kon);

                faturaac.Transaction = trns;
                faturaac.CommandType = CommandType.StoredProcedure;

                SqlParameter fatura_no = new SqlParameter("@fatura_no", SqlDbType.VarChar, 50);
                fatura_no.Value = label4.Text;
                faturaac.Parameters.Add(fatura_no);

                faturaac.ExecuteNonQuery();
                
                
            }

            catch (Exception)
            {
                
            }

            button1.Enabled = true;
            btn_ara.Enabled = true;
            button2.Enabled = false;
            listBox1.Items.Clear();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            maskedTextBox1.Text = "";
            textBox2.Text = "0";
        }

        private void yapılanSatışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                Y_Satıslar ysatıs = new Y_Satıslar();
                ysatıs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Satış Tamamlanmadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "")
            {
                decimal p_üstü, p_alti, p_toplam;
                p_üstü = Convert.ToDecimal(textBox9.Text);
                p_alti = Convert.ToDecimal(textBox10.Text);
                p_toplam = p_üstü - p_alti;
                textBox11.Text = (p_toplam.ToString());
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar <= 44)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                Giris grs = new Giris();
                grs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Satış Tamamlanmadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
            Hakkında hknda = new Hakkında();
            hknda.ShowDialog();
            }
                 else
            {
                MessageBox.Show("Satış Tamamlanmadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void Satıs_Click(object sender, EventArgs e)
        {
            if (button2.Enabled == true)
            {
                MessageBox.Show("İşlem Yapabilmek için Fatura Açmalısınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama rpr = new Raporlama();
            rpr.Show();
            this.Hide();
        }

      
         
    }
}
