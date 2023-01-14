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
using WpfApp1.Bibliotheque.BusinessLogic;
using WpfApp1.Bibliotheque.DTO;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour ListeRdvChauffeur.xaml
    /// </summary>
    public partial class ListeRdvChauffeur : Page
    {
        public ListeRdvChauffeur()
        {
            InitializeComponent();
            var rdvsAvecCollabo = GetRdvsAvecCollabo();
            datagridRdv.ItemsSource = rdvsAvecCollabo.Rdvs;
            dgcb_collab.ItemsSource = rdvsAvecCollabo.Collaborateurs;
        }
        
        private ListRdvAvecCollaborateur GetRdvsAvecCollabo()
        {
            var rdvChauffeurBusinessLogic = new RdvChauffeurBusinessLogic();

            return rdvChauffeurBusinessLogic.ListRvdChauffeurAvecCollaborateur();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            Uri uri = new Uri("Test.xaml", UriKind.Relative);
            nav.Navigate(uri);
        }

        
    }
}
