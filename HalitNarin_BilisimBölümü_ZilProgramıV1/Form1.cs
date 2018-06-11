using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;

namespace HalitNarin_BilisimBölümü_ZilProgramıV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zilÇalmaSaatleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=derssaati.accdb");
        public void göster()
        {
            baglanti.Open();
            OleDbDataAdapter asd = new OleDbDataAdapter("Select*from derssaati", baglanti);
            DataTable tablo = new DataTable();
            asd.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private NotifyIcon nicon = new NotifyIcon();
        private ContextMenu cMenu = new ContextMenu();
       public OleDbConnection sesbaglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=sesler.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {

            this.derssaatiTableAdapter.Fill(this.derssaatiDataSet.derssaati);
            sesbaglanti.Open();
            OleDbDataAdapter sesasd = new OleDbDataAdapter("Select*from sesler where kimlik=" + 1 + "", sesbaglanti);
            DataTable sestablo = new DataTable();
            sesasd.Fill(sestablo);
            sesyolu = sestablo.Rows[0][1].ToString();
            sesadi = sestablo.Rows[0][2].ToString();
            label3.Text = sesadi;
            sesbaglanti.Close();
            nicon.Text = "Zil Kontrol Programı";
            nicon.Visible = true;
            nicon.Icon = new Icon("favicon.ico");
            cMenu.MenuItems.Add(0, new MenuItem("Göster", new System.EventHandler(Goster_Click)));
            cMenu.MenuItems.Add(1, new MenuItem("Gizle", new System.EventHandler(Gizle_Click)));
            cMenu.MenuItems.Add(2, new MenuItem("Kapat", new System.EventHandler(Kapat_Click)));
            nicon.ContextMenu = cMenu;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label1.Text = DateTime.Now.ToLongTimeString();
            göster();
        }
        public void Goster_Click(object sender, System.EventArgs e)
        {
            Show();
        }

        public void Gizle_Click(object sender, System.EventArgs e)
        {
            Hide();
            frm2.Hide();
            frm3.Hide();
        }
        public void Kapat_Click(object sender, System.EventArgs e)
        {
            nicon.Dispose();
            Application.Exit();
            Application.ExitThread();
        }
        SoundPlayer player = new SoundPlayer();
        private void cal()
        {
            try
            {
                
                string path = sesyolu;
                player.SoundLocation = path;
                player.Play();
            }
            catch
            {
                DialogResult sescevap = new DialogResult();
               sescevap=MessageBox.Show(sesadi + " Adındaki Ses Dosyası Bulunamadı. Farklı Bir Ses Dosyası Seçmek İstiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
               if (sescevap == DialogResult.Yes)
               {
                   button4_Click(button4, new EventArgs());
               }
               else
               {
               }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            göster();
            label1.Text = DateTime.Now.ToLongTimeString();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int a = 1; a < dataGridView1.ColumnCount; a++)
                {
                    if (label1.Text ==Convert.ToDateTime(dataGridView1.Rows[i].Cells[a].Value.ToString()).ToLongTimeString())
                    {
                        cal();
                    }
                }
            }
            
        }
        Form2 frm2 = new Form2();

        private void zilSaatleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            frm2.Hide();
        }
        Form3 frm3 = new Form3();

        private void kayıtlıZilSüreleriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cal();
        }
        string sesyolu, sesadi;
        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen (.wav) Uzantılı Ses Dosyası Seçiniz";
            openFileDialog1.Filter = "(*.wav)|*.wav";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sesyolu = openFileDialog1.FileName.ToString();
                sesadi = System.IO.Path.GetFileName(openFileDialog1.FileName);
                label3.Text = sesadi;
                sesbaglanti.Open();
                OleDbCommand sesgüncelle = new OleDbCommand("update sesler set sesyolu='" + sesyolu + "',sesadi='"+sesadi+"' where kimlik=" + 1 + "", sesbaglanti);
                sesgüncelle.ExecuteNonQuery();
                sesbaglanti.Close();

            }
        }

            SoundPlayer ses2 = new SoundPlayer();
        private void button1_Click(object sender, EventArgs e)
        {
            string yol = "istiklalmarsi.wav";
            ses2.SoundLocation = yol;
            ses2.Play();
        }
        SoundPlayer ses3 = new SoundPlayer();

        private void button2_Click(object sender, EventArgs e)
        {

            string yol2 = "saygidurusu.wav";
            ses3.SoundLocation = yol2;
            ses3.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Stop();
            ses2.Stop();
            ses3.Stop();
            
        }
    }
}
