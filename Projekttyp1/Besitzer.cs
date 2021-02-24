using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    public class Besitzer
    {
        List<Tiere> owner = new List<Tiere>();

        public void Hinzufügen(Tiere tier)
        {
            owner.Add(tier);
        }
        public void Entfernen(Tiere tier)
        {
            owner.Remove(tier);
        }
    }
}
