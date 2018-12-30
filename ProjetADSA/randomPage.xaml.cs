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
    /// Logique d'interaction pour ramdomPage.xaml
    /// </summary>
    public partial class randomPage : Page
    {
        Tournament t;

        public randomPage()
        {
            InitializeComponent();

            t = new Tournament();

            pool1.Content = t.Array[0].ToString();
            pool2.Content = t.Array[1].ToString();
            pool3.Content = t.Array[2].ToString();
            pool4.Content = t.Array[3].ToString();
            pool5.Content = t.Array[4].ToString();
            pool6.Content = t.Array[5].ToString();
            pool7.Content = t.Array[6].ToString();
            pool8.Content = t.Array[7].ToString();
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new rankPage(t));
        }
    }
}
