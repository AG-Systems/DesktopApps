using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = 0;
            int counter = 0;
            double distance = 0.0;
            double introvelo = 0.0;
            double velo = 0.0;
            double accel = 0.0;
            double infinity = 0.0;
            //distance = Convert.ToDouble(textBox1.Text);
            //distance = double.Parse(textBox1.Text);
            if (double.TryParse(textBox1.Text, out distance))
            {
                distance = Convert.ToDouble(textBox1.Text);
                distance = double.Parse(textBox1.Text);
                counter++;    
            }
            if (double.TryParse(textBox2.Text, out introvelo))
            {
                introvelo = Convert.ToDouble(textBox2.Text);
                introvelo = double.Parse(textBox2.Text);
                counter++;
            }
            if (double.TryParse(textBox3.Text, out velo))
            {
                velo = Convert.ToDouble(textBox3.Text);
                velo = double.Parse(textBox3.Text);
                counter++;
            }
            if (double.TryParse(textBox4.Text, out accel))
            {
                accel = Convert.ToDouble(textBox4.Text);
                accel = double.Parse(textBox4.Text);
                counter++;
            }
            if (double.TryParse(textBox5.Text, out infinity))
            {
                infinity = Convert.ToDouble(textBox5.Text);
                infinity = double.Parse(textBox5.Text);
                counter++;
            }
            /*

        velo = Convert.ToDouble(textBox3.Text);
        velo = double.Parse(textBox3.Text);


        accel = Convert.ToDouble(textBox4.Text);
        accel = double.Parse(textBox4.Text);
        //infinity

        infinity = Convert.ToDouble(textBox5.Text);
        infinity = double.Parse(textBox5.Text);
        */
                velo = introvelo + (accel * infinity);
                System.Windows.Forms.MessageBox.Show(velo.ToString());
        
            /*
            if (string.IsNullOrWhiteSpace(this.textBox4.Text) && string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                accel = (velo - introvelo) % infinity;
                System.Windows.Forms.MessageBox.Show(accel.ToString());
            }
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                // x = x0 + v0*t + 1/2*a*t*t
                distance = introvelo + (introvelo * infinity) + (.5 * accel * infinity * infinity);
                System.Windows.Forms.MessageBox.Show(distance.ToString());
            }
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) && string.IsNullOrWhiteSpace(this.textBox5.Text))
            {
                infinity = (velo - introvelo) % accel;
                System.Windows.Forms.MessageBox.Show(infinity.ToString());
            }
            */


            //MessageBox.Show(velo);

            //MessageBox.Show("Hello world!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! Thank you for using our program and our site.");
        }

        private void velocityv1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 1;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: V0.2-Alpha");
        }
    }
}