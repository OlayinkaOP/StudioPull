using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialsMenu_App
{
    public partial class Form1 : Form
    {
        private double total;

        public Form1()
        {
            InitializeComponent();

            total = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total = Convert.ToInt32(textBox1.Text) * 15;

            if (total > 100)
            {
            //    total = total * 0.1;
            //}
            //else
            //{
            //    total = total * 0.3;
            }

            textBox2.Text = total.ToString("C");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 3);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
