using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelrezervasyonproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yıldızsayısı;
        string oteladı, kullanıcıadı, sifre;
        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();

            panel1.Hide();
            panel2.Enabled = false;
            menuStrip1.Enabled = false;

            string baglantı, sorgu;
            baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Otel.accdb";
            sorgu = "Select*From İşletmeci";
            OleDbConnection yeni = new OleDbConnection(baglantı);
            OleDbCommand veri = new OleDbCommand(sorgu, yeni);
            OleDbDataReader oku;
            yeni.Open();
            oku = veri.ExecuteReader();

            while (oku.Read())
            {

                oteladı = (oku[0]).ToString();
                label3.Text = (oku[2]).ToString();
            }
            oku.Close();
            yeni.Close();

            yıldızsayısı = int.Parse(label3.Text);
            if (yıldızsayısı == 1)
            {
                pictureBox1.Show();
            }
            if (yıldızsayısı == 2)
            {
                pictureBox1.Show();
                pictureBox2.Show();
            }
            if (yıldızsayısı == 3)
            {
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
            }
            if (yıldızsayısı == 4)
            {
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
            }
            if (yıldızsayısı == 5)
            {
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
            }
            label3.Text = oteladı.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            panel1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            girişişlemleri();
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            menuStrip1.Enabled = false;
            panel1.Show();

        }

        private void işletmeciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void kullanıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.ShowDialog();
        }

        private void odalarDurumuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.ShowDialog();
        }

        private void işletmeciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.ShowDialog();
        }

        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.ShowDialog();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.ShowDialog();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.ShowDialog();
        }

        private void odaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form10 = new Form10();
            form10.ShowDialog();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Yeniden Başlatılıyor");
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Boş ve Temiz Odalar")
            {
                listBox1.Items.Clear();
                string bağlantı, sorgu;
                bağlantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Otel.accdb";
                sorgu = "Select OdaAdı From BoşveTemiz";
                OleDbConnection yeni = new OleDbConnection(bağlantı);
                OleDbCommand baglan = new OleDbCommand(sorgu, yeni);
                OleDbDataReader oku;
                yeni.Open();
                oku = baglan.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku["OdaAdı"].ToString());
                }
                oku.Close();
                yeni.Close();
            }
            else
            {
                if (comboBox1.Text == "Kirli Odalar")
                {
                    listBox1.Items.Clear();
                    string bağlantı, sorgu;
                    bağlantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Otel.accdb";
                    sorgu = "Select OdaAdı From Kirli";
                    OleDbConnection yeni = new OleDbConnection(bağlantı);
                    OleDbCommand baglan = new OleDbCommand(sorgu, yeni);
                    OleDbDataReader oku;
                    yeni.Open();
                    oku = baglan.ExecuteReader();
                    while (oku.Read())
                    {
                        listBox1.Items.Add(oku["OdaAdı"].ToString());
                    }
                    oku.Close();
                    yeni.Close();

                }
                else
                {
                    if (comboBox1.Text == "Dolu Odalar")
                    {

                        listBox1.Items.Clear();
                        string bağlantı, sorgu;
                        bağlantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Otel.accdb";
                        sorgu = "Select OdaAdı From Dolu";
                        OleDbConnection yeni = new OleDbConnection(bağlantı);
                        OleDbCommand baglan = new OleDbCommand(sorgu, yeni);
                        OleDbDataReader oku;
                        yeni.Open();
                        oku = baglan.ExecuteReader();
                        while (oku.Read())
                        {
                            listBox1.Items.Add(oku["OdaAdı"].ToString());
                        }
                        oku.Close();
                        yeni.Close();
                    }
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form form10 = new Form10();
            form10.ShowDialog();
        }
        private void girişişlemleri()
        {
            string baglantı2, sorgu2;
            baglantı2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Otel.accdb";
            sorgu2 = "Select KullanıcıAdı,Sifre From Kullanıcı";
            OleDbConnection yeni2 = new OleDbConnection(baglantı2);
            OleDbCommand veri2 = new OleDbCommand(sorgu2, yeni2);
            OleDbDataReader oku2;
            yeni2.Open();
            oku2 = veri2.ExecuteReader();
            while (oku2.Read())
            {
                sifre = (oku2["Sifre"]).ToString();
            }
            oku2.Close();
            yeni2.Close();

            string baglantı, sorgu;
            baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Otel.accdb";
            sorgu = "Select KullanıcıAdı,Sifre From Kullanıcı";
            OleDbConnection yeni = new OleDbConnection(baglantı);
            OleDbCommand veri = new OleDbCommand(sorgu, yeni);
            OleDbDataReader oku;
            yeni.Open();
            oku = veri.ExecuteReader();
            while (oku.Read())
            {
                kullanıcıadı = (oku["KullanıcıAdı"]).ToString();

            }
            oku.Close();
            yeni.Close();

            if (kullanıcıadı == textBox1.Text)
            {
                if (sifre == textBox2.Text)
                {
                    panel2.Enabled = true;
                    menuStrip1.Enabled = true;
                    panel1.Hide();

                }
                else
                {
                    MessageBox.Show("Şifre Yanlış");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Yanlış");
            }
    }
}
