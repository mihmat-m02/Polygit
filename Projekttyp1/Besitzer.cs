using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    class Besitzer
    {
        List<Tiere> owner = new List<Tiere>();

        protected void Hinzufügen(Tiere tier)
        {
            owner.Add(tier);
        }
        protected void Entfernen(Tiere tier)
        {
            owner.Remove(tier);
        }
    }
}
