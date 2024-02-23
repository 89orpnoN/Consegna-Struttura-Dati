using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_in_Cs
{
    internal class Link<tipo>
    {
        public tipo valore { get; private set; }
        public Link<tipo>? prossimo { get; private set; }

        public Link(tipo val, Link<tipo> link = null)
        {
            valore = val;
            prossimo = link;
        }
        public void SetNext(Link<tipo> link)
        {
            prossimo = link;
        }
    }
}
