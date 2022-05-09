using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EternalKit.Application.Services.Convert.Length;

namespace EternalKit.Application.UnitTests
{
    [TestFixture]
    public class LengthConvertServiceTests
    {
        [Test]
        [TestCase(2, 1, 1000, 0.002)]
        [TestCase(2, 1, 0.1, 20)]
        [TestCase(2, 1, 0.01, 200)]
        [TestCase(2, 0.1, 0.01, 20)]
        public void Execute_ConvertValueToTargetUnit_ReturnConvertResult(decimal value, decimal from, decimal to, decimal res)
        {
            //Arrange
            var convertor = new LengthConvertService();


            //Act
            var result = convertor.Execute(new LengthConvertDto()
            {
                Value = value,
                From = from,
                To = to
            });


            //Assert
            Assert.That(result.Data, Is.EqualTo(res));
        }
    }
}
