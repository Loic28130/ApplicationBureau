using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1.EF
{
    [Table("collaborateurs")]
    public class CollaborateurModel
    {
        [Column("ID_collaborateurs")]
        [Key]
        public int IdCollaborateur { get; set; }

        [Column("nom")]
        public string Nom { get; set; }

        [Column("prenom")] 
        public string Prenom { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("mot_de_passe")]
        public string MotDePasse { get; set; }

        [Column("admin")]
        public bool Admin { get; set; }

        public override string ToString()
        {
            return $"ID: {IdCollaborateur} Nom {Nom}  Prenom {Prenom}";
        }
    }
}
