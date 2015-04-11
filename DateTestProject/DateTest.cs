using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DateProject;

namespace DateTestProject
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Date date = new Date(10,10,2010);

            Assert.AreEqual(date.day, 10, "Day not correct.");
            Assert.AreEqual(date.month, 10, "Month not correct.");
            Assert.AreEqual(date.year, 2010, "Year not correct.");
        }

        [TestMethod]
        public void MonthNameTest()
        {
            var date = new Date(10, 10, 2010);
            var month = date.getMonthName();
            Assert.AreEqual(month, "Listopad", "Month name not correct.");
        }

        [TestMethod]
        public void NumberOfRemaingDaysInMonthTest()
        {
            var date = new Date(10, 10, 2010);
            var remDays = date.getNumberOfRemaingDaysInMonth();
            Assert.AreEqual(remDays, 21, "Number of remaining days in month is not correct.");
        }

        [TestMethod]
        public void LeapYearTest()
        {
            var date = new Date(10, 10, 2012);
            Assert.AreEqual(date.isLeapYear(), true, "Leap year not detected.");
        }

        [TestMethod]
        public void NotLeapYearTest()
        {
            var date = new Date(10, 10, 2010);
            Assert.AreEqual(date.isLeapYear(), false, "Leap year falsely detected.");
        }

    }
}
