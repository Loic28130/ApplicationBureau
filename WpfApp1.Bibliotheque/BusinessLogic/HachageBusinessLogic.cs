using System;
using System.Security.Cryptography;
using System.Text;
namespace WpfApp1.Bibliotheque.BusinessLogic
{
    public class HachageBusinessLogic


    {
        public string HachageMotDePasse(string motDePasse)
        {
           return BCrypt.Net.BCrypt.HashPassword(motDePasse);
        }

        public bool VerifMotDePasse(string motDePasse, string motDePasseHacher)
        {
            return BCrypt.Net.BCrypt.Verify(motDePasse, motDePasseHacher);
        }
    }
}
