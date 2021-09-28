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
            Console.WriteLine(Print("Asish", 5));
        }

        static string Print(string str, int N)
        {
            return string.Concat(Enumerable.Repeat(str, N));
        }
    }
}
