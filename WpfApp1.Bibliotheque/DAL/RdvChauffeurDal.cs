using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using WpfApp1.Bibliotheque.DTO;
using WpfApp1.Bibliotheque.EF;
using WpfApp1.EF;

namespace WpfApp1.Bibliotheque.DAL
{
    public class RdvChauffeurDal
    {
        public IEnumerable<RdvDto> ListRvdChauffeur()
        {
            using (var context = new MonProjetDBcontext())
            {
                var rdvs = context.RdvsChauffeurs.Include("Client").Include("Collaborateur");

                return Map(rdvs);
            }
        }

        private IEnumerable<RdvDto> Map(IEnumerable<RdvChauffeurModel> rdvs)
        {
            var list = new List<RdvDto>();
            foreach (RdvChauffeurModel rdvModel in rdvs)
            {
                list.Add(new RdvDto
                {
                    AdresseArrivee = rdvModel.AdresseArrivee,
                    Date = rdvModel.DateDeDepart,
                    ID = rdvModel.IdRdvChauffeur,
                    LieuxDepart = rdvModel.LieuxDeDepart,
                    HeureDeDepart = rdvModel.HeureDeDepart,
                    Client = new ClientDTO()
                    {
                        Nom = rdvModel.Client.Nom,
                        Prenom = rdvModel.Client.Prenom
                    },

                     Collaborateur = new CollaborateurDto()
                     {
                         Nom = rdvModel.Collaborateur?.Nom,
                        
                     }
                });
            }

            return list;
        }
    }
}
