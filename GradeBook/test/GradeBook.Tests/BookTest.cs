using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace GradeBook.Tests
{
    [ExcludeFromCodeCoverage]
    public class BookTest
    {
        [Fact]
        public void PreMinValueTest()
        {
            var book = GivenTheDefaultBook();
         
            var preMin = book.GetPreMinValue();

            Assert.Equal(10,preMin);
        }

        [Fact]
        public void PreAvgValueTest()
        {
            var book = GivenTheDefaultBook();

            var preAvg = book.GetPreAvgValue();

            Assert.Equal(50,preAvg);
        }

        [Fact]
        public void PreMaxValueTest()
        {
            var book = GivenTheDefaultBook();

            var preMax = book.GetPreMaxValue();

            Assert.Equal(90,preMax);
        }

        [Fact]
        public void MinValueTest()
        {
            var book = GivenTheDefaultBook();

            var min = book.GetMinValue();

            Assert.Equal(10,min);
        }

        [Fact]
        public void AvgValueTest()
        {
            var book = GivenTheDefaultBook();

            var avg = book.GetAvgValue();
            
            Assert.Equal(50,avg);
        }

        [Fact]
        public void MaxValueTest()
        {
            var book = GivenTheDefaultBook();

            var max = book.GetMaxValue();
            Assert.Equal(90,max);
        }

        public Book GivenTheDefaultBook(){
            var book = new Book("TestBook");
            book.AddGrade(10);
            book.AddGrade(20);
            book.AddGrade(30);
            book.AddGrade(40);
            book.AddGrade(50);
            book.AddGrade(60);
            book.AddGrade(70);
            book.AddGrade(80);
            book.AddGrade(90);

            return book;
        }
    }
}
