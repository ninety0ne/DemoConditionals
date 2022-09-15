using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ConditionalStatements
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Methods(int count)
        {
            if(count > 5)
            {
                MessageBox.Show("Value van de parameter is groter dan 5 ... Value: " + count);
            }

            else
            {
                MessageBox.Show("Value van de parameter is kleiner dan 5 ... Value: " + count);
            }
        }

        private void btnCounter_Click(object sender, RoutedEventArgs e)
        {
            int counter = int.Parse((string)btnCounter.Content);
            counter++;
            btnCounter.Content = counter.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int count = int.Parse((string)btnCounter.Content);

            Methods(count);
        }

        private void btnFor_click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("Value: " + i);
            }
        }

        private void btnWhile_click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            while (i < 5)
            {
                MessageBox.Show("Value: " + i);
                i++;
            }
        }
    }
}
