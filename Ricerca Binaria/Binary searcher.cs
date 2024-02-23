using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Ricerca_Binaria
{
    internal class BinaryList<T> where T : IComparable<T>
    {
        public T[] Lista;

        public BinaryList(T[] arr)
        {
            Lista = arr;
        }
        public int BynarySrc(T val, T[]? arr = null)
        {
            if (arr == null)
            {
                // spero non mi esploda tutto
                arr = Lista;
            }

            int mid = arr.Length / 2;
            int returnidx = -1;

            if (arr[mid].CompareTo(val) == 0)
            // conoscenza barbanesca
            {
                returnidx = mid;
            } 
            else if (arr[mid].CompareTo(val) < 0)
            {

                T?[] newArr = Enumerable.Repeat<T>(default, mid).ToArray();
                Array.Copy(arr, mid+1, newArr, 0, mid );
                int result = BynarySrc(val, newArr);
                if (result != -1) returnidx = mid + result+1;


            } else
            {
                T?[] newArr = Enumerable.Repeat<T>(default, mid).ToArray();
                Array.Copy(arr, 0, newArr, 0, mid);
                int result = BynarySrc(val, newArr);
                if (result != -1) returnidx = result;
                
            }

            return returnidx;
        }
    }
}
