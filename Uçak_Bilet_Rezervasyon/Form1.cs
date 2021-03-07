using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bilet_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("SEFER BİLGİSİ" +" = "+ comboBox1.Text + " - " + comboBox2.Text + " / " + dateTimePicker1.Text + " / " + maskedTextBox1.Text+"  " + " ~~ "+" "+"YOLCU BİLGİSİ"+" = "+textBox1.Text+" / " +maskedTextBox2.Text+" / "+ maskedTextBox3.Text);
            MessageBox.Show("YOLCU KAYDI YAPILDI");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
