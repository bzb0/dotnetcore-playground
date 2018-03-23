using System;
using Xunit;
using Math;

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
		
		[Fact]
        public void AddTwoNumbersTest()
        {
            var cut = new Calculator();
            Assert.Equal(30, cut.AddNumbers(10, 20));
        }
    }
}
