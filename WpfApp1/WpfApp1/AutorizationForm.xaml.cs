using EasyCaptcha.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using WpfApp1.Models;

namespace WpfApp1
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Demo db = new Demo();
        private bool FirstTryToEnter = true;
        DispatcherTimer waitingTimer = new DispatcherTimer();




        public MainWindow()
        {
            InitializeComponent();
            Global.StartPage = this;

        }
        private void CB_Checked(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Visible;
            PasswordHidden.Visibility = Visibility.Hidden;
            PasswordUnmask.Text = PasswordHidden.Password;
        }
        private void CB_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Hidden;
            PasswordHidden.Visibility = Visibility.Visible;
            PasswordHidden.Password = PasswordUnmask.Text;
        }
        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            if (FirstTryToEnter)
            {

                var admin = from admins in db.Administrator where admins.Login == LoginTextBox.Text && admins.Password == PasswordHidden.Password select admins;
                if (admin.Count() < 1)
                {

                    var accountant = from accountants in db.Accountant where accountants.Login == LoginTextBox.Text && accountants.Password == PasswordHidden.Password select accountants;
                    if (accountant.Count() < 1)
                    {
                        FirstTryToEnter = false;
                        MessageBox.Show("Дурачок, неверный ты ");
                        EnterButton.Margin = new Thickness(358, 353, 0, 0);
                        MyCaptcha.Visibility = Visibility.Visible;
                        CaptchaTextBox.Visibility = Visibility.Visible;
                        ButtonAnotherCaptcha.Visibility = Visibility.Visible;
                        MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
                    }
                    else
                    {
                        Global.UserID = accountant.First().IdAccountant;
                        Global.UserType = "Accountant";
                        BarcodePage barcodePage = new BarcodePage();
                        this.Hide();
                        barcodePage.Show();
                    }
                }
                else
                {
                    Global.UserID = admin.First().IdAdministrator;
                    Global.UserType = "Admin";
                    BarcodePage barcodePage = new BarcodePage();
                    this.Hide();
                    barcodePage.Show();
                }
            }
            else
            {
                var admin = from admins in db.Administrator where admins.Login == LoginTextBox.Text && admins.Password == PasswordHidden.Password select admins;
                var accountant = from accountants in db.Accountant where accountants.Login == LoginTextBox.Text && accountants.Password == PasswordHidden.Password select accountants;

                if (admin.Count() > 0 && MyCaptcha.CaptchaText == CaptchaTextBox.Text)
                {
                    Global.UserID = admin.First().IdAdministrator;
                    Global.UserType = "Admin";
                    BarcodePage barcodePage = new BarcodePage();
                    this.Hide();
                    barcodePage.Show();
                }
                else if (accountant.Count() > 0 && MyCaptcha.CaptchaText == CaptchaTextBox.Text)
                {
                    Global.UserID = accountant.First().IdAccountant;
                    Global.UserType = "Accountant";
                    BarcodePage barcodePage = new BarcodePage();
                    this.Hide();
                    barcodePage.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль, повторите попытку через 10 секунд");

                    waitingTimer.Tick += new EventHandler(waitingTimer_Tick);
                    waitingTimer.Interval = new TimeSpan(0, 0, 10);
                    EnterButton.IsEnabled = false;
                    waitingTimer.Start();
                    MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
                }

            }

        }
        private void ButtonAnotherCaptcha_Click(object sender, RoutedEventArgs e)
        {
            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
        }


        private void waitingTimer_Tick(object sender, EventArgs e)
        {
            EnterButton.IsEnabled = true;
            waitingTimer.Tick -= waitingTimer_Tick;
            waitingTimer.Stop();
        }
    }
}
