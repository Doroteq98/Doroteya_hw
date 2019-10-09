using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework.upr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Celta na prilojenieto e da se vyvede chislo-chetno ili nechetno i chrez klikvane na" +
                "butona da se proveri kakvo chislo e vyvedeno!","VAJNO!!");
            this.BackColor = Color.Lavender;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                double d = double.Parse(textBox1.Text);
                if (d % 2 == 0)
                { MessageBox.Show("Chisloto,koeto ste vyveli e chetno");
                    textBox1.Clear();
                }
                else
                { MessageBox.Show("Chisloto,koeto ste vyveli e nechetno");
                    textBox1.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Vyvedete korektni danni predi da natisnete butona");
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("Jelaete li da zatvorite prilojenieto","Izhod?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }
    }
}
