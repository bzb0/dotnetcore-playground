using System;
using Xunit;

namespace Testing
{
    public class CalculatorTest
    {
        [Fact]
        public void StringEqualsTest()
        {
            string inputStr = "abc";
            Assert.Equal("abc", inputStr);
        }
    }
}
