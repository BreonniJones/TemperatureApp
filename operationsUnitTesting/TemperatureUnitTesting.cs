using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using operationsLibrary;

namespace operationsUnitTesting
{
    [TestClass]
    public class TemperatureUnitTesting
    {
        // Test Celsius to Fahrenheit conversion
        [TestMethod]
        public void testCelsiusToFahrenheit()
        {
            // Arrange
            double celsius = 0.0;
            double expectedFahrenheit = 32.0;

            // Act
            double actualFahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit);
        }

        // Test Fahrenheit to Celsius conversion
        [TestMethod]
        public void testFahrenheitToCelsius()
        {
            // Arrange
            double fahrenheit = 32.0;
            double expectedCelsius = 0.0;

            // Act
            double actualCelsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expectedCelsius, actualCelsius);
        }
    }
}
