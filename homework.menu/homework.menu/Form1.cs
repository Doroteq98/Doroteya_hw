using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework.menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        double staro, novo, formula,br;
        void Res()
        {
            
            staro = double.Parse(textBox2.Text);
            novo = double.Parse(textBox3.Text);
            formula = staro - novo;
            label5.Text = formula.ToString();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Nekorektni danni");
            }

        }

        private void forProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Programata e dosta elementarna i typichka!Syjalqvam za koeto?", "Doroteya's program", MessageBoxButtons.OK, MessageBoxIcon.Question);
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        void newClient()
        {
            
            br ++;
            label9.Text = br.ToString();
            textBox2.Clear();
            textBox3.Clear();
            label5.Update();
            label8.Update();
            radioButton1.Checked=false;
            radioButton2.Checked = false;
            radioButton3.Checked=false;
            label9.Update();


        }
        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newClient();
        }

        void Radiobutton()
        {
            
            if (radioButton1.Checked)
            {
                label8.Text = (formula * 0.34).ToString();

            }
            if (radioButton2.Checked)
            {
                label8.Text = (formula * 0.44).ToString();
            }
            if (radioButton3.Checked)
            {
                label8.Text = (formula * 0.55).ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Res();
            }
            catch { };
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Res();
            }
            catch { };
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Radiobutton();
            }
            catch { };
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Radiobutton();
            }
            catch { };
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Radiobutton();
            }
            catch { };
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
