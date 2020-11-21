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
            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 45.69, 50, "Adres A"));
            w.VerkoopProduct(new Bestelling(ProductType.Kriek, 45.69, 25, "Adres A"));
            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 45.69, 19, "Adres B"));

            w.Sales.Rapport();
            /*
            w.Groothandelaar.stockbeheer.Toon_stocks();
            w.Groothandelaar.stockbeheer.Vull_alle_stocks_aan();
            w.Groothandelaar.stockbeheer.Toon_stocks();

            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 45.69, 99, "Adres C"));

            w.Groothandelaar.stockbeheer.Toon_stocks();*/
        }
    }
}
