using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    class Affe:Tiere
    {
        private string name;
        protected override string Name { get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new TierException("Die Zeile ist leer");
                }
                name = value;
            } }
        protected override int Beine { get { return 2; } set { } }

        protected Affe(string Name) : base(Name)
        {
            this.Name = Name;
        }

    }
}
