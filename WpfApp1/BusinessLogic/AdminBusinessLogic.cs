using WpfApp1.DTO;
using WpfApp1.DAL;

namespace WpfApp1.BusinessLogic
{
    public class AdminBusinessLogic
    {
        public void Inscription(AdminDto clientDto)
        {
            var clientDal = new AdminDal();

            //clientDal.Select(clientDto);
        }

        public bool Connexion(InformationDeConnexionDTO connexionDTO)
        {
            AdminDal clientDAL = new AdminDal();

            var client = clientDAL.Select(connexionDTO);

            if(client == null)
            {
                return false;                
            }
            else
            {
                // garder en memoire les infos du client
                return true;
            }
        }
    }
}
