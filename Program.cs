using Opdracht_Delegates_en_Events.Models;
using System;

namespace Opdracht_Delegates_en_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm alive!");

            Winkel w = new Winkel();
            Sales s = new Sales();
            Stockbeheer sb = new Stockbeheer();
            Groothandelaar g = new Groothandelaar();

            w.BestellingEvent += s.Add_bestelling;
            w.BestellingEvent += sb.Add_bestelling;
            sb.StockbeheerEvent += g.Add_bestelling;

            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 45.69, 50, "Adres A"));
            w.VerkoopProduct(new Bestelling(ProductType.Kriek, 45.69, 25, "Adres A"));
            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 45.69, 19, "Adres B"));

            s.Rapport();
            sb.Toon_stocks();
            sb.Vull_alle_stocks_aan();
            sb.Toon_stocks();

            Console.WriteLine(g.Geef_laatste_bestelling().ToString());
            /*
            w.Groothandelaar.stockbeheer.Toon_stocks();
            w.Groothandelaar.stockbeheer.Vull_alle_stocks_aan();
            w.Groothandelaar.stockbeheer.Toon_stocks();

            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 45.69, 99, "Adres C"));

            w.Groothandelaar.stockbeheer.Toon_stocks();*/
        }
    }
}
