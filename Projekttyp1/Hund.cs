using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    class Hund : Tiere
    {
        protected override string Name { get; set; }
        protected override int Beine { get { return 4; } }

        protected Hund(string Name):base(Name)
        {
            this.Name = Name;
        }
    }
}
