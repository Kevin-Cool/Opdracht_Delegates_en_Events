using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models
{
    public class Groothandelaar
    {
        #region Attibutes
        public List<Bestelling> Bestellingen { get; private set; } = new List<Bestelling>();
        public Stockbeheer stockbeheer = new Stockbeheer();
        #endregion

        #region Constructors
        public Groothandelaar() 
        {
        }
        #endregion

        #region Methodes
        public Bestelling Geef_laatste_bestelling()
        {
            return Bestellingen.LastOrDefault();
        }
        public void Voeg_bestelling_toe(Bestelling bestelling)
        {
            Bestellingen.Add(bestelling);
            stockbeheer.Reduce_stock(bestelling.Product, bestelling.Aantal);
        }
        #endregion
    }
}
