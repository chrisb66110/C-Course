using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace GradeBook.Tests
{
    [ExcludeFromCodeCoverage]
    public class StatisticsTest
    {
        [Fact]
        public void GetStatisticsTest()
        {
            var statistics = GivenTheDefaultStatistics();

            statistics.ShowPreStatistics();
            statistics.ShowStatistics();
        }

        public Statistics GivenTheDefaultStatistics()
        {
            double minValue = 10;
            double avgValue = 50;
            double maxValue = 100;
            double minPreValue = 10;
            double avgPreValue = 50; 
            double maxPreValue = 100;
            var response = new Statistics(minValue, avgValue, maxValue, minPreValue, avgPreValue, maxPreValue);
            return response;
        }
    }
}
