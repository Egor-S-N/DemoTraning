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

namespace WpfApp1
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool FirstTryToEnter = true;
        public MainWindow()
        {
            InitializeComponent();
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
        }
        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            if (FirstTryToEnter)
            {
                if (PasswordHidden.Password == "Admin" && LoginTextBox.Text == "Admin")
                {
                    BarcodePage barcodePage = new BarcodePage();
                    this.Close();
                    barcodePage.Show();
                }
                else
                {
                    FirstTryToEnter = false;
                    MessageBox.Show("Дурачок, неверный ты ");
                    EnterButton.Margin = new Thickness(358, 353, 0, 0);
                    MyCaptcha.Visibility = Visibility.Visible;
                    CaptchaTextBox.Visibility = Visibility.Visible;
                    ButtonAnotherCaptcha.Visibility = Visibility.Visible;
                    MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
                }
            }
            else
            {
                if (PasswordHidden.Password == "Admin" && LoginTextBox.Text == "Admin" && MyCaptcha.CaptchaText == CaptchaTextBox.Text)
                {
                    BarcodePage barcodePage = new BarcodePage();
                    this.Close();
                    barcodePage.Show();
                }
                else
                {
                    MessageBox.Show("Дурачок, неверный ты ");
                    EnterButton.Margin = new Thickness(358, 353, 0, 0);
                    MyCaptcha.Visibility = Visibility.Visible;
                    CaptchaTextBox.Visibility = Visibility.Visible;
                    ButtonAnotherCaptcha.Visibility = Visibility.Visible;
                    MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
                }
            }
            
        }
        private void ButtonAnotherCaptcha_Click(object sender, RoutedEventArgs e)
        {
            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
        }
    }
}
