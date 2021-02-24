using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    public class Affe:Tiere
    {
        private string name;
        public override string Name { get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new TierException("Die Zeile ist leer");
                }
                name = value;
            } }
        public override int Beine { get { return 2; }}

        public Affe(string Name) : base(Name)
        {
            this.Name = Name;
        }

    }
}
