using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, answer;
        int count;

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && textBox1.TextLength > 0)
            {
                num1 = 0;
                textBox1.Clear();
            }
            else if (num1 > 0 && textBox1.TextLength > 0)
            {
                textBox1.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;

            string text = textBox1.Text;

            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }

            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 6;
        }

        private void btnDiv1_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 7;
        }

        public void compute(int count)
        {

            switch (count)
            {

                case 1:

                    answer = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();

                    break;
                case 2:

                    answer = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();

                    break;
                case 3:

                    answer = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();

                    break;
                case 4:
                    answer = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();

                    break;
                case 5:
                    answer = (float)Math.Sqrt(num1);
                    textBox1.Text = answer.ToString();
                    break;
                case 6:
                    answer = num1 * num1;
                    textBox1.Text = answer.ToString();
                    break;
                case 7:
                    answer = 1 / num1;
                    textBox1.Text = answer.ToString();
                    break;
                default:
                    break;
            }





        }


        

        
    }
}
