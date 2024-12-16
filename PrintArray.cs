using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPractices
{
    internal class PrintArray<T>
    {

        private T[] array;
        public PrintArray(T[] array)
        {
            this.array=array;
        }


        //public static void ToPrint(int[] intArray)
        //{
        //    foreach (int element in intArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

        //public static void ToPrint(double[] doubleArray)
        //{
        //    foreach (double element in doubleArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

        //public static void ToPrint(char[] charArray)
        //{
        //    foreach (char element in charArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

        public void ToPrint()
        {
            foreach(T element in array)
            {
                Console.WriteLine(element);
            }
        }


    }
}
