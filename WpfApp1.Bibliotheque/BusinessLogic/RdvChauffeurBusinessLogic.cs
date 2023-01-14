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

        public ListRdvAvecCollaborateur ListRvdChauffeurAvecCollaborateur()
        {
            var rdvChauffeurs = ListRvdChauffeur();

            var collaborateurDal = new CollaborateurDal();

            var collaborateurs = collaborateurDal.ListeCollaborateurs();

            return new ListRdvAvecCollaborateur
            {
                Collaborateurs = collaborateurs,
                Rdvs = rdvChauffeurs
            };
        }
    }
}
