using System;m
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_assignment
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        string n;
        double res;
        bool div,mul,add,sub,mod,p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            n += "0";
            textBox1.Text = n;
            ena();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            n += "1";
            textBox1.Text = n;
            ena();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            n += "2";
            textBox1.Text = n;
            ena();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            n += "3";
            textBox1.Text = n;
            ena();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n += "4";
            textBox1.Text = n;
            ena();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            n += "5";
            textBox1.Text = n;
            ena();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            n += "6";
            textBox1.Text = n;
            ena();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n += "7";
            textBox1.Text = n;
            ena();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            n += "8";
            textBox1.Text = n;
            ena();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n += "9";
            textBox1.Text = n;
            ena();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sub = true;
            dis();
            textBox2.Text = n + " -";
            textBox1.Clear();
            num1 = double.Parse(n);
            n = "";
            button17.Enabled = true;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            add = true;
            dis();
            textBox2.Text = n + " +";
            textBox1.Clear();
            num1 = double.Parse(n);
            n = "";
            button17.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            n = "";

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (n == "")
            {
                n += "0.";
            }
            else
            {
                n += ".";
            }
            button17.Enabled = false;
            textBox1.Text = n;
            ena();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mod = true;
            textBox2.Text = n + " %";
            textBox1.Clear();
            num1 = double.Parse(n);
            n = "";
            button17.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            div = true;
            dis();
            textBox2.Text = n + " /";
            textBox1.Clear();
            num1 = double.Parse(n);
            n = "";
            button17.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mul = true;
            dis();
            textBox2.Text = n+" x";
            textBox1.Clear();
            num1 = double.Parse(n);
            n = "";
            button17.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ena();
            if (div) {
                num2 = double.Parse(n);
                res = num1 / num2;
                div = false;
            }

            if (mod)
            {
                num2 = double.Parse(n);
                res = num1 % num2;
                div = false;
            }
            if (add)
            {
                num2 = double.Parse(n);
                res = num1 + num2;
                add = false;
            }
            if (sub)
            {
                num2 = double.Parse(n);
                res = num1 - num2;
                sub = false;
            }
            if (mul)
            {
                num2 = double.Parse(n);
                res = num1 * num2;
                mul = false;
            }
            n = res.ToString();
            textBox2.Clear();
            textBox1.Text = res.ToString();
        }

        public void  dis()
        {
            button2.Enabled = false;
            button12.Enabled = false;
            button16.Enabled = false;
            button19.Enabled = false;
            button11.Enabled = false;
        }

        public void ena()
        {
            button2.Enabled = true;
            button12.Enabled = true;
            button16.Enabled = true;
            button19.Enabled = true;
            button11.Enabled = true;
        }

    }
}
