using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Services.Text.CharacterCounter;
using NUnit.Framework;

namespace EternalKit.Application.UnitTests.Text
{
    [TestFixture]
    public class CharacterCounterServiceTests
    {
        private CharacterCounterService _characterCounter;

        [SetUp]

        public void SetUp()
        {
            _characterCounter = new CharacterCounterService();
        }


        [Test]
        public void Execute_CountSpaceAndCountPunctuation_ReturnCorrectResult()
        {
            //Arrange

            var text = "Hi i am navid!?;.";

            //Act
            var result = _characterCounter.Execute(text, true, true);

            //Assert
            Assert.That(result.Data, Is.EqualTo(17));
        }

        [Test]
        public void Execute_CountSpaceAndDoNotCountPunctuation_ReturnCorrectResult()
        {
            //Arrange

            var text = "Hi i am navid!?;.";

            //Act
            var result = _characterCounter.Execute(text, true, false);

            //Assert
            Assert.That(result.Data, Is.EqualTo(13));
        }


        [Test]
        public void Execute_DoNotCountSpaceAndCountPunctuation_ReturnCorrectResult()
        {
            //Arrange

            var text = "Hi i am navid!?;.";

            //Act
            var result = _characterCounter.Execute(text, false, true);

            //Assert
            Assert.That(result.Data, Is.EqualTo(14));
        }

        [Test]
        public void Execute_DoNotCountSpaceAndDoNotCountPunctuation_ReturnCorrectResult()
        {
            //Arrange

            var text = "Hi i am navid!?;.";

            //Act
            var result = _characterCounter.Execute(text, false, false);

            //Assert
            Assert.That(result.Data, Is.EqualTo(10));
        }
    }
}
