using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter.Tests
{
    [TestClass]
    public class ConvertTests
    {
        private readonly Convert _sut;
        public ConvertTests()
        {
            _sut = new Convert();
        }

        [TestMethod]
        public void Check_F2C()
        {
            // Arrange
            double f = 32;
            double c = 0;

            // Act
            double result = _sut.f2c(f);

            // Assert
            // (expected , received)
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void Check_C2F()
        {
            // Arrange
            double c = 100;
            double f = 212;

            // Act
            double result = _sut.c2f(c);

            // Assert
            // (expected , received)
            Assert.AreEqual(f, result);
        }

        [TestMethod]
        public void Check_K2C()
        {
            // Arrange
            double k = 0;
            double c = -273.15;

            // Act
            double result = _sut.k2c(k);

            // Assert
            // (expected , received)
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void When_Passing_Under_10_Return_Cold()
        {
            // Arrange
            double c = 9;
            string tempText = "Kallt";

            // Act
            string result = _sut.c2Text(c);

            // Assert
            // (expected , received)
            Assert.AreEqual(tempText, result);
        }

        [TestMethod]
        public void When_Passing_Between_10_and_20_Return_Warm()
        {
            // Arrange
            double c = 15;
            string tempText = "Varmt";

            // Act
            string result = _sut.c2Text(c);

            // Assert
            // (expected , received)
            Assert.AreEqual(tempText, result);
        }

        [TestMethod]
        public void When_Passing_Over_20_Return_Hot()
        {
            // Arrange
            double c = 25;
            string tempText = "Hett";

            // Act
            string result = _sut.c2Text(c);

            // Assert
            // (expected , received)
            Assert.AreEqual(tempText, result);
        }
    }
}
