using System;

namespace inheritance.Entities
{
    public class Author
    {
        private string _name;
        private string _lastName;
        private int _yearOfBirth;

        //первые люди до н.э.
        private static int _minimalYearOfBirth = -2800000;
        public Author(string name, string lastName, int yearOfBirth)
        {
            if (yearOfBirth < _minimalYearOfBirth)
            {
                throw new ArgumentException();
            }
            _name = name;
            _lastName = name;
            _yearOfBirth = yearOfBirth;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public int YearOfBirth
        {
            get => _yearOfBirth;
            set
            {
                if (value < _minimalYearOfBirth)
                {
                    throw new ArgumentException();
                }

                _yearOfBirth = value;
            }
        }
    }
}