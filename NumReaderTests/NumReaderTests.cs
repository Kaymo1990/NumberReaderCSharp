using NUnit.Framework;
using System;
using NumberReader;

namespace NumReaderTests
{
    [TestFixture]
    public class NumReaderTests
    {

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void IsValid_ShouldReturnValid_WhenPassedNum1To10([Values(1,2,3,4,5,6,7,8,9,10)] int input)
        {
            var output = NumberReader.NumberReader.IsValidNumber(input);
            Assert.AreEqual("Valid", output);
        }

        [Test]
        public void IsValid_ShouldReturnInvalid_WhenPassedInput([Values(-1, -10, 11, 20, 102132)] int input)
        {
            var output = NumberReader.NumberReader.IsValidNumber(input);
            Assert.AreEqual("Invalid", output);
        }
        

    }
}
