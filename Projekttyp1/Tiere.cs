using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    public abstract class Tiere
    {
        public abstract string Name { get; set; }
        public virtual int Beine { get { return 4; }}

        public Tiere(string name)
        {
            Name = name;
        }
    }
}
