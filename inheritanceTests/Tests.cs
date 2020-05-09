using System;
using inheritance.Entities;
using NUnit.Framework;

namespace inheritanceTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CorrectManAndStudentInit()
        {
            Man defaultMan = new Man();
            Man ivan = new Man("Ivan", 12, 180, 80);
            
            Student defaultStudent = new Student();
            Student petr = new Student("Petr", 12, 2017, 3, 341);
            
            Assert.AreEqual("Ivan", ivan.Name);
            Assert.AreEqual(2017, petr.YearOfCommencementOfStudies);
        }

        [Test]
        public void WrongParams()
        {
            //Age is less than minimal
            Assert.Throws<ArgumentException>(
                delegate
                {
                    new Man("Ivan", 12);
                });
            
            //Weight cannot be negative or zero
            Assert.Throws<ArgumentException>(
                delegate
                {
                    new Man("Ivan", 18, 150, -1);
                });
            
            //course number can't be less than 1 and more than 6
            Assert.Throws<ArgumentException>(
                delegate
                {
                    new Student("Ivan", 18, 150, 40, 2012, 7, 712);
                });
        }

        [Test]
        public void wrongPropertiesSets()
        {
            //wrong height
            Assert.Throws<ArgumentException>(
                delegate
                {
                    Student.AverageHeight = -12;
                });
            
            //Wrong group number
            Assert.Throws<ArgumentException>(
                delegate
                {
                    Student s = new Student();
                    s.GroupNumber = 10;
                });
        }
    }
}