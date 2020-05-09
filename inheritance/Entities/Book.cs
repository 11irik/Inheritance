using System;

namespace inheritance.Entities
{
    public class Book
    {
        private string _name;
        private int _pageCount;
        private string _publisherName;
        //Данный тип данных накладывает ограничение на минимальный год написания/издания книги - 1 января 2001 года
        private DateTime _dateOfPublishing;
        private DateTime _dateOfWriting;

        public Book(string name, int pageCount, string publisherName, DateTime dateOfPublishing, DateTime dateOfWriting)
        {
            if (pageCount < 0)
            {
                throw new ArgumentException();
            }
            _name = name;
            _pageCount = pageCount;
            _publisherName = publisherName;
            _dateOfPublishing = dateOfPublishing;
            _dateOfWriting = dateOfWriting;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int PageCount
        {
            get => _pageCount;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                _pageCount = value;
            }
        }

        public string PublisherName
        {
            get => _publisherName;
            set => _publisherName = value;
        }

        public DateTime DateOfPublishing
        {
            get => _dateOfPublishing;
            set => _dateOfPublishing = value;
        }

        public DateTime DateOfWriting
        {
            get => _dateOfWriting;
            set => _dateOfWriting = value;
        }
    }
}