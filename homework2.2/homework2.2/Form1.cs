using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double startingTemp, resultTemp;
            startingTemp = double.Parse(textBox1.Text);
            if (comboBox1.Text == "feet" && comboBox2.Text == "mile")
            {
                resultTemp = startingTemp * 5280;
                textBox2.Text = resultTemp.ToString();
            }
            if (comboBox1.Text == "yard" && comboBox2.Text == "mile")
            {
                resultTemp = startingTemp * 1760;
                textBox2.Text = resultTemp.ToString();
            }
            if (comboBox1.Text == "inch" && comboBox2.Text == "mile")
            {
                resultTemp = startingTemp * 6330;
                textBox2.Text = resultTemp.ToString();
            }
            if (comboBox1.Text == "feet" && comboBox2.Text == "yard")
            {
                resultTemp = startingTemp * 3;
                textBox2.Text = resultTemp.ToString();
            }
            if (comboBox1.Text == "feet" && comboBox2.Text == "inch")
            {
                resultTemp = startingTemp * 0.8341;
                textBox2.Text = resultTemp.ToString();
            }
        }
    }
}
