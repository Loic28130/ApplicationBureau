using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1.Bibliotheque.EF
{
    [Table("clients")]
    public class ClientModel
    {
        [Column("IDclient")]
        [Key]
        public int IdClient { get; set; }

        [Column("nom")]
        public string Nom { get; set; }

        [Column("prenom")]
        public string Prenom { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("MotDePasse")]
        public string MotDePasse { get; set; }
    }
}


