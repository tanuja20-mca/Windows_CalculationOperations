using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation_1;

namespace Windows_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            calculation cal = new calculation();
            textBox3.Text = Convert.ToString(cal.addition(a, b));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            calculation cal = new calculation();
            textBox3.Text = Convert.ToString(cal.subtraction(a, b));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            calculation cal = new calculation();
            textBox3.Text = Convert.ToString(cal.multiplication(a, b));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            calculation cal = new calculation();
            textBox3.Text = Convert.ToString(cal.division(a, b));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
