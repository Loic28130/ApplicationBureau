using WpfApp1.Bibliotheque.DTO;
using WpfApp1.EF;

namespace WpfApp1.Bibliotheque.DAL
{
    public class CollaborateurDal
    {
        public IEnumerable<CollaborateurDto> ListeCollaborateurs()
        {
            using (var context = new MonProjetDBcontext())
            {
                var collaborateurs = context.Collaborateurs;

                return Map(collaborateurs);
            }
        }

        private IEnumerable<CollaborateurDto> Map(IEnumerable<CollaborateurModel> collaborateurs)
        {
            var list = new List<CollaborateurDto>();
            foreach (var collaborateur in collaborateurs)
            {
                list.Add(new CollaborateurDto
                {
                    Nom = collaborateur.Nom,
                    Prenom = collaborateur.Prenom
                });
            }

            return list;
        }
    }
}
