using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_in_Cs
{
    internal class Steck<tipo>
    {
        int len;
        public Link<tipo>? primo { get; private set; }
        public void Push(tipo val)
        {
            var link = new Link<tipo>(val);

            link.SetNext(primo);
            primo = link;
            len++;

        }
        public tipo Pop()
        {
            if (len <= 0) throw new Exception("Lunghezza invalida per POP"); 
            Link<tipo> nodoesploso = primo;
            primo = primo.prossimo;

            len--;
            return nodoesploso.valore;
        }
        public Steck(tipo val)
        {
            len = 1;
            primo = new Link<tipo>(val);
        }
    }
}
