using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    public class Hund : Tiere
    {
        public override string Name { get; set; }
        public override int Beine { get { return 4; } }

        public Hund(string Name):base(Name)
        {
            this.Name = Name;
        }
    }
}
