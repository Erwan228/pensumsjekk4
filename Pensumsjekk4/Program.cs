namespace Pensumsjekk4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilforhandler bilforhandlerern = new Bilforhandler("PerPålolo", "Hell's fith circle");
            Bil bil1 = new Bil("Mercedes", "YF66699", 2017, 0);
            Bil bil2 = new Bil("Fiat", "KH69332", 2015, 12);
            Bil bil3 = new Bil("Ford", "SD48278", 2009, 50000);
            Bil bil4 = new Bil("Bugatti", "MM99909", 2012, 999999);
            Bil bil5 = new Bil("BMW", "BM12345", 2023, 567);
            bilforhandlerern.LeggTilBil(bil1);
            bilforhandlerern.LeggTilBil(bil2);
            bilforhandlerern.LeggTilBil(bil3);
            bilforhandlerern.LeggTilBil(bil4);
            bilforhandlerern.LeggTilBil(bil5);
            foreach (Bil bil in bilforhandlerern.Biler)
            {
                Console.WriteLine(bil.Merke);
            }
        }
    }
}