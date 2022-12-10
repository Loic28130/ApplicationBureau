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
            var client = new ClientDto();
            client.Nom = tb_test.Text;
            client.Prenom = "pouet";

            var clientBu = new ClientBusinessLogic();
            clientBu.Inscription(client);

            MessageBox.Show($"inscritpion du client {client.Nom} effectué");
        }
    }
}
