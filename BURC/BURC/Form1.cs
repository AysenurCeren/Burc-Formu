using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURC
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string burc, yukselen, konum; //hangi değişkenleri kullancaksak onları tanıtıyoruz
            int gun, ay, saat, dakika;

            gun = int.Parse(textBox1.Text);  //text kutularını gün - ay ve saat - dakika olarak tanıtıyoruz
            ay = int.Parse(textBox2.Text);
            saat = int.Parse(textBox4.Text);
            dakika = int.Parse(textBox3.Text);
            burc = label4.Text;
            yukselen = label3.Text;
            konum = label6.Text;

            if (gun >= 20 & gun <= 30 & ay == 1)
            { // gün ve ay textlerine girilen tarihlere göre Burcları yazdırıyor.

                label4.Text = "Kova";
                MessageBox.Show("kova hava grubudur. Uğurlu sayısı:1'dir. " +
                                 "Özgürlükçü, Akıllı ve Donanımlı insanlardır. Genelde Bilim insanı olurlar.", 
                                 "Kova Burcu Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (gun >= 1 & gun <= 20 & ay == 2)
            {
                label4.Text = "Kova";
                MessageBox.Show("kova hava grubudur. Uğurlu sayısı:1'dir. " +
                                "Özgürlükçü, Akıllı ve Donanımlı insanlardır. Genelde Bilim insanı olurlar.", 
                                "Kova Burcu Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else 
            {
                if (gun >= 19 & gun <= 29 & ay == 2)
                {
                    label4.Text = "Balık";
                    MessageBox.Show("Balık su grubudur. Uğurlu sayısı:2'dir. " +
                                    "Hayalperest, romantik ve çok duygulu insanlardır. Genelde Yazar olurlar.", 
                                    "Balık Burcu Hakkında Bilgi", MessageBoxButtons.OK);

                }
                else if (gun >= 1 & gun <= 21 & ay == 3)
                {
                    label4.Text = "Balık";
                    MessageBox.Show("Balık su grubudur. Uğurlu sayısı:2'dir. " +
                                    "Hayalperest, romantik ve çok duygulu insanlardır. Genelde Yazar olurlar.",
                                    "Balık Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                }
                else
                {
                    if (gun >= 22 & gun <= 31 & ay == 3)
                    {
                        label4.Text = "Koç";
                        MessageBox.Show("Koç ateş grubudur. Uğurlu sayısı:3'dir. " +
                                        "Lider, Güce önem veren ve hırslı insanlardır. Genelde Başkan olurlar.",
                                        "Koç Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                    }
                    else if (gun >= 1 & gun <= 21 & ay == 4)
                    {
                        label4.Text = "Koç";
                        MessageBox.Show("Koç ateş grubudur. Uğurlu sayısı:3'dir. " +
                                       "Lider, Güce önem veren ve hırslı insanlardır. Genelde Başkan olurlar.",
                                       "Koç Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                    }
                    else
                    {

                        if (gun >= 22 & gun <= 30 & ay == 4)
                        {
                            label4.Text = "Boğa";
                            MessageBox.Show("Boğa toprak grubudur. Uğurlu sayısı:4'dir. " +
                                            "Yemek yemeyi seven,üşengeç ve inatçı insanlardır. Genelde Aşçı olurlar.",
                                             "Boğa Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                        }
                        else if (gun >= 1 & gun <= 21 & ay == 5)
                        {
                            label4.Text = "Boğa";
                            MessageBox.Show("Boğa toprak grubudur. Uğurlu sayısı:4'dir. " +
                                            "Yemek yemeyi seven,üşengeç ve inatçı insanlardır. Genelde Aşçı olurlar.",
                                             "Boğa Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                        }
                        else
                        {

                            if (gun >= 22 & gun <= 31 & ay == 5)
                            {
                                label4.Text = "İkizler";
                                MessageBox.Show("İkizler Hava grubudur. Uğurlu sayısı:5'dir. " +
                                                "Her an eğlence isteyen ve kararsız insanlardır. Genelde Aktör olurlar.",
                                                "İkizler Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                            }
                            else if (gun >= 1 & gun <= 22 & ay == 6)
                            {
                                label4.Text = "İkizler";
                                MessageBox.Show("İkizler Hava grubudur. Uğurlu sayısı:5'dir. " +
                                                "Her an eğlence isteyen ve kararsız insanlardır. Genelde Aktör olurlar.",
                                                "İkizler Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                            }
                            else
                            {

                                if (gun >= 23 & gun <= 30 & ay == 6)
                                {
                                    label4.Text = "Yengeç";
                                    MessageBox.Show("Yengeç su grubudur. Uğurlu sayısı:6'dir. " +
                                                    "Duygusal,Hassas ve güçlü hafızaya sahip insanlardır. Genelde Öğretmen olurlar.",
                                                    "Yengeç Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                }
                                else if (gun >= 1 & gun <= 25 & ay == 7)
                                {
                                    label4.Text = "Yengeç";
                                    MessageBox.Show("Yengeç su grubudur. Uğurlu sayısı:6'dir. " +
                                                    "Duygusal,Hassas ve güçlü hafızaya sahip insanlardır. Genelde Öğretmen olurlar.",
                                                    "Yengeç Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                }
                                else
                                {

                                    if (gun >= 26 & gun <= 31 & ay == 7)
                                    {

                                        label4.Text = "Başak";
                                        MessageBox.Show("Başak toprak grubudur. Uğurlu sayısı:7'dir. " +
                                                        "İşkolik,parayı seven sorumluluk sahibi insanlardır. Genelde Şirketlerde çalışırlar.",
                                                        "Başak Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                    }
                                    else if (gun >= 1 & gun <= 24 & ay == 8)
                                    {

                                        label4.Text = "Başak";
                                        MessageBox.Show("Başak toprak grubudur. Uğurlu sayısı:7'dir. " +
                                                        "İşkolik,parayı seven sorumluluk sahibi insanlardır. Genelde Şirketlerde çalışırlar.",
                                                        "Başak Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        if (gun >= 25 & gun <= 31 & ay == 8)
                                        {

                                            label4.Text = "Terazi";
                                            MessageBox.Show("Terazi hava grubudur. Uğurlu sayısı:8'dir. " +
                                                            "Sosyal,sıcak kanlı ve kararsız insanlardır. Genelde Gazeteci olurlar.",
                                                            "Terazi Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                        }
                                        else if (gun >= 1 & gun <= 24 & ay == 9)
                                        {

                                            label4.Text = "Terazi";
                                            MessageBox.Show("Terazi hava grubudur. Uğurlu sayısı:8'dir. " +
                                                            "Sosyal,sıcak kanlı ve kararsız insanlardır. Genelde Gazeteci olurlar.",
                                                            "Terazi Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                        }
                                        else
                                        {
                                            if (gun >= 25 & gun <= 31 & ay == 9)
                                            {

                                                label4.Text = "Akrep";
                                                MessageBox.Show("Akrep su grubudur. Uğurlu sayısı:9'dir. " +
                                                                "Rekabetçi,güçlü ve akıllı insanlardır. Genelde Avukat olurlar.",
                                                                "Akrep Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                            }
                                            else if (gun >= 1 & gun <= 23 & ay == 10)
                                            {
                                                label4.Text = "Akrep";
                                                MessageBox.Show("Akrep su grubudur. Uğurlu sayısı:9'dir. " +
                                                                "Rekabetçi,güçlü ve akıllı insanlardır. Genelde Avukat olurlar.",
                                                                "Akrep Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                            }
                                            else
                                            {
                                                if (gun >= 24 & gun <= 30 & ay == 10)
                                                {

                                                    label4.Text = "Yay";
                                                    MessageBox.Show("Yay ateş grubudur. Uğurlu sayısı:10'dir. " +
                                                                    "Eğlenceli,maceracı ve komik insanlardır. Genelde sporcu olurlar.",
                                                                    "Yay Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                                }
                                                else if (gun >= 1 & gun <= 22 & ay == 11)
                                                {

                                                    label4.Text = "Yay";
                                                    MessageBox.Show("Yay ateş grubudur. Uğurlu sayısı:10'dir. " +
                                                                    "Eğlenceli,maceracı ve komik insanlardır. Genelde sporcu olurlar.",
                                                                    "Yay Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                                }
                                                else
                                                {

                                                    if (gun >= 23 & gun <= 31 & ay == 11)
                                                    {

                                                        label4.Text = "Oğlak";
                                                        MessageBox.Show("Oğlak toprak grubudur. Uğurlu sayısı:11'dir. " +
                                                                        "Çalışkan, hırslı ve mantıkla hareket eden insanlardır. Genelde Hakim olurlar.",
                                                                        "Oğlak Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                                    }
                                                    else if (gun >= 1 & gun <= 21 & ay == 12)
                                                    {

                                                        label4.Text = "Oğlak";
                                                        MessageBox.Show("Oğlak toprak grubudur. Uğurlu sayısı:11'dir. " +
                                                                        "Çalışkan, hırslı ve mantıkla hareket eden insanlardır. Genelde Hakim olurlar.",
                                                                        "Oğlak Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                                    }
                                                    else
                                                    {

                                                        if (gun >= 22 & gun <= 31 & ay == 12)
                                                        {

                                                            label4.Text = "Aslan";
                                                            MessageBox.Show("Aslan ateş grubudur. Uğurlu sayısı:12'dir. " +
                                                                            "Öfkeli, Kendini ve başarıyı çok seven  insanlardır. Genelde Model olurlar.",
                                                                            "Aslan Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                                        }
                                                        else if (gun >= 1 & gun <= 19 & ay == 1)
                                                        {

                                                            label4.Text = "Aslan";
                                                            MessageBox.Show("Aslan ateş grubudur. Uğurlu sayısı:12'dir. " +
                                                                            "Öfkeli, Kendini ve başarıyı çok seven  insanlardır. Genelde Model olurlar.",
                                                                            "Aslan Burcu Hakkında Bilgi", MessageBoxButtons.OK);
                                                        }
                                                        else
                                                        {
                                                            label4.Text = "Hata";

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            



            if (dakika >= 0 & dakika <= 59 & saat >= 0 & saat <= 1)
            {
                label3.Text = "Koç";
                MessageBox.Show("Koç yükseleni savaşçı ve hırs özelliğini verir. ","Koç Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);
            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 2 & saat <= 3)
            {
                label3.Text = "Boğa";
                MessageBox.Show("Boğa yükseleni inatçılığını ve iştah özelliğini verir. ", "Boğa Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 4 & saat <= 5)
            {
                label3.Text = "ikizler";
                MessageBox.Show("İkizler yükseleni girişkenliğini ve kararsızlık özelliğini verir. ", "İkizler Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 6 & saat <= 7)
            {
                label3.Text = "Yengeç";
                MessageBox.Show("Yengeç yükseleni Duygusallığını ve kurnazlık özelliğini verir. ", "Yengeç Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 8 & saat <= 9)
            {
                label3.Text = "Aslan";
                MessageBox.Show("Aslan yükseleni ben merkezciliğini ve tutkusunu verir. ", "Aslan Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 10 & saat <= 11)
            {
                label3.Text = "Başak";
                MessageBox.Show("Başak yükseleni para kazanma tutkusunu ve mantıksal bakış özelliğini verir. ", "Başak Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 12 & saat <= 13)
            {
                label3.Text = "Terazi";
                MessageBox.Show("Terazi yükseleni konuşkanlık ve sosyallik özelliğini verir. ", "Terazi Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 14 & saat <= 15)
            {
                label3.Text = "Oğlak";
                MessageBox.Show("Oğlak yükseleni çalışkan ve inatçı özelliğini verir. ", "Oğlak Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 16 & saat <= 17)
            {
                label3.Text = "Kova";
                MessageBox.Show("Kova yükseleni Akılcı ve Özgürlükçü yanını verir. ", "Kova Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 18 & saat <= 19)
            {
                label3.Text = "Balık";
                MessageBox.Show("Balık yükseleni Hayalperestliğini ve duygusallığını verir. ", "Balık Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 20 & saat <= 21)
            {
                label3.Text = "Yay";
                MessageBox.Show("Yay yükseleni eğlence ve stressiz yaşama özelliğini verir. ", "Yay Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else if (dakika >= 0 & dakika <= 59 & saat >= 22 & saat <= 23)
            {
                label3.Text = "Akrep";
                MessageBox.Show("Akrep yükseleni rekabet ve kurnaz özelliğini verir. ", "Koç Yükseleni Hakkında Bilgi", MessageBoxButtons.OK);

            }
            else
            {
                label3.Text = "Hata";
            }

            label6.Text = Convert.ToString(listBox1.SelectedItem);
            button1.Enabled = false;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }
    }
}
