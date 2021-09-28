using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintStringMultipleTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintItems<int>.ConcatMultiple(12, 5));
        }
    }
            
    public class PrintItems<T> where T :  new()
    {
        public static string ConcatMultiple(T item, int N)
        {
            return string.Concat(Enumerable.Repeat(item.ToString() + " ", N));
        }
    }
}
