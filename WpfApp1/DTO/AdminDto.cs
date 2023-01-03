namespace WpfApp1.DTO
{
    public class AdminDto
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override string ToString()
        {
            return $"Mon nom est {Nom} et prenom est {Prenom}";
        }
    }
}
