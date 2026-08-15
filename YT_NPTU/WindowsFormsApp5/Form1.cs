using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
                label2.Text = "Correct!";
            else
                label2.Text = "Incorrect!";

            if (radioButton2.Checked == true)
                label4.Text = "Correct!";
            else
                label4.Text = "Incorrect!";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
