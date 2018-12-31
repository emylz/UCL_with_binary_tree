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

namespace ProjetADSA
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void manualButton_Click(object sender, RoutedEventArgs e)
        {
            main.NavigationService.Navigate(new manualPage());
        }

        private void randomButton_Click(object sender, RoutedEventArgs e)
        {
            main.NavigationService.Navigate(new randomPage());
        }
    }
}
