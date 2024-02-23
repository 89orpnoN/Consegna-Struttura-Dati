using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_in_Cs
{
    internal class Queue<tipo>
    {
        int _len;
        public Link<tipo>? Primo { get; private set; }
        public Link<tipo>? Ultimo { get; private set; }
        public void Enqueue(tipo val)
        {
            var link = new Link<tipo>(val);
            Ultimo.SetNext(link);
            Ultimo = link;
            _len++;

        }
        public tipo Dequeue()
        {
            if (_len <= 0) throw new Exception("Lunghezza invalida per POP"); 
            Link<tipo> nodoesploso = Ultimo;

            Link<tipo> Penultimo = Primo;
            for (int i = 0; i < _len -2; i++)
            {
                Penultimo = Penultimo.prossimo;
            }
            Penultimo.SetNext(null);
            Ultimo = Penultimo;

            _len--;
            return nodoesploso.valore;
        }
        public Queue(tipo val)
        {
            _len = 1;
            Primo = new Link<tipo>(val);
            Ultimo = Primo;
        }
    }
}
