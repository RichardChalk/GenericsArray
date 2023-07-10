using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArray
{
    public class ArraysGeneric
    {
        // Generics
        public T[] CreateArrayGeneric<T>(T item1, T item2)
        {
            return new T[]
            {
                item1,
                item2
            };
        }

        // Method overloading
        public int[] CreateArray(int item1, int item2) 
        { 
            return new int[]
            {
                item1,
                item2
            }; 
        }

        // Method overloading
        public double[] CreateArray(double item1, double item2)
        {
            return new double[]
            {
                item1,
                item2
            };
        }

        // Method overloading
        public string[] CreateArray(string item1, string item2)
        {
            return new string[]
            {
                item1,
                item2
            };
        }
    }
}
