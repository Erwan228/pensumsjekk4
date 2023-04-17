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
            //Biler.Remove(regNummer);
        }
    }
}
