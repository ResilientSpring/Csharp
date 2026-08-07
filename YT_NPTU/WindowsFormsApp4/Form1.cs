using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = 0;
            age = int.Parse(textBox1.Text);  // [1]

            label2.Text = age.ToString();
        }
    }
}

// References:
// 1. https://chatgpt.com/c/6a75c7de-a524-83ee-9fb2-773b4ebfb678

