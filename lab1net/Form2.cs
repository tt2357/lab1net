using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1net
{
    public partial class Form2 : Form
    {
        int tss, ts, tm;
        bool isOn;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            reset();
            bool IsOn = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isOn = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isOn = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isOn = false;
            reset();
        }

        private void reset()
        {
            tss = 0;
            ts = 0;
            tm = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isOn)
            {
                tss++;

                if(tss>=100)
                {
                    ts++;
                    tss = 0;
                    if(ts>=60)
                    {
                        tm++;
                        ts = 0;
                    }
                }
            }
            updatetime();
        }

        private void updatetime()
        {
            labelmin.Text = String.Format("{0:00}", tm);
            labelsec.Text = String.Format("{0:00}", ts);
            labelssec.Text = String.Format("{0:00}", tss);

            //string minuty = tm.ToString();
            //string sekundy = ts.ToString();
            //string ssekundy = tss.ToString();

            //labelmin.Text = minuty;
            //labelsec.Text = sekundy;
            //labelssec.Text = ssekundy;
        }

        //private void Button2_click(object sender, EventArgs e)
        //{
        //    timer1.Start();
        //    this.Stopwatch.Start();
        //}
    }
}
