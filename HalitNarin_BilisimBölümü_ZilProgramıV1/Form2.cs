using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Data.SqlClient;
using System.Media;

namespace HalitNarin_BilisimBölümü_ZilProgramıV1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
      public  OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=derssaati.accdb");
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'derssaatiDataSet6.derssaati' table. You can move, or remove it, as needed.
            this.derssaatiTableAdapter.Fill(this.derssaatiDataSet6.derssaati);
            // TODO: This line of code loads data into the 'derssaatiDataSet.derssaati' table. You can move, or remove it, as needed.
            maskedTextBox1.Mask = "##:##:##";
            maskedTextBox2.Mask = "##:##:##";
            maskedTextBox3.Mask = "##:##:##";
            göster();
            timer1.Enabled = true;
            timer1.Interval = 1000;

        }
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
  
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
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
       
        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol_1 = 0;
            if (textBox1.Text != "" && maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "")
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox1.Text)
                    {
                        kontrol_1 = 1;
                    }
                }
                if (kontrol_1 != 1)
                {
                    try
                    {
                        baglanti.Open();
                        OleDbCommand ekle = new OleDbCommand("insert into derssaati (DersSaati,GirişSüresi,ÖğretmenZili,ÇıkışSüresi)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "')", baglanti);
                        ekle.ExecuteNonQuery();
                        baglanti.Close();
                        göster();
                        MessageBox.Show("Yeni Ders Süreleri Eklendi");
                        textBox1.Text = "";
                        maskedTextBox1.Text = "";
                        maskedTextBox2.Text = "";
                        maskedTextBox3.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Süre Değerlerini Boş Bırakmayın ve Kontrol Edin,\nGirilen Değerlerin 00:00:00 ile 23:59:59 Arasında Olduğundan\nve Aynı Ders Saatine Ait Ders Eklemeye Çalışmadığınızdan Emin Olun", "Uyarı");
                        baglanti.Close();

                    }
                    
                    
                }
                else
                {
                    MessageBox.Show(textBox1.Text + " DersSaati ne Sahip Ders Zaten Var.Lütfen Başka Ders Saati Girin");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ders Sürelerini Boş Bırakmayın!", "Uyarı!");
            }
            
        }



        private void dersSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int kontrol_2 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox2.Text)
                    {
                        kontrol_2 = 1;
                    }
                }
                if (kontrol_2 == 1)
                {
                    DialogResult cevap = new DialogResult();
                    cevap = MessageBox.Show(textBox2.Text + " Numaralı Dersi Silmek İstediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                    if (cevap == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand sil = new OleDbCommand("delete from derssaati where derssaati='" + textBox2.Text + "'", baglanti);
                        sil.ExecuteNonQuery();
                        baglanti.Close();
                        göster();
                        MessageBox.Show(textBox2.Text + " Numaralı DersSaati Silindi");
                        textBox2.Text = "";
                    }
                    
                }
                else
                {
                    MessageBox.Show(textBox2.Text + " Numaralı DersSaati Bulunamadı");
                }
                
                
            }
            else
            {
                MessageBox.Show("Lütfen Kaçıncı Ders Saatine Ait Süreleri Silmek İstediğinizi Belirtiniz");
            }
            textBox2.Text = "";
            Form3 frm3 = new Form3();
            frm3.göster();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            göster();
        }
    }
}
