using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        void Calcx1()
        {
            
            try
            {
               double A = Double.Parse(a.Text);
               double B = Double.Parse(b.Text);
               double C = Double.Parse(c.Text);

               double D = B * B - 4 * A* C;
                if (D < 0)
                {  MessageBox.Show("Root are imeainary ");  }
                else if (D == 0)
                {
                    textBox4.Text = (-B /(2 * A)).ToString();
                    textBox5.Text = (-B / (2 * A)).ToString();

                }
                else if (D > 0)
                {
                    textBox4.Text = ((-B + Math.Sqrt(D)) / (2*A)).ToString();
                    textBox5.Text= ((-B - Math.Sqrt(D)) / (2 * A)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ne ste vyveli korektni danni!");
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calcx1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (a.Text != "" && b.Text != "" && c.Text != "")
                Calcx1();
        }
    }
}
