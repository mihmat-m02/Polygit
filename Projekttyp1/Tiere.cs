using System;
using System.Collections.Generic;
using System.Text;

namespace Projekttyp1
{
    abstract class Tiere
    {
        protected abstract string Name { get; set; }
        protected virtual int Beine { get { return 4; }}

        protected Tiere(string name)
        {
            Name = name;
        }
    }
}
