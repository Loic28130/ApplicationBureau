namespace WpfApp1.DTO
{
    public class ClientDto
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override string ToString()
        {
            return $"Mon nom est {Nom} et prenom est {Prenom}";
        }
    }
}
