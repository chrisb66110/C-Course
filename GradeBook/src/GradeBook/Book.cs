using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> _grades;
        private string _name;
        private double minValue;
        private double avgValue;
        private double maxValue;

        public Book(string name)
        {
            _grades = new List<double>();
            _name = name;
            minValue = 100.0;
            avgValue = 0;
            maxValue = 0.0;
        }

        public void AddGrade(double grade)
        {
            if( 0 <= grade && grade <= 100)
            {
                minValue = minValue<grade ? minValue : grade;
                maxValue = maxValue>grade ? maxValue : grade;
                avgValue = avgValue * _grades.Count;
                avgValue += grade;
                avgValue /= _grades.Count + 1;
                _grades.Add(grade);
            }
        }

        public double GetMaxValue()
        {
            var response = 0.0;
            foreach (var grade in _grades)
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
            return maxValue;
        }

        public double GetMinValue()
        {
            var response = 100.0;
            foreach (var grade in _grades)
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
            return minValue;
        }

        public double GetAvgValue()
        {
            var response = 0.0;
            foreach (var grade in _grades)
            {
                response += grade;
            }

            response /= _grades.Count;
            return response;
        }

        public double GetPreAvgValue()
        {
            return avgValue;
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