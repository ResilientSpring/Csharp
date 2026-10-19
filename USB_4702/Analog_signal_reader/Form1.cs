using System;
using System.Drawing;
using System.Windows.Forms;
using Automation.BDaq;

namespace Analog_signal_reader
{
    public partial class Form1 : Form
    {

        private InstantAiCtrl ai;
        private const double ThresholdVoltage = 2.5;


        public Form1()
        {
            InitializeComponent();

            // Use your initialized USB-4702 controller here.
            // This assignment assuems your project already initializes App.instantAiCtrl.
      

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
