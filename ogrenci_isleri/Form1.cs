using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_isleri
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="202013709029")
            {
                listBox1.Items.Clear();
                OGR1 ogr1 = new OGR1();
                ogr1.isim = "RANA";
                ogr1.soyad = "ÜZEL";
                ogr1.numara = "202013709029";
                ogr1.bölüm = "BİLGİSAYAR MÜHENDİSLİĞİ";
                ogr1.sınıf = "2.SINIF";
                listBox1.Items.Add("İSİM : " + ogr1.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr1.soyad);
                listBox1.Items.Add("NUMARA: " + ogr1.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr1.bölüm);
                listBox1.Items.Add("SINIF : " + ogr1.sınıf);

            }
            if (textBox1.Text == "202010709023")
            {
                listBox1.Items.Clear();
                OGR2 ogr2 = new OGR2();
                ogr2.isim = "AHMET";
                ogr2.soyad = "CANBAY";
                ogr2.numara = "202010709023";
                ogr2.bölüm = "TURİZM VE OTELCİLİK";
                ogr2.sınıf = "2.SINIF";
                listBox1.Items.Add("İSİM : " + ogr2.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr2.soyad);
                listBox1.Items.Add("NUMARA: " + ogr2.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr2.bölüm);
                listBox1.Items.Add("SINIF : " + ogr2.sınıf);

            }
            if (textBox1.Text == "201810907034")
            {
                listBox1.Items.Clear();
                OGR3 ogr3 = new OGR3();
                ogr3.isim = "MURAT";
                ogr3.soyad = "ÜNLÜ";
                ogr3.numara = "201810907034";
                ogr3.bölüm = "EDEBİYAT";
                ogr3.sınıf = "4.SINIF";
                listBox1.Items.Add("İSİM : " + ogr3.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr3.soyad);
                listBox1.Items.Add("NUMARA: " + ogr3.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr3.bölüm);
                listBox1.Items.Add("SINIF : " + ogr3.sınıf);

            }
            if (textBox1.Text == "201910103012")
            {
                listBox1.Items.Clear();
                OGR4 ogr4 = new OGR4();
                ogr4.isim = "SEVGİ";
                ogr4.soyad = "ÇİNTAŞ";
                ogr4.numara = "201910103012";
                ogr4.bölüm = "TARİH";
                ogr4.sınıf = "3.SINIF";
                listBox1.Items.Add("İSİM : " + ogr4.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr4.soyad);
                listBox1.Items.Add("NUMARA: " + ogr4.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr4.bölüm);
                listBox1.Items.Add("SINIF : " + ogr4.sınıf);

            }
            if (textBox1.Text == "202030409019")
            {
                listBox1.Items.Clear();
                OGR5 ogr5 = new OGR5();
                ogr5.isim = "SENA";
                ogr5.soyad = "AYDIN";
                ogr5.numara = "202030409019";
                ogr5.bölüm = "MOLEKÜLER BİYOLOJİ VE GENETİK";
                ogr5.sınıf = "2.SINIF";
                listBox1.Items.Add("İSİM : " + ogr5.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr5.soyad);
                listBox1.Items.Add("NUMARA: " + ogr5.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr5.bölüm);
                listBox1.Items.Add("SINIF : " + ogr5.sınıf);

            }
            if (textBox1.Text == "2021137090211")
            {
                listBox1.Items.Clear();
                OGR6 ogr6 = new OGR6();
                ogr6.isim = "SALİH";
                ogr6.soyad = "KAR";
                ogr6.numara = "202013709029";
                ogr6.bölüm = "BİLGİSAYAR MÜHENDİSLİĞİ";
                ogr6.sınıf = "1.SINIF";
                listBox1.Items.Add("İSİM : " + ogr6.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr6.soyad);
                listBox1.Items.Add("NUMARA: " + ogr6.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr6.bölüm);
                listBox1.Items.Add("SINIF : " + ogr6.sınıf);
            }
            if (textBox1.Text == "201810901014")
            {
                listBox1.Items.Clear();
                OGR7 ogr7 = new OGR7();
                ogr7.isim = "MUSTAFA";
                ogr7.soyad = "USLU";
                ogr7.numara = "201810901014";
                ogr7.bölüm = "İŞLETME";
                ogr7.sınıf = "4.SINIF";
                listBox1.Items.Add("İSİM : " + ogr7.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr7.soyad);
                listBox1.Items.Add("NUMARA: " + ogr7.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr7.bölüm);
                listBox1.Items.Add("SINIF : " + ogr7.sınıf);
            }
            if (textBox1.Text == "202013709022")
            {
                listBox1.Items.Clear();
                OGR8 ogr8 = new OGR8();
                ogr8.isim = "BUSE";
                ogr8.soyad = "BOYLAN";
                ogr8.numara = "202013709022";
                ogr8.bölüm = "BİLGİSAYAR MÜHENDİSLİĞİ";
                ogr8.sınıf = "2.SINIF";
                listBox1.Items.Add("İSİM : " + ogr8.isim);
                listBox1.Items.Add("SOYİSİM : " +ogr8.soyad);
                listBox1.Items.Add("NUMARA: " + ogr8.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr8.bölüm);
                listBox1.Items.Add("SINIF : " + ogr8.sınıf);
            }
            if (textBox1.Text == "202010103003")
            {
                listBox1.Items.Clear();
                OGR9 ogr9 = new OGR9();
                ogr9.isim = "AHMET";
                ogr9.soyad = "ÜNAL";
                ogr9.numara =" 202010103003";
                ogr9.bölüm = "MATEMATİK";
                ogr9.sınıf = "2.SINIF";
                listBox1.Items.Add("İSİM : " + ogr9.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr9.soyad);
                listBox1.Items.Add("NUMARA: " + ogr9.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr9.bölüm);
                listBox1.Items.Add("SINIF : " + ogr9.sınıf);
            }
            if (textBox1.Text == "202010103025")
            {
                listBox1.Items.Clear();
                OGR10 ogr10 = new OGR10();
                ogr10.isim = "ÇAĞLA";
                ogr10.soyad = "GÜR";
                ogr10.numara = "202010103025";
                ogr10.bölüm = "MATEMATİK";
                ogr10.sınıf = "2.SINIF";
                listBox1.Items.Add("İSİM : " + ogr10.isim);
                listBox1.Items.Add("SOYİSİM : " + ogr10.soyad);
                listBox1.Items.Add("NUMARA: " + ogr10.numara);
                listBox1.Items.Add("BÖLÜM : " + ogr10.bölüm);
                listBox1.Items.Add("SINIF : " + ogr10.sınıf);
            }
            textBox1.Clear();
        }
    }
}
