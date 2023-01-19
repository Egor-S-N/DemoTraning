using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для AnalizatorPage.xaml
    /// </summary>
    public partial class AnalizatorPage : Window
    {

        Demo db = new Demo();
        public AnalizatorPage()
        {
            db.AnalyzerOperationOrder.Load();
            InitializeComponent();
            TableAnalizators.ItemsSource = db.PatientData.Local.ToList();
            TableAnalizators.Items.Refresh();
        }
    }
}
