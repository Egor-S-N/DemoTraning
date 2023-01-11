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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (PasswordHidden.Password == "Admin" && LoginTextBox.Text == "Admin")
            //{
            //    BarcodePage barcodePage = new BarcodePage();
            //    barcodePage.Show();
            //    MessageBox.Show("Test");
            //}
            
            var answer = MyCaptcha.CaptchaText;
            Captcha a = new Captcha();
            a.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);
            MessageBox.Show(a.CaptchaText);
        }
       
    }
}

