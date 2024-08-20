using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {

        double sayı1, sayı2, sonuc;
        char işlem = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TUŞLAR(object sender, EventArgs e)
        {
            if (textBox1.Text =="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void bTOPLA_Click(object sender, EventArgs e)
        {
            sayı1 = double.Parse(textBox1.Text);
            işlem = '+';
            textBox1.Text = "0";


        }

        private void bCIKAR_Click(object sender, EventArgs e)
        {
            sayı1 = double.Parse(textBox1.Text);
            işlem = '-';
            textBox1.Text = "0";
        }

        private void bBÖL_Click(object sender, EventArgs e)
        {
            sayı1 = double.Parse(textBox1.Text);
            işlem = '/';
            textBox1.Text = "0";
        }

        private void bCARP_Click(object sender, EventArgs e)
        {
            sayı1 = double.Parse(textBox1.Text);
            işlem = '*';
            textBox1.Text = "0";
        }

        private void bESİTTİR_Click(object sender, EventArgs e)
        {
            sayı2 = double.Parse(textBox1.Text);
            if (işlem == '+')
            {
                sonuc = sayı1 + sayı2;
                textBox1.Text = sonuc.ToString();
            }
            if (işlem == '-')
            {
                sonuc = sayı1 - sayı2;
                textBox1.Text = sonuc.ToString();
            }
            if (işlem == '*')
            {
                sonuc = sayı1 * sayı2;
                textBox1.Text = sonuc.ToString();
            }
            if (işlem == '/')
            {
                sonuc = sayı1 / sayı2;
                textBox1.Text = sonuc.ToString();
            }
        }

        private void bVİRGÜL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") < 1) { 
            textBox1.Text = textBox1.Text + ",";
        }}

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="0") {
                if (textBox1.Text.StartsWith("-"))
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                }else if (textBox1.Text.StartsWith("")){
                    textBox1.Text = "-" + textBox1.Text;
                }
                {

                }
            }
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bDELETE_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);
            if (textBox1.Text =="")
            {
                textBox1.Text = 0.ToString();
            }
        }
    }
}
