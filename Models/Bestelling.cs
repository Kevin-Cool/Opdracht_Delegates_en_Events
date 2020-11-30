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
        public Bestelling(ProductType product, int aantal, string adres)
        {
            Product = product;
            Aantal = aantal;
            Adres = adres;
        }
        #endregion

        #region Methodes
        public override string ToString()
        {
            if (Prijs < 0) 
            {
                return "Bestelling met Product:" + Product.ToString() + " een Prijs van:" + Prijs + " een Aantal van:" + Aantal + " en het Adres:" + Adres;
            }
            else
            {
                return "Bestelling met Product:" + Product.ToString() + " een Aantal van:" + Aantal + " en het Adres:" + Adres;
            }
        }
        #endregion
    }
}
