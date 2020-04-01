using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("BookTest");
            book.AddGrade(89.2);
            book.AddGrade(90.1);
            book.AddGrade(101);

            var statistics = book.GetStatistics();

            statistics.ShowStatistics();
            statistics.ShowPreStatistics();
        }
    }
}
