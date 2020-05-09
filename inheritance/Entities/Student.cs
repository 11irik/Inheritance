using System;

namespace inheritance.Entities
{
    public class Student : Man
    {
        private int _yearOfCommencementOfStudies;
        private int _courseNumber;
        private int _groupNumber;
        
        private static int _defaultYearOfCommencementOfStudies = 2000;
        private static int _minCourseNumber = 1;
        private static int _maxCourseNumber = 6;
        private static int _minGroupNum = 100;
        private static int _maxGroupNum = 999;
        public Student()
        :base()
        {
            _yearOfCommencementOfStudies = _defaultYearOfCommencementOfStudies;
            _courseNumber = _minCourseNumber;
            _groupNumber = _maxGroupNum;
        }
        
        public Student(string name, int age, int enterYear, int courseNumber, int groupNumber)
            :base(name, age)
        {
            if (enterYear < _defaultYearOfCommencementOfStudies || 
                courseNumber < _minCourseNumber || 
                courseNumber > _maxCourseNumber || 
                _groupNumber < _minGroupNum || 
                _groupNumber > _maxGroupNum)
            {
                throw new ArgumentException();
            }
            _yearOfCommencementOfStudies = enterYear;
            _courseNumber = courseNumber;
            _groupNumber = groupNumber;
        }
        
        public Student(string name, int age, double height, double weight, int enterYear, int courseNumber, int groupNumber)
        :base(name, age, height, weight)
        {
            if (enterYear < 2000 || courseNumber < 1 || courseNumber > 6 || _groupNumber < 0 || _groupNumber > 999)
            {
                throw new ArgumentException();
            }
            _yearOfCommencementOfStudies = enterYear;
            _courseNumber = courseNumber;
            _groupNumber = groupNumber;
        }
        
        public int YearOfCommencementOfStudies
        {
            get => _yearOfCommencementOfStudies;
            set
            {
                if (value < 2000)
                {
                    throw new ArgumentException();
                }
                _yearOfCommencementOfStudies = value;
            }
        }

        public int CourseNumber
        {
            get => _courseNumber;
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentException();
                }
                _courseNumber = value;
            }
        }

        public int GroupNumber
        {
            get => _groupNumber;
            set
            {
                if (value < 0 || value > 999)
                {
                    throw new ArgumentException();
                }
                _courseNumber = value;
            }
        }
    }
}