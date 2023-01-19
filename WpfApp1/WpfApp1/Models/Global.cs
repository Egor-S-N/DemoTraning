using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using WpfApp1;

namespace WpfApp1.Models
{
    class Global
    {
        public static int? UserID;
        public static string UserType;
        public static Label TimeLabel;
        private static DispatcherTimer dispatcherTimer = new DispatcherTimer();
        
        private static int time = 9000; // 2ч:30мин = 150мин = 9000 с     15мин = 900с
        public static Window CurentPage;
        public static Window StartPage;


        public static void StartTimer()
        {
            
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            CurentPage.Closed += Window_Closed;

            
        }

        private static void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (time == 5)
            {
                MessageBox.Show("Скоро спасть");
            }


            if (time > 0)
            {
                time--;
                TimeSpan a = TimeSpan.FromSeconds(time);
                TimeLabel.Content = a.Hours.ToString() + " : " + a.Minutes.ToString() + " : " + a.Seconds.ToString();
            }
            else
            {
                dispatcherTimer.Stop();
                dispatcherTimer.Tick -=dispatcherTimer_Tick;
                MessageBox.Show("Время вышло");
                GoBack();
                Clear();
            }
        }
        private static void Clear()
        {
            UserID = null;
            UserType = null;
            TimeLabel = null;
            time = 9000;
            CurentPage = null;

        }
        private static void Window_Closed(object sender, EventArgs e)
        {
            StartPage.Close();
        }
        public static void GoBack()
        {
            CurentPage.Closed -= Window_Closed;
            CurentPage.Close();
            StartPage.Show();
        }
    }
}
