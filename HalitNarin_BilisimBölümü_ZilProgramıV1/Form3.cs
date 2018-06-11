using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HalitNarin_BilisimBölümü_ZilProgramıV1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
     public   OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=derssaati.accdb");
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'derssaatiDataSet7.derssaati' table. You can move, or remove it, as needed.
            this.derssaatiTableAdapter.Fill(this.derssaatiDataSet7.derssaati);
            göster();
            maskedTextBox1.Mask = "##:##:##";
            maskedTextBox2.Mask = "##:##:##";
            maskedTextBox3.Mask = "##:##:##";
        }
        public void göster()
        {
            baglanti.Open();
            OleDbDataAdapter asd = new OleDbDataAdapter("Select*from derssaati", baglanti);
            DataTable tablo = new DataTable();
            asd.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string kntrlsecim = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == secim)
                    {
                        kntrlsecim = "1";
                    }
                }
                if (kntrlsecim == "1")
                {
                    baglanti.Open();
                    OleDbCommand güncelle = new OleDbCommand("update derssaati set derssaati='" + textBox1.Text + "',Girişsüresi='" + maskedTextBox1.Text + "',öğretmenzili='" + maskedTextBox2.Text + "',çıkışsüresi='" + maskedTextBox3.Text + "' where derssaati='" + secim + "'", baglanti);
                    güncelle.ExecuteNonQuery();
                    baglanti.Close();
                    göster();
                    MessageBox.Show(secim + " DersSaati'ne sahip Ders Süreleri Güncellendi");
                    textBox1.Text = "";
                    maskedTextBox1.Text = "";
                    maskedTextBox2.Text = "";
                    maskedTextBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Lütfen Güncellemek İstediğiniz Satırı Seçiniz(Tekrar)","Uyarı");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Süre Değerlerini Boş Bırakmayın ve Kontrol Edin,\nGirilen Değerlerin 00:00:00 ile 23:59:59 Arasında Olduğundan\nve Aynı Ders Saatine Ait Ders Eklemeye Çalışmadığınızdan Emin Olun","Uyarı");
                baglanti.Close();
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        string secim;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                secim = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            göster();
        }
    }
}
