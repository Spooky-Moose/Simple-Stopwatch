using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Timers;
using System.Diagnostics;

namespace SWProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SWProjectPage : ContentPage
    {
        Stopwatch stopwatch;

        public SWProjectPage()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void startBtn_Clicked(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Reset();
            }
            else
            {
                stopwatch.Start();

                Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
                {
                    TimeSpan ts = stopwatch.Elapsed;

                    swLabel.Text = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";

                    return true;
                }
                );
            }
            

            
        }

        private void stopBtn_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void resetBtn_Clicked(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }
    }
}