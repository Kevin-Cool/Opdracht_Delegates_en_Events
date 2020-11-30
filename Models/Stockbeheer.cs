using Opdracht_Delegates_en_Events.Models.events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models
{
    public class Stockbeheer
    {
        #region Attibutes
        private Dictionary<ProductType, int> _stonks = new Dictionary<ProductType, int>();
        private int _minimumgrens = 25;
        public event EventHandler<WinkelEventArgs> StockbeheerEvent;
        #endregion

        #region Constructors
        public Stockbeheer()
        {
            _stonks[ProductType.Tripel] = 100;
            _stonks[ProductType.Dubbel] = 100;
            _stonks[ProductType.Kriek] = 100;
            _stonks[ProductType.Pils] = 100;
        }
        #endregion

        #region Methodes
        public void Toon_stocks()
        {
            string TS = "";
            TS += "-------------\n";
            TS += "[stocks:Tripel," + _stonks[ProductType.Tripel]   + "]\n";
            TS += "[stocks:Dubbel," + _stonks[ProductType.Dubbel]   + "]\n";
            TS += "[stocks:Kriek,"  + _stonks[ProductType.Kriek]    + "]\n";
            TS += "[stocks:Pils,"   + _stonks[ProductType.Pils]     + "]\n";
            TS += "-------------\n";
            Console.WriteLine(TS);
        }
        public void Add_bestelling(object sender, WinkelEventArgs args)
        {
            Reduce_stock(args.Bestelling.Product, args.Bestelling.Aantal);
        }
        public void  Reduce_stock(ProductType productType, int aantal)
        {
            _stonks[productType] -= aantal;
            if ((_stonks[ProductType.Tripel] < _minimumgrens) || (_stonks[ProductType.Dubbel] < _minimumgrens) || (_stonks[ProductType.Kriek] < _minimumgrens) || (_stonks[ProductType.Pils] < _minimumgrens))
            {
                Vull_alle_stocks_aan();
            }
        }
        public void Vull_alle_stocks_aan()
        {
            string TS = "";
            TS += "-------------\n";

            if (_stonks[ProductType.Tripel] < 100)
            {
                OnVullStocksAan(new Bestelling(ProductType.Tripel, (100 - _stonks[ProductType.Tripel]), "Stockbeheer"));
                TS += "Voorraadbestelling : Tripel,"+ (100 - _stonks[ProductType.Tripel]) + "\n"; _stonks[ProductType.Tripel] = 100;
            }
            if (_stonks[ProductType.Dubbel] < 100)
            {
                OnVullStocksAan(new Bestelling(ProductType.Dubbel, (100 - _stonks[ProductType.Dubbel]), "Stockbeheer"));
                TS += "Voorraadbestelling : Dubbel," + (100 - _stonks[ProductType.Dubbel]) + "\n"; _stonks[ProductType.Dubbel] = 100;
            }
            if (_stonks[ProductType.Kriek] < 100)
            {
                OnVullStocksAan(new Bestelling(ProductType.Kriek, (100 - _stonks[ProductType.Kriek]), "Stockbeheer"));
                TS += "Voorraadbestelling : Kriek," + (100 - _stonks[ProductType.Kriek]) + "\n"; _stonks[ProductType.Kriek] = 100;
            }
            if (_stonks[ProductType.Pils] < 100)
            {
                OnVullStocksAan(new Bestelling(ProductType.Pils, (100 - _stonks[ProductType.Pils]), "Stockbeheer"));
                TS += "Voorraadbestelling : Pils," + (100 - _stonks[ProductType.Pils]) + "\n"; _stonks[ProductType.Pils] = 100;
            }

            TS += "-------------\n";
            Console.WriteLine(TS);
        }
        protected virtual void OnVullStocksAan(Bestelling Lbestelling)
        {
            if (!(StockbeheerEvent is null))
            {
                StockbeheerEvent(this, new WinkelEventArgs { Bestelling = Lbestelling });
            }
        }

        #endregion

    }
}
