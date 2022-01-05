using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vizsgaremek.Models;

namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTestVersion()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            Version expected = new Version(0, 0, 3, 0);

            // act
            Version actual = programInfo.Version;

            // assert
            Assert.AreEqual(expected, actual, "Version is not 0.0.3.0");
        }

        [TestMethod()]
        public void ProgramInfoTestTitle()
        {
            //arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Vizsgaremek";

            // act
            string actual = programInfo.Title.ToString();

            // assert
            Assert.AreEqual(expected, actual, "Title is not Vizsgaremek");

        }

        [TestMethod()]
        public void ProgramInfoTestCompany()
        {
            //arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Vasvári";

            // act
            string actual = programInfo.Company.ToString();

            // assert
            Assert.AreEqual(expected, actual, "Title is not Vasvári");

        }

        [TestMethod()]
        public void ProgramInfoTestDescription()
        {
            //arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "A program fejlesztés alatt";

            // act
            string actual = programInfo.Description.ToString();

            // assert
            Assert.AreEqual(expected, actual, "Description is not A program fejlesztés alatt");

        }

    }
}