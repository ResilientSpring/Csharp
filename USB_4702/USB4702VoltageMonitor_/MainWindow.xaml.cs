using Automation.BDaq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace USB4702VoltageMonitor_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InstantAiCtrl ai;
        private DispatcherTimer timer;

        private const double Threshold = 2.5;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {

                double voltage;

                ErrorCode error = ai.Read(0, out voltage);

                if(error != ErrorCode.Success)
                {
                    timer.Stop();
                    StatusText.Text = "READ ERROR";

                }

            } catch(Exception ex)
            {

            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}