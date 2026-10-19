using System;
using System.Drawing;
using System.Drawing.Text;
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

            lblVoltage.Text = "Voltage: -- V";
            lblState.Text = "Initializing...";
            
            timerRead.Interval = 100;
            timerRead.Tick += timerRead_Tick;

            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeUsb4702();
        }

        private void InitializeUsb4702()
        {
            try
            {
                ai = new InstantAiCtrl();

                // Select USB-4702, device number 0.
                ai.SelectedDevice = new DeviceInformation("USB-4702,BID#0");

                lblState.Text = "Ready";
                timerRead.Interval = 100;
                timerRead.Start();
            }
            catch (Exception ex) {

                timerRead.Stop();

                ai?.Dispose();

                ai = null;
                
                MessageBox.Show(
                    "Could not initialize USB-4702:\n"+ex.Message, "Initialization Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);            
            
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            if (ai == null)
                return;

            double voltage;

            ErrorCode error = ai.Read(0, out voltage);

            if(error != ErrorCode.Success)
            {
                timerRead.Stop();
                lblState.Text = "Read error: " + error;
                lblVoltage.Text = "Voltage: unavailable";
                return;
            }

            lblVoltage.Text = $"Voltage: {voltage:F3} V";

            if(voltage >= ThresholdVoltage)
            {
                lblState.Text = "HIGH";
                lblState.ForeColor = Color.Green;
            }
            else
            {
                lblState.Text = "LOW";
                lblState.ForeColor = Color.Red;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerRead.Stop();


            if(ai != null)
            {
                ai.Dispose();
                ai = null;
            }

        }
    }
}
