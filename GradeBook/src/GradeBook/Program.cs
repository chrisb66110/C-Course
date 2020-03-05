using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = args.Length > 0 ? args[0] : "World";
            Console.WriteLine($"Hello {name}!");

            var numbers = new List<double>() {2.14, 1.14, 0.14, 1};
            
            var result = 0D;
            foreach(var number in numbers)
            {
                result += number;
            }

            Console.WriteLine(result);
        }
    }
}
