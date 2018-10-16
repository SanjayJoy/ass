using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp3
{
    public partial class Form2 : Form
    {
        public static int num1;
        public static int num2;
        public static int res;
        public int ch;

        public Form2()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            lb_res.Text = "0";
        }



        private void one_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "1";
            }
            else
            {
                resultBox.Text = resultBox.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "2";
            }
            else
            {
                resultBox.Text = resultBox.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "3";
            }
            else
            {
                resultBox.Text = resultBox.Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "4";
            }
            else
            {
                resultBox.Text = resultBox.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "5";
            }
            else
            {
                resultBox.Text = resultBox.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "6";
            }
            else
            {
                resultBox.Text = resultBox.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "7";
            }
            else
            {
                resultBox.Text = resultBox.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "8";
            }
            else
            {
                resultBox.Text = resultBox.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "9";
            }
            else
            {
                resultBox.Text = resultBox.Text + "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "0";
            }
            else
            {
                resultBox.Text = resultBox.Text + "0";
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(resultBox.Text);
            lb_res.Text = num1 + "+";
            resultBox.Clear();
            ch = 1;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(resultBox.Text);
            lb_res.Text = num1 + "-";
            resultBox.Clear();
            ch = 2;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(resultBox.Text);
            lb_res.Text = num1 + "*";
            resultBox.Clear();
            ch = 3;
        }

        private void result_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(resultBox.Text);
            switch(ch)
            {
                case 1:
                    {
                        res = num1 + num2;
                        lb_res.Text = num1 + "+" + num2;
                        resultBox.Text =Convert.ToString(res);
                        num1 = res;
                        break;
                    }
                case 2:
                    {
                        res = num1 - num2;
                        lb_res.Text = num1 + "-" + num2;
                        resultBox.Text = Convert.ToString(res);
                        num1 = res;
                        break;
                    }
                case 3:
                    {
                        res = num1 * num2;
                        lb_res.Text = num1 + "*" + num2;
                        resultBox.Text = Convert.ToString(res);
                        num1 = res;
                        break;
                    }
            }
        }
    }
}
