using Opdracht_Delegates_en_Events.Models.events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models
{
    public class Sales
    {
        #region Attibutes
        private Dictionary<string, List<Bestelling>> _bestellingen = new Dictionary<string, List<Bestelling>>();
        #endregion

        #region Constructors
        public Sales( ) {  }
        #endregion

        #region Methodes
        public void Add_bestelling(object sender, WinkelEventArgs args)
        {
            if (_bestellingen.ContainsKey(args.Bestelling.Adres)) 
            {
                _bestellingen[args.Bestelling.Adres].Add(args.Bestelling);
            }
            else
            {
                _bestellingen.Add(args.Bestelling.Adres, new List<Bestelling> { args.Bestelling });
            }
        }
        public void Rapport()
        {
            string TS = "";
            TS += "-------------\n";
            foreach (string adress in _bestellingen.Keys)
            {
                TS += adress+"\n";
                foreach (Bestelling bes in _bestellingen[adress])
                {
                    TS += "   " + bes.Product + ","+ bes.Aantal + "\n";
                }
            }
            TS += "-------------\n";
            Console.WriteLine(TS);
        }

        #endregion

    }
}
