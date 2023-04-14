namespace Pensumsjekk4
{
    public class Bil
    {
        public string Merke { get; private set; }
        public string Registreringsnummer { get; private set; }
        public int Årgang { get; private set; }
        public int Kilometer { get; private set; }
        public Bil(string merke, string registreringsnummer, int årgang, int kilometer)
        {
            Merke = merke;
            Registreringsnummer = registreringsnummer;
            Årgang = årgang;
            Kilometer = kilometer;
        }
    }
}
