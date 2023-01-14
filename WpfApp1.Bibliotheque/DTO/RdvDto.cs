namespace WpfApp1.Bibliotheque.DTO
{
    public class RdvDto
    {
        public int ID { get; set; }
        public string LieuxDepart { get; set; }
        public string AdresseArrivee { get; set; }
        public string Date { get; set; }
        public string HeureDeDepart { get; set; }

        public ClientDTO Client { get; set; }

        public CollaborateurDto Collaborateur { get; set; }
    }
}
