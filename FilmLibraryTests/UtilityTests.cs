using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Tests
{
    [TestClass()]
    public class UtilityTests
    {
        // shared instans field
        private Utility? u;
        private Movie? m;


        // Arrange for all tests:
        [TestInitialize]
        public void BeforeTest()
        {
            u = new Utility();
        }



        [TestMethod()]
        [DataRow(1)]
        [DataRow(90)]
        [DataRow(120)]
        [DataRow(300)]
        [DataRow(600)]
        public void ConvertMinutesToSecondsOK(int minutes)
        {
            // arrange movie
            m = new Movie();

            // act
            int sxpectedTime = minutes;


            // assert
            
            Assert.AreEqual((minutes), m.LengthInMinutes);
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(-5)]
        [DataRow(-40)]

        public void ConvertMinutesToSecondsBad(int minutes)
        {
            // arrange movie
            m = new Movie();


            Assert.ThrowsException<ArgumentException>(() =>
            {
                u.ConvertMinutesToSeconds(minutes);
            });
        }

    }
}