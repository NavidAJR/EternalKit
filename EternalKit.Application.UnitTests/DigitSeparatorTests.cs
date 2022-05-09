using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Utilities;
using NUnit.Framework;

namespace EternalKit.Application.UnitTests
{
    [TestFixture]
    public class DigitSeparatorTests
    {

        [Test]
        public void Separate_NumberDoesNotHaveDecimalPoint_ReturnNumberInSeparatedForm()
        {
            //Arrange
            decimal number = 12345;

            //Act
            var result = number.Separate();

            //Assert
            Assert.That(result, Is.EqualTo("12,345"));
        }


        [Test]
        public void Separate_NumberHasDecimalPoint_ReturnNumberInSeparatedForm()
        {

            //Arrange
            decimal number = 12345.678m;

            //Act
            var result = number.Separate();

            //Assert
            Assert.That(result, Is.EqualTo("12,345.678"));
        }


        [Test]
        [TestCase(7)]
        public void Separate_NumberHasDecimalPoint_ReturnNumberInSeparatedFormWithCorrectNumberOfDigitsAfterDecimalPoint(int numberOfDigitsAfterDecimalPoint)
        {

            //Arrange
            decimal number = 12345.67890123456m;

            //Act
            var result = number.Separate(numberOfDigitsAfterDecimalPoint);

            //Assert
            Assert.That(result, Is.EqualTo("12,345.6789012"));
        }
    }
}
