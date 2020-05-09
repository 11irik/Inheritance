using System;

namespace inheritance.Entities
{
    public class Man
    {
        private string _name;
        private int _age;
        private double _height;
        private double _weight;

        private static double _averageHeight = 175;
        private static double _averageWeight = 73;
        private static int _minimalRegAge = 18;

        public Man()
        {
            _name = "No Name";
            _age = _minimalRegAge;
            _height = _averageHeight;
            _weight = _averageWeight;
        }
        
        public Man(string name, int age)
        {
            if (age < _minimalRegAge)
            {
                throw new ArgumentException();
            }
            _name = name;
            _age = age;
            _height = _averageHeight;
            _weight = _averageWeight;
        }
        public Man(string name, int age, double height, double weight)
        {
            if (age < _minimalRegAge || height <= 0 || weight <= 0)
            {
                throw new ArgumentException();
            }
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
        }

        public static double AverageWeight
        {
            get => _averageWeight;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _averageWeight = value;
            }
        }

        public static double AverageHeight
        {
            get => _averageHeight;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _averageHeight = value;
            }
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < _minimalRegAge)
                {
                    throw new ArgumentException();
                }

                _age = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _height = value;
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _weight = value;
            }
        }

        public static int MinimalRegAge
        {
            get => _minimalRegAge;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _minimalRegAge = value;
            }
        }
    }
    
}