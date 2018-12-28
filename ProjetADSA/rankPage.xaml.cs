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
    /// Logique d'interaction pour rankPage.xaml
    /// </summary>
    public partial class rankPage : Page
    {
        public rankPage()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            okButton.Visibility = Visibility.Visible;
            goButton.Visibility = Visibility.Hidden;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
