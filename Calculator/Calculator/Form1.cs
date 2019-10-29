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
    public partial class Calc : Form
    {
        char mycharacter = 'c';
        string input = string.Empty;
        string oprand1 = string.Empty;
        string oprand2 = string.Empty;
        char op;
        Double result = 0.0;

        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            op = '+';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            op = '/';
            input = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            oprand2 = input;
            double num1, num2;
            double.TryParse(oprand1, out num1);
            double.TryParse(oprand2, out num2);

            if (op == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (op == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (op == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            op = '*';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            op = '-';
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.oprand1 = string.Empty;
            this.oprand2 = string.Empty;
        }
    }
}
