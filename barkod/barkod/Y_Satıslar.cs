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
    public partial class Y_Satıslar : Form
    {
        public Y_Satıslar()
        {
            InitializeComponent();
        }
        SqlConnection kon = new SqlConnection("Server=localhost;Database=Barkod_Okuyucu;User id=ksk;Password=12345678");
        SqlDataAdapter ksk;


        private void Y_Satıslar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barkod_OkuyucuDataSet4.Satıs' table. You can move, or remove it, as needed.
            this.satısTableAdapter1.Fill(this.barkod_OkuyucuDataSet4.Satıs);
            // TODO: This line of code loads data into the 'Barkod_OkuyucuDataSet3.Rapor' table. You can move, or remove it, as needed.
            this.RaporTableAdapter.Fill(this.Barkod_OkuyucuDataSet3.Rapor);
            // TODO: This line of code loads data into the 'barkod_OkuyucuDataSet2.Satıs' table. You can move, or remove it, as needed.
            this.satısTableAdapter.Fill(this.barkod_OkuyucuDataSet2.Satıs);

            
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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Silme İşlemi Gerçeklestirilsin Mi ?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = string.Format("DELETE Satıs WHERE Barkod_no='" + maskedTextBox_ÜAra.Text + "'and fatura_no='" + textBox1.Text + "'");
                    SqlCommand cmd = new SqlCommand(sql, kon);
                    kon.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Silme İşlemi Başarılıdır", "İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else 
                {
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kon.Close();
                maskedTextBox_ÜAra.Text = "";
                textBox1.Text = "";
            }
            
        }

        private void maskedTextBox_ÜAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (kon.State != ConnectionState.Open)
                {
                    kon.Open();
                }
                ksk = new SqlDataAdapter("Select * from Satıs", kon);
                DataTable dt = new DataTable();

                ksk.SelectCommand.CommandText = "Select * from Satıs where fatura_no like '%" + textBox1.Text + "%'" + " and Barkod_no like '%" + maskedTextBox_ÜAra.Text + "%'";
                dt.Clear();
                ksk.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kon.Close();
            }
                
               
                   
        }
        
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (kon.State != ConnectionState.Open)
                {
                    kon.Open();
                }
                ksk = new SqlDataAdapter("Select * from Satıs", kon);
                DataTable dt = new DataTable();
                ksk.SelectCommand.CommandText = "Select * from Satıs where fatura_no like '%" + textBox1.Text + "%'"+" and Barkod_no like '%" + maskedTextBox_ÜAra.Text + "%'";
                dt.Clear();
                ksk.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kon.Close();
            }
            

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                maskedTextBox_ÜAra.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}