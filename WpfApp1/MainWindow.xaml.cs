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

            var clientBu = new ClientBusinessLoginc();
            clientBu.Inscription(client);

            MessageBox.Show($"inscritpion du client {client.Nom} effectué");
        }
    }

    public class ClientDto
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override string ToString()
        {
            return $"Mon nom est {Nom} et prenom est {Prenom}";
        }
    }

    public class ClientBusinessLoginc
    {
        public void Inscription(ClientDto clientDto)
        {
            var clientDal = new ClientDAL();

            clientDal.Insert(clientDto);
        }
    }

    public class ClientDAL
    {
        public void Insert(ClientDto dto)
        {
            // requete sql et insertion en bdd
        }
    }


}
