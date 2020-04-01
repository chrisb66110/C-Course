using System;

namespace GradeBook
{
    public class Statistics
    {
        double _minValue;
        double _avgValue;
        double _maxVlue;
        double _minPreValue;
        double _avgPreValue;
        double _maxPreValue;
        public Statistics(double minValue, double avgValue, double maxValue, double minPreValue, double avgPreValue, double maxPreValue)
        {
            _minValue = minValue;
            _avgValue = avgValue;
            _maxVlue = maxValue;
            _minPreValue = minPreValue;
            _avgPreValue = avgPreValue;
            _maxPreValue = maxPreValue;
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"MaxValue {_minValue}!");
            Console.WriteLine($"AvgValue {_avgValue}!");
            Console.WriteLine($"MinValue {_maxVlue}!");
        }

        public void ShowPreStatistics()
        {
            Console.WriteLine($"MaxValue {_minPreValue}!");
            Console.WriteLine($"AvgValue {_avgPreValue}!");
            Console.WriteLine($"MinValue {_maxPreValue}!");
        }
    }
}