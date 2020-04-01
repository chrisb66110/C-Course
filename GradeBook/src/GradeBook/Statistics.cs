using System;

namespace GradeBook
{
    public class Statistics
    {
        private double _MinValue;
        private double _AvgValue;
        private double _MaxVlue;
        private double _MinPreValue;
        private double _AvgPreValue;
        private double _MaxPreValue;
        public Statistics(double minValue, double avgValue, double maxValue, double minPreValue, double avgPreValue, double maxPreValue)
        {
            _MinValue = minValue;
            _AvgValue = avgValue;
            _MaxVlue = maxValue;
            _MinPreValue = minPreValue;
            _AvgPreValue = avgPreValue;
            _MaxPreValue = maxPreValue;
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"MaxValue {_MinValue}!");
            Console.WriteLine($"AvgValue {_AvgValue}!");
            Console.WriteLine($"MinValue {_MaxVlue}!");
        }

        public void ShowPreStatistics()
        {
            Console.WriteLine($"MaxValue {_MinPreValue}!");
            Console.WriteLine($"AvgValue {_AvgPreValue}!");
            Console.WriteLine($"MinValue {_MaxPreValue}!");
        }
    }
}