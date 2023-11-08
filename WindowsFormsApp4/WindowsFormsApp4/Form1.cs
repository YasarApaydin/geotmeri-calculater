using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kare alanı hesaplama
            float kareKenarUzunluk =(float) Convert.ToDouble(textBoxKenar.Text);
            float alan = kareKenarUzunluk * kareKenarUzunluk;
            labelKare.Text = alan.ToString();

            // dikdörtgen alanı hesaplama
            float kısaKenar = (float)Convert.ToDouble(textBoxKisaKenar.Text);
            float uzunKenar = (float)Convert.ToDouble(textBoxUzunKenar.Text);
            float alan1 = uzunKenar * kısaKenar;
            labelDikdortgen.Text = alan1.ToString();

            // Cember hesaplama
            float pi;
            pi =(float) 3.14;
            float yaricap = (float)Convert.ToDouble(textBoxYaricap.Text);
            float alan2 = pi * yaricap * yaricap;
            labelCember.Text = alan2.ToString();

        }

    
    }
}
