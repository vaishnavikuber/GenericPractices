using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPractices
{
    internal class MaximumOfThree<T> where T : IComparable<T>
    {
        private T var1,var2,var3;

        public MaximumOfThree(T var1, T var2, T var3)
        {
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }
        //public static void Maximum(int a,int b, int c)
        //{
        //    int max = a>b&&a>c ? a : (b>c&&b>a ? b : c);
        //    Console.WriteLine($"Maximum value is : {max}");
        //}

        //public static void Maximum(double a, double b, double c)
        //{
        //    double max = a > b && a > c ? a : (b > c && b > a ? b : c);
        //    Console.WriteLine($"Maximum value is : {max}");
        //}

        //public static void Maximum(string str1, string str2, string str3)
        //{
        //    if(String.Compare(str1,str2)>0 && String.Compare(str1, str3) > 0)
        //    {
        //        Console.WriteLine($"{str1} -> is greater");
        //    }
        //    else if(String.Compare(str2, str1) > 0 && String.Compare(str2, str3) > 0)
        //    {
        //        Console.WriteLine($"{str2} -> is greater");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{str3} -> is greater");
        //    }
            
            
        //}
        public void Maximum()
        {
            if (var1.CompareTo(var2) > 0 && var1.CompareTo(var3) > 0)
            {
                Console.WriteLine($"{var1} is greater");
            }
            else if (var2.CompareTo(var1) > 0 && var2.CompareTo(var3) > 0)
            {
                Console.WriteLine($"{var2} is greater");
            }
            else
            {
                Console.WriteLine($"{var3} is greater");
            }
        }
    }
}
