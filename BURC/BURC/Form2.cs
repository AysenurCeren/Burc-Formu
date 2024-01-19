using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uyum,burc1,burc2;
            uyum = label2.Text;
            burc1 = listBox2.Text;
            burc2 = listBox1.Text;
            

            if(burc1 == burc2)
            {
                label2.Text = "Uyumlular.";
            }
            else if(burc1=="koç" && burc2 == "kova"|| burc2=="yay"||burc2=="aslan"||burc2=="terazi")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "kova" && burc2 == "boğa" || burc2 == "balık" || burc2 == "ikizler" || burc2 == "terazi")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "yay" && burc2 == "ikizler" || burc2 == "koç" || burc2 == "aslan" || burc2 == "boğa")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "aslan" && burc2 == "yay" || burc2 == "koç" || burc2 == "ikizler" || burc2 == "akrep")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "terazi" && burc2 == "balık" || burc2 == "koç" || burc2 == "başak" || burc2 == "akrep")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "ikizler" && burc2 == "boğa" || burc2 == "yay" || burc2 == "aslan" || burc2 == "yengeç")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "yengeç" && burc2 == "oğlak" || burc2 == "başak" || burc2 == "kova" || burc2 == "balık")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "balık" && burc2 == "yengeç" || burc2 == "başak" || burc2 == "ikizler" || burc2 == "terazi")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "akrep" && burc2 == "koç" || burc2 == "terazi" || burc2 == "aslan" || burc2 == "kova")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "başak" && burc2 == "oğlak" || burc2 == "yengeç" || burc2 == "balık" || burc2 == "terazi")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "oğlak" && burc2 == "balık" || burc2 == "yengeç" || burc2 == "terazi" || burc2 == "başak")
            {
                label2.Text = "Uyumlular.";
            }
            else if (burc1 == "boğa" && burc2 == "aslan" || burc2 == "ikizler" || burc2 == "terazi" || burc2 == "kova")
            {
                label2.Text = "Uyumlular.";
            }
            else
            {
                label2.Text = "Uyumsuzlar";
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
