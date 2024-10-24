namespace Domen
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Pol Pol { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
