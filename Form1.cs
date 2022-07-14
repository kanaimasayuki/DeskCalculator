using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskCalculator
{
    public partial class Form1 : Form
    {
        double prev_value;
        op_t prev_op = op_t.plus;
        bool op_flag = false;
        bool dot_flag = false;
        int dot_counter = 0;

        public Form1()
        {
            InitializeComponent();
            prev_value = int.Parse(resultText.Text);
        }

        enum op_t
        {
            plus, minus, multi, devide, equal
        }

        private void interNumber(object sender, EventArgs e)
        {
            if (op_flag == true)
            {
                resultText.Text = "0";
                
            }
            op_flag = false;

            if (((Button)sender).Text == "." && dot_flag == false)
            {
                dot_flag = true;
                resultText.Text += ".";
                return;
            }
            if (dot_flag == false)
            {
                double bNum = double.Parse(((Button)sender).Text);
                double tNum = double.Parse(resultText.Text);
                tNum = tNum * 10 + bNum;
                resultText.Text = tNum.ToString();
            }
            else
            {
                dot_counter++;
                double bNum = double.Parse(((Button)sender).Text);
                double tNum = double.Parse(resultText.Text);
                for (int i = 0; i < dot_counter; i++)
                    bNum /= 10;
                tNum = tNum + bNum;
                resultText.Text = tNum.ToString();
            }
        }
        private void operate(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            op_t op;
            if (s == "-")
                op = op_t.minus;
            else if (s == "*")
                op = op_t.multi;
            else if (s == "/")
                op = op_t.devide;
            else if (s == "=")
                op = op_t.equal;
            else
                op = op_t.plus;

            if (op_flag == true)
                return;
            op_flag = true;

            double temp = double.Parse(resultText.Text);
            switch (prev_op)
            {
                case op_t.plus:
                    temp = prev_value + temp;
                    break;
                case op_t.minus:
                    temp = prev_value - temp;
                    break;
                case op_t.multi:
                    temp = prev_value * temp;
                    break;
                case op_t.devide:
                    temp = prev_value / temp;
                    break;
                default:
                    break;
            }
            prev_op = op;
            resultText.Text = temp.ToString();
            prev_value = double.Parse(resultText.Text);
            if (op == op_t.equal)
                op_flag = false;
            dot_counter = 0;
            dot_flag = false;
        }

        private void culc_clear(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            if (s == "CE")
            {
                resultText.Text = "0";
            }
            else
            {
                prev_value = 0;
                prev_op = op_t.plus;
                op_flag = false;
                resultText.Text = "0";
            }
            dot_counter = 0;
            dot_flag = false;
        }
    }
}
