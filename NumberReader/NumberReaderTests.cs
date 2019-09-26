using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NumberReader

{
    [TestFixture]
    class NumberReaderTests
    {


        [Test]
        public void InputValid_WhenPassedInput_ShouldReturnValid([Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)] int input)
        {
            string output = NumberReader.IsValidNumber(input);
            Assert.AreEqual("Valid", output);
        }

        [Test]
        public void InputInvalid_WhenPassedInput_ShouldReturnInvalid([Values(11, 12, 13, 14, 0, -1, -2)] int input)
        {
            string output = NumberReader.IsValidNumber(input);
            Assert.AreEqual("Invalid", output);
        }
    }
}
