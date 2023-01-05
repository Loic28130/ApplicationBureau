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
using WpfApp1.BusinessLogic;
using WpfApp1.DTO;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Connection.xaml
    /// </summary>
    public partial class Connection : Page
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //// Recuperation des infos
            var connexionDto = new InformationDeConnexionDTO();
            connexionDto.Email = tb_Email.Text;
            connexionDto.MotDePasse = pb_MotDePasse.Password;

            // Connexion
            var clientBu = new AdminBusinessLogic();
            var estConnecter = clientBu.Connexion(connexionDto);

            MessageBox.Show($"estco {estConnecter}");

            if (estConnecter)
            {
                var page = new ListeRdvChauffeur();
                var t = NavigationService.GetNavigationService(this);
                t.Navigate(page);
            }
        }
    }
}
