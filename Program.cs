using System;

namespace GenericPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Generics--------");

            //int[] intArray = { 10,20,30,40 };
            //double[] doubleArray = {1.1,2.1,3.1,4.1 };
            //char[] charArray = { 'a', 'b', 'c', 'd' };

            // without using generics
            //PrintArray.ToPrint(intArray);
            //PrintArray.ToPrint(doubleArray);
            //PrintArray.ToPrint(charArray);

            //with using generics

            //Program.ToPrint<int>(intArray);
            //Program.ToPrint<double>(doubleArray);
            //Program.ToPrint<char>(charArray);


            //using generics to class
            //new PrintArray<int>(intArray).ToPrint();
            //new PrintArray<double>(doubleArray).ToPrint();
            //new PrintArray<char>(charArray).ToPrint();



            //maximum of three
            //MaximumOfThree.Maximum(30, 20, 10);
            //MaximumOfThree.Maximum(10, 30, 20);
            //MaximumOfThree.Maximum(20, 10, 30);

            //MaximumOfThree.Maximum(10.1, 10.2, 10.3);
            //MaximumOfThree.Maximum(10.1,10.3,10.2);
            //MaximumOfThree.Maximum(10.3,10.1,10.2);

            //MaximumOfThree.Maximum("apple","boll","cat");
            //MaximumOfThree.Maximum("zebra","cow","dog");
            //MaximumOfThree.Maximum("Lion", "Zebra", "Apple");

            Program.Maximum(10.78,80.65,30.89);

        }




        public static void ToPrint<T>(T[] array) 
        {
            foreach (T element in array)
            {
                Console.WriteLine(element);
            }
        }

        public static void  Maximum<T>(T value1,T value2, T value3) where T : IComparable<T> 
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3)>0)
            {
                Console.WriteLine($"{value1} is greater");
            }
            else if (value2.CompareTo(value1)>0 && value2.CompareTo(value3) > 0)
            {
                Console.WriteLine($"{value2} is greater");
            }
            else
            {
                Console.WriteLine($"{value3} is greater");
            }
        }

        
    }
}
