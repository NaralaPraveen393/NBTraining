using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {  //Author:Narala Praveen
        //Purpose: To consume web services in windows app.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            PraveenNaralaserviceSoapClient pc = new PraveenNaralaserviceSoapClient();
            textBox2.Text = pc.Factorial(n).ToString();
        }
    }
}
