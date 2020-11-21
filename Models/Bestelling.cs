using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models
{
    public class Bestelling
    {
        #region Attibutes
        public ProductType Product { get; private set; }
        public double Prijs { get; private set; }
        public int Aantal { get; private set; }
        public string Adres { get; private set; }
        #endregion

        #region Constructors
        public Bestelling(ProductType product, double prijs, int aantal, string adres)
        {
            Product = product;
            Prijs = prijs;
            Aantal = aantal;
            Adres = adres;
        }
        #endregion

        #region Methodes
        //todo
        #endregion
    }
}
