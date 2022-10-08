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
        Calcul Method =new Calcul();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=Method.Add(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text));
            Rslt.Text = a.ToString();
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            int b = Method.Subtract(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text));
            Rslt.Text = b.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int c = Method.Mul(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text));
            Rslt.Text = c.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int d = Method.Division(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text));
            Rslt.Text = d.ToString();
        }
    }
}
