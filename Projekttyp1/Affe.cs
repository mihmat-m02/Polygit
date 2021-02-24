using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    class Affe:Tiere
    {
        protected override string Name { get; set; }
        protected override int Beine { get { return 2; } set { } }

        protected Affe(string Name) : base(Name)
        {
            this.Name = Name;
        }
    }
}
