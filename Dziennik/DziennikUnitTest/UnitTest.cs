using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dziennik;
using System;
using System.Collections.Generic;

namespace DziennikUnitTest
{
    [TestClass]
    public class UnitTest
    {
         [TestMethod]
         public void HashStringTest()
         {
             //Arrange
             var stringToHash="test";
             var expected = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";
             //Act
             var result = User.HashString(stringToHash);
             //Assert
             Assert.AreEqual(expected, result);
         }
        [TestMethod]
        public void AvgGradeTest()
        {
            //Arrange
            var exampleGrades = new List<Grade>();
            exampleGrades.Add(new Grade("Przedmiot1", 4.5f));
            exampleGrades.Add(new Grade("Przedmiot2", 3.5f));
            exampleGrades.Add(new Grade("Przedmiot3", 0f));
            exampleGrades.Add(new Grade("Przedmiot4", 4f));
            exampleGrades.Add(new Grade("Przedmiot5", 5f));
            var expected = 4.25f;
            //Act
            var result = Grade.avgGrade(exampleGrades);
            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
