using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1.Bibliotheque.EF
{
    [Table("rdv_chauffeur")]
    public class RdvChauffeurModel
    {
        [Column("ID_RDV_chauffeur")]
        [Key]
        public int IdRdvChauffeur { get; set; }
        
        [Column("lieux de depart")]
        public string LieuxDeDepart { get; set; }
        
        [Column("adresse arrivee")]
        public string AdresseArrivee { get; set; }
        
        [Column("date de depart")]
        public string DateDeDepart { get; set; }
        
        [Column("heure de depart")]
        public string HeureDeDepart { get; set; }
        
        [Column("IDclient")]
        public int IDClient { get; set; }
        
        [Column("ID_collaborateurs")]
        public int? IDCollaborateur { get; set; }
    }
}
