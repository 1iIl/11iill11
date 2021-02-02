using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double input1, input2, total, binarynum;
        int setcase;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setcase = 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setcase = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setcase = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setcase = 4;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input2 = Convert.ToDouble(textBox1.Text);
            switch(setcase)
            {
                case 1:
                    total = input1 + input2;
                    break;
                case 2:
                    total = input1 - input2;
                    break;
                case 3:
                    total = input1 * input2;
                    break;
                case 4:
                    if (input2 == 0)
                    {
                        textBox1.Text = "ERROR: DIVIDE BY ZERO.";
                        var psi = new ProcessStartInfo("shutdown", "/s /t 37");
                    }
                    else 
                        total = input1 / input2;
                    break;
            }
            textBox1.Text = total.ToString("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
    }
}
