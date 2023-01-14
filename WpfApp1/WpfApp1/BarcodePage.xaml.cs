using BarcodeLib;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
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
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для BarcodePage.xaml
    /// </summary>
    public partial class BarcodePage : Window
    {
        public BarcodePage()
        {
            InitializeComponent();
            UserType.Content = Global.UserType;

            var bitmapImage = new BitmapImage();

            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri($"C:\\Users\\429191-18\\Desktop\\coding\\DemoTraning\\WpfApp1\\WpfApp1\\Sources\\{Global.UserType}.jpeg");
            bitmapImage.EndInit();
            Photo.Source = bitmapImage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Barcode barcode = new Barcode();
            //var img = barcode.Encode(TYPE.MSI_2Mod10, "111111111111",  290, 120);

            //SaveFileDialog SaveFileDialog = new SaveFileDialog();
            //SaveFileDialog.ShowDialog();
            //img.Save(SaveFileDialog.FileName);
            barcode.IncludeLabel = true;
            var img = barcode.Encode(TYPE.CODE128, "111111111111",  290, 120);
            using (var ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Bmp);
                ms.Seek(0, SeekOrigin.Begin);

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();

                BarcodePhoto.Source = bitmapImage;
            }
            //SaveFileDialog SaveFileDialog = new SaveFileDialog();
            //SaveFileDialog.ShowDialog();
            //img.Save(SaveFileDialog.FileName);
        }
    }
}
