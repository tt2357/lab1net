using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1net
{
    public partial class Form1 : Form
    {
        //System.Diagnostics.Stopwatch Stopwatch = new System.Diagnostics.Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void refresh(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
}
