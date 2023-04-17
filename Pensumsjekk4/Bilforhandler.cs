namespace Pensumsjekk4
{
    public class Bilforhandler
    {
        public string Navn { get; private set; }
        public string Adresse { get; private set; }
        public List<Bil> Biler { get; set; }
        public Bilforhandler(string navn, string adresse)
        {
            Navn = navn;
            Adresse = adresse;
            Biler = new List<Bil>();
        }
        public void LeggTilBil(Bil bil)
        {
            Biler.Add(bil);
        }
        public void FjernBil(string regNummer)
        {
            foreach (Bil Bil in Biler)
            {
                if (Bil.Registreringsnummer == regNummer)
                {
                    Biler.Remove(Bil);
                    return;
                }
            }
        }
        public List<Bil> eldreBiler(int criteria)
        {
            List<Bil> _eldreBiler = new List<Bil>();
            foreach (Bil Bil in Biler)
            {
                if (Bil.Årgang < criteria)
                {
                    _eldreBiler.Add(Bil);
                }
            }
            return _eldreBiler;
        }
        public List<Bil> longRoad(int criteria)
        {
            List<Bil> _longRoad = new List<Bil>();
            foreach (Bil Bil in Biler)
            {
                if (Bil.Kilometer > criteria)
                {
                    _longRoad.Add(Bil);
                }
            }
            return _longRoad;
        }
    }
}
