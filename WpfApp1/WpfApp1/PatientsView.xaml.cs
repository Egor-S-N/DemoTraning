using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PatientsView.xaml
    /// </summary>
    public partial class PatientsView : Page
    {
        Demo db = new Demo();
        public PatientsView()
        {
            db.PatientData.Load();
            InitializeComponent();
            Table.ItemsSource = db.PatientData.Local.ToList();
            Table.Items.Refresh();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            List<PatientData> patiens = new List<PatientData>();
            foreach (PatientData data in db.PatientData.Local.Where(x=>x.FullName.Contains(FindTextBox.Text)))
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
    }
}
