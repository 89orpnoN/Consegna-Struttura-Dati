using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Binary_tree_attempt
{
    internal class IntNode
    {
        public int valore { get; private set; }
        public IntNode? Maggiore { get; private set; }
        public IntNode? Minore { get; private set; }

        public IntNode(int val)
        {
            valore = val;
        }
        public IntNode? SrcNode(int val)
        // "eH mA iL TeRzO eLsE If CoPrE Il 100% DeI CaSi, DoVrEStI UsAre SoLo Un ElSe" -barban
        // "lo so" (tanto il compilatore lo ottimizzerà in qualche modo)
        {
            if (valore == val) return this;
            else if (valore >= val && Maggiore != null )  return Maggiore.SrcNode(val);
            else if (valore < val && Minore != null)  return Minore.SrcNode(val);

            
            return null;
            // ho fatto un casino, sarebbe molto più facile se l'albero fosse bidirezionale
            // eh lo so (scritto 2 settimane dopo)
        }

        public override string ToString()
        {
            return valore.ToString();
        }

        public void Stampa(IntNode nodo)
        {
            Console.WriteLine(nodo.ToString());
        }

        

            public IntNode? DFSSearch(int? val, int flag, Action<IntNode> CustomMethod)
        {
            IntNode?[] INodes =  {null,null,null };

            

            switch (flag)
            // prima volta in tutta la mia vita che uso gli switch (li odio, preferisco fare 26 if-statement consecutivi)
            {
                case 0:
                    // nodo -> sx -> dx
                    INodes[0] = this;
                    INodes[1] = Minore;
                    INodes[2] = Maggiore;
                    break;

                case 1:
                    // sx -> dx -> nodo
                    INodes[0] = Minore;
                    INodes[1] = Maggiore;
                    INodes[2] = this;
                    break;

                case 2:
                    // sx -> nodo -> dx
                    INodes[0] = Minore;
                    INodes[1] = this;
                    INodes[2] = Maggiore;
                    break;
                default: 
                    throw new Exception("Inserito flag Incompatibile");
            }
            IntNode returnNode = null;
            foreach (var node in INodes)
            {

                if (node == this)
                {
                    CustomMethod(this);
                    if (val == valore) return this;

                } else if (node != null)
                {
                    returnNode = node.DFSSearch(val,flag, CustomMethod);
                    if (returnNode != null) return returnNode;
                }

            }
            return null;
            
        }



        public IntNode? DeleteNode(int val)
        {
            IntNode? ricercato = null;
            if (valore == val) return this;
            else if (valore < val && Maggiore != null) ricercato = Maggiore.DeleteNode(val);
            else if (valore > val && Minore != null) ricercato = Minore.DeleteNode(val);

            if (ricercato == Maggiore) Maggiore = null;
            else if (ricercato == Minore) Minore = null;
            
            return ricercato;
        // ho fatto un casino, sarebbe molto più facile se l'albero fosse bidirezionale
        }

        public void SetChild(IntNode nodo)
        // c'è un modo migliore di farlo, ma non ne ho l'amore -alessandro manzoni
        // tanto il compilatore lo ottimizzerà in qualche modo
        {
            if (nodo.valore >= valore)
            {
                if (Maggiore == null) Maggiore = nodo;
                else Maggiore.SetChild(nodo);
            }
            else if (nodo.valore <= valore)
            {
                if (Minore == null) Minore = nodo;
                else Minore.SetChild(nodo);
            }
            
        }

       

    }
}
