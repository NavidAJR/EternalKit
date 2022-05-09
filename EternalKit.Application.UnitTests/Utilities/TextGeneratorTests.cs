using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Utilities;
using NUnit.Framework;

namespace EternalKit.Application.UnitTests.Utilities
{
    [TestFixture]
    public class TextGeneratorTests
    {
        [Test]
        public void GenerateLengthConvertResultText_ConvertCentimeterToMilimeter_ReturnResultInCorrectHtmlFormat()
        {
            //Act
            var result = TextGenerator.GenerateLengthConvertResultText(1, 0.01m, 10, 0.001m);

            //Assert
            Assert.That(result, Is.EqualTo($@"<p>مقدار <span class=""text-primary"">1 سانتی متر (Centimeter)</span> برابر با <span class=""text-success"">10 میلی متر (Millimeter)</span> است</p>"));
        }
    }
}
