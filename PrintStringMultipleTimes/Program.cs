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
            while (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"Number {number} is {(Number.IsPrime(number)? "PRIME" : "COMPOSITE")}");
            }
        }
    }

    public class PrintItems<T> where T : new()
    {
        public static string ConcatMultiple(T item, int N)
        {
            return string.Concat(Enumerable.Repeat(item.ToString() + " ", N));
        }
    }

    public class Number
    {
        public static bool IsPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
