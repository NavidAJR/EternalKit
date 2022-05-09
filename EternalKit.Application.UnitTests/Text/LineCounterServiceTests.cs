using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Services.Text.LineCounter;
using NUnit.Framework;

namespace EternalKit.Application.UnitTests.Text
{
    [TestFixture]
    public class LineCounterServiceTests
    {
        [Test]
        public void Execute_TextIsThreeLines_ReturnCorrectNumberOfLines()
        {

            //Arrange
            var text = "Hello programmer \n so glad to see you      \n          Let's check the test.";
            var lineCounter = new LineCounterService();

            //Act
            var result = lineCounter.Execute(text);

            //Assert
            Assert.That(result.Data, Is.EqualTo(3));
        }
    }
}
