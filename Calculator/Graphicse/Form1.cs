using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphicse
{
    public partial class Form1 : Form
    {
        Calculator mycal=new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = mycal.Add(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text));
            rslt.Text=a.ToString();
         }

        private void button2_Click(object sender, EventArgs e)
        {

    
        }
    }
}
