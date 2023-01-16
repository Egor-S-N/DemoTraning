using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WpfApp1;

namespace WpfApp1.Models
{
    class Global
    {
        public static int UserID;
        public static string UserType;
        public static DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public static int time = 20;
        public static Window CurentPage;

        public static void StartTimer()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public static void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
            }
            else
            {
                dispatcherTimer.Stop();
                MessageBox.Show("Test");
                CurentPage.Close();
                MainWindow a = new MainWindow();
                a.Show();
            }
        }
    }
}
