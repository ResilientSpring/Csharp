namespace Analog_signal_reader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblVoltage = new Label();
            lblState = new Label();
            timerRead = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblVoltage
            // 
            lblVoltage.AutoSize = true;
            lblVoltage.Location = new Point(65, 66);
            lblVoltage.Name = "lblVoltage";
            lblVoltage.Size = new Size(154, 35);
            lblVoltage.TabIndex = 0;
            lblVoltage.Text = "Voltage: -- V";
            lblVoltage.Click += label1_Click;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(65, 152);
            lblState.Name = "lblState";
            lblState.Size = new Size(114, 35);
            lblState.TabIndex = 1;
            lblState.Text = "Waiting...";
            // 
            // timerRead
            // 
            timerRead.Tick += timerRead_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblState);
            Controls.Add(lblVoltage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVoltage;
        private Label lblState;
        private System.Windows.Forms.Timer timerRead;
    }
}
