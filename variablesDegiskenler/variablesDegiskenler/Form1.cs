using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablesDegiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            //String değişken işlem 1
            string adsoyad, meslek;
            adsoyad = "Selim Çınar";
            meslek = "Yazılımcı";
            label1.Text = adsoyad + " " + meslek;

            //String değişken işlem 2
            string sehir;
            sehir = textBox1.Text;
            label2.Text = sehir;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //labela sayı yazdırma
            int sayi;
            sayi = 24;
            label4.Text = sayi.ToString();

            //dışardan gelen kodlardan toplam değeri bulma
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 4;
            toplam = sayi1 + sayi2;
            label3.Text = toplam.ToString();

            // alan cevre hesabı
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label5.Text = "Alan : " + alan + " " + "Çeve : " + cevre;

            //Alan cevre hesabı dikdörtgen
            int kısakenar, uzunkenar, alan1, cevre1;
            kısakenar = 10;
            uzunkenar = 20;
            alan1 = kısakenar * uzunkenar;
            cevre1 = (kısakenar + uzunkenar) * 2;
            label6.Text = cevre.ToString();

            // 3 sınav notu girilen öğrencinin ortalaması
            int sınav1, sınav2, sınav3, ortalama;
            sınav1 = Convert.ToInt32(textBox2.Text);
            sınav2 = Convert.ToInt32(textBox3.Text);
            sınav3 = Convert.ToInt32(textBox4.Text);
            ortalama = sınav1 + sınav2 + sınav3;
            label7.Text = ortalama.ToString();

            // dışardan sayı girişi ve küpünü alan program
            int sayi25,sonuc;
            sayi25 = Convert.ToInt16(textBox5.Text);
            sonuc = sayi25 * sayi25 * sayi25;
            label9.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, fark, bolum;
            sayi1 = Convert.ToInt16(textBox6.Text);
            sayi2 = Convert.ToInt16(textBox7.Text);
            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            fark = sayi1 - sayi2;

            MessageBox.Show("Toplam : " + toplam + "\n" + "Fark:" + fark + "Çarpım: " + carpim + "\n" + "Bolum: " + bolum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = 60;
            s2 = 70;
            s3 = 79;
            ort = (s1 + s2 + s3) / 3;
            label13.Text = ort.ToString("0.0000");

            //klavyeden değer alma
            double sayi50 = Convert.ToDouble(textBox8.Text);
            label12.Text = sayi50.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ortalama35;
            ad = textBox9.Text;
            soyad = textBox10.Text;
            s1 = Convert.ToInt16(textBox11.Text);
            s2 = Convert.ToInt16(textBox12.Text);
            proje = Convert.ToInt16(textBox13.Text);
            ortalama35 = (s1 + s2 + proje) / 3;
            listBox1.Items.Add("AD SOYAD : "+ ad + " " + soyad +"  "+ "Ortalama : " + ortalama35);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char takim;
            takim = 'f';
            label20.Text = takim.ToString();

            char ders;
            ders = Convert.ToChar(textBox14.Text);
            label21.Text = ders.ToString();

        }
    }
}
