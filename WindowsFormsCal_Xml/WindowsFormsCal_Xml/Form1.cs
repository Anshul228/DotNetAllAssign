using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassCalculate;

namespace WindowsFormsCal_Xml
{
    public partial class Form1 : Form
    {
        Class1 c = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            c.x = Convert.ToInt32(txt1.Text);
            c.y = Convert.ToInt32(txt2.Text);
            label3.Text = c.Add().ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            c.x = Convert.ToInt32(txt1.Text);
            c.y = Convert.ToInt32(txt2.Text);
            label4.Text = c.Sub().ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            c.x = Convert.ToInt32(txt1.Text);
            c.y = Convert.ToInt32(txt2.Text);
            label5.Text = c.Div().ToString();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            c.x = Convert.ToInt32(txt1.Text);
            c.y = Convert.ToInt32(txt2.Text);
            label6.Text = c.Mult().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
