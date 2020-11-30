using Opdracht_Delegates_en_Events.Models.events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models
{
    public class Winkel
    {
        #region Attibutes
        public event EventHandler<WinkelEventArgs> BestellingEvent;
        #endregion

        #region Constructors
        public Winkel(){}
        #endregion

        #region Methodes
        public void VerkoopProduct(Bestelling bestelling)
        {
            OnVerkoopProduct(bestelling);
        }
        protected virtual void OnVerkoopProduct(Bestelling Lbestelling)
        {
            if(!(BestellingEvent is null))
            {
                BestellingEvent(this, new WinkelEventArgs { Bestelling = Lbestelling });
            }
        }
        #endregion
    }
}
