using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace GradeBook.Tests
{
    [ExcludeFromCodeCoverage]
    public class TypeTest
    {
        [Fact]
        public void DifferentReferenceTest()
        {
            var book01 = GivenTheDefaultBook("Book01");
            var book02 = GivenTheDefaultBook("Book02");
         
            Assert.Equal("Book01", book01.Name);
            Assert.Equal("Book02", book02.Name);
            Assert.NotSame(book01, book02);
            Assert.NotEqual(book01, book02);
        }
        
        [Fact]
        public void SameReferenceTest()
        {
            var book01 = GivenTheDefaultBook("Book01");
            var book02 = book01;
         
            Assert.Equal("Book01", book01.Name);
            Assert.Equal("Book01", book02.Name);
            Assert.Same(book01, book02);
            Assert.Equal(book01, book02);
        }

        public Book GivenTheDefaultBook(string nameBook){
            var book = new Book(nameBook);
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
