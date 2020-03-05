using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = args.Length > 0 ? args[0] : "World";
            Console.WriteLine($"Hello {name}!");

            var number1 = 2.14;
            var number2 = 1;
            var result = number1 + number2;
            System.Console.WriteLine(result);
        }
    }
}
