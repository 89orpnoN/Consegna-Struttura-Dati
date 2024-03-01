using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Binary_tree_attempt
{
    internal class Tree
    {
        int links;
        public IntNode? primo { get; private set; }
        public void Add(int val)
        {
            var link = new IntNode(val);
            primo.SetChild(link);
            links++;

        }
        public int? Remove(int valore)
        {
            if (links <= 0) throw new Exception("Non ci sono elementi da rimuovere");

            IntNode nodo = primo.DeleteNode(valore);
            if (nodo == null) return null;
            links++;
            return nodo.valore;
        }
        public IntNode? BreadSearch(int? val, Action<IntNode>? CustomMethod = null)
        {

            List<IntNode> buffer;

            List<IntNode> queue = new List<IntNode>();
            queue.Add(primo);

            
            
            foreach (IntNode? nodo in queue)
            {
                // TODO: prima del ciclo viene riempito buffer, while true che riempe queue, i vecchi nodi vengono rimossi da queue
                if (nodo != null)
                {
                    if (CustomMethod != null)
                    {
                        CustomMethod(nodo);
                    }
                    
                    if (nodo.valore == val && val != null)
                    {
                        return nodo;
                    }
                    
                    queue.Add(nodo.Minore);
                    queue.Add(nodo.Maggiore);
                }
                
            }



            return null;
        }
        public void BreadVisits()
        {
            BreadSearch(null, primo.Stampa);
        }

        public void DFSVisits(int flag)
        {
            primo.DFSSearch(null, flag, primo.Stampa);
        }

        public Tree(int val)
        {
            links = 1;
            primo = new IntNode(val);
        }
    }
}
