using WpfApp1.DTO;
using WpfApp1.DAL;

namespace WpfApp1.BusinessLogic
{
    public class AdminBusinessLogic
    {

        public bool Connexion(InformationDeConnexionDTO connexionDTO)
        {
            AdminDal adminDAL = new AdminDal();

            var admin = adminDAL.Select(connexionDTO);

            if(admin == null)
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
