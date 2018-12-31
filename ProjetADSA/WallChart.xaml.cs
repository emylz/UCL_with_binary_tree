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
using System.IO;

namespace ProjetADSA
{
    /// <summary>
    /// Logique d'interaction pour WallChart.xaml
    /// </summary>
    public partial class WallChart : Page
    {
        Tournament t;
        int count = 1;
        string[,] logo = new string[2, 40];

        public void setLogo()
        {
            DirectoryInfo d = new DirectoryInfo(@"pictures");//Assuming Test is your Folder
            FileInfo[] files = d.GetFiles("*.png");
            int j = 0;
            for(int i = 0; j < logo.GetLength(1); i+=2)
            {
                logo[1, j] = Convert.ToString(files[i]);
                j++;
            }

            logo[0, 0] = "Milan AC";
            logo[0, 1] = "Ajax";
            logo[0, 2] = "AS Monaco";
            logo[0, 3] = "AS Roma";
            logo[0, 4] = "Atletico Madrid";
            logo[0, 5] = "Benfica";
            logo[0, 6] = "BSC Young Boys";
            logo[0, 7] = "Celtics Glasgow";
            logo[0, 8] = "Club Brugge";
            logo[0, 9] = "CSKA Moskva";
            logo[0, 10] = "Dinamo Zagreb";
            logo[0, 11] = "Borussia Dortmund";
            logo[0, 12] = "Everton";
            logo[0, 13] = "FC Barcelona";
            logo[0, 14] = "Basel";
            logo[0, 15] = "Bayern FC";
            logo[0, 16] = "Fenerbahce";
            logo[0, 17] = "Galatasaray";
            logo[0, 18] = "Gent";
            logo[0, 19] = "Inter Milan";
            logo[0, 20] = "Juventus";
            logo[0, 21] = "Lazio Rome";
            logo[0, 22] = "Locomotiv Moscow";
            logo[0, 23] = "Manchester City";
            logo[0, 24] = "Manchester United";
            logo[0, 25] = "SC Napoli";
            logo[0, 26] = "Lyon";
            logo[0, 27] = "Olympique Marseille";
            logo[0, 28] = "Porto";
            logo[0, 29] = "Paris Saint Germain";
            logo[0, 30] = "PSV";
            logo[0, 31] = "Real Madrid";
            logo[0, 32] = "Salzbourg";
            logo[0, 33] = "Schalke 04";
            logo[0, 34] = "Sevilla";
            logo[0, 35] = "Shakhtar Donetsk";
            logo[0, 36] = "Spartak Moscow";
            logo[0, 37] = "Sporting CP";
            logo[0, 38] = "Tottenham";
            logo[0, 39] = "Valence CF";
        }

        public String search(string name)
        {
            for (int i = 0; i < this.logo.GetLength(1); i++)
            {
                if (name == this.logo[0,i]) return "pictures/" +this.logo[1,i];
            }
            return null;
        }

        public WallChart(Tournament t)
        {
            InitializeComponent();
            this.t = t;
            setLogo();

            t.getHead();
            t.DirectE.draw();

            t.DirectE.DirectElim.tourSelction();

            l1.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.leftLeaf.match.Team1.Name;
            l2.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.leftLeaf.match.Team2.Name;
            i1.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.leftLeaf.match.Team1.Name)) as ImageSource;
            i2.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.leftLeaf.match.Team2.Name)) as ImageSource;


            l3.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.rightLeaf.match.Team1.Name;
            l4.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.rightLeaf.match.Team2.Name;
            i3.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.rightLeaf.match.Team1.Name)) as ImageSource;
            i4.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.rightLeaf.match.Team2.Name)) as ImageSource;

            l5.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.leftLeaf.match.Team1.Name;
            l6.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.leftLeaf.match.Team2.Name;
            i5.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.leftLeaf.match.Team1.Name)) as ImageSource;
            i6.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.leftLeaf.match.Team2.Name)) as ImageSource;

            l7.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.rightLeaf.match.Team1.Name;
            l8.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.rightLeaf.match.Team2.Name;
            i7.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.rightLeaf.match.Team1.Name)) as ImageSource;
            i8.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.rightLeaf.match.Team2.Name)) as ImageSource;

            l9.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.leftLeaf.match.Team1.Name;
            l10.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.leftLeaf.match.Team2.Name;
            i9.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.leftLeaf.match.Team1.Name)) as ImageSource;
            i10.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.leftLeaf.match.Team2.Name)) as ImageSource;

            l11.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.rightLeaf.match.Team1.Name;
            l12.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.rightLeaf.match.Team2.Name;
            i11.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.rightLeaf.match.Team1.Name)) as ImageSource;
            i12.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.rightLeaf.match.Team2.Name)) as ImageSource;


            l13.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.leftLeaf.match.Team1.Name;
            l14.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.leftLeaf.match.Team2.Name;
            i13.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.leftLeaf.match.Team1.Name)) as ImageSource;
            i14.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.leftLeaf.match.Team2.Name)) as ImageSource;


            l15.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.rightLeaf.match.Team1.Name;
            l16.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.rightLeaf.match.Team2.Name;
            i15.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.rightLeaf.match.Team1.Name)) as ImageSource;
            i16.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.rightLeaf.match.Team2.Name)) as ImageSource;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t.DirectE.DirectElim.tourSelction();
            if(count == 1)
            {
                sc1.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.leftLeaf.match.ScoreTeam1;
                sc2.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.leftLeaf.match.ScoreTeam2;
                sc3.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.rightLeaf.match.ScoreTeam1;
                sc4.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.rightLeaf.match.ScoreTeam2;
                sc5.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.leftLeaf.match.ScoreTeam1;
                sc6.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.leftLeaf.match.ScoreTeam2;
                sc7.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.rightLeaf.match.ScoreTeam1;
                sc8.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.rightLeaf.match.ScoreTeam2;
                sc9.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.leftLeaf.match.ScoreTeam1;
                sc10.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.leftLeaf.match.ScoreTeam2;
                sc11.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.rightLeaf.match.ScoreTeam1;
                sc12.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.rightLeaf.match.ScoreTeam2;
                sc13.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.leftLeaf.match.ScoreTeam1;
                sc14.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.leftLeaf.match.ScoreTeam2;
                sc15.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.rightLeaf.match.ScoreTeam1;
                sc16.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.rightLeaf.match.ScoreTeam2;



                l17.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.match.Team1.Name;
                l18.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.match.Team2.Name;
                i17.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.match.Team1.Name)) as ImageSource;
                i18.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.match.Team2.Name)) as ImageSource;

                l19.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.match.Team1.Name;
                l20.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.match.Team2.Name;
                i19.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.match.Team1.Name)) as ImageSource;
                i20.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.match.Team2.Name)) as ImageSource;

                l21.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.match.Team1.Name;
                l22.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.match.Team2.Name;
                i21.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.match.Team1.Name)) as ImageSource;
                i22.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.match.Team2.Name)) as ImageSource;

                l23.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.match.Team1.Name;
                l24.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.match.Team2.Name;
                i23.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.match.Team1.Name)) as ImageSource;
                i24.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.match.Team2.Name)) as ImageSource;

                count++;
            }
            else if (count == 2)
            {

                sc17.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.match.ScoreTeam1;
                sc18.Content = t.DirectE.DirectElim.Root.leftLeaf.leftLeaf.match.ScoreTeam2;
                sc19.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.match.ScoreTeam1;
                sc20.Content = t.DirectE.DirectElim.Root.leftLeaf.rightLeaf.match.ScoreTeam2;
                sc21.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.match.ScoreTeam1;
                sc22.Content = t.DirectE.DirectElim.Root.rightLeaf.leftLeaf.match.ScoreTeam2;
                sc23.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.match.ScoreTeam1;
                sc24.Content = t.DirectE.DirectElim.Root.rightLeaf.rightLeaf.match.ScoreTeam2;


                l25.Content = t.DirectE.DirectElim.Root.leftLeaf.match.Team1.Name;
                l26.Content = t.DirectE.DirectElim.Root.leftLeaf.match.Team2.Name;
                i25.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.match.Team1.Name)) as ImageSource;
                i26.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.leftLeaf.match.Team2.Name)) as ImageSource;

                l27.Content = t.DirectE.DirectElim.Root.rightLeaf.match.Team1.Name;
                l28.Content = t.DirectE.DirectElim.Root.rightLeaf.match.Team2.Name;
                i27.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.match.Team1.Name)) as ImageSource;
                i28.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.rightLeaf.match.Team2.Name)) as ImageSource;


                count++;
            }
            else if(count == 3)
            {
                sc25.Content = t.DirectE.DirectElim.Root.leftLeaf.match.ScoreTeam1;
                sc26.Content = t.DirectE.DirectElim.Root.leftLeaf.match.ScoreTeam2;
                sc27.Content = t.DirectE.DirectElim.Root.rightLeaf.match.ScoreTeam1;
                sc28.Content = t.DirectE.DirectElim.Root.rightLeaf.match.ScoreTeam2;

                l29.Content = t.DirectE.DirectElim.Root.match.Team1.Name;
                l30.Content = t.DirectE.DirectElim.Root.match.Team2.Name;
                i29.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.match.Team1.Name)) as ImageSource;
                i30.Source = new ImageSourceConverter().ConvertFromString(search(t.DirectE.DirectElim.Root.match.Team2.Name)) as ImageSource;

                count++;
                
            }
            else if(count == 4)
            {
                sc29.Content = t.DirectE.DirectElim.Root.match.ScoreTeam1;
                sc30.Content = t.DirectE.DirectElim.Root.match.ScoreTeam2;
                if (t.DirectE.DirectElim.Root.match.ScoreTeam2 > t.DirectE.DirectElim.Root.match.ScoreTeam1)
                {
                    t2.Visibility = Visibility.Visible;
                }
                else t1.Visibility = Visibility.Visible;

                count++;
            }
            else if(count == 5)
            {
                System.Windows.Application.Current.Shutdown();
            }


        }
    }
}
