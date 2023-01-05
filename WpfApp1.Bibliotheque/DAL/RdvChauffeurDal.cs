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
                var rdvs = context.RdvsChauffeurs;

                return Map(rdvs);
            }
        }

        private IEnumerable<RdvDto> Map(IEnumerable<RdvChauffeurModel> rdvs)
        {
            var list = new List<RdvDto>();
            foreach (var rdv in rdvs)
            {
                list.Add(new RdvDto
                {
                    AdresseArrivee = rdv.AdresseArrivee,
                    Date = rdv.DateDeDepart,
                    ID = rdv.IdRdvChauffeur,
                    LieuxDepart = rdv.LieuxDeDepart
                });
            }

            return list;
        }
    }
}
