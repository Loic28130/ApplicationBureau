namespace WpfApp1.Bibliotheque.DTO
{
    public class ListRdvAvecCollaborateur
    {
        public IEnumerable<RdvDto> Rdvs { get; set; }
        public IEnumerable<CollaborateurDto> Collaborateurs { get; set; }
    }
}
