using System.Windows;
using WpfApp1.BusinessLogic;
using WpfApp1.DTO;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Recuperation des infos
            var connexionDto = new InformationDeConnexionDTO();
            connexionDto.Email = tb_Email.Text;
            connexionDto.MotDePasse = pb_MotDePasse.Password;

            // Connexion
            var clientBu = new AdminBusinessLogic();
            var estConnecter = clientBu.Connexion(connexionDto);

            MessageBox.Show($"estco {estConnecter}");
        }
    }
}
