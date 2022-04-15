using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReviewApp.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ReverseHyphenatedLib_WhenNullStringInput_ReturnsNull()
        {
            // Arrange
            string input = null;

            // Act
            string output = StringExtensions.ReverseHyphenatedLib(input);

            // Assert
            Assert.IsNull(output);
        }

        [TestMethod]
        public void ReverseHyphenatedLib_WhenEmptyStringInput_ReturnsNull()
        {
            // Arrange
            string input = String.Empty;

            // Act
            string output = StringExtensions.ReverseHyphenatedLib(input);

            // Assert
            Assert.IsNull(output);
        }

        [TestMethod]
        public void ReverseHyphenatedLib_WhenWhitespaceStringInput_ReturnsHyphenated()
        {
            // Arrange
            string input = "   ";
            string expectedOutput = " - - ";

            // Act
            string actualOutput = StringExtensions.ReverseHyphenatedLib(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReverseHyphenatedLib_WhenValidStringInput_ReturnsHyphenated()
        {
            // Arrange
            string input = "JOE";
            string expectedOutput = "E-O-J";

            // Act
            string actualOutput = StringExtensions.ReverseHyphenatedLib(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReverseHyphenatedManual_WhenNullStringInput_ReturnsNull()
        {
            // Arrange
            string input = null;

            // Act
            string output = StringExtensions.ReverseHyphenatedManual(input);

            // Assert
            Assert.IsNull(output);
        }

        [TestMethod]
        public void ReverseHyphenatedManual_WhenEmptyStringInput_ReturnsNull()
        {
            // Arrange
            string input = String.Empty;

            // Act
            string output = StringExtensions.ReverseHyphenatedManual(input);

            // Assert
            Assert.IsNull(output);
        }

        [TestMethod]
        public void ReverseHyphenatedManual_WhenWhitespaceStringInput_ReturnsHyphenated()
        {
            // Arrange
            string input = "   ";
            string expectedOutput = " - - ";

            // Act
            string actualOutput = StringExtensions.ReverseHyphenatedManual(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReverseHyphenatedManual_WhenValidStringInput_ReturnsHyphenated()
        {
            // Arrange
            string input = "JOE";
            string expectedOutput = "E-O-J";

            // Act
            string actualOutput = StringExtensions.ReverseHyphenatedManual(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
