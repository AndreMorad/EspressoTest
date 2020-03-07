using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EspressoTest.Tests
{
    [TestClass()]
    public class CoffeMakerTests
    {
        [TestMethod()]
        public void AddChocolateSyrupTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddEspressoTest()
        {
            // Arrange the data.
            string s = "hello";
            int i = 3;

            // Act on the data.
            string result = Program.(s, i);

            // Assert about the result.
            Assert.AreEqual("hellohellohello", result);
            Assert.Fail();
        }

        [TestMethod()]
        public void AddMilkTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddMilkFoamTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddWaterTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateBewerageTest()
        {
            Assert.Fail();
        }
    }
}