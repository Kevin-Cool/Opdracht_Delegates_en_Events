using Opdracht_Delegates_en_Events.Models.events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models
{
    public class Winkel
    {
        #region Attibutes
        public Sales Sales { get; set; }
        public Groothandelaar Groothandelaar { get; set; }
        public BestellingsSysteem BestellingsSysteem { get; set; }
        #endregion

        #region Constructors
        public Winkel() 
        {
            BestellingsSysteem = new BestellingsSysteem();
            Sales = new Sales(BestellingsSysteem);
            Groothandelaar = new Groothandelaar();
        }
        #endregion

        #region Methodes
        public void VerkoopProduct(Bestelling bestelling)
        {
            BestellingsSysteem.GeefBestellingIn(new WinkelEventArgs { Bestelling = bestelling });
            //Sales.Add_bestelling(bestelling);
            //Groothandelaar.Voeg_bestelling_toe(bestelling);
        }
        #endregion
    }
}
