using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Delegates_en_Events.Models.events
{
    public class WinkelEventArgs : EventArgs
    {
        public Bestelling Bestelling { get; set; }
    }
}
