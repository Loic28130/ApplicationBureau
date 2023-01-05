using WpfApp1.Bibliotheque.DAL;
using WpfApp1.Bibliotheque.DTO;

namespace WpfApp1.Bibliotheque.BusinessLogic
{
    public class RdvChauffeurBusinessLogic
    {
        public IEnumerable<RdvDto> ListRvdChauffeur()
        {
            var rdvChauffeurDal = new RdvChauffeurDal();

            return rdvChauffeurDal.ListRvdChauffeur();
        }
    }
}
