using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoGin_Click(object sender, EventArgs e)
        {
            if
                (UserName.Text == "sanjay" && PassWord.Text == "2016cse120")
                MessageBox.Show("Login Success");
            else MessageBox.Show("Invalid username or password");
        }
    }
}
