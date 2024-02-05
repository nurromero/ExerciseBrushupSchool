using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseBrushupSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBrushupSchool.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            var teacher = new Teacher { Id = 1, Name = "Nur Nur", Salary = 50000 };
            var expectedString = "ID: 1, Name: Nur Nur, Salary: 50000";

            //Act
            var result = teacher.ToString();

            //Assert
            Assert.AreEqual(expectedString, result);
         
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            //Arrange
            var teacher = new Teacher { Name = "Z" };


            // Act and Assert
            teacher.ValidateName();


        }

        [TestMethod()]
        public void ValidateSalaryTest()
        {
            //Arrange 
            var teacher = new Teacher { Salary = -1 };

            // Act and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.ValidateSalary());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            Assert.Fail();
        }
    }
}