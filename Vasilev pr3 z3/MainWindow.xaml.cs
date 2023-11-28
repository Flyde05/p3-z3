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

namespace Vasilev_pr3_z3
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(V1.Text, out double v1))
            {
                MessageBox.Show("Поле V1 только число");
            }
            if (!double.TryParse(V2.Text, out double v2))
            {
                MessageBox.Show("Поле V2 только число");
            }
            if (!double.TryParse(S.Text, out double s))
            {
                MessageBox.Show("Поле S только число");
            }
            if (!double.TryParse(T.Text, out double t))
            {
                MessageBox.Show("Поле T только число");
            }
            double S2 = Math.Abs(s - t * (v1 + v2));
            MessageBox.Show($"S2={S2,1:f0}");
        }
    }
}
    