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

            /*string a = "";

            foreach (Team p in t.Total_team)
            {
                a +=p.Name + " " + p.Coefficient + "\n";
            }

            test.Content = a;

             string a = "";

             foreach(Pool p in t.Array)
             {
                 a += p.ToString() + "\n";
             }

             test.Content = a;


             t.getHead();
             a = "";

             foreach (Team p in t.DirectE.Head)
             {
                 a += p.ToString() + "\n";
             }
             foreach (Team p in t.DirectE.NoHead)
             {
                 a += p.ToString() + "\n";
             }

             test.Content = a;
             a = " ";

             t.DirectE.draw();

             t.DirectE.DirectElim.tourSelction();

             a+= t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.match.Team1 + "\n";

             t.DirectE.DirectElim.tourSelction();

             a += t.DirectE.DirectElim.Root.rightLeaf.match.Team1 + "\n";

             t.DirectE.DirectElim.tourSelction();

             a+= t.DirectE.DirectElim.Root.match.Team1 + "\n";

             t.DirectE.DirectElim.tourSelction();

             a+= t.DirectE.DirectElim.Root.match.Winner;
             test.Content = a;*/
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
