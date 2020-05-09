using System;
using inheritance.Entities;

namespace inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book f = new Book("fd", 12, "id",DateTime.Parse("12, 12, 0"), DateTime.Parse("12, 12, -3"));
            Console.WriteLine(f.DateOfPublishing);
        }
    }
}