using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EternalKit.Application.Services.Text.WordCounter;
using NUnit.Framework;

namespace EternalKit.Application.UnitTests.Text
{
    [TestFixture]
    public class WordCounterServiceTests
    {
        [Test]
        [TestCase("Hi my name is navid. ! ? : ... \"")]
        [TestCase("Hi   my          name is navid. ! ? : ... \"")]
        [TestCase("   Hi   my          name is   navid. ! ? : ... \"")]
        [TestCase("   Hi   my     name is   navid. ! ? : ... \"")]
        public void Execute_CountPunctuationCharacters_ReturnNumberOfWordsInText(string text)
        {

            //Arrange
            var wordCounter = new WordCounterService();

            //Act
            var result = wordCounter.Execute(text, true);

            //Assert
            Assert.That(result.Data, Is.EqualTo(10));
        }


        [Test]
        [TestCase("Hi my name is navid. ! ? : ... \"")]
        [TestCase("Hi   my          name is navid. ! ? : ... \"")]
        [TestCase("   Hi   my          name is   navid. ! ? : ... \"")]
        [TestCase("   Hi   my     name is   navid. ! ? : ... \"")]
        public void Execute_DoNotCountPunctuationCharacters_ReturnNumberOfWordsInText(string text)
        {

            //Arrange
            var wordCounter = new WordCounterService();

            //Act
            var result = wordCounter.Execute(text, false);

            //Assert
            Assert.That(result.Data, Is.EqualTo(5));
        }
    }
}
