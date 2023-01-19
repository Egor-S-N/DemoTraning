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
    /// Логика взаимодействия для Patients.xaml
    /// </summary>
    public partial class Patients : Window
    {
        Demo db = new Demo();
        public Patients()
        {
            Global.CurentPage = this;
            InitializeComponent();
            Global.StartTimer();
            Global.TimeLabel = TimeLabel;
            ResetTable();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            List<PatientData> patiens = new List<PatientData>();
            foreach (PatientData data in db.PatientData.Local.Where(x => x.FullName.Contains(FindTextBox.Text)))
            {
                patiens.Add(data);
            }
            if (patiens.Count() > 0)
            {
                Table.ItemsSource = patiens.ToList();
                Table.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Совпадений не найдено");
            }
        }

        private void ResetTable()
        {
            db.PatientData.Load();
            Table.ItemsSource = db.PatientData.Local.ToList();
            Table.Items.Refresh();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetTable();
        }
    }
}
