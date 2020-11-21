using Opdracht_Delegates_en_Events.Models.events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models
{
    public class BestellingsSysteem
    {
        #region Events
        public event EventHandler<WinkelEventArgs> BestellingEvent;
        #endregion

        #region Methods
        public void GeefBestellingIn(WinkelEventArgs args)
        {
            BestellingEvent?.Invoke(this, args);
        }
        #endregion
    }
}
