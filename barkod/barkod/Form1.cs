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
    public partial class Form1 : Form
    {
        SqlConnection kon = new SqlConnection("Server=localhost;Database=Barkod_Okuyucu;User id=ksk;Password=12345678");
        SqlDataAdapter ksk;
        
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_barkodno.Text.Length < 13)
                {
                    MessageBox.Show("Barkod Numarasını Kontrol Ediniz...", "HATA" ,MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
                else if (textBox_barkodno.Text.Length == 0 || textBox_ürünadı.Text.Length == 0 || textBox_ürünmarka.Text.Length == 0 || textBox_ürünözel.Text.Length == 0 || textBox_fiyat.Text.Length == 0 || textBox_stok.Text.Length == 0)
                {
                    MessageBox.Show("Boş Alanları Doldurunuz..." , "HATA" ,MessageBoxButtons.OK ,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
                else
                {
                    kon.Open();
                    SqlCommand kmt = new SqlCommand("urunekle", kon);
                    kmt.CommandType = CommandType.StoredProcedure;

                    SqlParameter spbarkod = new SqlParameter("@barkodno", SqlDbType.VarChar, 50);
                    spbarkod.Value = textBox_barkodno.Text;
                    kmt.Parameters.Add(spbarkod);

                    SqlParameter urunmarka = new SqlParameter("@urunmarkası", SqlDbType.VarChar, 50);
                    urunmarka.Value = textBox_ürünmarka.Text;
                    kmt.Parameters.Add(urunmarka);

                    SqlParameter urunadı = new SqlParameter("@urunadı", SqlDbType.VarChar, 50);
                    urunadı.Value = textBox_ürünadı.Text;
                    kmt.Parameters.Add(urunadı);

                    SqlParameter urunozellik = new SqlParameter("@urunozellik", SqlDbType.VarChar, 50);
                    urunozellik.Value = textBox_ürünözel.Text;
                    kmt.Parameters.Add(urunozellik);

                    SqlParameter fiyatı = new SqlParameter("@fiyatı", SqlDbType.VarChar,50);
                    fiyatı.Value = textBox_fiyat.Text;
                    kmt.Parameters.Add(fiyatı);

                    SqlParameter stok = new SqlParameter("@stok", SqlDbType.Int);
                    stok.Value = textBox_stok.Text;
                    kmt.Parameters.Add(stok);
                    if (kmt.ExecuteNonQuery() > 0)
                    {
                        
                        ksk = new SqlDataAdapter("Select * from Urunler", kon);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        ksk.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                   
                    MessageBox.Show("Kayıt Basarılıdır","KAYIT", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Barkod Numarası Sistemde Kayıtlıdır...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kon.Close();
                textBox_barkodno.Text = "";
                textBox_ürünadı.Text = "";
                textBox_ürünmarka.Text = "";
                textBox_ürünözel.Text = "";
                textBox_fiyat.Text = "";
                textBox_stok.Text = "";
            }
        }

       

        private void güncelle_Click(object sender, EventArgs e)
        {
           
            try
            {

                if (textBox5.Text.Length == 0 || textBox4.Text.Length == 0 || textBox3.Text.Length == 0 || textBox2.Text.Length == 0 || textBox1.Text.Length == 0 || maskedTextBox1.Text.Length == 0)
                {
                    MessageBox.Show("Boş Alanları Doldurunuz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                else
                    kon.Open();

                SqlCommand kmt = new SqlCommand("urunguncelle", kon);
                kmt.CommandType = CommandType.StoredProcedure;

                SqlParameter spbarkod = new SqlParameter("@barkodno", SqlDbType.VarChar, 50);
                spbarkod.Value = maskedTextBox1.Text;
                kmt.Parameters.Add(spbarkod);

                SqlParameter urunmarka = new SqlParameter("@urunmarkası", SqlDbType.VarChar, 50);
                urunmarka.Value = textBox5.Text;
                kmt.Parameters.Add(urunmarka);

                SqlParameter urunadı = new SqlParameter("@urunadı", SqlDbType.VarChar, 50);
                urunadı.Value = textBox4.Text;
                kmt.Parameters.Add(urunadı);

                SqlParameter urunozellik = new SqlParameter("@urunozellik", SqlDbType.VarChar, 50);
                urunozellik.Value = textBox3.Text;
                kmt.Parameters.Add(urunozellik);

                SqlParameter fiyatı = new SqlParameter("@fiyatı", SqlDbType.VarChar, 50);
                fiyatı.Value = textBox1.Text;
                kmt.Parameters.Add(fiyatı);

                SqlParameter stok = new SqlParameter("@stok", SqlDbType.Int);
                stok.Value = textBox2.Text;
                kmt.Parameters.Add(stok);
                
                if (kmt.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılıdır", "İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ksk = new SqlDataAdapter("Select * from Urunler", kon);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    ksk.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception )
            {
                

            }
            finally
            {
                kon.Close();
            }

            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            button2.Enabled = true;
            button1.Enabled = true;

        }
        public static string table;
        private void maskedTextBox_ÜAra_TextChanged(object sender, EventArgs e)
        {
            
            if (kon.State != ConnectionState.Open)
            {
                kon.Open();
            }
            ksk = new SqlDataAdapter("Select * from Urunler", kon);
            DataTable dt = new DataTable();
            ksk.SelectCommand.CommandText = "Select * from Urunler where Barkod_no like '%" + maskedTextBox_ÜAra.Text + "%'";
            dt.Clear();
            ksk.Fill(dt);
            dataGridView1.DataSource = dt;
            kon.Close();
            
            
        }
        private void göster()
        {
           

            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            



        }

        
        
        private void textBox_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //yardımcı kaynak http://forum.donanimhaber.com/m_29131512/tm.htm

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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////yardımcı kaynak http://forum.donanimhaber.com/m_29131512/tm.htm

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barkod_OkuyucuDataSet.Urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.barkod_OkuyucuDataSet.Urunler);

        }
        
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                if (dataGridView1.CurrentRow != null) göster();
            }
            catch(Exception)
            {
           

            }
        }

        private void silme_Click(object sender, EventArgs e)
        {
            try
            {
                kon.Open();
                SqlCommand cmd = new SqlCommand("urunsilme", kon);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter spbarkod = new SqlParameter("@barkodno", SqlDbType.VarChar, 50);
                spbarkod.Value = maskedTextBox1.Text;
                cmd.Parameters.Add(spbarkod);
                if (cmd.ExecuteNonQuery() > 0)
                {

                    MessageBox.Show("Silme İşlemi Başarılıdır","İşlem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ksk = new SqlDataAdapter("Select * from Urunler", kon);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    ksk.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kon.Close();
            }
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
           
            
        }

        private void faturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.ShowDialog();
            
        }
        
        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Satıs satıs = new Satıs();
            satıs.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stok_cıkarıs = (Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox6.Text));
            textBox2.Text = Convert.ToString(stok_cıkarıs);
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int stok_arts = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text));
            textBox2.Text = Convert.ToString(stok_arts);
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = "";
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hknda = new Hakkında();
            hknda.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama rpr = new Raporlama();
            rpr.Show();
            this.Hide();
        }

        

       

        
        }
        }

    

