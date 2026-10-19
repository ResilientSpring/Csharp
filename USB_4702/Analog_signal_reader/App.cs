using Automation.BDaq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analog_signal_reader
{
    internal class App
    {

        public static InstantAiCtrl instantAiCtrl = new InstantAiCtrl();
        public static string USBDeviceName = "";
        public static bool bGotUSBDevice = false;

        public static StringBuilder sbLog = new StringBuilder();

    }

}
