using System;
using System.Linq;
using WpfApp1.DTO;
using WpfApp1.EF;

namespace WpfApp1.DAL
{
    public class AdminDal
    {
        public AdminDto Select(InformationDeConnexionDTO informationDeConnexionDTO)
        {
            // requete select permettant de recuperer les infos du client
            // select * from client where email = informationDeConnexionDTO.Email etc....
            // execution requete
            // Gets and prints all books in database
            AdminDto client = null;
            using (var context = new MonProjetDBcontext())
            {
                var collaborateurs = context.Collaborateurs.Where(collabo => collabo.Email.Equals(informationDeConnexionDTO.Email) && collabo.MotDePasse.Equals(informationDeConnexionDTO.MotDePasse)).FirstOrDefault();
                if(collaborateurs != null)
                {
                    client = new AdminDto()
                    {
                        ID = collaborateurs.IdCollaborateur,
                        Nom = collaborateurs.Nom,
                        Prenom = collaborateurs.Prenom
                    };
                }
            }

            return client;
        }
    }


}
