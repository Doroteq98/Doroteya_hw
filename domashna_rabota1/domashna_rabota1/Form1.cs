using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domashna_rabota1
{
    public partial class Form1 : Form
    {
        Calculator Calc = new Calculator();
        double val1, val2, sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Double.Parse(textBox1.Text); // promenqme tipa na teksta v poletata tyi kato teksta e string a na nas ni trqbva double
                val2 = Double.Parse(textBox2.Text);
                textBox3.Text = Calcs(val1, val2,sender).ToString();
                


            }
            catch
            {
                MessageBox.Show("Vyvedete korektni danni predi da natisnete butona");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Double.Parse(textBox1.Text); // promenqme tipa na teksta v poletata tyi kato teksta e string a na nas ni trqbva double
                val2 = Double.Parse(textBox2.Text);
                // textBox3.Text = Calc.AddNumber(val1, val2).ToString();
                if (comboBox1.Text == "+")
                {
                    textBox3.Text = Calcs(val1, val2,sender).ToString();
                }
                else
                {
                    textBox3.Text = Calcs(val1, val2,sender).ToString();
                }




            }
            catch
            {
                MessageBox.Show("Vyvedete korektni danni predi da natisnete butona");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Double.Parse(textBox1.Text); // promenqme tipa na teksta v poletata tyi kato teksta e string a na nas ni trqbva double
                val2 = Double.Parse(textBox2.Text);

                textBox3.Text = Calcs(val1, val2,sender).ToString();


            }
            catch
            {
                MessageBox.Show("Vyvedete korektni danni predi da natisnete butona");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Double.Parse(textBox1.Text); // promenqme tipa na teksta v poletata tyi kato teksta e string a na nas ni trqbva double
                val2 = Double.Parse(textBox2.Text);
                textBox3.Text = Calcs(val1, val2,sender).ToString();
                if (val2 == 0)
                    MessageBox.Show("Ne se deli na nula");


            }
            catch
            {
                MessageBox.Show("Vyvedete korektni danni predi da natisnete butona");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }

        }
        double AddNumber(double val1, double val2)
        {
            sum = val1 + val2;
            return sum;
        }
        double SubNumber(double val1, double val2)
        {
            sum = val1 - val2;
            return sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        double PNumber(double val1, double val2)
        {
            sum = val1 * val2;
            return sum;
        }
        double DNumber(double val1, double val2)
        {
            sum = val1 / val2;
            return sum;
        }

        double Calcs(double v1, double v2, object sender) {
            string s = (sender as Button).Text;
            switch (s)
            {
                case "+":
                    return Calc.AddNumber(v1, v2);
                case "-":
                    return Calc.SubNumber(v1, v2);
                case "*":
                    return Calc.PNumber(v1, v2);
                case "/":
                    return Calc.DNumber(v1, v2);
                default:
                    return 0;
            }
        }



    }
}

