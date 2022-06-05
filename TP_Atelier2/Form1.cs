using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_Atelier2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string opr;
        double A, B, result;
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text +="0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);
            opr = "+";
            textBox1.Clear();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);
            opr = "-";
            textBox1.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);
            opr = "*";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);
            opr = "/";
            textBox1.Clear();

        }

        private void egal_Click(object sender, EventArgs e)
        {
            B = Convert.ToDouble(textBox1.Text);
            switch (opr)
            {
                case "+":
                    result = A + B;
                    textBox1.Text = Convert.ToString(result);
                    break;

                case "-":
                    result = A - B;
                    textBox1.Text = Convert.ToString(result);
                    break;

                case "*":
                    result = A * B;
                    textBox1.Text = Convert.ToString(result);
                    break;

                case "/":
                    if (B == 0)
                    {
                        textBox1.Text = "Error Sytanque";
                        break;
                    }
                    else
                    {
                        result = A / B;
                        textBox1.Text = Convert.ToString(result);
                        break;
                    }
            }
        }

    }

}
