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
using Newtonsoft.Json;

namespace ProjetADSA
{
    /// <summary>
    /// Logique d'interaction pour manualPage.xaml
    /// </summary>
    public partial class manualPage : Page
    {
        Tournament t;
        List<Team> tmp = new List<Team>();

        public manualPage()
        {
             InitializeComponent();
        }

        public Team search(string name)
        {
            string json = File.ReadAllText("Equipe_Tournoi.json");
            json.Replace('"', '\'');
            List<Team> temp = new List<Team>();
            temp = JsonConvert.DeserializeObject<List<Team>>(json);

            for(int i = 0; i < temp.Count; i++)
            {
                if (name == temp[i].Name) return temp[i];
            }
            return null;
        }

        private void btnPSG_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectPSG.Opacity = 0.7;
                btnPSG.IsEnabled = false;
                tmp.Add(search("Paris Saint Germain"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
           
        }

        private void btnBayern_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectBayern.Opacity = 0.7;
                btnBayern.IsEnabled = false;
                tmp.Add(search("Bayern FC"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
           
        }

        private void btnPSV_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectPSV.Opacity = 0.7;
                btnPSV.IsEnabled = false;
                tmp.Add(search("PSV"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnOL_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectOL.Opacity = 0.7;
                btnOL.IsEnabled = false;
                tmp.Add(search("Lyon"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnAjax_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectAjax.Opacity = 0.7;
                btnAjax.IsEnabled = false;
                tmp.Add(search("Ajax"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnInterMilan_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectInterMilan.Opacity = 0.7;
                btnInterMilan.IsEnabled = false;
                tmp.Add(search("Inter Milan"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnMU_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectMU.Opacity = 0.7;
                btnMU.IsEnabled = false;
                tmp.Add(search("Manchester United"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnGala_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectGala.Opacity = 0.7;
                btnGala.IsEnabled = false;
                tmp.Add(search("Galatasaray"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnAtletico_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectAtletico.Opacity = 0.7;
                btnAtletico.IsEnabled = false;
                tmp.Add(search("Atletico Madrid"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnBasel_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectBasel.Opacity = 0.7;
                btnBasel.IsEnabled = false;
                tmp.Add(search("Basel"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnJuve_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectJuve.Opacity = 0.7;
                btnJuve.IsEnabled = false;
                tmp.Add(search("Juventus"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnFCB_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectFCB.Opacity = 0.7;
                btnFCB.IsEnabled = false;
                tmp.Add(search("FC Barcelona"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnMonaco_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectMonaco.Opacity = 0.7;
                btnMonaco.IsEnabled = false;
                tmp.Add(search("AS Monaco"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnTottenham_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectTottenham.Opacity = 0.7;
                btnTottenham.IsEnabled = false;
                tmp.Add(search("Tottenham"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnDortmund_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectDortmund.Opacity = 0.7;
                btnDortmund.IsEnabled = false;
                tmp.Add(search("Borussia Dortmund"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnPorto_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectPorto.Opacity = 0.7;
                btnPorto.IsEnabled = false;
                tmp.Add(search("Porto"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnRoma_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectRoma.Opacity = 0.7;
                btnRoma.IsEnabled = false;
                tmp.Add(search("AS Roma"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnACMilan_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectACMilan.Opacity = 0.7;
                btnACMilan.IsEnabled = false;
                tmp.Add(search("Milan AC"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {

                rectMC.Opacity = 0.7;
                btnMC.IsEnabled = false;
                tmp.Add(search("Manchester City"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            
            }
        }

        private void btnReal_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectReal.Opacity = 0.7;
                btnReal.IsEnabled = false;
                tmp.Add(search("Real Madrid"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnCSKA_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectCSKA.Opacity = 0.7;
                btnCSKA.IsEnabled = false;
                tmp.Add(search("CSKA Moskva"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnBrugge_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectBrugge.Opacity = 0.7;
                btnBrugge.IsEnabled = false;
                tmp.Add(search("Club Brugge"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnNapoli_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectNapoli.Opacity = 0.7;
                btnNapoli.IsEnabled = false;
                tmp.Add(search("SC Napoli"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnSchalke_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectSchalke.Opacity = 0.7;
                btnSchalke.IsEnabled = false;
                tmp.Add(search("Schalke 04"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnValence_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectValence.Opacity = 0.7;
                btnValence.IsEnabled = false;
                tmp.Add(search("Valence CF"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnEverton_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectEverton.Opacity = 0.7;
                btnEverton.IsEnabled = false;
                tmp.Add(search("Everton"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnBSC_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectBSC.Opacity = 0.7;
                btnBSC.IsEnabled = false;
                tmp.Add(search("BSC Young Boys"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnSevilla_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectSevilla.Opacity = 0.7;
                btnSevilla.IsEnabled = false;
                tmp.Add(search("Sevilla"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnCeltics_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectCeltics.Opacity = 0.7;
                btnCeltics.IsEnabled = false;
                tmp.Add(search("Celtics Glasgow"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");

            }
        }

        private void btnDinamo_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectDinamo.Opacity = 0.7;
                btnDinamo.IsEnabled = false;
                tmp.Add(search("Dinamo Zagreb"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnSpartak_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectSpartak.Opacity = 0.7;
                btnSpartak.IsEnabled = false;
                tmp.Add(search("Spartak Moscow"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnFener_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectFener.Opacity = 0.7;
                btnFener.IsEnabled = false;
                tmp.Add(search("Fenerbahce"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnGent_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectGent.Opacity = 0.7;
                btnGent.IsEnabled = false;
                tmp.Add(search("Gent"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnSalzbourg_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectSalzbourg.Opacity = 0.7;
                btnSalzbourg.IsEnabled = false;
                tmp.Add(search("Salzbourg"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnBenfica_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectBenfica.Opacity = 0.7;
                btnBenfica.IsEnabled = false;
                tmp.Add(search("Benfica"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnSporting_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectSporting.Opacity = 0.7;
                btnSporting.IsEnabled = false;
                tmp.Add(search("Sporting CP"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnShakhtar_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectShakhtar.Opacity = 0.7;
                btnShakhtar.IsEnabled = false;
                tmp.Add(search("Shakhtar Donetsk"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnLokomotiv_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectLokomotiv.Opacity = 0.7;
                btnLokomotiv.IsEnabled = false;
                tmp.Add(search("Locomotiv Moscow"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnLazio_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectLazio.Opacity = 0.7;
                btnLazio.IsEnabled = false;
                tmp.Add(search("Lazio Rome"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnOM_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count <= 31)
            {
                rectOM.Opacity = 0.7;
                btnOM.IsEnabled = false;
                tmp.Add(search("Olympique Marseille"));
                label();
            }
            else
            {
                MessageBox.Show("There are too many team !");
            }
        }

        private void btnContinuer_Click(object sender, RoutedEventArgs e)
        {
            if (tmp.Count < 32)
            {
                MessageBox.Show("Please select 32 teams !");
            }
            else
            {
                this.t = new Tournament(this.tmp);
                this.NavigationService.Navigate(new rankPage(t));
            }
        }

        public void label()
        {
            Number.Content = Convert.ToString(this.tmp.Count);
        }
        
    }
}
