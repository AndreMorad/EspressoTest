using Microsoft.VisualStudio.TestTools.UnitTesting;
using EspressoTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoTest.Tests
{
    [TestClass()]
    public class CoffeMakerTests
    {
        [TestMethod()]
        public void AddEspressoTest()
        {

            // Arrange the data.
            string s = "Espresso";
            int i = 3;

            // Act on the data.
            string result = Program.Equals(s, i);

            // Assert about the result.
            Assert.AreEqual("hellohellohello", result);
            Assert.Fail();
        }
    }
}