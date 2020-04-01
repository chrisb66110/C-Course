using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> _Grades;
        public string Name;
        private double MinValue;
        private double AvgValue;
        private double MaxValue;

        public Book(string name)
        {
            _Grades = new List<double>();
            Name = name;
            MinValue = 100.0;
            AvgValue = 0;
            MaxValue = 0.0;
        }

        public void AddGrade(double grade)
        {
            if( 0 <= grade && grade <= 100)
            {
                MinValue = MinValue<grade ? MinValue : grade;
                MaxValue = MaxValue>grade ? MaxValue : grade;
                AvgValue = AvgValue * _Grades.Count;
                AvgValue += grade;
                AvgValue /= _Grades.Count + 1;
                _Grades.Add(grade);
            }
        }

        public double GetMaxValue()
        {
            var response = 0.0;
            foreach (var grade in _Grades)
            {
                if(grade > response)
                {
                    response = grade;
                }
            }
            return response;
        }

        public double GetPreMaxValue()
        {
            return MaxValue;
        }

        public double GetMinValue()
        {
            var response = 100.0;
            foreach (var grade in _Grades)
            {
                if(grade < response)
                {
                    response = grade;
                }
            }
            return response;
        }

        public double GetPreMinValue()
        {
            return MinValue;
        }

        public double GetAvgValue()
        {
            var response = 0.0;
            foreach (var grade in _Grades)
            {
                response += grade;
            }

            response /= _Grades.Count;
            return response;
        }

        public double GetPreAvgValue()
        {
            return AvgValue;
        }

        public Statistics GetStatistics()
        {
            var _minValue = GetMinValue();
            var _avgValue = GetAvgValue();
            var _maxVlue = GetMaxValue();
            var _minPreValue = GetPreMinValue();
            var _avgPreValue = GetPreAvgValue();
            var _maxPreValue = GetPreMaxValue();

            var statistics = new Statistics(_minValue, _avgValue, _maxVlue, _minPreValue, _avgPreValue, _maxPreValue);

            return statistics;
        }
    }
}